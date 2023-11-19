﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vieru_Marina_lab2.Models;

namespace Vieru_Marina_lab2.Data
{
    public class Vieru_Marina_lab2Context : DbContext
    {
        public Vieru_Marina_lab2Context (DbContextOptions<Vieru_Marina_lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Vieru_Marina_lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Vieru_Marina_lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Vieru_Marina_lab2.Models.Author>? Author { get; set; }
    }
}
