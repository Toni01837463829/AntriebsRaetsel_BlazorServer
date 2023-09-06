using Microsoft.EntityFrameworkCore;
using Model.Entities;

namespace Model.Configurations;

public class AntriebsContext : DbContext
{
    public AntriebsContext(DbContextOptions<AntriebsContext> options) : base(options)
    {
    }


    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Answers>().HasOne(a => a.Question)
            .WithMany()
            .HasForeignKey(a => a.QuestionId);

    }

    public DbSet<Scores> Scores { get; set; }
    public DbSet<Questions> Questions { get; set; }
    public DbSet<Answers> Answers { get; set; }


}