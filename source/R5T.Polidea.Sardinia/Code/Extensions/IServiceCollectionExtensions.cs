using System;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

using R5T.Dacia;
using R5T.Sardinia;


namespace R5T.Polidea.Sardinia
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="IOptions{TOptions}"/> of <see cref="GitHubAuthentication"/>.
        /// </summary>
        public static IServiceCollection AddGitHubAuthenticationOptions(this IServiceCollection services)
        {
            services
                .Configure<GitHubAuthentication>()
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="IOptions{TOptions}"/> of <see cref="GitHubAuthentication"/>.
        /// </summary>
        public static IServiceAction<IOptions<GitHubAuthentication>> AddGitHubAuthenticationOptionsAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction.New<IOptions<GitHubAuthentication>>(() => services.AddGitHubAuthenticationOptions());
            return serviceAction;
        }
    }
}
