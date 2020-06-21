using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cwiczenia11.Migrations
{
    public partial class SeedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "IdDoctor", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "aprofit0@ning.com", "Alva", "Profit" },
                    { 9, "asemered8@washingtonpost.com", "Adel", "Semered" },
                    { 8, "abessey7@networkadvertising.org", "Alica", "Bessey" },
                    { 7, "ageorgiades6@linkedin.com", "Amil", "Georgiades" },
                    { 6, "sdudley5@surveymonkey.com", "Saw", "Dudley" },
                    { 10, "dlambol9@yellowbook.com", "Dieter", "Lambol" },
                    { 4, "akhomin3@reference.com", "Arlin", "Khomin" },
                    { 3, "msaintepaul2@bbb.org", "Maressa", "Sainte Paul" },
                    { 2, "ccottem1@examiner.com", "Cass", "Cottem" },
                    { 5, "rshapira4@ebay.com", "Reeva", "Shapira" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "IdPatient", "Date", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 9, new DateTime(1974, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bobbie", "Hayman" },
                    { 1, new DateTime(1965, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jania", "Sherbrook" },
                    { 2, new DateTime(1978, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Collie", "Jenkison" },
                    { 3, new DateTime(1970, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dulcia", "Alejandre" },
                    { 4, new DateTime(1946, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Westleigh", "McCome" },
                    { 5, new DateTime(1976, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anthe", "MacDonogh" },
                    { 6, new DateTime(1946, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Blair", "Burtwell" },
                    { 7, new DateTime(1982, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Isahella", "Drepp" },
                    { 8, new DateTime(1975, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Freddy", "Burgoin" },
                    { 10, new DateTime(1976, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dinny", "Sneesbie" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 10);
        }
    }
}
