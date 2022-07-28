using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Allup.Migrations
{
    public partial class initialProject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Banners",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ImageURL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ImageURL = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ImageURL = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ImageURL = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Quotes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageURL = table.Column<string>(nullable: true),
                    Quote = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageURL = table.Column<string>(nullable: true),
                    Profit = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    DiscountPrice = table.Column<double>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false),
                    BrandId = table.Column<int>(nullable: false),
                    IsFeatured = table.Column<bool>(nullable: false),
                    IsBestseller = table.Column<bool>(nullable: false),
                    IsNewArrival = table.Column<bool>(nullable: false),
                    IsComputer = table.Column<bool>(nullable: false),
                    IsSmartphone = table.Column<bool>(nullable: false),
                    IsGameConsoles = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    TotalPrice = table.Column<double>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    OrderStatus = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    UserId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_User_UserId1",
                        column: x => x.UserId1,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BasketItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    TotalPrice = table.Column<double>(nullable: false),
                    Count = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    UserId1 = table.Column<int>(nullable: true),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BasketItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasketItems_User_UserId1",
                        column: x => x.UserId1,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageURL = table.Column<string>(nullable: true),
                    IsMain = table.Column<bool>(nullable: false),
                    IsSecond = table.Column<bool>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    TotalPrice = table.Column<double>(nullable: false),
                    Count = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Banners",
                columns: new[] { "Id", "ImageURL", "Name" },
                values: new object[,]
                {
                    { 1, "banner-1.png", "Redmi 6 Pro" },
                    { 2, "banner-2.png", "Headphone" }
                });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "CreatedAt", "Description", "ImageURL", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 28, 15, 55, 6, 982, DateTimeKind.Local).AddTicks(6509), "Simply dummy text of the printing and typesetting industry.Lorem Ipsum...", "blog-1.jpg", "This is First Post For XipBlog" },
                    { 2, new DateTime(2022, 7, 28, 15, 55, 6, 982, DateTimeKind.Local).AddTicks(8668), "Simply dummy text of the printing and typesetting industry.Lorem Ipsum...", "blog-2.jpg", "This is Second Post For XipBlog" },
                    { 3, new DateTime(2022, 7, 28, 15, 55, 6, 982, DateTimeKind.Local).AddTicks(8740), "Simply dummy text of the printing and typesetting industry.Lorem Ipsum...", "blog-3.jpg", "This is Third Post For XipBlog" }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ImageURL", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 6, null, null, "brand-6.jpg", false, "Avant Agarde", null },
                    { 5, null, null, "brand-5.jpg", false, "David Smith", null },
                    { 4, null, null, "brand-4.jpg", false, "Climb The Mountain", null },
                    { 2, null, null, "brand-2.jpg", false, "Golden", null },
                    { 1, null, null, "brand-1.jpg", false, "Ostrich Cafe", null },
                    { 3, null, null, "brand-3.jpg", false, "Norcold", null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ImageURL", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 9, null, null, "category-9.jpg", false, "Appliances", null },
                    { 14, null, null, "category-14.jpg", false, "Tops & Sets", null },
                    { 13, null, null, "category-13.jpg", false, "Notebooks", null },
                    { 12, null, null, "category-12.jpg", false, "Home Tech", null },
                    { 11, null, null, "category-11.jpg", false, "Cases", null },
                    { 10, null, null, "category-10.jpg", false, "Camera", null },
                    { 8, null, null, "category-8.jpg", false, "Accessories", null },
                    { 7, null, null, "category-7.jpg", false, "Audio & Video", null },
                    { 6, null, null, "category-6.jpg", false, "Monitor", null },
                    { 5, null, null, "category-5.jpg", false, "Headphones", null },
                    { 4, null, null, "category-4.jpg", false, "Game Consoles", null },
                    { 3, null, null, "category-3.jpg", false, "Smartphone", null },
                    { 2, null, null, "category-2.jpg", false, "Computer", null },
                    { 1, null, null, "category-1.jpg", false, "Laptop", null }
                });

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "Id", "Description", "ImageURL", "Title" },
                values: new object[,]
                {
                    { 1, "Free shipping on all US order", "icon1.png", "Free Shipping" },
                    { 2, "Contact us 24 hours a day", "icon2.png", "Support 24/7" },
                    { 3, "You have 30 days to Return", "icon3.png", "100% Money Back" },
                    { 4, "If goods have problems", "icon4.png", "90 Days Return" },
                    { 5, "We ensure secure payment", "icon5.png", "Payment Secure" }
                });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Email", "ImageURL", "Name", "Quote" },
                values: new object[,]
                {
                    { 1, "email@yourwebsitename.com", "author-1.png", "John Doe", " An has feugiat vivendum, ad vix tacimates accusamus, cum commune lucilius no. Sit at alia civibus indoctum, ea mel regione percipit adipisci. Per modus nostrum vituperata no, eam ne magna solum constituam." },
                    { 2, "ElonMusk@gmail.com", "author-2.jpg", "Elon Musk", "Some people don't like change, but you need to embrace change if the alternative is disaster." },
                    { 3, "info@sony.com", "author-3.png", "Sony Pla", "Play Has No Limits." }
                });

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "Description", "ImageURL", "Profit", "Title" },
                values: new object[,]
                {
                    { 1, "Explore and immerse in exciting 360 content with Fulldive’s all-in-one virtual reality platform", "slider-1.jpg", "Save $120 when you buy", "<span>4K2020 Virtual Reality</span>Fulldive VR." },
                    { 2, "Explore and immerse in exciting 360 content with Fulldive’s all-in-one virtual reality platform", "slider-2.jpg", "Save $120 when you buy", "<span>4K HDR Smart TV 43 </span>Sony Bravia." }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "CreatedAt", "DeletedAt", "DiscountPrice", "IsBestseller", "IsComputer", "IsDeleted", "IsFeatured", "IsGameConsoles", "IsNewArrival", "IsSmartphone", "Name", "Price", "UpdatedAt" },
                values: new object[,]
                {
                    { 2, 2, 4, new DateTime(2022, 7, 28, 15, 55, 6, 978, DateTimeKind.Local).AddTicks(3528), null, 21.899999999999999, true, false, false, true, true, false, false, "Originals Kaval Wind breaker Winter Jacket eu...", 23.899999999999999, null },
                    { 6, 1, 4, new DateTime(2022, 7, 28, 15, 55, 6, 978, DateTimeKind.Local).AddTicks(7270), null, null, true, false, false, false, true, true, false, "Cale 6 eu accumsan massa facilisis Madden by Steve", 29.899999999999999, null },
                    { 8, 2, 4, new DateTime(2022, 7, 28, 15, 55, 6, 978, DateTimeKind.Local).AddTicks(7334), null, null, false, false, false, true, true, true, false, "Juicy Couture Juicy Quilted Terry Track Jacket eu...", 35.899999999999999, null },
                    { 3, 6, 5, new DateTime(2022, 7, 28, 15, 55, 6, 978, DateTimeKind.Local).AddTicks(4102), null, null, true, false, false, false, false, true, true, "Madden by Steve Madden Cale 6 eu accumsan massa...", 11.9, null },
                    { 4, 1, 5, new DateTime(2022, 7, 28, 15, 55, 6, 978, DateTimeKind.Local).AddTicks(7192), null, null, true, false, false, true, false, false, true, "Water and Wind Resistant Insulated Jacket eu massa", 11.9, null },
                    { 9, 3, 5, new DateTime(2022, 7, 28, 15, 55, 6, 978, DateTimeKind.Local).AddTicks(7346), null, null, true, false, false, false, false, true, true, "Trans-Weight Hooded Wind and Water Resistant Shell", 11.9, null },
                    { 5, 4, 7, new DateTime(2022, 7, 28, 15, 55, 6, 978, DateTimeKind.Local).AddTicks(7242), null, null, true, true, false, true, false, true, false, "Juicy Couture Solid Sleeve Puffer Jacket eu accumsan..", 18.899999999999999, null },
                    { 7, 4, 10, new DateTime(2022, 7, 28, 15, 55, 6, 978, DateTimeKind.Local).AddTicks(7319), null, null, false, false, false, true, false, true, true, "Winter Jacket eu accumsan massa facili originals Kaval Wind breaker", 23.899999999999999, null },
                    { 1, 3, 12, new DateTime(2022, 7, 28, 15, 55, 6, 976, DateTimeKind.Local).AddTicks(6973), null, null, true, true, false, true, false, true, false, "Cale 6 eu accumsan massa facilisis Madden by Steve", 11.9, null },
                    { 11, 5, 12, new DateTime(2022, 7, 28, 15, 55, 6, 978, DateTimeKind.Local).AddTicks(7377), null, null, false, false, false, true, false, true, true, "New Balance Fresh Foam LAZR v1 Sport eu accumsan...", 18.899999999999999, null },
                    { 12, 6, 12, new DateTime(2022, 7, 28, 15, 55, 6, 978, DateTimeKind.Local).AddTicks(7405), null, 26.100000000000001, true, false, false, false, true, true, false, "New Balance Arishi Sport v1Couture Juicy eu", 29.0, null },
                    { 10, 5, 14, new DateTime(2022, 7, 28, 15, 55, 6, 978, DateTimeKind.Local).AddTicks(7360), null, null, false, true, false, true, false, false, false, "New Balance Fresh Foam Kaymin eu accumsan massa...", 11.9, null }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "ImageURL", "IsMain", "IsSecond", "ProductId" },
                values: new object[,]
                {
                    { 3, "product-3.jpg", true, false, 2 },
                    { 18, "product-15.jpg", false, true, 11 },
                    { 17, "product-14.jpg", true, false, 11 },
                    { 2, "product-2.jpg", false, true, 1 },
                    { 1, "product-1.jpg", true, false, 1 },
                    { 12, "product-11.jpg", false, true, 7 },
                    { 11, "product-10.jpg", true, false, 7 },
                    { 8, "product-8.jpg", true, false, 5 },
                    { 19, "product-9.jpg", true, false, 12 },
                    { 15, "product-6.jpg", false, true, 9 },
                    { 7, "product-7.jpg", false, true, 4 },
                    { 6, "product-6.jpg", true, false, 4 },
                    { 5, "product-5.jpg", true, false, 3 },
                    { 13, "product-12.jpg", true, false, 8 },
                    { 10, "product-9.jpg", false, true, 6 },
                    { 9, "product-3.jpg", true, false, 6 },
                    { 4, "product-4.jpg", false, true, 2 },
                    { 14, "product-16.jpg", true, false, 9 },
                    { 16, "product-13.jpg", true, false, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_ProductId",
                table: "BasketItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_UserId1",
                table: "BasketItems",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId1",
                table: "Orders",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Banners");

            migrationBuilder.DropTable(
                name: "BasketItems");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "Quotes");

            migrationBuilder.DropTable(
                name: "Sliders");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
