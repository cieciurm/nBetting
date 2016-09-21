using System;

namespace NBetting.Web.Infrastructure.Commands
{
    public interface ICommandExecutor
    {
        void Execute(ICommand command);
    }

    public class CommandExecutor : ICommandExecutor
    {
        private readonly IServiceProvider _serviceProvider;

        public CommandExecutor(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void Execute(ICommand command)
        {
            var handlerType = typeof(ICommandHandler<>).MakeGenericType(command.GetType());
            dynamic handler = _serviceProvider.GetService(handlerType);
            handler.Handle((dynamic)command);
        }
    }
}
