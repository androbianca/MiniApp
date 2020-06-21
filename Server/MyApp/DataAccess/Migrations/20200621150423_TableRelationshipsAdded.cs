using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class TableRelationshipsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Singers_Concert_ConcertId",
                table: "Singers");

            migrationBuilder.DropIndex(
                name: "IX_Singers_ConcertId",
                table: "Singers");

            migrationBuilder.DropIndex(
                name: "IX_Concert_LocationId",
                table: "Concert");

            migrationBuilder.DropColumn(
                name: "ConcertId",
                table: "Singers");

            migrationBuilder.DropColumn(
                name: "Years",
                table: "Singers");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Singers",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MusicType",
                table: "Singers",
                maxLength: 20,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Locations",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "ConcertSinger",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    SingerId = table.Column<Guid>(nullable: false),
                    ConcertId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConcertSinger", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConcertSinger_Concert_ConcertId",
                        column: x => x.ConcertId,
                        principalTable: "Concert",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConcertSinger_Singers_SingerId",
                        column: x => x.SingerId,
                        principalTable: "Singers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Concert_LocationId",
                table: "Concert",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_ConcertSinger_ConcertId",
                table: "ConcertSinger",
                column: "ConcertId");

            migrationBuilder.CreateIndex(
                name: "IX_ConcertSinger_SingerId",
                table: "ConcertSinger",
                column: "SingerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConcertSinger");

            migrationBuilder.DropIndex(
                name: "IX_Concert_LocationId",
                table: "Concert");

            migrationBuilder.DropColumn(
                name: "MusicType",
                table: "Singers");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Singers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ConcertId",
                table: "Singers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "Years",
                table: "Singers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Locations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Singers_ConcertId",
                table: "Singers",
                column: "ConcertId");

            migrationBuilder.CreateIndex(
                name: "IX_Concert_LocationId",
                table: "Concert",
                column: "LocationId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Singers_Concert_ConcertId",
                table: "Singers",
                column: "ConcertId",
                principalTable: "Concert",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
