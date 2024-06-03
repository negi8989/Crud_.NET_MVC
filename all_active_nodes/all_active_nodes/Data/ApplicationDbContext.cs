using all_active_nodes.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace all_active_nodes.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<Node> Nodes { get; set; }

        public async Task<List<Node>> GetActiveNodesAsync()
        {
            return await Nodes.FromSqlRaw("EXEC GetActiveNodes").ToListAsync();
        }
    }
}
