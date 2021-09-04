using System;
using Microsoft.EntityFrameworkCore;

namespace KundeApp1.Model
{
    public class KundeDB :DbContext
    {
        public KundeDB (DbContextOptions<KundeDB> options) : base(options)
        {
            //Forsikrer oss om at databasen blir laget.
            Database.EnsureCreated();
        }

        //Kobler oss til databasen
        public DbSet<Kunde> Kunder { get; set; }
    }
}
