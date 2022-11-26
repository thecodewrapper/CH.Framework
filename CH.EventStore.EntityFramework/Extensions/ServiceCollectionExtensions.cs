using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CH.EventStore.Abstractions;
using CH.EventStore.EntityFramework.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CH.EventStore.EntityFramework.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddEventStoreEFCore(this IServiceCollection services, Action<EventStoreOptions> options)
        {
            EventStoreOptions eventStoreOptions = new EventStoreOptions();
            options.Invoke(eventStoreOptions);

            services.AddScoped<IEventStore, EFEventStore>();
            services.AddScoped<IEventStoreSnapshotProvider, EFEventStoreSnapshotProvider>();
            services.AddScoped<IRetroactiveEventsService, EFRetroactiveEventsService>();

            if (eventStoreOptions.UseInMemoryDatabase)
            {
                services.AddDbContext<EventStoreDbContext>(options =>
                    options.UseInMemoryDatabase("EventStoreDb"));
            }
            else
            {
                services.AddDbContext<EventStoreDbContext>(options => options.UseSqlServer(eventStoreOptions.ConnectionStringSQL));
            }
            return services;
        }
    }
}
