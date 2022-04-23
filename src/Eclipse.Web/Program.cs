using Eclipse.Core;
using Eclipse.Web;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped<IDiceRoller, DiceRoller>();
builder.Services.AddScoped<ShipAttack>();

await builder.Build().RunAsync();
