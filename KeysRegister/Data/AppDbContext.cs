using KeysRegister.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeysRegister.Data
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Identifier> Identifiers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=KeyRegisters;Username=root;Password=sasa");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Identifier>()
                .HasIndex(i => i.RfidCode)
                .IsUnique();
            modelBuilder.Entity<Identifier>()
                .HasData(
                    new Identifier(1, "0010614285", "Jan", "Kowalski", "Dział IT", ObjectType.Person),
                    new Identifier(2, "0004714539", "Arkadiusz", "Nowak", "Dział Transportu", ObjectType.Person),
                    new Identifier(3, "0011079912", "DZG27216", string.Empty, "100", ObjectType.Key),
                    new Identifier(4, "0004861400", "DZG27215", string.Empty, "185", ObjectType.Key),
                    new Identifier(5, "0004734756", "DZG00009", string.Empty, "185", ObjectType.Key),
                    new Identifier(6, "0004968393", "DZG10001", string.Empty, "188", ObjectType.Key)
                );
        }
    }
}
