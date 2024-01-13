﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace application.Migrations.ProductsDb
{
    [DbContext(typeof(ProductsDbContext))]
    partial class ProductsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("details.SportsProduct", b =>
                {
                    b.Property<int>("productId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("productId"), 1L, 1);

                    b.Property<string>("category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("count")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("highlights")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imageUrl1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imageUrl2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imageUrl3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("productName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("productPrice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("stocksAvailability")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("productId");

                    b.ToTable("sportsProduct");
                });
#pragma warning restore 612, 618
        }
    }
}
