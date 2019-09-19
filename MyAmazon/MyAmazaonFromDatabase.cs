namespace MyAmazon
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyAmazaonFromDatabase : DbContext
    {
        public MyAmazaonFromDatabase()
            : base("name=MyAmazaonFromDatabase")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.FirstName)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.LastName)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.Email)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Total_Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
            .Property(e => e.Name)
            .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.Description)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.Catagory)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Cart>()
                .Property(e => e.Customer_ID)
                .IsOptional();

            modelBuilder.Entity<Cart>()
                .Property(e => e.Product_ID)
                .IsOptional();

            modelBuilder.Entity<Cart>()
                .Property(e => e.Quality)
                .IsOptional();
        }
    }
}
