﻿// <auto-generated />
using System;
using GoodToyes.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GoodToyes.Migrations
{
    [DbContext(typeof(GoodToyesDbContext))]
    partial class GoodToyesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GoodToyes.Models.Cart", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("CheckedOut");

                    b.Property<decimal>("GrandTotal");

                    b.Property<string>("UserID");

                    b.HasKey("ID");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("GoodToyes.Models.CartItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CartID");

                    b.Property<int>("ProductID");

                    b.Property<int>("Quantity");

                    b.Property<decimal>("Total");

                    b.HasKey("ID");

                    b.HasIndex("CartID");

                    b.HasIndex("ProductID");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("GoodToyes.Models.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<decimal>("GrandTotal");

                    b.Property<string>("LastName");

                    b.Property<DateTime>("OrderDate");

                    b.Property<string>("UserID");

                    b.HasKey("ID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("GoodToyes.Models.OrderItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderID");

                    b.Property<int>("ProductID");

                    b.Property<int>("Quantity");

                    b.HasKey("ID");

                    b.HasIndex("OrderID");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("GoodToyes.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<string>("SKU");

                    b.HasKey("ID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "Your puppers will love this tasty toy from south of the border!",
                            Image = "Assets/Products/avacado_toy.png",
                            Name = "Avacado's Nibbler",
                            Price = 1.95m,
                            SKU = "DT00001"
                        },
                        new
                        {
                            ID = 2,
                            Description = "You can't got wrong with this time-tested classic.",
                            Image = "Assets/Products/bone_toy.png",
                            Name = "Throw Me A Bone",
                            Price = 0.95m,
                            SKU = "DT00002"
                        },
                        new
                        {
                            ID = 3,
                            Description = "A fine, feathered friend for your four-legged friend!",
                            Image = "Assets/Products/chicken_toy.png",
                            Name = "Cluckin' Good Time",
                            Price = 1.95m,
                            SKU = "DT00003"
                        },
                        new
                        {
                            ID = 4,
                            Description = "Perfect side toy for your doggo's morning puppaccino!",
                            Image = "Assets/Products/donut_toy.png",
                            Name = "Donut Bother Me",
                            Price = 1.95m,
                            SKU = "DT00004"
                        },
                        new
                        {
                            ID = 5,
                            Description = "Barbeque sauce sold separately.",
                            Image = "Assets/Products/drumstick_toy.png",
                            Name = "Ain't No Thing Like A Chicken Wing",
                            Price = 1.95m,
                            SKU = "DT00005"
                        },
                        new
                        {
                            ID = 6,
                            Description = "WARNING: May turn your pooch into an old timey movie villain.",
                            Image = "Assets/Products/mustache_toy.png",
                            Name = "I Mustache You A Question",
                            Price = 2.95m,
                            SKU = "DT00006"
                        },
                        new
                        {
                            ID = 7,
                            Description = "That classic thin-crust your dog loves, now in plush!",
                            Image = "Assets/Products/pizza_toy.png",
                            Name = "Pizza My Heart",
                            Price = 1.95m,
                            SKU = "DT00007"
                        },
                        new
                        {
                            ID = 8,
                            Description = "To the victor, go the spoils!",
                            Image = "Assets/Products/rope_toy.png",
                            Name = "Pug'o'War",
                            Price = 0.75m,
                            SKU = "DT00008"
                        },
                        new
                        {
                            ID = 9,
                            Description = "Give your woofer the beautiful pearly whites they deserve.",
                            Image = "Assets/Products/smile_toy.png",
                            Name = "Doggy Dentures",
                            Price = 2.95m,
                            SKU = "DT00009"
                        },
                        new
                        {
                            ID = 10,
                            Description = "Set of three extra jingly tennis balls.",
                            Image = "Assets/Products/tennis_balls.png",
                            Name = "Jingle Balls",
                            Price = 0.95m,
                            SKU = "DT00010"
                        });
                });

            modelBuilder.Entity("GoodToyes.Models.CartItem", b =>
                {
                    b.HasOne("GoodToyes.Models.Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GoodToyes.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GoodToyes.Models.OrderItem", b =>
                {
                    b.HasOne("GoodToyes.Models.Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
