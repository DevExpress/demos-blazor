<div class="alert dxbl-alert alert-primary" role="alert">AI services used for this demo have been rate limited. As such, you may experience performance-related delays when exploring the capabilities of DevExpress AI-powered Extensions.
<br />When connected to your own AI model/service without rate limits, DevExpress AI-powered Extensions will perform seamlessly, without artificial delays.</div>

This demo incorporates an AI-powered [Smart Paste extension](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFormLayout?v=26.1#ai-powered-smart-paste) into the DevExpress Blazor [Form Layout](xref:DevExpress.Blazor.DxFormLayout) component. The extension simplifies data entry scenarios when information is copied from external sources. It parses unstructured text (such as email content or free-form notes) and automatically populates matching form fields with extracted values.

To replicate Smart Paste functionality in your next great DevExpress-powered Blazor project, you must:

1. Register the desired AI service in your application. Select the approach that best fits your needs:

    * [Use the DevExpress Template Kit](https://docs.devexpress.com/Blazor/405228/ai-powered-extensions) to create a new project with pre-configured AI services and NuGet packages.
    * [Integrate](https://docs.devexpress.com/Blazor/405228/ai-powered-extensions#manual-ai-services-integration) the desired AI service into your existing application.

2. Register the following namespaces in the _Components/Imports.razor_ file or in your Razor file:
    * [DevExpress.AIIntegration.Blazor.Layout](https://docs.devexpress.com/Blazor/DevExpress.AIIntegration.Blazor.Layout)
    * [DevExpress.AIIntegration.Blazor](https://docs.devexpress.com/Blazor/DevExpress.AIIntegration.Blazor)
    * [DevExpress.AIIntegration.Extensions](https://docs.devexpress.com/CoreLibraries/DevExpress.AIIntegration.Extensions)

3. Use the [Extensions](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFormLayout.Extensions) property to add the AI-powered Smart Paste functionality to the Form Layout component.
4. Write your own code to obtain source text (for example, from an editor, clipboard, file, or external system).
5. Add a button that calls the [FormLayout.SmartPasteAsync](https://docs.devexpress.com/Blazor/DevExpress.AIIntegration.Blazor.Layout.FormLayoutSmartPasteExtensions.SmartPasteAsync(DevExpress.Blazor.DxFormLayout-System.String)?v=26.1) method. Pass the obtained text to this method.

**Note:** DevExpress AI-powered extensions follow the "bring your own key" principle. DevExpress does not offer a REST API and does not ship any built-in LLMs/SLMs. You need an active Azure/Open AI subscription to obtain the REST API endpoint, key, and model deployment name. These variables must be specified at application startup to register AI clients and enable DevExpress AI-powered extensions in your application.