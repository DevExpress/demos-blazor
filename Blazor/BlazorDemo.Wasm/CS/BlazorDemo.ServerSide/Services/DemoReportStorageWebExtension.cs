using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DevExpress.Data.Utils.Security;
using DevExpress.Security;
using DevExpress.XtraReports.Services;
using DevExpress.XtraReports.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace BlazorDemo.Services {
    public class DemoReportStorageWebExtension : DevExpress.XtraReports.Web.Extensions.ReportStorageWebExtension, IReportProviderAsync {
        const string SessionIdCookieKey = "xrSessionId";
        static readonly object SessionIdItemKey = new object();
        public static string TempReportsFolderName => Path.Join("obj", "UserReports");
        string TempReportsFolderPath => Path.Join(webHostEnvironment.ContentRootPath, TempReportsFolderName);
        protected IHttpContextAccessor httpContextAccessor { get; }
        protected IDemoReportSource PredefinedReports { get; }
        protected IWebHostEnvironment webHostEnvironment { get; }
        ReportingSession reportingSession { get; }
        string sessionId;

        public DemoReportStorageWebExtension(IHttpContextAccessor httpContextAccessor, IWebHostEnvironment webHostEnvironment, IDemoReportSource reportFactory, ReportingSession reportingSession) {
            this.httpContextAccessor = httpContextAccessor;
            this.webHostEnvironment = webHostEnvironment;
            PredefinedReports = reportFactory;
            this.reportingSession = reportingSession;
        }

        public static void EnsureSessionId(HttpContext context) {
            if(ReadSessionId(context) != null)
                return;
            var newSessionId = StrongRandom.NextGuid().ToString("N");
            context.Items[SessionIdItemKey] = newSessionId;
            context.Response.Cookies.Append(SessionIdCookieKey, newSessionId, new CookieOptions {
                HttpOnly = true,
                Secure = context.Request.IsHttps,
                SameSite = SameSiteMode.Lax,
                IsEssential = true,
                Path = "/"
            });
        }
        public static string ReadSessionId(HttpContext context) {
            if(context.Items.TryGetValue(SessionIdItemKey, out var issuedSessionId))
                return (string)issuedSessionId;
            return context.Request.Cookies.TryGetValue(SessionIdCookieKey, out var cookieValue) && IsValidSessionId(cookieValue) ? cookieValue : null;
        }
        public static bool IsValidSessionId(string value) {
            return Guid.TryParseExact(value, "N", out var guid) && guid.ToString("N") == value;
        }

        string GetSessionId() {
            if(sessionId == null)
                sessionId = reportingSession.Id;
            var context = httpContextAccessor.HttpContext;
            if(sessionId == null && context != null)
                sessionId = ReadSessionId(context);
            return sessionId;
        }
        string GetReportFolderPath() {
            var currentSessionId = GetSessionId();
            if(currentSessionId == null)
                return null;
            var folderPath = Path.GetFullPath(Path.Join(TempReportsFolderPath, currentSessionId));
            if(!SafePath.IsRooted(TempReportsFolderPath, folderPath))
                throw new InvalidOperationException("Invalid report folder path");
            return folderPath;
        }
        string GetReportFilePath(string reportName) {
            ValidateReportName(reportName);
            var folderPath = GetReportFolderPath();
            if(folderPath == null)
                return null;
            var filePath = Path.GetFullPath(Path.Join(folderPath, reportName + ".repx"));
            if(!SafePath.IsRooted(folderPath, filePath))
                throw new InvalidOperationException("Invalid report path");
            return filePath;
        }
        void SaveReport(XtraReport report, string reportName) {
            var filePath = GetReportFilePath(reportName)
                ?? throw new InvalidOperationException("Report storage is not available for the current session");
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            report.SaveLayoutToXml(filePath);
        }

        public override bool CanSetData(string reportName) {
            return true;
        }

        public override bool IsValidUrl(string reportName) {
            if(string.IsNullOrEmpty(reportName))
                return false;
            else if(reportName.Any(x => Array.IndexOf(Path.GetInvalidFileNameChars(), x) >= 0))
                return false;
            else if(reportName.Contains(".."))
                return false;
            return true;
        }

        public override async Task<byte[]> GetDataAsync(string reportName) {
            var reportPath = GetReportFilePath(reportName);
            if(File.Exists(reportPath)) return await File.ReadAllBytesAsync(reportPath);
            XtraReport report = PredefinedReports.GetReport(reportName);
            if(report == null) {
                throw new Exception("Report was not found.");
            }
            using(MemoryStream ms = new MemoryStream()) {
                report.SaveLayoutToXml(ms);
                return ms.ToArray();
            }
        }

        Task<XtraReport> IReportProviderAsync.GetReportAsync(string id, ReportProviderContext context) {
            var reportPath = GetReportFilePath(id);
            if(File.Exists(reportPath)) {
                return Task.FromResult(XtraReport.FromFile(reportPath));
            }
            var report = PredefinedReports.GetReport(id);
            if(report == null)
                throw new Exception("Report not found.");
            return Task.FromResult(report);
        }

        public override Dictionary<string, string> GetUrls() {
            var comparer = SafePath.IsCaseInsensitiveFileSystem ? StringComparer.OrdinalIgnoreCase : StringComparer.Ordinal;
            var reportList = new Dictionary<string, string>(PredefinedReports.GetReportList(), comparer);
            var folderPath = GetReportFolderPath();
            if(folderPath != null && Directory.Exists(folderPath)) {
                var files = Directory.EnumerateFiles(folderPath, "*.repx").Select(x => Path.GetFileNameWithoutExtension(x)).Where(x => !reportList.ContainsKey(x));
                foreach(var fileName in files) {
                    reportList.Add(fileName, fileName);
                }
            }
            return reportList;
        }

        public override void SetData(XtraReport report, string url) {
            SaveReport(report, url);
        }

        public override string SetNewData(XtraReport report, string defaultUrl) {
            SaveReport(report, defaultUrl);
            return defaultUrl;
        }

        void ValidateReportName(string reportName) {
            if(!IsValidUrl(reportName))
                throw new InvalidOperationException("Invalid name");
        }
    }
}
