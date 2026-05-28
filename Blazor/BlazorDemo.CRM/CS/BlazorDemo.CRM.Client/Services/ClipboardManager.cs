using Microsoft.JSInterop;

namespace BlazorDemo.CRM.Client.Services;

public class ClipboardManager {
    readonly ModuleLoader _moduleLoader;
    public ClipboardManager(ModuleLoader moduleLoader) {
        _moduleLoader = moduleLoader;
    }

    public async ValueTask CopyTextAsync(string text) {
        var module = await _moduleLoader.GetJSModuleSafeAsync("utils.js");
        if(module != null)
            await module.InvokeVoidAsync("copy", text);
    }
}
