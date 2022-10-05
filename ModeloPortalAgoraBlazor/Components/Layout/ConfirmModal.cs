using System.Text.Json.Serialization;
using Microsoft.JSInterop;
using ModeloPortalAgoraBlazor.Components.Enums;

namespace ModeloPortalAgoraBlazor.Components.Layout;

public class AlertModal
{
    private readonly string _alertType;
    private readonly string _title;
    private readonly string _message;
    private readonly string _icon;
    private readonly IJSRuntime _jsRuntime;

    public AlertModal(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    public async Task<bool> ShowConfirmAsync(string title, string message, string icon, string textButton = null)
    {
        var param = new Dictionary<string, object>
        {
            { "title", title },
            { "text", message },
            { "icon", icon },
            { "showCancelButton", true },
            { "confirmButtonColor", "#00ad88" },
            { "cancelButtonColor", "#d33" },
            { "confirmButtonText", textButton ?? "Excluir" },
            { "cancelButtonText", "Cancelar"}
        };

        var res = await _jsRuntime.InvokeAsync<JsonResponse>("Swal.fire", param);
        return res.Value;
    }
    public async Task ShowAlertAsync(string title, string message, string icon)
    {
        var param = new Dictionary<string, object>
        {
            { "title", title },
            { "text", message },
            { "icon", icon }
        };
        await _jsRuntime.InvokeVoidAsync("Swal.fire", param);
    }
    
    public async Task ShowToastAsync(string title, string icon)
    {
        await _jsRuntime.InvokeVoidAsync("toast", title, icon);
        // var param = new Dictionary<string, object>();
        // param.Add("title", _message);
        // param.Add("icon",  _icon.ToString());

        // param.Add("toast", _title);
        // param.Add("position", _message);
        // param.Add("showConfirmButton",  false);
        // param.Add("timer",  300);
        // param.Add("timerProgressBar",  true);
        // param.Add("showConfirmButton",  false);
    }
}

public class JsonResponse
{
    [JsonPropertyName("dismiss")]
    public string Dismiss { get; set; }
   
    [JsonPropertyName("value")]
    public bool Value { get; set; }
}
