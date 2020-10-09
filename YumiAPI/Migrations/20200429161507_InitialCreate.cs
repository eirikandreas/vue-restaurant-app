using Microsoft.EntityFrameworkCore.Migrations;

namespace YumiAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactMessage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Subject = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    DateSent = table.Column<string>(nullable: true),
                    ContactByPhone = table.Column<bool>(nullable: false),
                    IsRead = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactMessage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: true),
                    Ingredients = table.Column<string>(nullable: true),
                    Allergens = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Category = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImgSrc = table.Column<string>(nullable: true),
                    Rating = table.Column<double>(nullable: false),
                    DateAdded = table.Column<string>(nullable: true),
                    IsSpicy = table.Column<bool>(nullable: false),
                    IsFeatured = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Items = table.Column<string>(nullable: true),
                    TotalPrice = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    DateAdded = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PageSettings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HomeDisplayCarousel = table.Column<bool>(nullable: false),
                    HomeDisplayTopPicks = table.Column<bool>(nullable: false),
                    HomeHeroTitle = table.Column<string>(nullable: true),
                    HomeFavTitle = table.Column<string>(nullable: true),
                    HomeTitle = table.Column<string>(nullable: true),
                    HomeText = table.Column<string>(nullable: true),
                    MenuHeaderTitle = table.Column<string>(nullable: true),
                    AboutHeaderTitle = table.Column<string>(nullable: true),
                    AboutTitle = table.Column<string>(nullable: true),
                    AboutText1 = table.Column<string>(nullable: true),
                    AboutText2 = table.Column<string>(nullable: true),
                    ContactHeaderTitle = table.Column<string>(nullable: true),
                    ContactTitle = table.Column<string>(nullable: true),
                    ContactText = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    IsAdmin = table.Column<string>(nullable: true),
                    OrderCount = table.Column<string>(nullable: true),
                    LoggedIn = table.Column<string>(nullable: true),
                    UserImg = table.Column<string>(nullable: true),
                    DateRegistered = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactMessage");

            migrationBuilder.DropTable(
                name: "MenuItem");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "PageSettings");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
