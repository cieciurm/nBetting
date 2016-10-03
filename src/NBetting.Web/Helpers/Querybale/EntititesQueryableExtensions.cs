using System.Linq;
using NBetting.Domain.Entities;

namespace NBetting.Web.Helpers.Querybale
{
    public static class EntititesQueryableExtensions
    {
        public static IQueryable<TEntity> NotDeleted<TEntity>(this IQueryable<TEntity> query)
            where TEntity : Entity
        {
            return query.Where(x => !x.IsDeleted);
        }
    }
}
