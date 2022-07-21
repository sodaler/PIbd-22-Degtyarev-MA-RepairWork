using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;
using RepairWorkContracts.StoragesContracts;

namespace RepairWorkDatabaseImplement.Implements
{
    public class BackUpInfo : IBackUpInfo
    {
        public Assembly GetAssembly() => typeof(BackUpInfo).Assembly;

        public List<PropertyInfo> GetFullList()
        {
            using var context = new RepairWorkDatabase();
            var type = context.GetType();
            return type.GetProperties().Where(x =>
            x.PropertyType.FullName.StartsWith("Microsoft.EntityFrameworkCore.DbSet")).ToList();
        }

        public List<T> GetList<T>() where T : class, new()
        {
            using var context = new RepairWorkDatabase();
            return context.Set<T>().ToList();
        }
    }
}
