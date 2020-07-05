using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class LocationSingerSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Country", "County", "Name", "Street" },
                values: new object[,]
                {
                    { new Guid("bf6d2c0e-b636-4f51-94ff-aab3406427c8"), "Romania", "Bucuresti", "Bucuresti", "Strada z" },
                    { new Guid("bf6d2c1e-b636-4f51-94ff-aab3406427c8"), "Romania", "Iasi", "Iasi", "Strada x" },
                    { new Guid("bf6d2c2e-b636-4f51-94ff-aab3406427c8"), "Romania", "Brasov", "Brasov", "Strada y" }
                });

            migrationBuilder.InsertData(
                table: "Singers",
                columns: new[] { "Id", "MusicType", "Name" },
                values: new object[,]
                {
                    { new Guid("5880919e-ab87-4f3b-aac3-d12513a40103"), "Pop", "Rihanna" },
                    { new Guid("4880919e-ab87-4f3b-aac3-d12513a40103"), "Rock", "The weekend" },
                    { new Guid("3880919e-ab87-4f3b-aac3-d12513a40103"), "Jazz", "Delia" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("bf6d2c0e-b636-4f51-94ff-aab3406427c8"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("bf6d2c1e-b636-4f51-94ff-aab3406427c8"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("bf6d2c2e-b636-4f51-94ff-aab3406427c8"));

            migrationBuilder.DeleteData(
                table: "Singers",
                keyColumn: "Id",
                keyValue: new Guid("3880919e-ab87-4f3b-aac3-d12513a40103"));

            migrationBuilder.DeleteData(
                table: "Singers",
                keyColumn: "Id",
                keyValue: new Guid("4880919e-ab87-4f3b-aac3-d12513a40103"));

            migrationBuilder.DeleteData(
                table: "Singers",
                keyColumn: "Id",
                keyValue: new Guid("5880919e-ab87-4f3b-aac3-d12513a40103"));
        }
    }
}
