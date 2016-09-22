using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NBetting.Web.Infrastructure.Events;

namespace NBetting.Web.Controllers.Example
{
    public class ExampleEvent : IEvent
    {
        public string Value { get; set; }
    }

    public class ExampleEventHanlderOne : IEventHandler<ExampleEvent>
    {
        public void Handle(ExampleEvent @event)
        {
        }
    }

    public class ExampleEventHanlderTwo : IEventHandler<ExampleEvent>
    {
        public void Handle(ExampleEvent @event)
        {
        }
    }
}
