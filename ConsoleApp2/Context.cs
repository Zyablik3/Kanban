using Microsoft.EntityFrameworkCore;
using ConsoleApp2.entity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Context : DbContext
    {
        /*public Context()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("host=localhost;port=5432;database=db;username=postgres;password=1475");
        }
        
            
       
        public DbSet<KanbanTask> KanbanTasks { get; set; }
        public DbSet<Zakazchik> Zakazchik { get; set; }
        public DbSet<KanbanProject> KanbanProjects { get; set; }
        public DbSet<MyTaskStatus> MyTaskStatuses { get; set; }
    }
}
