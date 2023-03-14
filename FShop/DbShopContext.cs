using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FShop;

public partial class DbShopContext : DbContext
{
    private static DbShopContext _context;
   
    public static DbShopContext GetContext()
    {
        if (_context == null)
            _context = new DbShopContext();
        return _context;
    }
    public DbShopContext()
    {
    }

    public DbShopContext(DbContextOptions<DbShopContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductsInOrder> ProductsInOrders { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=C:\\Users\\bolsh\\Downloads\\Telegram Desktop\\DBShop.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasIndex(e => e.Id, "IX_Orders_ID").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Fullprice).HasColumnType("NUMERIC");
            entity.Property(e => e.IdUser).HasColumnName("ID_user");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasIndex(e => e.Id, "IX_Products_ID").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<ProductsInOrder>(entity =>
        {
            entity.ToTable("Products_In_Order");

            entity.HasIndex(e => e.Id, "IX_Products_In_Order_ID").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdOrder).HasColumnName("ID_order");
            entity.Property(e => e.IdProduct).HasColumnName("ID_product");

            entity.HasOne(d => d.IdOrderNavigation).WithMany(p => p.ProductsInOrders)
                .HasForeignKey(d => d.IdOrder)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.IdProductNavigation).WithMany(p => p.ProductsInOrders)
                .HasForeignKey(d => d.IdProduct)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasIndex(e => e.Email, "IX_Users_Email").IsUnique();

            entity.HasIndex(e => e.Id, "IX_Users_ID").IsUnique();

            entity.HasIndex(e => e.Login, "IX_Users_Login").IsUnique();

            entity.HasIndex(e => e.Phone, "IX_Users_Phone").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
