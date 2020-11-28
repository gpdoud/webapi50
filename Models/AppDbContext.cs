using Microsoft.EntityFrameworkCore;
using webapi50.Models;

public class AppDbContext : DbContext {

        public  DbSet<User>? Users { get; set; }
        public  DbSet<Vendor>? Vendors { get; set; }
        public  DbSet<Product>? Products { get; set; }
        public  DbSet<Request>? Requests { get; set; }
        public  DbSet<Requestline>? Requestlines { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public AppDbContext() { }

        //protected override void OnModelCreating(ModelBuilder bld) {
        
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder options) {
        //    options.UseSqlServer("server=localhost,1433;database=ProdDb;uid=sa;pwd=p@ssw0rd1!;");
        //}
    }
