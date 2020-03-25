using Microsoft.EntityFrameworkCore.Migrations;

namespace YumiAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MenuItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: true),
                    Ingredients = table.Column<string>(nullable: true),
                    Allergens = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    ImgUrl = table.Column<string>(nullable: true),
                    Rating = table.Column<string>(nullable: true),
                    TimesOrdered = table.Column<string>(nullable: true),
                    DateAdded = table.Column<string>(nullable: true),
                    IsFeatured = table.Column<string>(nullable: true)
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
                    Email = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Quantity = table.Column<string>(nullable: true),
                    Comments = table.Column<string>(nullable: true),
                    Estimate = table.Column<string>(nullable: true),
                    Delivered = table.Column<string>(nullable: true),
                    OrderCount = table.Column<string>(nullable: true),
                    IsFinished = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
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
                name: "MenuItem");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
