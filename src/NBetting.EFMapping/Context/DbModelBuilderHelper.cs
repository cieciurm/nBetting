using System.Data.Entity;
using NBetting.Domain.ValueObjects;

namespace NBetting.EFMapping.Context
{
    public static class DbModelBuilderHelper
    {
        public static void BuildModel(DbModelBuilder modelBuilder)
        {
            modelBuilder.ComplexType<Score>();
        }
    }
}
