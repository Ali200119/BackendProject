using Allup.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Allup.DAL
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Quotes> Quotes { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Features> Features { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(

                new Product { Id = 1, Name = "Cale 6 eu accumsan massa facilisis Madden by Steve", Price = 11.90, CategoryId = 12, BrandId = 3, IsNewArrival = true, IsBestseller = true, IsFeatured = true, CreatedAt = DateTime.Now, IsComputer = true, StockCount = 189, Description = "Block out the haters with the fresh adidas® Originals Kaval Windbreaker Jacket. Part of the Kaval Collection. Regular fit is eased, but not sloppy, and perfect for any activity. Plain-woven jacket specifically constructed for freedom of movement." },
                new Product { Id = 2, Name = "Originals Kaval Wind breaker Winter Jacket eu...", Price = 23.90, DiscountPrice = 21.90, CategoryId = 4, BrandId = 2, IsNewArrival = false, IsBestseller = true, IsFeatured = true, CreatedAt = DateTime.Now, IsGameConsoles = true, StockCount = 25, IsSpecialProduct = true, Description = "Block out the haters with the fresh adidas® Originals Kaval Windbreaker Jacket. Part of the Kaval Collection. Regular fit is eased, but not sloppy, and perfect for any activity. Plain-woven jacket specifically constructed for freedom of movement." },
                new Product { Id = 3, Name = "Madden by Steve Madden Cale 6 eu accumsan massa...", Price = 11.90, CategoryId = 5, BrandId = 6, IsNewArrival = true, IsBestseller = true, IsFeatured = false, CreatedAt = DateTime.Now, IsSmartphone = true, StockCount = 10, Description = "Block out the haters with the fresh adidas® Originals Kaval Windbreaker Jacket. Part of the Kaval Collection. Regular fit is eased, but not sloppy, and perfect for any activity. Plain-woven jacket specifically constructed for freedom of movement." },
                new Product { Id = 4, Name = "Water and Wind Resistant Insulated Jacket eu massa", Price = 11.90, CategoryId = 5, BrandId = 1, IsNewArrival = false, IsBestseller = true, IsFeatured = true, CreatedAt = DateTime.Now, IsSmartphone = true, StockCount = 101, Description = "Block out the haters with the fresh adidas® Originals Kaval Windbreaker Jacket. Part of the Kaval Collection. Regular fit is eased, but not sloppy, and perfect for any activity. Plain-woven jacket specifically constructed for freedom of movement." },
                new Product { Id = 5, Name = "Juicy Couture Solid Sleeve Puffer Jacket eu accumsan..", Price = 18.90, CategoryId = 7, BrandId = 4, IsNewArrival = true, IsBestseller = true, IsFeatured = true, CreatedAt = DateTime.Now, IsComputer = true, StockCount = 33, Description = "Block out the haters with the fresh adidas® Originals Kaval Windbreaker Jacket. Part of the Kaval Collection. Regular fit is eased, but not sloppy, and perfect for any activity. Plain-woven jacket specifically constructed for freedom of movement." },
                new Product { Id = 6, Name = "Cale 6 eu accumsan massa facilisis Madden by Steve", Price = 29.90, CategoryId = 4, BrandId = 1, IsNewArrival = true, IsBestseller = true, IsFeatured = false, CreatedAt = DateTime.Now, IsGameConsoles = true, StockCount = 87, Description = "Block out the haters with the fresh adidas® Originals Kaval Windbreaker Jacket. Part of the Kaval Collection. Regular fit is eased, but not sloppy, and perfect for any activity. Plain-woven jacket specifically constructed for freedom of movement." },
                new Product { Id = 7, Name = "Winter Jacket eu accumsan massa facili originals Kaval Wind breaker", Price = 23.90, CategoryId = 10, BrandId = 4, IsNewArrival = true, IsBestseller = false, IsFeatured = true, CreatedAt = DateTime.Now, IsSmartphone = true, StockCount = 23, IsSpecialProduct = true, Description = "Block out the haters with the fresh adidas® Originals Kaval Windbreaker Jacket. Part of the Kaval Collection. Regular fit is eased, but not sloppy, and perfect for any activity. Plain-woven jacket specifically constructed for freedom of movement." },
                new Product { Id = 8, Name = "Juicy Couture Juicy Quilted Terry Track Jacket eu...", Price = 35.90, CategoryId = 4, BrandId = 2, IsNewArrival = true, IsBestseller = false, IsFeatured = true, CreatedAt = DateTime.Now, IsGameConsoles = true, StockCount = 238, Description = "Block out the haters with the fresh adidas® Originals Kaval Windbreaker Jacket. Part of the Kaval Collection. Regular fit is eased, but not sloppy, and perfect for any activity. Plain-woven jacket specifically constructed for freedom of movement." },
                new Product { Id = 9, Name = "Trans-Weight Hooded Wind and Water Resistant Shell", Price = 11.90, CategoryId = 5, BrandId = 3, IsNewArrival = true, IsBestseller = true, IsFeatured = false, CreatedAt = DateTime.Now, IsSmartphone = true, StockCount = 235, IsSpecialProduct = true, Description = "Block out the haters with the fresh adidas® Originals Kaval Windbreaker Jacket. Part of the Kaval Collection. Regular fit is eased, but not sloppy, and perfect for any activity. Plain-woven jacket specifically constructed for freedom of movement." },
                new Product { Id = 10, Name = "New Balance Fresh Foam Kaymin eu accumsan massa...", Price = 11.90, CategoryId = 14, BrandId = 5, IsNewArrival = false, IsBestseller = false, IsFeatured = true, CreatedAt = DateTime.Now, IsComputer = true, StockCount = 25, Description = "Block out the haters with the fresh adidas® Originals Kaval Windbreaker Jacket. Part of the Kaval Collection. Regular fit is eased, but not sloppy, and perfect for any activity. Plain-woven jacket specifically constructed for freedom of movement." },
                new Product { Id = 11, Name = "New Balance Fresh Foam LAZR v1 Sport eu accumsan...", Price = 18.90, CategoryId = 12, BrandId = 5, IsNewArrival = true, IsBestseller = false, IsFeatured = true, CreatedAt = DateTime.Now, IsSmartphone = true, StockCount = 190, IsSpecialProduct = true, Description = "Block out the haters with the fresh adidas® Originals Kaval Windbreaker Jacket. Part of the Kaval Collection. Regular fit is eased, but not sloppy, and perfect for any activity. Plain-woven jacket specifically constructed for freedom of movement." },
                new Product { Id = 12, Name = "New Balance Arishi Sport v1Couture Juicy eu", Price = 29.00, DiscountPrice = 26.10, CategoryId = 12, BrandId = 6, IsNewArrival = true, IsBestseller = true, IsFeatured = false, CreatedAt = DateTime.Now, IsGameConsoles = true, StockCount = 255, Description = "Block out the haters with the fresh adidas® Originals Kaval Windbreaker Jacket. Part of the Kaval Collection. Regular fit is eased, but not sloppy, and perfect for any activity. Plain-woven jacket specifically constructed for freedom of movement." }


            );

            modelBuilder.Entity<Category>().HasData(

                new Category { Id = 1, Name = "Laptop", ImageURL = "category-1.jpg", CreatedAt = DateTime.Now },
                new Category { Id = 2, Name = "Computer", ImageURL = "category-2.jpg", CreatedAt = DateTime.Now },
                new Category { Id = 3, Name = "Smartphone", ImageURL = "category-3.jpg", CreatedAt = DateTime.Now },
                new Category { Id = 4, Name = "Game Consoles", ImageURL = "category-4.jpg", CreatedAt = DateTime.Now },
                new Category { Id = 5, Name = "Headphones", ImageURL = "category-5.jpg", CreatedAt = DateTime.Now },
                new Category { Id = 6, Name = "Monitor", ImageURL = "category-6.jpg", CreatedAt = DateTime.Now },
                new Category { Id = 7, Name = "Audio & Video", ImageURL = "category-7.jpg", CreatedAt = DateTime.Now },
                new Category { Id = 8, Name = "Accessories", ImageURL = "category-8.jpg", CreatedAt = DateTime.Now },
                new Category { Id = 9, Name = "Appliances", ImageURL = "category-9.jpg", CreatedAt = DateTime.Now },
                new Category { Id = 10, Name = "Camera", ImageURL = "category-10.jpg", CreatedAt = DateTime.Now },
                new Category { Id = 11, Name = "Cases", ImageURL = "category-11.jpg", CreatedAt = DateTime.Now },
                new Category { Id = 12, Name = "Home Tech", ImageURL = "category-12.jpg", CreatedAt = DateTime.Now },
                new Category { Id = 13, Name = "Notebooks", ImageURL = "category-13.jpg", CreatedAt = DateTime.Now },
                new Category { Id = 14, Name = "Tops & Sets", ImageURL = "category-14.jpg", CreatedAt = DateTime.Now }
            );

            modelBuilder.Entity<Brand>().HasData(

                new Brand { Id = 1, Name = "Ostrich Cafe", ImageURL = "brand-1.jpg", IsDeleted = false },
                new Brand { Id = 2, Name = "Golden", ImageURL = "brand-2.jpg", IsDeleted = false },
                new Brand { Id = 3, Name = "Norcold", ImageURL = "brand-3.jpg", IsDeleted = false },
                new Brand { Id = 4, Name = "Climb The Mountain", ImageURL = "brand-4.jpg", IsDeleted = false },
                new Brand { Id = 5, Name = "David Smith", ImageURL = "brand-5.jpg", IsDeleted = false },
                new Brand { Id = 6, Name = "Avant Agarde", ImageURL = "brand-6.jpg", IsDeleted = false }
            );

            modelBuilder.Entity<Blog>().HasData(

                new Blog { Id = 1, CreatedAt = new DateTime(2022, 12, 5), ImageURL = "blog-1.jpg", Title = "This is First Post For XipBlog", Description = "Simply dummy text of the printing and typesetting industry.Lorem Ipsum..." },
                new Blog { Id = 2, CreatedAt = new DateTime(2022, 12, 5), ImageURL = "blog-2.jpg", Title = "This is Second Post For XipBlog", Description = "Simply dummy text of the printing and typesetting industry.Lorem Ipsum..." },
                new Blog { Id = 3, CreatedAt = new DateTime(2022, 12, 5), ImageURL = "blog-3.jpg", Title = "This is Third Post For XipBlog", Description = "Simply dummy text of the printing and typesetting industry.Lorem Ipsum..." },
                new Blog { Id = 4, CreatedAt = new DateTime(2022, 12, 5), ImageURL = "blog-4.jpg", Title = "This is Fourth Post For XipBlog", Description = "Simply dummy text of the printing and typesetting industry.Lorem Ipsum..." }
            );

            modelBuilder.Entity<Quotes>().HasData(
                
                new Quotes { Id= 1, ImageURL = "author-1.png", Quote = " An has feugiat vivendum, ad vix tacimates accusamus, cum commune lucilius no. Sit at alia civibus indoctum, ea mel regione percipit adipisci. Per modus nostrum vituperata no, eam ne magna solum constituam.", Name = "John Doe", Email = "email@yourwebsitename.com" },
                new Quotes { Id = 2, ImageURL = "author-2.jpg", Quote = "Some people don't like change, but you need to embrace change if the alternative is disaster.", Name = "Elon Musk", Email = "ElonMusk@gmail.com" },
                new Quotes { Id = 3, ImageURL = "author-3.png", Quote = "Play Has No Limits.", Name = "Sony PlayStation", Email = "info@sony.com" }
            );

            modelBuilder.Entity<Slider>().HasData(

                new Slider { Id = 1, ImageURL = "slider-1.jpg", Profit = "Save $120 when you buy", Title = "<span>4K2020 Virtual Reality</span>Fulldive VR.", Description = "Explore and immerse in exciting 360 content with Fulldive’s all-in-one virtual reality platform" },
                new Slider { Id = 2, ImageURL = "slider-2.jpg", Profit = "Save $120 when you buy", Title = "<span>4K HDR Smart TV 43 </span>Sony Bravia.", Description = "Explore and immerse in exciting 360 content with Fulldive’s all-in-one virtual reality platform" }
            );

            modelBuilder.Entity<ProductImage>().HasData(

                new ProductImage { Id = 1, ImageURL = "product-1.jpg", IsMain = true, ProductId = 1 },
                new ProductImage { Id = 2, ImageURL = "product-2.jpg", IsMain = false, ProductId = 1, IsSecond = true },
                new ProductImage { Id = 3, ImageURL = "product-3.jpg", IsMain = true, ProductId = 2 },
                new ProductImage { Id = 4, ImageURL = "product-4.jpg", IsMain = false, ProductId = 2, IsSecond = true },
                new ProductImage { Id = 5, ImageURL = "product-5.jpg", IsMain = true, ProductId = 3 },
                new ProductImage { Id = 6, ImageURL = "product-6.jpg", IsMain = true, ProductId = 4 },
                new ProductImage { Id = 7, ImageURL = "product-7.jpg", IsMain = false, ProductId = 4, IsSecond = true },
                new ProductImage { Id = 8, ImageURL = "product-8.jpg", IsMain = true, ProductId = 5 },
                new ProductImage { Id = 9, ImageURL = "product-3.jpg", IsMain = true, ProductId = 6 },
                new ProductImage { Id = 10, ImageURL = "product-9.jpg", IsMain = false, ProductId = 6, IsSecond = true },
                new ProductImage { Id = 11, ImageURL = "product-10.jpg", IsMain = true, ProductId = 7 },
                new ProductImage { Id = 12, ImageURL = "product-11.jpg", IsMain = false, ProductId = 7, IsSecond = true },
                new ProductImage { Id = 13, ImageURL = "product-12.jpg", IsMain = true, ProductId = 8 },
                new ProductImage { Id = 14, ImageURL = "product-16.jpg", IsMain = true, ProductId = 9 },
                new ProductImage { Id = 15, ImageURL = "product-6.jpg", IsMain = false, ProductId = 9, IsSecond = true },
                new ProductImage { Id = 16, ImageURL = "product-13.jpg", IsMain = true, ProductId = 10 },
                new ProductImage { Id = 17, ImageURL = "product-14.jpg", IsMain = true, ProductId = 11 },
                new ProductImage { Id = 18, ImageURL = "product-15.jpg", IsMain = false, ProductId = 11, IsSecond = true },
                new ProductImage { Id = 19, ImageURL = "product-9.jpg", IsMain = true, ProductId = 12 },



                new ProductImage { Id = 20, ImageURL = "product-12.jpg", ProductId = 2 },
                new ProductImage { Id = 21, ImageURL = "product-9.jpg", ProductId = 2 },
                new ProductImage { Id = 22, ImageURL = "product-5.jpg", ProductId = 2 },
                new ProductImage { Id = 23, ImageURL = "product-13.jpg", ProductId = 7},
                new ProductImage { Id = 24, ImageURL = "product-15.jpg", ProductId = 7 },
                new ProductImage { Id = 25, ImageURL = "product-8.jpg", ProductId = 7 },
                new ProductImage { Id = 26, ImageURL = "product-10.jpg", ProductId = 9 },
                new ProductImage { Id = 27, ImageURL = "product-17.jpg", ProductId = 9 },
                new ProductImage { Id = 28, ImageURL = "product-7.jpg", ProductId = 9 },
                new ProductImage { Id = 29, ImageURL = "product-13.jpg", ProductId = 11 },
                new ProductImage { Id = 30, ImageURL = "product-6.jpg", ProductId = 11 },
                new ProductImage { Id = 31, ImageURL = "product-8.jpg", ProductId = 11 }
            );

            modelBuilder.Entity<Banner>().HasData(

                new Banner { Id = 1, Name = "Redmi 6 Pro", ImageURL = "banner-1.png"},
                new Banner { Id = 2, Name = "Headphone", ImageURL = "banner-2.png" }
            );

            modelBuilder.Entity<Features>().HasData(

                new Features { Id = 1, ImageURL = "icon1.png", Title = "Free Shipping", Description = "Free shipping on all US order" },
                new Features { Id = 2, ImageURL = "icon2.png", Title = "Support 24/7", Description = "Contact us 24 hours a day" },
                new Features { Id = 3, ImageURL = "icon3.png", Title = "100% Money Back", Description = "You have 30 days to Return" },
                new Features { Id = 4, ImageURL = "icon4.png", Title = "90 Days Return", Description = "If goods have problems" },
                new Features { Id = 5, ImageURL = "icon5.png", Title = "Payment Secure", Description = "We ensure secure payment" }
            );
        }
    }
}