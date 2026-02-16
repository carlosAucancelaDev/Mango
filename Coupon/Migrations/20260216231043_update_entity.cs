using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mango.Services.CouponAPI.Migrations
{
    /// <inheritdoc />
    public partial class update_entity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CuoponCode",
                table: "Coupons",
                newName: "CouponCode");

            migrationBuilder.RenameColumn(
                name: "CuoponId",
                table: "Coupons",
                newName: "CouponId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CouponCode",
                table: "Coupons",
                newName: "CuoponCode");

            migrationBuilder.RenameColumn(
                name: "CouponId",
                table: "Coupons",
                newName: "CuoponId");
        }
    }
}
