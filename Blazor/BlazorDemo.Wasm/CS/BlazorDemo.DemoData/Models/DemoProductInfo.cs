using System;

namespace BlazorDemo.DemoData {
    public class DemoProductInfo {
        public string Title { get; set; }
        public string PageUri { get; set; }
        public string IconKey { get; set; }
        public bool IsServerSideOnly { get; set; }
        public bool IsClientSideOnly { get; set; }
    }
}
