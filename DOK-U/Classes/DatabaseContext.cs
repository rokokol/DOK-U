using Microsoft.EntityFrameworkCore;


namespace DOK_U.Classes
{
    internal class DatabaseContext : DbContext
    {
        public DbSet<Person> Users { get; set; } = null!;
        public DbSet<Group> Groups { get; set; } = null!;
        public DbSet<Mark> Marks { get; set; } = null!;
        public DbSet<Cabinet> Cabinets { get; set; } = null!;
        public DbSet<Lecture> Lectures { get; set; } = null!;
        public DbSet<Schedule> Schedules { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=../../../Source/doku.db");
        }
    }
}
