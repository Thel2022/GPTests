﻿// <auto-generated />
using System;
using BookStore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookStore.Migrations
{
    [DbContext(typeof(BookStoreDbContext))]
    [Migration("20230218142810_OrderedBooksInCartTb")]
    partial class OrderedBooksInCartTb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookStore.Models.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Annotation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cover")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoverType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Format")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InStock")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfPages")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("PublishingHouse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("BooksTb");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8483cb96-f510-4315-84c7-53e8fa5f2972"),
                            Annotation = "Труды Иосифа Флавия являются ценнейшим источником сведений по библейской, греческой и римской истории.",
                            Author = "Иосиф Флавий",
                            Cover = "/Images/Covers/IFJW.jpg",
                            CoverType = "мягкий",
                            Format = "18x12",
                            Genre = "История",
                            ISBN = "978-5-389-18167-0",
                            InStock = 100,
                            NumberOfPages = 640,
                            Price = 27m,
                            PublishingHouse = "Азбука",
                            Title = "Иудейская война",
                            Weight = 311,
                            Year = 2020
                        },
                        new
                        {
                            Id = new Guid("d01959e3-dd4a-4b80-a497-d4d8bc47ff22"),
                            Annotation = "Книга Книг ХХ века. Самое популярное, самое читаемое, самое культовое произведение ушедшего столетия.",
                            Author = "Джон Рональд Руэл Толкин",
                            Cover = "/Images/Covers/JRRTLOTR.jpg",
                            CoverType = "твёрдый",
                            Format = "22x14,5",
                            Genre = "Фантастика. Фэнтези",
                            ISBN = "978-5-17-094268-8",
                            InStock = 200,
                            NumberOfPages = 1120,
                            Price = 33m,
                            PublishingHouse = "АСТ",
                            Title = "Властелин Колец (трилогия)",
                            Weight = 1200,
                            Year = 2022
                        },
                        new
                        {
                            Id = new Guid("d69e1c0f-07e1-4649-8880-e61d2fc3cd6d"),
                            Annotation = "«Ветер в ивах» – детская повесть, которую с равным удовольствием читают дети и взрослые.",
                            Author = "Кеннет Грэм",
                            Cover = "/Images/Covers/KGWW.jpg",
                            CoverType = "твёрдый",
                            Format = "70x90",
                            Genre = "Классическая литература",
                            ISBN = "978-5-88350-002-1",
                            InStock = 20,
                            NumberOfPages = 208,
                            Price = 40m,
                            PublishingHouse = "Век",
                            Title = "Ветер в ивах",
                            Weight = 530,
                            Year = 1992
                        });
                });

            modelBuilder.Entity("BookStore.Models.OrderedBooksInCart", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CartId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("OrderCost")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("OrderedBooksInCartTb");
                });

            modelBuilder.Entity("BookStore.Models.OrderedBooksInCart", b =>
                {
                    b.HasOne("BookStore.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId");
                });
#pragma warning restore 612, 618
        }
    }
}
