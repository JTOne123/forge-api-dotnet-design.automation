/* 
 * Forge SDK
 *
 * The Forge Platform contains an expanding collection of web service components that can be used with Autodesk cloud-based products or your own technologies. Take advantage of Autodesk’s expertise in design and engineering.
 *
 * Design Automation
 *
 * Generated by [Forge Swagger Codegen](https://git.autodesk.com/forge-ozone/forge-rsdk-codegen)
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using Autodesk.Forge.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Autodesk.Forge.DesignAutomation.Rsdk.Http;

namespace Autodesk.Forge.DesignAutomation.Rsdk
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds DesignAutomationClient and configures it with the given configuration.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IHttpClientBuilder AddDesignAutomation(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<Configuration>(configuration.GetSection("Forge").GetSection("DesignAutomation"));
            services.AddForgeService(configuration);
            services.AddTransient<IActivitiesApi,ActivitiesApi>();
            services.AddTransient<IAppBundlesApi,AppBundlesApi>();
            services.AddTransient<IEnginesApi,EnginesApi>();
            services.AddTransient<IForgeAppsApi,ForgeAppsApi>();
            services.AddTransient<IHealthApi,HealthApi>();
            services.AddTransient<ISharesApi,SharesApi>();
            services.AddTransient<IWorkItemsApi,WorkItemsApi>();
            services.AddTransient<DesignAutomationClient>();
            return services.AddForgeService(configuration);
        }
    }
}
