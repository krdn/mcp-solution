using Microsoft.Extensions.DependencyInjection;

namespace MCP.Core;

/// <summary>
/// Extension methods for setting up core services in an <see cref="IServiceCollection" />.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds core services to the container.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <returns>The service collection.</returns>
    public static IServiceCollection AddCoreServices(this IServiceCollection services)
    {
        // Register core services here
        
        return services;
    }
}
