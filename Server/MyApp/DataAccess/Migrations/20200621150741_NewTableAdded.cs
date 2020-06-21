using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class NewTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Concert_Locations_LocationId",
                table: "Concert");

            migrationBuilder.DropForeignKey(
                name: "FK_ConcertSinger_Concert_ConcertId",
                table: "ConcertSinger");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ConcertSinger",
                table: "ConcertSinger");

            migrationBuilder.DropIndex(
                name: "IX_ConcertSinger_SingerId",
                table: "ConcertSinger");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Concert",
                table: "Concert");

            migrationBuilder.RenameTable(
                name: "Concert",
                newName: "Concerts");

            migrationBuilder.RenameIndex(
                name: "IX_Concert_LocationId",
                table: "Concerts",
                newName: "IX_Concerts_LocationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ConcertSinger",
                table: "ConcertSinger",
                columns: new[] { "SingerId", "ConcertId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Concerts",
                table: "Concerts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Concerts_Locations_LocationId",
                table: "Concerts",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ConcertSinger_Concerts_ConcertId",
                table: "ConcertSinger",
                column: "ConcertId",
                principalTable: "Concerts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Concerts_Locations_LocationId",
                table: "Concerts");

            migrationBuilder.DropForeignKey(
                name: "FK_ConcertSinger_Concerts_ConcertId",
                table: "ConcertSinger");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ConcertSinger",
                table: "ConcertSinger");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Concerts",
                table: "Concerts");

            migrationBuilder.RenameTable(
                name: "Concerts",
                newName: "Concert");

            migrationBuilder.RenameIndex(
                name: "IX_Concerts_LocationId",
                table: "Concert",
                newName: "IX_Concert_LocationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ConcertSinger",
                table: "ConcertSinger",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Concert",
                table: "Concert",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ConcertSinger_SingerId",
                table: "ConcertSinger",
                column: "SingerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Concert_Locations_LocationId",
                table: "Concert",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ConcertSinger_Concert_ConcertId",
                table: "ConcertSinger",
                column: "ConcertId",
                principalTable: "Concert",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
