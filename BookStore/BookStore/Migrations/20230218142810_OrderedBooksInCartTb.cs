using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Migrations
{
    public partial class OrderedBooksInCartTb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BooksTb",
                keyColumn: "Id",
                keyValue: new Guid("189dbe1f-61f7-49b8-acd0-118afe740e34"));

            migrationBuilder.DeleteData(
                table: "BooksTb",
                keyColumn: "Id",
                keyValue: new Guid("269b35cd-00be-4343-8491-a89b76df9c0b"));

            migrationBuilder.DeleteData(
                table: "BooksTb",
                keyColumn: "Id",
                keyValue: new Guid("4cb231e8-147e-4808-8bda-a1972f1a60c5"));

            migrationBuilder.CreateTable(
                name: "OrderedBooksInCartTb",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    BookId = table.Column<Guid>(nullable: true),
                    CartId = table.Column<string>(nullable: true),
                    OrderCost = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderedBooksInCartTb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderedBooksInCartTb_BooksTb_BookId",
                        column: x => x.BookId,
                        principalTable: "BooksTb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "BooksTb",
                columns: new[] { "Id", "Annotation", "Author", "Cover", "CoverType", "Format", "Genre", "ISBN", "InStock", "NumberOfPages", "Price", "PublishingHouse", "Title", "Weight", "Year" },
                values: new object[] { new Guid("8483cb96-f510-4315-84c7-53e8fa5f2972"), "Труды Иосифа Флавия являются ценнейшим источником сведений по библейской, греческой и римской истории.", "Иосиф Флавий", "/Images/Covers/IFJW.jpg", "мягкий", "18x12", "История", "978-5-389-18167-0", 100, 640, 27m, "Азбука", "Иудейская война", 311, 2020 });

            migrationBuilder.InsertData(
                table: "BooksTb",
                columns: new[] { "Id", "Annotation", "Author", "Cover", "CoverType", "Format", "Genre", "ISBN", "InStock", "NumberOfPages", "Price", "PublishingHouse", "Title", "Weight", "Year" },
                values: new object[] { new Guid("d01959e3-dd4a-4b80-a497-d4d8bc47ff22"), "Книга Книг ХХ века. Самое популярное, самое читаемое, самое культовое произведение ушедшего столетия.", "Джон Рональд Руэл Толкин", "/Images/Covers/JRRTLOTR.jpg", "твёрдый", "22x14,5", "Фантастика. Фэнтези", "978-5-17-094268-8", 200, 1120, 33m, "АСТ", "Властелин Колец (трилогия)", 1200, 2022 });

            migrationBuilder.InsertData(
                table: "BooksTb",
                columns: new[] { "Id", "Annotation", "Author", "Cover", "CoverType", "Format", "Genre", "ISBN", "InStock", "NumberOfPages", "Price", "PublishingHouse", "Title", "Weight", "Year" },
                values: new object[] { new Guid("d69e1c0f-07e1-4649-8880-e61d2fc3cd6d"), "«Ветер в ивах» – детская повесть, которую с равным удовольствием читают дети и взрослые.", "Кеннет Грэм", "/Images/Covers/KGWW.jpg", "твёрдый", "70x90", "Классическая литература", "978-5-88350-002-1", 20, 208, 40m, "Век", "Ветер в ивах", 530, 1992 });

            migrationBuilder.CreateIndex(
                name: "IX_OrderedBooksInCartTb_BookId",
                table: "OrderedBooksInCartTb",
                column: "BookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderedBooksInCartTb");

            migrationBuilder.DeleteData(
                table: "BooksTb",
                keyColumn: "Id",
                keyValue: new Guid("8483cb96-f510-4315-84c7-53e8fa5f2972"));

            migrationBuilder.DeleteData(
                table: "BooksTb",
                keyColumn: "Id",
                keyValue: new Guid("d01959e3-dd4a-4b80-a497-d4d8bc47ff22"));

            migrationBuilder.DeleteData(
                table: "BooksTb",
                keyColumn: "Id",
                keyValue: new Guid("d69e1c0f-07e1-4649-8880-e61d2fc3cd6d"));

            migrationBuilder.InsertData(
                table: "BooksTb",
                columns: new[] { "Id", "Annotation", "Author", "Cover", "CoverType", "Format", "Genre", "ISBN", "InStock", "NumberOfPages", "Price", "PublishingHouse", "Title", "Weight", "Year" },
                values: new object[] { new Guid("189dbe1f-61f7-49b8-acd0-118afe740e34"), "Труды Иосифа Флавия являются ценнейшим источником сведений по библейской, греческой и римской истории.", "Иосиф Флавий", "/Images/Covers/IFJW.jpg", "мягкий", "18x12", "История", "978-5-389-18167-0", 100, 640, 27m, "Азбука", "Иудейская война", 311, 2020 });

            migrationBuilder.InsertData(
                table: "BooksTb",
                columns: new[] { "Id", "Annotation", "Author", "Cover", "CoverType", "Format", "Genre", "ISBN", "InStock", "NumberOfPages", "Price", "PublishingHouse", "Title", "Weight", "Year" },
                values: new object[] { new Guid("269b35cd-00be-4343-8491-a89b76df9c0b"), "Книга Книг ХХ века. Самое популярное, самое читаемое, самое культовое произведение ушедшего столетия.", "Джон Рональд Руэл Толкин", "/Images/Covers/JRRTLOTR.jpg", "твёрдый", "22x14,5", "Фантастика. Фэнтези", "978-5-17-094268-8", 200, 1120, 33m, "АСТ", "Властелин Колец (трилогия)", 1200, 2022 });

            migrationBuilder.InsertData(
                table: "BooksTb",
                columns: new[] { "Id", "Annotation", "Author", "Cover", "CoverType", "Format", "Genre", "ISBN", "InStock", "NumberOfPages", "Price", "PublishingHouse", "Title", "Weight", "Year" },
                values: new object[] { new Guid("4cb231e8-147e-4808-8bda-a1972f1a60c5"), "«Ветер в ивах» – детская повесть, которую с равным удовольствием читают дети и взрослые.", "Кеннет Грэм", "/Images/Covers/KGWW.jpg", "твёрдый", "70x90", "Классическая литература", "978-5-88350-002-1", 20, 208, 40m, "Век", "Ветер в ивах", 530, 1992 });
        }
    }
}
