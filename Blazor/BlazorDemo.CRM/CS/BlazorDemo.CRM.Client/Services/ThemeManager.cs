using BlazorDemo.CRM.Utils;
using DevExpress.Blazor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;

namespace BlazorDemo.CRM.Client.Services {
    public class ThemeManager {
        static readonly ITheme FluentLight = Themes.Fluent.Clone(p => {
            p.Name = "Fluent-Light";
            p.Mode = ThemeMode.Light;
        });
        static readonly ITheme FluentDark = Themes.Fluent.Clone(p => {
            p.Name = "Fluent-Dark";
            p.Mode = ThemeMode.Dark;
        });

        static readonly string IsDarkThemeCookieKey = "is-dark-theme";

        readonly ModuleLoader _moduleLoader;
        readonly PersistentComponentState _componentState;
        readonly PersistingComponentStateSubscription _subscription;
        readonly IThemeChangeService _themeService;

        public ThemeManager(ModuleLoader moduleLoader, IThemeChangeService themeService, PersistentComponentState componentState) {
            _moduleLoader = moduleLoader;
            _themeService = themeService;
            _componentState = componentState;
            if(componentState.TryTakeFromJson(nameof(ThemeInfo), out ThemeInfo? themeInfo))
                IsDarkTheme = themeInfo!.IsDarkTheme;
            else {
                _subscription = _componentState.RegisterOnPersisting(() => {
                    componentState.PersistAsJson(nameof(ThemeInfo), new ThemeInfo { IsDarkTheme = IsDarkTheme });
                    return Task.CompletedTask;
                }, RenderMode.InteractiveAuto);
            }
        }

        public bool IsDarkTheme { get; set; }
        public ITheme CurrentTheme => IsDarkTheme ? FluentDark : FluentLight;

        public async Task ToggleThemeAsync() {
            IsDarkTheme = !IsDarkTheme;
            if(await _themeService.SetTheme(CurrentTheme)) {
                var module = await _moduleLoader.GetJSModuleSafeAsync("utils.js");
                if(module != null) {
                    KeyValuePairSerializer<string, bool> themeData = new(IsDarkThemeCookieKey, IsDarkTheme);
                    await module!.InvokeVoidAsync("setThemeData", themeData);
                }
            }
        }

        public void ObtainTheme(IEnumerable<KeyValuePairSerializer<string, string>>? cookie) {
            var record = cookie?.FirstOrDefault(record => record.Key == IsDarkThemeCookieKey)?.ToKeyValuePair;

            if(record.HasValue && bool.TryParse(record.Value.Value, out var isDarkTheme))
                IsDarkTheme = isDarkTheme;
        }
    }
}
