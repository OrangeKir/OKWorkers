namespace OKWorkers.Controller
{
    using Microsoft.EntityFrameworkCore;
    using Model;

    /// <summary>
    /// База данных
    /// </summary>
    public class MyDbContext : DbContext
    {
        /// <summary> ctor </summary>
        private MyDbContext()
        {
            Database.EnsureCreated();
        }
        
        /// <summary> Тестируемые кандидаты </summary>
        public DbSet<Candidate> Candidates { get; set; }
        
        /// <summary> Навыки </summary>
        public DbSet<Skill> Skills { get; set; }

        /// <summary> Навыки в дизайне </summary>
        public DbSet<DesignSkill> DesignSkills { get; set; }
        
        /// <summary> Соединение </summary>
        public static MyDbContext Context { get; private set; }

        /// <inheritdoc />
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-DNUUDD2\SQLEXPRESS;Database=OKWorkers;Trusted_Connection=True");
        }

        /// <summary> Открыть соединение </summary>
        public static void OpenConnection()
        {
            Context ??= new MyDbContext();
        }
        
        /// <summary> Закрыть соединение </summary>
        public static void CloseConnection()
        {
            Context.Dispose();
        }
    }
}