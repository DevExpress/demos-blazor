using System.Collections.Concurrent;
using System.Reflection;
using Microsoft.JSInterop;

namespace BlazorDemo.CRM.Client.Services;

public class ModuleLoader : IAsyncDisposable {
    readonly CancellationTokenSource _disposeCts = new();
    readonly IJSRuntime _jsRuntime;
    readonly ConcurrentDictionary<string, ValueTask<IJSObjectReference?>> _modules = new();

    public ModuleLoader(IJSRuntime jsRuntime) {
        _jsRuntime = jsRuntime;
    }

    public async ValueTask<IJSObjectReference?> GetJSModuleSafeAsync(string jsModule) {
        return await _modules.GetOrAdd(jsModule, async moduleName => {
            try {
                return await _jsRuntime.InvokeAsync<IJSObjectReference>("import", _disposeCts.Token, $"./scripts/{jsModule}");
            } catch {
                return null;
            }
        });
    }

    public async ValueTask DisposeAsync() {
        _disposeCts.Cancel();
        try {
            foreach(var item in _modules) {
                var module = await item.Value;
                if(module != null)
                    await module.DisposeAsync();
            }
            _modules.Clear();
        } catch(JSDisconnectedException) { }
        _disposeCts.Dispose();
    }
}
