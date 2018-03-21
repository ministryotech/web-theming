using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;

namespace Ministry.Web.Themes
{
    /// <summary>
    /// DI shorthand extensions.
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public static class DependencyServiceManager
    {
        /// <summary>
        /// Adds the core library services to the Dependency Resolver.
        /// </summary>
        /// <param name="services">The service collection.</param>
        /// <returns></returns>
        public static IServiceCollection AddHostTheming(this IServiceCollection services)
            => services
                .AddTransient<IThemeManager, HostThemeManager>()
                .AddTransient<IKeyedTheme, HostTheme>();
    }
}
