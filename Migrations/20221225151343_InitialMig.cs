using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcBook.Migrations
{
    public partial class InitialMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    B_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    B_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    B_Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B_Page = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgTitle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.B_Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    U_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    U_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    U_LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    U_Password = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    U_Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    U_Bday = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    U_SignupDay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Is_Admin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.U_Id);
                });

            migrationBuilder.CreateTable(
                name: "Commentaries",
                columns: table => new
                {
                    C_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    U_Id = table.Column<int>(type: "int", nullable: false),
                    B_Id = table.Column<int>(type: "int", nullable: false),
                    C_Head = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C_Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commentaries", x => x.C_Id);
                    table.ForeignKey(
                        name: "FK_Commentaries_Books_B_Id",
                        column: x => x.B_Id,
                        principalTable: "Books",
                        principalColumn: "B_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Commentaries_Users_U_Id",
                        column: x => x.U_Id,
                        principalTable: "Users",
                        principalColumn: "U_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Commentaries_B_Id",
                table: "Commentaries",
                column: "B_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Commentaries_U_Id",
                table: "Commentaries",
                column: "U_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Commentaries");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
