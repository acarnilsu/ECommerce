using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.DataAccessLayer.Migrations
{
    public partial class initialize_mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    barcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cat1name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ingcat1name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cat2name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ingcat2name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cat3name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ingcat3name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cat4name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ingcat4name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    urlcat1name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    urlcat2name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    urlcat3name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    urlcat4name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ws_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ingname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    stock = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    newprice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    detail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    width = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    height = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    imageUrl1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    imageUrl2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    imageUrl3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    imageUrl4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    imageUrl5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    imageUrl6 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
