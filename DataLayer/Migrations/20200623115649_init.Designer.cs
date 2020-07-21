﻿// <auto-generated />
using DataLayer.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataLayer.Migrations
{
    [DbContext(typeof(AuctionDbContext))]
    [Migration("20200623115649_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataLayer.Entities.Category", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageFileName");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new { Id = 1L, ImageFileName = "7a9ae808-5cba-4aca-a548-9e5497dcf520.png", Name = "Monitors" },
                        new { Id = 2L, ImageFileName = "d9b53dda-f99b-4569-a294-3807faefec49.png", Name = "Smartphones" },
                        new { Id = 3L, ImageFileName = "f2647ff0-3530-4e7a-a009-a2957e19db6d.png", Name = "Tablets" }
                    );
                });

            modelBuilder.Entity("DataLayer.Entities.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("Bidder");

                    b.Property<long>("CategoryId");

                    b.Property<string>("Description");

                    b.Property<string>("ImageFileName");

                    b.Property<string>("Name");

                    b.Property<int>("Price");

                    b.Property<int>("SellerPrice");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new { Id = 1L, Bidder = 0L, CategoryId = 1L, Description = "M: 1201", ImageFileName = "7b739908-b892-4961-80cd-46a80d45b1e9.png", Name = "Monitor", Price = 500000, SellerPrice = 500000 },
                        new { Id = 2L, Bidder = 0L, CategoryId = 2L, Description = "S: 1301", ImageFileName = "0cbc67c4-37e1-4046-9068-5fd6b5eb8410.png", Name = "Smartphone", Price = 300000, SellerPrice = 300000 },
                        new { Id = 3L, Bidder = 0L, CategoryId = 3L, Description = "T: 1401", ImageFileName = "00c24b2c-3117-4e82-8161-c877e8550b09.png", Name = "Tablet", Price = 400000, SellerPrice = 400000 },
                        new { Id = 4L, Bidder = 0L, CategoryId = 1L, Description = "M: 1202", ImageFileName = "9d3ace22-2a12-4fe8-8998-a4464aff13f6.png", Name = "Monitor", Price = 500000, SellerPrice = 500000 },
                        new { Id = 5L, Bidder = 0L, CategoryId = 2L, Description = "S: 1302", ImageFileName = "2f4e71c1-b99f-41f5-a4e3-04eae3998cf4.png", Name = "Smartphone", Price = 300000, SellerPrice = 300000 },
                        new { Id = 6L, Bidder = 0L, CategoryId = 3L, Description = "T: 1402", ImageFileName = "1a710d16-e145-4eff-9df3-8422e917e582.png", Name = "Tablet", Price = 400000, SellerPrice = 400000 },
                        new { Id = 7L, Bidder = 0L, CategoryId = 1L, Description = "M: 1203", ImageFileName = "578dd49b-b719-40bb-a562-31f47f98c68b.png", Name = "Monitor", Price = 500000, SellerPrice = 500000 },
                        new { Id = 8L, Bidder = 0L, CategoryId = 2L, Description = "S: 1303", ImageFileName = "7b5554f9-8eee-4d7f-95ed-943b31ddfcfd.png", Name = "Smartphone", Price = 300000, SellerPrice = 300000 },
                        new { Id = 9L, Bidder = 0L, CategoryId = 3L, Description = "T: 1403", ImageFileName = "7eb25132-59a7-4ce8-95a4-fb9239200147.png", Name = "Tablet", Price = 400000, SellerPrice = 400000 },
                        new { Id = 10L, Bidder = 0L, CategoryId = 1L, Description = "M: 1204", ImageFileName = "9049d1b8-2d9a-40f7-b38f-b5d185d4b547.png", Name = "Monitor", Price = 500000, SellerPrice = 500000 },
                        new { Id = 11L, Bidder = 0L, CategoryId = 2L, Description = "S: 1304", ImageFileName = "56c9618e-fb42-42d3-bdc3-eeec29f28e72.png", Name = "Smartphone", Price = 300000, SellerPrice = 300000 },
                        new { Id = 12L, Bidder = 0L, CategoryId = 3L, Description = "T: 1404", ImageFileName = "babeb68c-ff0b-4b24-b237-8c57c4773924.png", Name = "Tablet", Price = 400000, SellerPrice = 400000 },
                        new { Id = 13L, Bidder = 0L, CategoryId = 1L, Description = "M: 1205", ImageFileName = "99145066-ab8a-409f-88a9-6096ce62d6f6.png", Name = "Monitor", Price = 500000, SellerPrice = 500000 },
                        new { Id = 14L, Bidder = 0L, CategoryId = 2L, Description = "S: 1305", ImageFileName = "60917223-b1cb-47a0-a167-b229d2bca970.png", Name = "Smartphone", Price = 300000, SellerPrice = 300000 },
                        new { Id = 15L, Bidder = 0L, CategoryId = 3L, Description = "T: 1405", ImageFileName = "d84d23da-f2ca-4271-8a49-b4d0b474d549.png", Name = "Tablet", Price = 400000, SellerPrice = 400000 }
                    );
                });

            modelBuilder.Entity("DataLayer.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<string>("Role");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

                    b.ToTable("Users");

                    b.HasData(
                        new { Id = 1L, Email = "admin@auction.com", FirstName = "Yuri", LastName = "Yuriev", Password = "CQF9pVh87cIuoNg0xksMsOEJrcqD86hy/H9P8fSjl8mk5ymCjBE2ZOrm1l0C6DlV5xhVeX7I9ecQ8upjo7/Dcg==", Role = "admin" },
                        new { Id = 2L, Email = "ivan@gmail.com", FirstName = "Ivan", LastName = "Ivanov", Password = "WgkOqhMuNVfIVBZxP++JdOWBXZkVWNbztiLBuV2ICeZxV1aDC3Rl3DHaTaDqzKdaqy0LQio+kJdy6xxDFlNR3Q==", Role = "user" }
                    );
                });

            modelBuilder.Entity("DataLayer.Entities.Product", b =>
                {
                    b.HasOne("DataLayer.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
