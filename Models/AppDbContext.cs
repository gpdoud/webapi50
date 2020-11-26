using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext {

    public virtual DbSet<User>? Users { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    //protected override void OnConfiguring(DbContextOptionsBuilder options) {
    //    options.UseSqlServer("server=localhost,1433;database=ProdDb;uid=sa;pwd=p@ssw0rd1!;");
    //}
}