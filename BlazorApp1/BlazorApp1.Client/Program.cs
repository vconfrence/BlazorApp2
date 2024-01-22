using BlazorApp1.Client.Components;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

//builder.Services.AddCascadingValue(sp => new CascadingAppState { });
//builder.Services.AddCascadingValue(sp =>
//    new CascadingAppState());

//builder.Services.AddCascadingValue(sp =>
//    new CascadingAppState() { LastAccessed=DateTime.Now });

builder.Services.AddBlazoredLocalStorage();

await builder.Build().RunAsync();
