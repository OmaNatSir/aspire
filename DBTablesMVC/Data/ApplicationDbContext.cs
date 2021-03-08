﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBTablesMVC.Models;

namespace DBTablesMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        } 

        public DbSet<DldDatabase> DldDatabase { get; set; }
        public DbSet<DldSchema> DldSchema { get; set; }
        public DbSet<DldTable> DldTable { get; set; }
        public DbSet<DldColumn> DldColumn { get; set; }
    }
}