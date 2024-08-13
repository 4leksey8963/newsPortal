using FakeNews.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using MongoDB.EntityFrameworkCore.Extensions;

namespace FakeNews.Persistence.Extension;

public static class PersistenceLayerExtension
{
    public static void AddPersistence(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddDbContext<FakeNewsDbContext>(options =>
            options.UseMongoDB(CreateClient(), MongoDBSettings.DatabaseName));
    }

    private static MongoClient CreateClient()
    {
        return new MongoClient(MongoDBSettings.AtlasURI);
    }
        
}