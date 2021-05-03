using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Up4All.Framework.MessageBus.Abstractions.Mocks;
using Up4All.Framework.MessageBus.Abstractions.Options;

namespace Up4All.Framework.MessageBus.Abstractions.Configurations
{
    public static class MessageBusConfiguration
    {
        private static void AddConfigurationBinder(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<MessageBusOptions>(config => configuration.GetSection("MessageBusOptions").Bind(config));
        }

        public static void AddMessageBusQueueClient<T>(this IServiceCollection services, IConfiguration configuration) where T : MessageBusQueueClient
        {
            services.AddConfigurationBinder(configuration);
            services.AddScoped<MessageBusQueueClient, T>();
        }

        public static void AddMessageBusTopicClient<T>(this IServiceCollection services, IConfiguration configuration) where T : MessageBusTopicClient
        {
            services.AddConfigurationBinder(configuration);
            services.AddScoped<MessageBusTopicClient, T>();
        }

        public static void AddMessageBusSubscribeClient<T>(this IServiceCollection services, IConfiguration configuration) where T : MessageBusSubscribeClient
        {
            services.AddConfigurationBinder(configuration);
            services.AddScoped<MessageBusSubscribeClient, T>();
        }

        public static void AddMessageBusQueueClientMocked<T>(this IServiceCollection services) where T : MessageBusQueueClientMock
        {            
            services.AddScoped<MessageBusQueueClientMock, T>();
        }

        public static void AddMessageBusTopicClientMocked<T>(this IServiceCollection services) where T : MessageBusTopicClientMock
        {            
            services.AddScoped<MessageBusTopicClientMock, T>();
        }

        public static void AddMessageBusSubscribeClientMocked<T>(this IServiceCollection services) where T : MessageBusSubscribeClientMock
        {            
            services.AddScoped<MessageBusSubscribeClientMock, T>();
        }
    }
}
