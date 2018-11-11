using Microsoft.EntityFrameworkCore.Migrations;

namespace StockExchanges.Model.Migrations
{
    public partial class alter_maxlength_Content : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>("Content", "Post", maxLength: 10000);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>("Content", "Post", maxLength: 2048);
        }
    }
}
