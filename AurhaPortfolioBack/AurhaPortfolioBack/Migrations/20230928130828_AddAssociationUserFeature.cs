using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AurhaPortfolioBack.Migrations
{
    /// <inheritdoc />
    public partial class AddAssociationUserFeature : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Artworks_ArtworkFeaturesId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ArtworkFeaturesId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ArtworkFeaturesId",
                table: "Users");

            migrationBuilder.CreateTable(
                name: "ArtworkFeaturesUserFeatures",
                columns: table => new
                {
                    ArtworksId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtworkFeaturesUserFeatures", x => new { x.ArtworksId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_ArtworkFeaturesUserFeatures_Artworks_ArtworksId",
                        column: x => x.ArtworksId,
                        principalTable: "Artworks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtworkFeaturesUserFeatures_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArtworkFeaturesUserFeatures_UsersId",
                table: "ArtworkFeaturesUserFeatures",
                column: "UsersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtworkFeaturesUserFeatures");

            migrationBuilder.AddColumn<int>(
                name: "ArtworkFeaturesId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_ArtworkFeaturesId",
                table: "Users",
                column: "ArtworkFeaturesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Artworks_ArtworkFeaturesId",
                table: "Users",
                column: "ArtworkFeaturesId",
                principalTable: "Artworks",
                principalColumn: "Id");
        }
    }
}
