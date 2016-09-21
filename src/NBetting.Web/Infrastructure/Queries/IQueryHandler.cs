namespace NBetting.Web.Infrastructure.Queries
{
    public interface IQueryHandler<in TQuery, out TResponse> where TQuery : IQuery<TResponse>
    {
        TResponse Execute(TQuery query);
    }
}