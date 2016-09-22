using System;
using System.Collections;
using Microsoft.Extensions.DependencyInjection;

namespace NBetting.Web.Infrastructure.Events
{
    public interface IEventPublisher
    {
        void Publish(IEvent @event);
    }

    public class EventPublisher : IEventPublisher
    {
        private readonly IServiceProvider _serviceProvider;

        public EventPublisher(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void Publish(IEvent @event)
        {
            if (@event == null)
                throw new ArgumentNullException(nameof(@event));

            var eventHandlerType = typeof(IEventHandler<>).MakeGenericType(@event.GetType());
            IEnumerable handlers = _serviceProvider.GetServices(eventHandlerType);
            foreach (var handler in handlers)
            {
                //Event handlers should be independent so we catch each execution of single handler
                try
                {
                    ((dynamic)handler).Handle((dynamic)@event);
                }
                catch (Exception)
                {
                    //TODO[JA] : We should log here
                    throw;
                }
            }
        }
    }
}
