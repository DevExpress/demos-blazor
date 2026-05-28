using DevExpress.Blazor;
using Microsoft.JSInterop;

namespace BlazorDemo.CRM.Client.Services;

public class SizeModeManager {
    readonly ModuleLoader _moduleLoader;
    public SizeModeManager(ModuleLoader moduleLoader) {
        _moduleLoader = moduleLoader;
    }

    public async ValueTask SwitchToSizeModeAsync(SizeMode sizeMode) {
        var module = await _moduleLoader.GetJSModuleSafeAsync("utils.js");
        if(module != null)
            await module.InvokeVoidAsync("setBodyClass", GetClassName(sizeMode));
    }

    public string GetClassName(SizeMode sizeMode) => sizeMode switch {
        SizeMode.Small => "small-size",
        SizeMode.Large => "large-size",
        _ => "medium-size"
    };
}
