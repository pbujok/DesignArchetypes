﻿// <auto-generated />
using System;
using ItEmperor.Product.Dal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ItEmperor.Product.Dal.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    partial class ProductDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ItEmperor.Product.Classifications.MarketInterest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("PartyType")
                        .HasColumnType("int");

                    b.Property<Guid>("ProductCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProductCategoryId");

                    b.ToTable("MarketInterest");
                });

            modelBuilder.Entity("ItEmperor.Product.Classifications.ProductCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductCategory", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("ProductCategory");
                });

            modelBuilder.Entity("ItEmperor.Product.Classifications.ProductCategoryClassification", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EdnDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ProductCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProductCategoryId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductCategoryClassification");
                });

            modelBuilder.Entity("ItEmperor.Product.Classifications.ProductCategoryRollup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ChildId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ParentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ChildId");

                    b.HasIndex("ParentId");

                    b.ToTable("ProductCategoryRollup");
                });

            modelBuilder.Entity("ItEmperor.Product.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("IntroductionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("SupportEndDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Product", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("Product");
                });

            modelBuilder.Entity("ItEmperor.Product.Classifications.GoodsCategory", b =>
                {
                    b.HasBaseType("ItEmperor.Product.Classifications.ProductCategory");

                    b.ToTable("ProductCategory", (string)null);

                    b.HasDiscriminator().HasValue("GoodsCategory");
                });

            modelBuilder.Entity("ItEmperor.Product.Classifications.ServicesCategory", b =>
                {
                    b.HasBaseType("ItEmperor.Product.Classifications.ProductCategory");

                    b.ToTable("ProductCategory", (string)null);

                    b.HasDiscriminator().HasValue("ServicesCategory");
                });

            modelBuilder.Entity("ItEmperor.Product.Good", b =>
                {
                    b.HasBaseType("ItEmperor.Product.Product");

                    b.ToTable("Product", (string)null);

                    b.HasDiscriminator().HasValue("Good");
                });

            modelBuilder.Entity("ItEmperor.Product.Service", b =>
                {
                    b.HasBaseType("ItEmperor.Product.Product");

                    b.ToTable("Product", (string)null);

                    b.HasDiscriminator().HasValue("Service");
                });

            modelBuilder.Entity("ItEmperor.Product.Classifications.MarketInterest", b =>
                {
                    b.HasOne("ItEmperor.Product.Classifications.ProductCategory", "ProductCategory")
                        .WithMany()
                        .HasForeignKey("ProductCategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("ProductCategory");
                });

            modelBuilder.Entity("ItEmperor.Product.Classifications.ProductCategoryClassification", b =>
                {
                    b.HasOne("ItEmperor.Product.Classifications.ProductCategory", "ProductCategory")
                        .WithMany()
                        .HasForeignKey("ProductCategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ItEmperor.Product.Product", "Product")
                        .WithMany("ProductCategoryClassification")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("ProductCategory");
                });

            modelBuilder.Entity("ItEmperor.Product.Classifications.ProductCategoryRollup", b =>
                {
                    b.HasOne("ItEmperor.Product.Classifications.ProductCategory", "Child")
                        .WithMany()
                        .HasForeignKey("ChildId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ItEmperor.Product.Classifications.ProductCategory", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Child");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("ItEmperor.Product.Product", b =>
                {
                    b.Navigation("ProductCategoryClassification");
                });
#pragma warning restore 612, 618
        }
    }
}
