using Crud_Operation.Modal;
using Microsoft.EntityFrameworkCore;

namespace Crud_Operation.Data
{
    public class ApiDbContext : DbContext

    {

        public ApiDbContext(DbContextOptions<ApiDbContext> options)
          : base(options)
        {
        }

        public DbSet<Node> Nodes { get; set; }
    }
}
