using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Allup.Migrations
{
    public partial class initialProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
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
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    IsSpecialProduct = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    StockCount = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
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
                name: "BasketItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    TotalPrice = table.Column<double>(nullable: false),
                    Count = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
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
                        name: "FK_BasketItems_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    { 1, new DateTime(2022, 8, 1, 15, 32, 55, 318, DateTimeKind.Local).AddTicks(4802), "Simply dummy text of the printing and typesetting industry.Lorem Ipsum...", "blog-1.jpg", "This is First Post For XipBlog" },
                    { 2, new DateTime(2022, 8, 1, 15, 32, 55, 318, DateTimeKind.Local).AddTicks(8835), "Simply dummy text of the printing and typesetting industry.Lorem Ipsum...", "blog-2.jpg", "This is Second Post For XipBlog" },
                    { 3, new DateTime(2022, 8, 1, 15, 32, 55, 318, DateTimeKind.Local).AddTicks(8951), "Simply dummy text of the printing and typesetting industry.Lorem Ipsum...", "blog-3.jpg", "This is Third Post For XipBlog" },
                    { 4, new DateTime(2022, 8, 1, 15, 32, 55, 318, DateTimeKind.Local).AddTicks(8971), "Simply dummy text of the printing and typesetting industry.Lorem Ipsum...", "blog-4.jpg", "This is Fourth Post For XipBlog" }
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
                    { 6, null, null, "category-6.jpg", false, "Monitor", null },
                    { 5, null, null, "category-5.jpg", false, "Headphones", null },
                    { 4, null, null, "category-4.jpg", false, "Game Consoles", null },
                    { 3, null, null, "category-3.jpg", false, "Smartphone", null },
                    { 2, null, null, "category-2.jpg", false, "Computer", null },
                    { 1, null, null, "category-1.jpg", false, "Laptop", null },
                    { 7, null, null, "category-7.jpg", false, "Audio & Video", null }
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
                    { 3, "info@sony.com", "author-3.png", "Sony PlayStation", "Play Has No Limits." }
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
                columns: new[] { "Id", "BrandId", "CategoryId", "CreatedAt", "DeletedAt", "Description", "DiscountPrice", "IsBestseller", "IsComputer", "IsDeleted", "IsFeatured", "IsGameConsoles", "IsNewArrival", "IsSmartphone", "IsSpecialProduct", "Name", "Price", "StockCount", "UpdatedAt" },
                values: new object[,]
                {
                    { 2, 2, 4, new DateTime(2022, 8, 1, 15, 32, 55, 313, DateTimeKind.Local).AddTicks(5339), null, "Block out the haters with the fresh adidas® Originals Kaval Windbreaker Jacket. Part of the Kaval Collection. Regular fit is eased, but not sloppy, and perfect for any activity. Plain-woven jacket specifically constructed for freedom of movement.", 21.899999999999999, true, false, false, true, true, false, false, true, "Originals Kaval Wind breaker Winter Jacket eu...", 23.899999999999999, 25, null },
                    { 6, 1, 4, new DateTime(2022, 8, 1, 15, 32, 55, 313, DateTimeKind.Local).AddTicks(9794), null, "Block out the haters with the fresh adidas® Originals Kaval Windbreaker Jacket. Part of the Kaval Collection. Regular fit is eased, but not sloppy, and perfect for any activity. Plain-woven jacket specifically constructed for freedom of movement.", null, true, false, false, false, true, true, false, false, "Cale 6 eu accumsan massa facilisis Madden by Steve", 29.899999999999999, 87, null },
                    { 8, 2, 4, new DateTime(2022, 8, 1, 15, 32, 55, 313, DateTimeKind.Local).AddTicks(9871), null, "Block out the haters with the fresh adidas® Originals Kaval Windbreaker Jacket. Part of the Kaval Collection. Regular fit is eased, but not sloppy, and perfect for any activity. Plain-woven jacket specifically constructed for freedom of movement.", null, false, false, false, true, true, true, false, false, "Juicy Couture Juicy Quilted Terry Track Jacket eu...", 35.899999999999999, 238, null },
                    { 3, 6, 5, new DateTime(2022, 8, 1, 15, 32, 55, 313, DateTimeKind.Local).AddTicks(8652), null, "Block out the haters with the fresh adidas® Originals Kaval Windbreaker Jacket. Part of the Kaval Collection. Regular fit is eased, but not sloppy, and perfect for any activity. Plain-woven jacket specifically constructed for freedom of movement.", null, true, false, false, false, false, true, true, false, "Madden by Steve Madden Cale 6 eu accumsan massa...", 11.9, 10, null },
                    { 4, 1, 5, new DateTime(2022, 8, 1, 15, 32, 55, 313, DateTimeKind.Local).AddTicks(9658), null, "Block out the haters with the fresh adidas® Originals Kaval Windbreaker Jacket. Part of the Kaval Collection. Regular fit is eased, but not sloppy, and perfect for any activity. Plain-woven jacket specifically constructed for freedom of movement.", null, true, false, false, true, false, false, true, false, "Water and Wind Resistant Insulated Jacket eu massa", 11.9, 101, null },
                    { 9, 3, 5, new DateTime(2022, 8, 1, 15, 32, 55, 313, DateTimeKind.Local).AddTicks(9892), null, "Block out the haters with the fresh adidas® Originals Kaval Windbreaker Jacket. Part of the Kaval Collection. Regular fit is eased, but not sloppy, and perfect for any activity. Plain-woven jacket specifically constructed for freedom of movement.", null, true, false, false, false, false, true, true, true, "Trans-Weight Hooded Wind and Water Resistant Shell", 11.9, 235, null },
                    { 5, 4, 7, new DateTime(2022, 8, 1, 15, 32, 55, 313, DateTimeKind.Local).AddTicks(9751), null, "Block out the haters with the fresh adidas® Originals Kaval Windbreaker Jacket. Part of the Kaval Collection. Regular fit is eased, but not sloppy, and perfect for any activity. Plain-woven jacket specifically constructed for freedom of movement.", null, true, true, false, true, false, true, false, false, "Juicy Couture Solid Sleeve Puffer Jacket eu accumsan..", 18.899999999999999, 33, null },
                    { 7, 4, 10, new DateTime(2022, 8, 1, 15, 32, 55, 313, DateTimeKind.Local).AddTicks(9832), null, "Block out the haters with the fresh adidas® Originals Kaval Windbreaker Jacket. Part of the Kaval Collection. Regular fit is eased, but not sloppy, and perfect for any activity. Plain-woven jacket specifically constructed for freedom of movement.", null, false, false, false, true, false, true, true, true, "Winter Jacket eu accumsan massa facili originals Kaval Wind breaker", 23.899999999999999, 23, null },
                    { 1, 3, 12, new DateTime(2022, 8, 1, 15, 32, 55, 310, DateTimeKind.Local).AddTicks(5169), null, "Block out the haters with the fresh adidas® Originals Kaval Windbreaker Jacket. Part of the Kaval Collection. Regular fit is eased, but not sloppy, and perfect for any activity. Plain-woven jacket specifically constructed for freedom of movement.", null, true, true, false, true, false, true, false, false, "Cale 6 eu accumsan massa facilisis Madden by Steve", 11.9, 189, null },
                    { 11, 5, 12, new DateTime(2022, 8, 1, 15, 32, 55, 313, DateTimeKind.Local).AddTicks(9931), null, "Block out the haters with the fresh adidas® Originals Kaval Windbreaker Jacket. Part of the Kaval Collection. Regular fit is eased, but not sloppy, and perfect for any activity. Plain-woven jacket specifically constructed for freedom of movement.", null, false, false, false, true, false, true, true, true, "New Balance Fresh Foam LAZR v1 Sport eu accumsan...", 18.899999999999999, 190, null },
                    { 12, 6, 12, new DateTime(2022, 8, 1, 15, 32, 55, 313, DateTimeKind.Local).AddTicks(9973), null, "Block out the haters with the fresh adidas® Originals Kaval Windbreaker Jacket. Part of the Kaval Collection. Regular fit is eased, but not sloppy, and perfect for any activity. Plain-woven jacket specifically constructed for freedom of movement.", 26.100000000000001, true, false, false, false, true, true, false, false, "New Balance Arishi Sport v1Couture Juicy eu", 29.0, 255, null },
                    { 10, 5, 14, new DateTime(2022, 8, 1, 15, 32, 55, 313, DateTimeKind.Local).AddTicks(9912), null, "Block out the haters with the fresh adidas® Originals Kaval Windbreaker Jacket. Part of the Kaval Collection. Regular fit is eased, but not sloppy, and perfect for any activity. Plain-woven jacket specifically constructed for freedom of movement.", null, false, true, false, true, false, false, false, false, "New Balance Fresh Foam Kaymin eu accumsan massa...", 11.9, 25, null }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "ImageURL", "IsMain", "IsSecond", "ProductId" },
                values: new object[,]
                {
                    { 3, "product-3.jpg", true, false, 2 },
                    { 31, "product-8.jpg", false, false, 11 },
                    { 30, "product-6.jpg", false, false, 11 },
                    { 29, "product-13.jpg", false, false, 11 },
                    { 18, "product-15.jpg", false, true, 11 },
                    { 17, "product-14.jpg", true, false, 11 },
                    { 2, "product-2.jpg", false, true, 1 },
                    { 1, "product-1.jpg", true, false, 1 },
                    { 25, "product-8.jpg", false, false, 7 },
                    { 24, "product-15.jpg", false, false, 7 },
                    { 23, "product-13.jpg", false, false, 7 },
                    { 12, "product-11.jpg", false, true, 7 },
                    { 11, "product-10.jpg", true, false, 7 },
                    { 8, "product-8.jpg", true, false, 5 },
                    { 19, "product-9.jpg", true, false, 12 },
                    { 28, "product-7.jpg", false, false, 9 },
                    { 26, "product-10.jpg", false, false, 9 },
                    { 15, "product-6.jpg", false, true, 9 },
                    { 14, "product-16.jpg", true, false, 9 },
                    { 7, "product-7.jpg", false, true, 4 },
                    { 6, "product-6.jpg", true, false, 4 },
                    { 5, "product-5.jpg", true, false, 3 },
                    { 13, "product-12.jpg", true, false, 8 },
                    { 10, "product-9.jpg", false, true, 6 },
                    { 9, "product-3.jpg", true, false, 6 },
                    { 22, "product-5.jpg", false, false, 2 },
                    { 21, "product-9.jpg", false, false, 2 },
                    { 20, "product-12.jpg", false, false, 2 },
                    { 4, "product-4.jpg", false, true, 2 },
                    { 27, "product-17.jpg", false, false, 9 },
                    { 16, "product-13.jpg", true, false, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_ProductId",
                table: "BasketItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_UserId",
                table: "BasketItems",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
