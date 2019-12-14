using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Sardinia;


namespace R5T.Polidea.Sardinia
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddGitHubAuthentication(this IServiceCollection services)
        {
            services
                .AddOptions()
                .Configure<GitHubAuthentication>()
                ;

            return services;
        }
    }
}
