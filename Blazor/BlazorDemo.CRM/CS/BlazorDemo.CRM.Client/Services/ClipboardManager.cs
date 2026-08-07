using Microsoft.JSInterop;

namespace BlazorDemo.CRM.Client.Services;

public class ClipboardManager {
    readonly ModuleLoader _moduleLoader;
    IJSObjectReference? _utilsModule;
    public ClipboardManager(ModuleLoader moduleLoader) {
        _moduleLoader = moduleLoader;
    }

    public async ValueTask InitCopyFromElementAsync<T>(DotNetObjectReference<T> dotNetRef, string buttonSelector, string sourceSelector) where T : class {
        _utilsModule ??= await _moduleLoader.GetJSModuleSafeAsync("utils.js");
        if(_utilsModule != null)
            await _utilsModule.InvokeVoidAsync("initCopyButton", dotNetRef, buttonSelector, sourceSelector);
    }

    public async ValueTask DisposeCopyFromElementAsync(string buttonSelector) {
        if(_utilsModule != null)
            await _utilsModule.InvokeVoidAsync("disposeCopyButton", buttonSelector);
    }
}
