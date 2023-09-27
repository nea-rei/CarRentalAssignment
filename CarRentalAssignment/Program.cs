using Business.Classes;
using CarRentalAssignment;
using Data.Classes;
using Data.Interfaces;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddSingleton<IData, CollectionData>();//kan l�gga till en testklass, tex f�r unittesting
builder.Services.AddSingleton<BookingProcessor>();//skapar ett enda objekt som lever f�r hela appen

await builder.Build().RunAsync();
