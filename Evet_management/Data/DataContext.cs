using Evet_management.models;
using Microsoft.EntityFrameworkCore;

namespace  Evet_management.Data
{
     public class DataContext:DbContext{
        public DataContext(DbContextOptions<DataContext>options) : base(options){

        }
        public DbSet<Event> Events{get; set;}

        internal object GetEvents()
        {
            throw new NotImplementedException();
        }
    }


}