using BlazorDemo.CRM.Models;

namespace BlazorDemo.CRM.Services.DataProviders;

public class ChartAnnotationsProvider(Action onChanged) {
    public List<Annotation> ChartAnnotations { get; } = [];

    public void Notify() {
        onChanged();
    }
}
