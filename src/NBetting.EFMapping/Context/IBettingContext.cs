using System.Data.Entity;
using NBetting.Domain.Entities;

namespace NBetting.EFMapping.Context
{
    public interface IBettingContext
    {
        DbSet<TEntity> DbSet<TEntity>() where TEntity : Entity;
        int Commit();
    }
}