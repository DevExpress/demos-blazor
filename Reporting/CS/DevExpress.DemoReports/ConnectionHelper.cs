using System;
using System.IO;

namespace XtraReportsDemos {
    public static class ConnectionHelper {
        const string dataDirectoryName = "DataDirectory";
        internal const string DataDirectoryTag = "|" + dataDirectoryName + "|";

        public static string PatchConnection(string connectionString, string dataDirectory) {
            return PatchConnectionCore(connectionString, () => dataDirectory);
        }
        public static string PatchConnectionCore(string connectionString, Func<string> getDataDirectory) {
            if(!string.IsNullOrEmpty(connectionString) && connectionString.Contains(DataDirectoryTag))
                return connectionString.Replace(DataDirectoryTag, getDataDirectory());
            return connectionString;
        }
        static string ValidateDirectory(string dataDirectory) {
            string result = Path.GetFullPath(dataDirectory);
            return result.TrimEnd('\\');
        }
        public static string PatchDataDirectory(string connectionString) {
            return PatchConnectionCore(connectionString, GetDataDirectory);
        }
        static string GetDataDirectory() {
            string dataDirectory = AppDomain.CurrentDomain.GetData(dataDirectoryName) as string;
            if(string.IsNullOrEmpty(dataDirectory))
                dataDirectory = AppDomain.CurrentDomain.BaseDirectory;
            return ValidateDirectory(dataDirectory);
        }
        public static void SetDataDirectory(string directory) {
            AppDomain.CurrentDomain.SetData("DataDirectory", directory);
        }
    }
}
