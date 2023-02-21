using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Migrations
{
    public partial class NewFieldInBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BooksTb",
                keyColumn: "Id",
                keyValue: new Guid("4f994aeb-224b-4651-8cef-2cd37ec02aea"));

            migrationBuilder.DeleteData(
                table: "BooksTb",
                keyColumn: "Id",
                keyValue: new Guid("5069f22c-0e69-4f03-b79d-c3244226c0fa"));

            migrationBuilder.DeleteData(
                table: "BooksTb",
                keyColumn: "Id",
                keyValue: new Guid("b9e0e0f4-d1f4-43e9-a9f9-755acf8ca93d"));

            migrationBuilder.AddColumn<int>(
                name: "InStock",
                table: "BooksTb",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "InStock",
                table: "BooksTb");

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
    }
}
