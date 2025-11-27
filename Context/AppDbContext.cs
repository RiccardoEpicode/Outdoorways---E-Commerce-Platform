using E_Commerce_Outdoorways.Entities;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_Outdoorways.Context
{
    // DbContext represents a working session with the database.
    // It manages:
    // - the database connection
    // - executing queries
    // - transactions
    // - tracking changes of entities
    //
    // EF Core creates ONE DbContext per HTTP request (via Dependency Injection).
    public class AppDbContext : DbContext
    {
        // The constructor receives DbContextOptions,
        // which contain all configuration needed by EF Core:
        // - SQL Server provider
        // - Connection string
        // - Lazy loading settings
        // - Tracking behavior
        //
        // The options are sent to the base class (DbContext)
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        // DbSet<T> represents a TABLE in the database.
        //
        // Example:
        // DbSet<Product> Products → SQL table "Products"
        // DbSet<User> Users       → SQL table "Users"
        //
        // Each DbSet:
        // - Allows LINQ queries (SELECT)
        // - Allows adding objects (INSERT)
        // - Allows modifying objects (UPDATE)
        // - Allows removing objects (DELETE)
        //
        // EF Core automatically maps each entity class to the SQL table
        // using "conventions" unless a different mapping is configured.


        // --------------------------------------------------------------------
        // EXPLANATION: WHY "DbSet<Category> Categories { get; set; }" ?
        // --------------------------------------------------------------------
        //
        // DbSet<Category>:
        // - "DbSet" means: this is a database table.
        // - "<Category>" means: each row in the table is mapped to a Category object.
        //
        // Categories (property name):
        // - Should be plural because it represents a COLLECTION of Category objects.
        // - EF Core uses this name to generate the SQL table name (by convention).
        //
        // { get; set; }:
        // - EF Core uses the property accessors to read/write data to the table.
        //
        // In summary:
        // DbSet<Category> Categories = a strongly-typed representation of the SQL "Categories" table.

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        // --------------------------------------------------------------------
        // OnModelCreating()
        // --------------------------------------------------------------------
        //
        // This method is used to configure the database model BEFORE
        // EF Core generates the tables.
        //
        // Here you can:
        // - Define relationships (1-to-many, many-to-many, etc.)
        // - Override table names and column names
        // - Configure field constraints (max length, required, default values)
        // - Add seed data (initial data for tables)
        // - Add indexes
        //
        // If left empty (as now), EF Core uses *conventions* and *data annotations*
        // to build the schema automatically.
        //
        // Calling base.OnModelCreating(modelBuilder) ensures EF's default
        // conventions still work correctly.

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>(e => 
            {
                e.HasKey("CategoryId");
                e.Property("CategoryId").ValueGeneratedOnAdd();
                e.HasData(
                    new Category { CategoryId = 1, CategoryName = "Men"},
                    new Category { CategoryId = 2, CategoryName = "Women" },
                    new Category { CategoryId = 3, CategoryName = "Kids" },
                    new Category { CategoryId = 4, CategoryName = "Autumn" },
                    new Category { CategoryId = 5, CategoryName = "Winter" },
                    new Category { CategoryId = 6, CategoryName = "Spring" },
                    new Category { CategoryId = 7, CategoryName = "Summer" }
                );
            });

            modelBuilder.Entity<Product>(e =>
            {
                e.HasKey("ProductId");
                e.Property("ProductId").ValueGeneratedOnAdd();
                e.Property("Price").HasColumnType("decimal(10,2)");
                e.HasOne(e => e.Category).WithMany(p => p.Products).HasForeignKey(e => e.CategoryId).OnDelete(DeleteBehavior.Restrict);

                // SEED PRODUCTS -> this is how you add data to the tables
                e.HasData(
                   new Product
                   {
                       ProductId = 1,
                       ProductName = "Men Winter Jacket",
                       ProductDesc = "High-quality winter jacket designed for extreme cold. Warm, durable and perfect for outdoor adventures.",
                       Price = 129.99m,
                       ProductQty = 20,
                       CategoryId = 1,
                       ProductIMG = "jacket1.jpg"
                   },

                    new Product
                    {
                        ProductId = 2,
                        ProductName = "Women Winter Coat",
                        ProductDesc = "Premium women’s winter coat crafted for warmth, comfort and style. Ideal for harsh winter conditions.",
                        Price = 149.99m,
                        ProductQty = 15,
                        CategoryId = 2,
                        ProductIMG = "coat1.jpg"
                    },

                    new Product
                    {
                        ProductId = 3,
                        ProductName = "Kids Hoodie",
                        ProductDesc = "Soft and comfortable hoodie for kids. Perfect for school, play, or layering on chilly days.",
                        Price = 39.99m,
                        ProductQty = 30,
                        CategoryId = 3,
                        ProductIMG = "hoodie.jpg"
                    },

                    new Product
                    {
                        ProductId = 4,
                        ProductName = "Autumn Flannel Shirt",
                        ProductDesc = "Classic autumn flannel shirt made from breathable cotton. A warm and stylish choice for the fall season.",
                        Price = 49.99m,
                        ProductQty = 40,
                        CategoryId = 4,
                        ProductIMG = "flannel.jpg"
                    },

                    new Product
                    {
                        ProductId = 5,
                        ProductName = "Winter Thermal Gloves",
                        ProductDesc = "Insulated thermal gloves for maximum warmth. Ideal for winter sports, hiking, and everyday use.",
                        Price = 19.99m,
                        ProductQty = 50,
                        CategoryId = 5,
                        ProductIMG = "gloves.jpg"
                    },

                    new Product
                    {
                        ProductId = 6,
                        ProductName = "Spring Light Jacket",
                        ProductDesc = "Lightweight spring jacket designed for mild weather. Wind-resistant and comfortable for outdoor activities.",
                        Price = 69.99m,
                        ProductQty = 22,
                        CategoryId = 6,
                        ProductIMG = "lightjacket.jpg"
                    },

                    new Product
                    {
                        ProductId = 7,
                        ProductName = "Summer T-Shirt",
                        ProductDesc = "Breathable, comfortable summer t-shirt made from soft cotton. Perfect for hot days and outdoor adventures.",
                        Price = 15.99m,
                        ProductQty = 60,
                        CategoryId = 7,
                        ProductIMG = "tshirt.jpg"
                    },

                    new Product
                    {
                        ProductId = 8,
                        ProductName = "Summer Shorts",
                        ProductDesc = "Light and durable summer shorts designed for maximum comfort. Ideal for hiking, beach, and casual wear.",
                        Price = 24.99m,
                        ProductQty = 45,
                        CategoryId = 7,
                        ProductIMG = "shorts.jpg"
                    }


                );



            });

            modelBuilder.Entity<Order>(e =>
            {
                e.HasKey("OrderId");
                e.Property("OrderId").ValueGeneratedOnAdd();
                e.Property("TotalAmount").HasColumnType("decimal(10,2)");
                e.HasOne(e => e.User).WithMany(p => p.Orders).HasForeignKey(e => e.UserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<OrderItem>(e =>
            {
                e.HasKey("OrderItemId");
                e.Property("OrderItemId").ValueGeneratedOnAdd();
                e.Property("Price").HasColumnType("decimal(10,2)");
                e.HasOne(e => e.Order).WithMany(p => p.OrderItems).HasForeignKey(e => e.OrderId).OnDelete(DeleteBehavior.Restrict);

                e.HasOne(e => e.Product).WithMany().HasForeignKey(e => e.ProductId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<User>(e =>
            {
                e.HasData(
                    new User{UserId = 1, FullName = "Riccardo Reali" , Email = "realiriccardo05@gmail.com", Type = "Admin", Password = "W_Back_End" }
                );
            });
        }


        /*
         - Now to create the database we first need to add this:
           "ConnectionStrings": {
           "SqlString": 
           "Data Source=(local)\\SQLEXPRESS;Database=OUTDOORWAYS;Trusted_Connection=True;TrustServerCertificate=True;"
           }
           To the file appsettings.json

         - Then we need to go inside program and add these 2 usings up top:
           using Microsoft.EntityFrameworkCore;
           using E_Commerce_Outdoorways.Context;

           Second we type this line of code to execute the connection:
           builder.Services.AddDbContext<AppDbContext>(options => 
           {
           options.UseSqlServer(builder.Configuration.GetConnectionString("SqlString"));
           });

          To finally lunch the commands we click on TOOLS -> NuGet package manager -> Package manager console.

          We first lunch:

          - Add-Migration firstMigration;

          Then we update the DB to show the tables in SQL Server Management like this: 

          - Add-Migration firstMigration
            
         
        */
    }
}
