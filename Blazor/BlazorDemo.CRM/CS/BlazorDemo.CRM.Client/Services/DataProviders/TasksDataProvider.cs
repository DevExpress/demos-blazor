using BlazorDemo.CRM.Models;

namespace BlazorDemo.CRM.Services.DataProviders {
    public class TasksDataProvider : DataProvider {
        public TasksDataProvider(HttpClient httpClient)
            : base(httpClient) {
        }

        protected override string GetBasePath() => "Employees/AllTasks";

        public Task<List<WorkTaskDetail>?> GetAsync(CancellationToken cancellationToken = default) =>
            LoadDataAsync<List<WorkTaskDetail>>(cancellationToken: cancellationToken);
    }
}
