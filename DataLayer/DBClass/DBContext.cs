using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.TableClass;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace DataLayer.DBClass
{
   public class DBContext:IdentityDbContext
    {
        public DBContext(DbContextOptions<DBContext> option):base(option)
        {

        }
        public DbSet<OPS_Mst_Employee> TBL_OPS_Mst_Employees { get; set; }
        public DbSet<OPS_Mst_Dept> TBL_OPS_Mst_Dept { get; set; }
        public DbSet<Ops_Mst_Activity> TBL_OPS_Mst_Activity { get; set; }
        public DbSet<OPS_Mst_ProvisionalMerchant> TBL_OPS_Mst_ProvisionalMerchant { get; set; }
        public DbSet<OPS_Trn_ActivityPerformed> TBL_OPS_Trn_ActivityPerformed { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
