using System;

namespace NBetting.Web.Infrastructure.Queries
{
    public interface IQueryExecutor
    {
        TResult Execute<TResult>(IQuery<TResult> query);
    }

    public class QueryExecutor : IQueryExecutor
    {
        private readonly IServiceProvider _serviceProvider;

        public QueryExecutor(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public TResult Execute<TResult>(IQuery<TResult> query)
        {
            if (query == null)
                throw new ArgumentNullException(nameof(query));

            var handlerType = typeof(IQueryHandler<,>).MakeGenericType(query.GetType(), typeof(TResult));
            var handler = _serviceProvider.GetService(handlerType);
            return (TResult)((dynamic)handler).Handle((dynamic)query);
        }
    }
}
