using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mvc_locations.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "id", "country_code", "country_name", "country_name_eng" },
                values: new object[] { 1, "CHN", "Kina", "China" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "id", "country_code", "country_name", "country_name_eng" },
                values: new object[] { 2, "HRV", "Hrvatska", "Croatia" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "id", "country_code", "country_name", "country_name_eng" },
                values: new object[] { 3, "UGA", "Uganda", "Uganda" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "id", "city_name", "country_id", "latitude", "longitude" },
                values: new object[,]
                {
                    { 1, "Zagreb", 2, 45.8150m, 15.9819m },
                    { 2, "Split", 2, 43.5147m, 16.4435m },
                    { 3, "Peking", 1, 39.9042m, 116.4074m },
                    { 4, "Šangaj", 1, 31.2304m, 121.4737m },
                    { 5, "Kampala", 3, 0.3476m, 32.5825m },
                    { 6, "Gulu", 3, 2.7724m, 32.2881m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
