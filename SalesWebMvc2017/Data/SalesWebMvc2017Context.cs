﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc2017.Models
{
    public class SalesWebMvc2017Context : DbContext
    {
        public SalesWebMvc2017Context (DbContextOptions<SalesWebMvc2017Context> options)
            : base(options)
        {
        }

        public DbSet<SalesWebMvc2017.Models.Department> Department { get; set; }
    }
}
