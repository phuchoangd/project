using Microsoft.EntityFrameworkCore.Migrations;

namespace StockExchanges.Model.Migrations
{
    public partial class drop_column_category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>("CategoryId", "Categories", nullable: true);
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>("CategoryId", "Categories", nullable: false);
        }
    }
}
