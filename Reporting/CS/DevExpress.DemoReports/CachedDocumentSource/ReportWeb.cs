namespace XtraReportsDemos.CachedDocumentSourceReport {
    public class ReportWeb : Report {
        public ReportWeb() : this(2500u) { }
        public ReportWeb(uint countParameter) {
            RowCountParameter.Value = countParameter;
        }
    }
}
