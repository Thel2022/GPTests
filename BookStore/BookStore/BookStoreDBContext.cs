﻿using System;
using System.Data;
using System.Linq;
using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore
{
    public class BookStoreDbContext : DbContext
    {
        public DbSet<Book> BooksTb { get; set; } = null!;
        public DbSet<OrderedBooksInCart> OrderedBooksInCartTb { get; set; }
        public DbSet<Order> OrderTb { get; set; }
        public DbSet<OrderContent> OrderContentTb { get; set; }
        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = Guid.NewGuid(),
                    Title = "Иудейская война",
                    Author = "Иосиф Флавий",
                    Year = 2020,
                    ISBN = "978-5-389-18167-0",
                    Genre = "История",
                    Annotation = "Труды Иосифа Флавия являются ценнейшим источником сведений по библейской, греческой и римской истории.",
                    PublishingHouse = "Азбука",
                    CoverType = "мягкий",
                    NumberOfPages = 640,
                    Format = "18x12",
                    Weight = 311,
                    Price = 27,
                    Cover = "/Images/Covers/IFJW.jpg",
                    InStock = 100
                },
                new Book
                {
                    Id = Guid.NewGuid(),
                    Title = "Властелин Колец (трилогия)",
                    Author = "Джон Рональд Руэл Толкин",
                    Year = 2022,
                    ISBN = "978-5-17-094268-8",
                    Genre = "Фантастика. Фэнтези",
                    Annotation = "Книга Книг ХХ века. Самое популярное, самое читаемое, самое культовое произведение ушедшего столетия.",
                    PublishingHouse = "АСТ",
                    CoverType = "твёрдый",
                    NumberOfPages = 1120,
                    Format = "22x14,5",
                    Weight = 1200,
                    Price = 33,
                    Cover = "/Images/Covers/JRRTLOTR.jpg",
                    InStock = 200
                },
                new Book
                {
                    Id = Guid.NewGuid(),
                    Title = "Ветер в ивах",
                    Author = "Кеннет Грэм",
                    Year = 1992,
                    ISBN = "978-5-88350-002-1",
                    Genre = "Классическая литература",
                    Annotation = "«Ветер в ивах» – детская повесть, которую с равным удовольствием читают дети и взрослые.",
                    PublishingHouse = "Век",
                    CoverType = "твёрдый",
                    NumberOfPages = 208,
                    Format = "70x90",
                    Weight = 530,
                    Price = 40,
                    Cover = "/Images/Covers/KGWW.jpg",
                    InStock = 20
                });

            modelBuilder.Entity<Book>().Property(p => p.Price).HasColumnType("decimal(18,4)");
        }


    }
}
