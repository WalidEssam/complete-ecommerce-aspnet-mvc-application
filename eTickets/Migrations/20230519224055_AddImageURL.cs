using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class AddImageURL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProfilePictureUrl",
                table: "Producers",
                newName: "ProfilePictureURL");

            migrationBuilder.RenameColumn(
                name: "Fullname",
                table: "Producers",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "ProfilePictureUrl",
                table: "Actors",
                newName: "ProfilePictureURL");

            migrationBuilder.RenameColumn(
                name: "Fullname",
                table: "Actors",
                newName: "FullName");

            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "ProfilePictureURL",
                table: "Producers",
                newName: "ProfilePictureUrl");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Producers",
                newName: "Fullname");

            migrationBuilder.RenameColumn(
                name: "ProfilePictureURL",
                table: "Actors",
                newName: "ProfilePictureUrl");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Actors",
                newName: "Fullname");
        }
    }
}
