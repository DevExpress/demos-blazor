using DevExpress.Utils;

namespace BlazorDemo.CRM.Services {
    public class SearchManager {
        readonly List<Action<string>> _handlers = new();
        string _searchText = string.Empty;

        public string SearchText {
            get => _searchText;
            set {
                if (_searchText != value) {
                    _searchText = value != null ? value : string.Empty;
                    OnSearchTextChanged();
                }
            }
        }

        void OnSearchTextChanged() =>
            _handlers.ForEach(handler => handler(SearchText));

        public IDisposable RegisterSearchTextChangingHandler(Action<string> handler) {
            Guard.ArgumentNotNull(handler, nameof(handler));
            _handlers.Add(handler);
            return new Unsubscriber(_handlers, handler);
        }
    }

    class Unsubscriber : IDisposable {
        readonly List<Action<string>> _handlers;
        readonly Action<string> _handler;

        public Unsubscriber(List<Action<string>> handlers, Action<string> handler) {
            this._handlers = handlers;
            this._handler = handler;
        }

        public void Dispose() {
            if (_handlers != null && _handlers.Contains(_handler))
                _handlers.Remove(_handler);
        }
    }
}
