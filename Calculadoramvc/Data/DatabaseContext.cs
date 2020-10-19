using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace mvc_lab.Data{

    public class DatabaseContext : DbContext{

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        { }

        public DbSet<mvc_lab.Models.Contacto> Contactos { get; set; }
        public DbSet<mvc_lab.Models.Covid> Covid { get; set; }
    }
}