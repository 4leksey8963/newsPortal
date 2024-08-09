namespace FakeNews.API.NSwag;

public static class NSwagConfig
{
    public static void AddNSwag(this WebApplicationBuilder builder)
    {
        builder.Services.AddOpenApiDocument();
    }

    public static void AddNSwagDev(this WebApplication app)
    {
        if (!app.Environment.IsDevelopment()) return;
        
        app.UseOpenApi();
        app.UseSwaggerUi();
        app.UseReDoc(options =>
        {
            options.Path = "/redoc";
        });
    }
}