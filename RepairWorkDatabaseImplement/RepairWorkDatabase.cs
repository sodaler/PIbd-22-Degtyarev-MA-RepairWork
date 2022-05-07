using System;
using System.Collections.Generic;
using System.Text;
using RepairWorkDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;

namespace RepairWorkDatabaseImplement
{
    public class RepairWorkDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-1TH8GFI\SQLEXPRESS;Initial Catalog=RepairWorkDatabase;Integrated Security=True;MultipleActiveResultSets=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Component> Components { set; get; }
        public virtual DbSet<Repair> Repairs { set; get; }
        public virtual DbSet<RepairComponent> RepairComponents { set; get; }
        public virtual DbSet<Order> Orders { set; get; }
        public virtual DbSet<Client> Clients { set; get; }
    }
}
