﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4_EFCore.CodeFirst.Models
{
    public class MundialDBContext: DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {

            string myConnectionString = "Server=DESKTOP-S1DROK0\\SQLEXPRESS;Database=MundialUEFADB;MultipleActiveResultSets=true;Trusted_Connection=true";

            //string myConnectionString = "Server=DESKTOP-S1DROK0\\SQLEXPRESS;Database=MundialUEFADB;User=esan;Pwd=esan2021";

            optionsBuilder.UseSqlServer(myConnectionString)
                .LogTo(Console.WriteLine, LogLevel.Information);

            base.OnConfiguring(optionsBuilder);
        
        }

        public virtual DbSet<Player> Player { get; set; }


    }
}
