using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ModeloPortalAgoraBlazor;
using ModeloPortalAgoraBlazor.Components.Layout;
using ModeloPortalAgoraBlazor.Services;
using ModeloPortalAgoraBlazor.Services.Interfaces;
using ModeloPortalAgoraBlazor.State;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped<ClienteState>();
builder.Services.AddScoped<IChangeService, ChangeService>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
