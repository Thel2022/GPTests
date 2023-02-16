using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BooksTb",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    ISBN = table.Column<string>(nullable: true),
                    Genre = table.Column<string>(nullable: true),
                    Annotation = table.Column<string>(nullable: true),
                    PublishingHouse = table.Column<string>(nullable: true),
                    CoverType = table.Column<string>(nullable: true),
                    NumberOfPages = table.Column<int>(nullable: false),
                    Format = table.Column<string>(nullable: true),
                    Weight = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Cover = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooksTb", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BooksTb",
                columns: new[] { "Id", "Annotation", "Author", "Cover", "CoverType", "Format", "Genre", "ISBN", "NumberOfPages", "Price", "PublishingHouse", "Title", "Weight", "Year" },
                values: new object[] { new Guid("5069f22c-0e69-4f03-b79d-c3244226c0fa"), "Труды Иосифа Флавия являются ценнейшим источником сведений по библейской, греческой и римской истории.", "Иосиф Флавий", "/Images/Covers/IFJW.jpg", "мягкий", "18x12", "История", "978-5-389-18167-0", 640, 27m, "Азбука", "Иудейская война", 311, 2020 });

            migrationBuilder.InsertData(
                table: "BooksTb",
                columns: new[] { "Id", "Annotation", "Author", "Cover", "CoverType", "Format", "Genre", "ISBN", "NumberOfPages", "Price", "PublishingHouse", "Title", "Weight", "Year" },
                values: new object[] { new Guid("4f994aeb-224b-4651-8cef-2cd37ec02aea"), "Книга Книг ХХ века. Самое популярное, самое читаемое, самое культовое произведение ушедшего столетия.", "Джон Рональд Руэл Толкин", "/Images/Covers/JRRTLOTR.jpg", "твёрдый", "22x14,5", "Фантастика. Фэнтези", "978-5-17-094268-8", 1120, 33m, "АСТ", "Властелин Колец (трилогия)", 1200, 2022 });

            migrationBuilder.InsertData(
                table: "BooksTb",
                columns: new[] { "Id", "Annotation", "Author", "Cover", "CoverType", "Format", "Genre", "ISBN", "NumberOfPages", "Price", "PublishingHouse", "Title", "Weight", "Year" },
                values: new object[] { new Guid("b9e0e0f4-d1f4-43e9-a9f9-755acf8ca93d"), "«Ветер в ивах» – детская повесть, которую с равным удовольствием читают дети и взрослые.", "Кеннет Грэм", "/Images/Covers/KGWW.jpg", "твёрдый", "70x90", "Классическая литература", "978-5-88350-002-1", 208, 40m, "Век", "Ветер в ивах", 530, 1992 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BooksTb");
        }
    }
}
