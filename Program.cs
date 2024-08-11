using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);


// Register HttpClient
builder.Services.AddHttpClient();

builder.Services.AddControllers();
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.MapControllers();
app.MapGet("/", () => "Hello World!");

app.Run();



// LINQ Dictionary 
// Definition: Select 
// Does XYZ

// Format  example
// Link to official microsoft documentation 

// 


// look for modules


// connect to a database?
// could be useful ..





// what do I want 

// I want a helper application that can be used for 
// 1. managing local developer environments 
// 2. creating snadbox modules for various programming language scenarios
    // ex: testing linq query operation using different sets of data 

// modules
// container entity
// module for managing local dev projects 
// -> comes with tools to debug startup times
// -> find hanging threads
// * a set of scripts that can be ran manually or automatically every so often 
// 


// when this project runs 
// it looks for available modules 
// where do modules come from? 
// self owned package manager 
// container registry? 
// -> so these modules would be containers? 
// -> on my local machine, pull down the latest container for my module 
// __ too much thinking, lets just make the linq dictionary first and go from there 

// 