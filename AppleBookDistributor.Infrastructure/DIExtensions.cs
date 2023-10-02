using AppleBookDistributor.Domain.IRepositories;
using AppleBookDistributor.Domain.IServices;
using AppleBookDistributor.Domain.Services;
using AppleBookDistributor.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AppleBookDistributor.Infrastructure;

public static class DiExtensions
{
    public static IServiceCollection AddCommonServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddSingleton<IAppleRepository, AppleRepository>();
        services.AddSingleton<IBookRepository, BookRepository>();
        services.AddSingleton<IAppleService, AppleService>();
        services.AddSingleton<IBookService, BookService>();
        return services;
    }

}