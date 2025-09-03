using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurant.DAL.Migrations.SqlServerMigrations
{
    /// <inheritdoc />
    public partial class InitialSqlServer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Food",
                columns: table => new
                {
                    FoodID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Left = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Food", x => x.FoodID);
                });

            migrationBuilder.CreateTable(
                name: "Table",
                columns: table => new
                {
                    TableID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table", x => x.TableID);
                });

            migrationBuilder.CreateTable(
                name: "FoodToTable",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TableID = table.Column<int>(type: "int", nullable: false),
                    FoodID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodToTable", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FoodToTable_Food_FoodID",
                        column: x => x.FoodID,
                        principalTable: "Food",
                        principalColumn: "FoodID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodToTable_Table_TableID",
                        column: x => x.TableID,
                        principalTable: "Table",
                        principalColumn: "TableID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FoodToTable_FoodID",
                table: "FoodToTable",
                column: "FoodID");

            migrationBuilder.CreateIndex(
                name: "IX_FoodToTable_TableID",
                table: "FoodToTable",
                column: "TableID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodToTable");

            migrationBuilder.DropTable(
                name: "Food");

            migrationBuilder.DropTable(
                name: "Table");
        }
    }
}
