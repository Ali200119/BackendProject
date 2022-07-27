using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Allup.Migrations
{
    public partial class Features : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageURL = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 27, 21, 19, 37, 893, DateTimeKind.Local).AddTicks(9503));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 27, 21, 19, 37, 894, DateTimeKind.Local).AddTicks(241));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 27, 21, 19, 37, 894, DateTimeKind.Local).AddTicks(266));

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "Id", "Description", "ImageURL", "Title" },
                values: new object[,]
                {
                    { 5, "We ensure secure payment", "icon5.png", "Payment Secure" },
                    { 1, "Free shipping on all US order", "icon1.png", "Free Shipping" },
                    { 3, "You have 30 days to Return", "icon3.png", "100% Money Back" },
                    { 2, "Contact us 24 hours a day", "icon2.png", "Support 24/7" },
                    { 4, "If goods have problems", "icon4.png", "90 Days Return" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 27, 21, 19, 37, 892, DateTimeKind.Local).AddTicks(2664));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 27, 21, 19, 37, 892, DateTimeKind.Local).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 27, 21, 19, 37, 892, DateTimeKind.Local).AddTicks(9165));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 27, 21, 19, 37, 892, DateTimeKind.Local).AddTicks(9346));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 27, 21, 19, 37, 892, DateTimeKind.Local).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 27, 21, 19, 37, 892, DateTimeKind.Local).AddTicks(9365));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 27, 21, 19, 37, 892, DateTimeKind.Local).AddTicks(9376));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 27, 21, 19, 37, 892, DateTimeKind.Local).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 27, 21, 19, 37, 892, DateTimeKind.Local).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 27, 21, 19, 37, 892, DateTimeKind.Local).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 27, 21, 19, 37, 892, DateTimeKind.Local).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 27, 21, 19, 37, 892, DateTimeKind.Local).AddTicks(9388));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 27, 20, 59, 57, 521, DateTimeKind.Local).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 27, 20, 59, 57, 521, DateTimeKind.Local).AddTicks(6031));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 27, 20, 59, 57, 521, DateTimeKind.Local).AddTicks(6056));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 27, 20, 59, 57, 519, DateTimeKind.Local).AddTicks(7803));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 27, 20, 59, 57, 520, DateTimeKind.Local).AddTicks(4072));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 27, 20, 59, 57, 520, DateTimeKind.Local).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 27, 20, 59, 57, 520, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 27, 20, 59, 57, 520, DateTimeKind.Local).AddTicks(4523));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 27, 20, 59, 57, 520, DateTimeKind.Local).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 27, 20, 59, 57, 520, DateTimeKind.Local).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 27, 20, 59, 57, 520, DateTimeKind.Local).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 27, 20, 59, 57, 520, DateTimeKind.Local).AddTicks(4545));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 27, 20, 59, 57, 520, DateTimeKind.Local).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 27, 20, 59, 57, 520, DateTimeKind.Local).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 27, 20, 59, 57, 520, DateTimeKind.Local).AddTicks(4589));
        }
    }
}
