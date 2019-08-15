using Core_web.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core_web.ViewModels;

namespace Core_web.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            :base(options)
        {

        }

        public DbSet<Student> Students { get; set; }

    }
    
}
