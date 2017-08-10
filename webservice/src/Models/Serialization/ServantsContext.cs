using System.Data.Entity;

namespace FGOData.Models.Serialization
{
    public class ServantsContext : DbContext
    {
        public ServantsContext() : base("name=ServantsContext")
        {
        }
        public DbSet<Servant> Servants { get; set; }
    }
}