using Microsoft.AspNetCore.Components;

namespace BlazorDemo.CRM.Components {
    public abstract class DataPresenter<T> : ComponentBase {
        [Parameter] public T? Data { get; set; }
        [Parameter] public EventCallback<T> DataChanged { get; set; }

        public bool IsDataLoaded { get; set; }

        protected override void OnParametersSet() {
            IsDataLoaded = Data != null;
            base.OnParametersSet();
        }

        protected async Task OnDataChangedAsync(T data) {
            if(DataChanged.HasDelegate)
                await DataChanged.InvokeAsync(data);
        }
    }
}
