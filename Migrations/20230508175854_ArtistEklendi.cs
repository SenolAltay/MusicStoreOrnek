using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicStoreOrnek.Migrations
{
    public partial class ArtistEklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Albums",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "ListPrice",
                table: "Albums");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Genres",
                newName: "GenreId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Albums",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "ImagePath",
                table: "Albums",
                newName: "AlbumArtUrl");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Albums",
                newName: "ArtistId");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Genres",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "ArtistId",
                table: "Albums",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "AlbumId",
                table: "Albums",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Albums",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Albums",
                table: "Albums",
                column: "AlbumId");

            migrationBuilder.CreateTable(
                name: "Artist",
                columns: table => new
                {
                    ArtistId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artist", x => x.ArtistId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Albums_ArtistId",
                table: "Albums",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Albums_GenreId",
                table: "Albums",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_Artist_ArtistId",
                table: "Albums",
                column: "ArtistId",
                principalTable: "Artist",
                principalColumn: "ArtistId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_Genres_GenreId",
                table: "Albums",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albums_Artist_ArtistId",
                table: "Albums");

            migrationBuilder.DropForeignKey(
                name: "FK_Albums_Genres_GenreId",
                table: "Albums");

            migrationBuilder.DropTable(
                name: "Artist");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Albums",
                table: "Albums");

            migrationBuilder.DropIndex(
                name: "IX_Albums_ArtistId",
                table: "Albums");

            migrationBuilder.DropIndex(
                name: "IX_Albums_GenreId",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "AlbumId",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Albums");

            migrationBuilder.RenameColumn(
                name: "GenreId",
                table: "Genres",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Albums",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ArtistId",
                table: "Albums",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "AlbumArtUrl",
                table: "Albums",
                newName: "ImagePath");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Albums",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<double>(
                name: "ListPrice",
                table: "Albums",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Albums",
                table: "Albums",
                column: "Id");
        }
    }
}
