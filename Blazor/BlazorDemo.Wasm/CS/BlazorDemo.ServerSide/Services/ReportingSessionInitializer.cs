using Microsoft.AspNetCore.Components;

namespace BlazorDemo.Services {
    public class ReportingSession {
        public string Id { get; set; }
    }

    public class ReportingSessionInitializer : ComponentBase {
        [Inject] ReportingSession Session { get; set; }
        [Parameter] public string SessionId { get; set; }
        protected override void OnInitialized() {
            if(Session.Id == null && DemoReportStorageWebExtension.IsValidSessionId(SessionId))
                Session.Id = SessionId;
        }
    }
}
