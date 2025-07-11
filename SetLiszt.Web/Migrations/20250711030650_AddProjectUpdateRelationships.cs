using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SetLiszt.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddProjectUpdateRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Set_Gig_GigId",
                table: "Set");

            migrationBuilder.DropForeignKey(
                name: "FK_Song_Set_SetId",
                table: "Song");

            migrationBuilder.DropIndex(
                name: "IX_Song_SetId",
                table: "Song");

            migrationBuilder.DropIndex(
                name: "IX_Set_GigId",
                table: "Set");

            migrationBuilder.DropColumn(
                name: "SetId",
                table: "Song");

            migrationBuilder.DropColumn(
                name: "GigId",
                table: "Set");

            migrationBuilder.CreateTable(
                name: "GigSet",
                columns: table => new
                {
                    GigsId = table.Column<int>(type: "integer", nullable: false),
                    SetsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GigSet", x => new { x.GigsId, x.SetsId });
                    table.ForeignKey(
                        name: "FK_GigSet_Gig_GigsId",
                        column: x => x.GigsId,
                        principalTable: "Gig",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GigSet_Set_SetsId",
                        column: x => x.SetsId,
                        principalTable: "Set",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SetSong",
                columns: table => new
                {
                    SetsId = table.Column<int>(type: "integer", nullable: false),
                    SongsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SetSong", x => new { x.SetsId, x.SongsId });
                    table.ForeignKey(
                        name: "FK_SetSong_Set_SetsId",
                        column: x => x.SetsId,
                        principalTable: "Set",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SetSong_Song_SongsId",
                        column: x => x.SongsId,
                        principalTable: "Song",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GigProject",
                columns: table => new
                {
                    GigsId = table.Column<int>(type: "integer", nullable: false),
                    ProjectsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GigProject", x => new { x.GigsId, x.ProjectsId });
                    table.ForeignKey(
                        name: "FK_GigProject_Gig_GigsId",
                        column: x => x.GigsId,
                        principalTable: "Gig",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GigProject_Project_ProjectsId",
                        column: x => x.ProjectsId,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectSet",
                columns: table => new
                {
                    ProjectsId = table.Column<int>(type: "integer", nullable: false),
                    SetsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectSet", x => new { x.ProjectsId, x.SetsId });
                    table.ForeignKey(
                        name: "FK_ProjectSet_Project_ProjectsId",
                        column: x => x.ProjectsId,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectSet_Set_SetsId",
                        column: x => x.SetsId,
                        principalTable: "Set",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectSong",
                columns: table => new
                {
                    ProjectsId = table.Column<int>(type: "integer", nullable: false),
                    SongsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectSong", x => new { x.ProjectsId, x.SongsId });
                    table.ForeignKey(
                        name: "FK_ProjectSong_Project_ProjectsId",
                        column: x => x.ProjectsId,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectSong_Song_SongsId",
                        column: x => x.SongsId,
                        principalTable: "Song",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GigProject_ProjectsId",
                table: "GigProject",
                column: "ProjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_GigSet_SetsId",
                table: "GigSet",
                column: "SetsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSet_SetsId",
                table: "ProjectSet",
                column: "SetsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSong_SongsId",
                table: "ProjectSong",
                column: "SongsId");

            migrationBuilder.CreateIndex(
                name: "IX_SetSong_SongsId",
                table: "SetSong",
                column: "SongsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GigProject");

            migrationBuilder.DropTable(
                name: "GigSet");

            migrationBuilder.DropTable(
                name: "ProjectSet");

            migrationBuilder.DropTable(
                name: "ProjectSong");

            migrationBuilder.DropTable(
                name: "SetSong");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.AddColumn<int>(
                name: "SetId",
                table: "Song",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GigId",
                table: "Set",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Song_SetId",
                table: "Song",
                column: "SetId");

            migrationBuilder.CreateIndex(
                name: "IX_Set_GigId",
                table: "Set",
                column: "GigId");

            migrationBuilder.AddForeignKey(
                name: "FK_Set_Gig_GigId",
                table: "Set",
                column: "GigId",
                principalTable: "Gig",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Song_Set_SetId",
                table: "Song",
                column: "SetId",
                principalTable: "Set",
                principalColumn: "Id");
        }
    }
}
