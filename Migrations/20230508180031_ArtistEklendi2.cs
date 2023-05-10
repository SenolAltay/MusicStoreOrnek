using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicStoreOrnek.Migrations
{
    public partial class ArtistEklendi2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GenreId",
                table: "Genres",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ArtistId",
                table: "Artist",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "AlbumId",
                table: "Albums",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Genres",
                newName: "GenreId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Artist",
                newName: "ArtistId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Albums",
                newName: "AlbumId");
        }
    }
}
