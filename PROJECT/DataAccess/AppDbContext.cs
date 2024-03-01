using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace DataAccess
{
    public class AppDbContext : BizlabbgIcanContext
    {
        public AppDbContext() { }
        public AppDbContext(DbContextOptions<BizlabbgIcanContext> options): base(options) { }

    }
}
