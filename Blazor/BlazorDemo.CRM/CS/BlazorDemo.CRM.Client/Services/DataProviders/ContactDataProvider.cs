using BlazorDemo.CRM.Models;

namespace BlazorDemo.CRM.Services.DataProviders {
    public class ContactDataProvider : DataProvider {
        public ContactDataProvider(HttpClient httpClient) : base(httpClient) { }

        protected override string GetBasePath() => "Users/Contacts";

        public Task<List<Contact>?> GetAsync(CancellationToken cancellationToken = default) {
            return LoadDataAsync<List<Contact>?>(cancellationToken: cancellationToken);
        }

        public async Task<ContactDetail?> GetAsync(int index, bool full = false, CancellationToken cancellationToken = default) {
            var contact = await LoadDataAsync<ContactDetail>([index.ToString()], cancellationToken);

            if(full && contact != null) {
                contact.Opportunities = await GetOpportunitiesAsync(index, cancellationToken);
                contact.Notes = await GetNotesAsync(index, cancellationToken);
            }

            return contact;
        }

        Task<List<Opportunity>?> GetOpportunitiesAsync(int index, CancellationToken cancellationToken = default) {
            return LoadDataAsync<List<Opportunity>>([index.ToString(), "Opportunities"], cancellationToken);
        }

        Task<List<Note>?> GetNotesAsync(int index, CancellationToken cancellationToken = default) {
            return LoadDataAsync<List<Note>>([index.ToString(), "Notes"], cancellationToken);
        }
    }
}
