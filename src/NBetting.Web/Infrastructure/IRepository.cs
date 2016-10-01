using System.Data.Entity.Migrations;
using System.Linq;
using NBetting.Domain.Entities;
using NBetting.EFMapping.Context;

namespace NBetting.Web.Infrastructure
{
    public interface IRepository<TEntity>
        where TEntity : Entity
    {
        TEntity AddOrEdit(TEntity entity);
        TEntity Get(int id);
        IQueryable<TEntity> Query();

    }

    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : Entity

    {
        private readonly IBettingContext _context;

        public Repository(IBettingContext context)
        {
            _context = context;
        }

        public TEntity AddOrEdit(TEntity entity)
        {
            _context.DbSet<TEntity>().AddOrUpdate(entity);
            return entity;
        }

        public TEntity Get(int id)
        {
            return _context.DbSet<TEntity>().SingleOrDefault(x => x.Id == id && !x.IsDeleted);
        }

        public IQueryable<TEntity> Query()
        {
            return _context.DbSet<TEntity>().AsQueryable();
        }
    }
}
