using KeysRegister.Entities;
using Microsoft.EntityFrameworkCore;

namespace KeysRegister.Data
{
    internal sealed class AppDbContext : DbContext
    {
        private readonly string _connectionString;
        internal AppDbContext(string connectionString)
        {
            _connectionString = connectionString;
            InitializeDatabase();
        }
        private void InitializeDatabase()
        {
            try
            {
                this.Database.EnsureCreated();
            }
            catch 
            {
                //ignore
            }
        }

        public DbSet<Identifier> Identifiers { get; set; }
        public DbSet<ReleasedKey> ReleasedKeys { get; set; }
        public DbSet<ReleasedKeyHistory> ReleasedKeysHistory { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(_connectionString);
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Identifier>()
                .HasIndex(i => i.RfidCode)
                .IsUnique();

            modelBuilder.Entity<ReleasedKey>()
                .HasIndex(i => i.KeyId)
                .IsUnique();

            modelBuilder.Entity<Identifier>()
                .HasData(
                    new Identifier(1, "0010614285", "Jan", "Kowalski", "Dział IT", ObjectType.Person),
                    new Identifier(2, "0004714539", "Arkadiusz", "Nowak", "Dział Transportu", ObjectType.Person),
                    new Identifier(3, "0011079912", "DZG27216", "Samochód osobowy", "Id 100", ObjectType.Key),
                    new Identifier(4, "0004861400", "DZG27215", "Samochód osobowy", "Id 101", ObjectType.Key),
                    new Identifier(5, "0004734756", "DZG00009", "Samochód ciężarowy", "Nr boczny 185", ObjectType.Key),
                    new Identifier(6, "0004968393", "DZG10001", "Samochód ciężarowy", "Nr boczny 188", ObjectType.Key)
                );
        }
    }
}
