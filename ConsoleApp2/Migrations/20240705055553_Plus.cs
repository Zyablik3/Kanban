using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ConsoleApp2.Migrations
{
    /// <inheritdoc />
    public partial class Plus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /*migrationBuilder.CreateTable(
                name: "KanbanTasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Interview = table.Column<string>(type: "text", nullable: true),
                    WriteTZ = table.Column<string>(type: "text", nullable: true),
                    ApproveTZ = table.Column<string>(type: "text", nullable: true),
                    DevelopSoft = table.Column<string>(type: "text", nullable: true),
                    AcceeptSoft = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KanbanTasks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MyTaskStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Queue = table.Column<string>(type: "text", nullable: true),
                    Analysis = table.Column<string>(type: "text", nullable: true),
                    Development = table.Column<string>(type: "text", nullable: true),
                    Accept = table.Column<string>(type: "text", nullable: true),
                    Drop = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyTaskStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Zakazchik",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Surname = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    INN = table.Column<int>(type: "integer", nullable: false),
                    PhoneNumber = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zakazchik", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KanbanProjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Cost = table.Column<int>(type: "integer", nullable: false),
                    KanbanTaskId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KanbanProjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KanbanProjects_KanbanTasks_KanbanTaskId",
                        column: x => x.KanbanTaskId,
                        principalTable: "KanbanTasks",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_KanbanProjects_KanbanTaskId",
                table: "KanbanProjects",
                column: "KanbanTaskId");*/
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
           /* migrationBuilder.DropTable(
                name: "KanbanProjects");

            migrationBuilder.DropTable(
                name: "MyTaskStatuses");

            migrationBuilder.DropTable(
                name: "Zakazchik");

            migrationBuilder.DropTable(
                name: "KanbanTasks");*/
        }
    }
}
