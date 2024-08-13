using FakeNews.API.Mocks;
using FakeNews.API.NSwag;
using FakeNews.Persistence.Context;
using FakeNews.Persistence.Extension;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.AddNSwag();
builder.Services.AddControllers();

builder.Services.Configure<MongoDBSettings>(builder.Configuration.GetSection(nameof(MongoDBSettings)));


// Mocks
builder.Services.AddSingleton<MockNewsStorage>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.AddNSwagDev();
}

app.UseRouting();
app.MapControllers();

app.Run();
