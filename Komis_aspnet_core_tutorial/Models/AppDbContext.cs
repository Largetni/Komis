﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Komis_aspnet_core_tutorial.Models
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {
        }

        public DbSet<Samochod> Samochody { get; set; }
    }
}