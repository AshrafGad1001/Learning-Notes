using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace User_Management__with_Identity.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddProfilePictureAttr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "ProfilePicture",
                schema: "security",
                table: "users",
                type: "varbinary(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                schema: "security",
                table: "users");
        }
    }
}
