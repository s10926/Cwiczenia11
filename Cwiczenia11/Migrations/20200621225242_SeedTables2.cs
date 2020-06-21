using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cwiczenia11.Migrations
{
    public partial class SeedTables2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Medicaments",
                columns: new[] { "IdMedicament", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "Cardinal Health", "PHENYLEPHRINE HYDROCHLORIDE", "Phenylephrine Hydrochloride" },
                    { 20, "BioComp Pharma, Inc.", "BENZOYL PEROXIDE", "BP Cleansing" },
                    { 18, "Jani-Source, LLC", "TRICLOSAN", "High Five" },
                    { 17, "Mylan Institutional Inc.", "doxazosin mesylate", "doxazosin" },
                    { 16, "ADVANCED BIOMEDICS INC", "ALLANTOIN GLYCERIN", "NEUTRACETT" },
                    { 15, "Graceway Pharmaceuticals, LLC", "orphenadrine citrate", "Norflex" },
                    { 14, "Preferred Pharmaceuticals, Inc", "Brompheniramine maleate and Pseudoephedrine hydrochloride", "Q-Tapp" },
                    { 13, "QUALITY CHOICE (Chain Drug Marketing Association)", "Isopropyl alcohol", "Isopropyl alcohol" },
                    { 12, "Kinray Inc.", "Mineral Oil", "Mineral Oil" },
                    { 11, "Aurobindo Pharma Limited", "Lamotrigine", "Lamotrigine" },
                    { 19, "Avon Products, Inc.", "TOLNAFTATE", "Foot Works Healthy" },
                    { 9, "Kremers Urban Pharmaceuticals Inc.", "anastrozole", "Anastrozole" },
                    { 10, "Taizhou Xinzhixuan Daily-Use Co., Ltd.", "TRICLOSAN", "Healing Waters Mandarin Vanilla Antibacterial Hand Soap" },
                    { 3, "West-Ward Pharmaceutical Corp", "ceftriaxone", "Ceftriaxone" },
                    { 4, "Perrigo New York Inc", "mineral oil, petrolatum, phenylephrine HCl", "Hemorrhoidal" },
                    { 2, "THEFACESHOP CO., LTD.", "TITANIUM DIOXIDE", "PHYTOGENIC INFINITE MAKEUP BASE" },
                    { 6, "Mason Chemical Company", "Benzalkonium Chloride", "Nobac Plus AB-F" },
                    { 7, "Novartis Pharmaceuticals Corporation", "carbamazepine", "Tegretol" },
                    { 8, "GlaxoSmithKline Consumer Healthcare LP", "sodium fluoride", "BIOTENE" },
                    { 5, "Akorn, Inc.", "Fluorescein Sodium", "FUL-GLO" }
                });

            migrationBuilder.InsertData(
                table: "Prescription_Medicaments",
                columns: new[] { "IdMedicament", "IdPrescription", "Details", "Dose", "MedicamentIdMedicament", "PrescriptionIdPrescription" },
                values: new object[,]
                {
                    { 7, 10, "id sapien in sapien iaculis congue", 61, null, null },
                    { 6, 5, "aliquam non mauris morbi non lectus aliquam sit amet", 8, null, null },
                    { 3, 15, "non sodales sed tincidunt eu", 50, null, null },
                    { 14, 7, "consequat lectus in est risus auctor", 82, null, null },
                    { 1, 19, "accumsan tellus nisi eu orci mauris lacinia sapien quis", 60, null, null },
                    { 14, 11, "ligula pellentesque ultrices phasellus id sapien in", 95, null, null },
                    { 16, 3, "sed lacus morbi sem mauris laoreet ut rhoncus aliquet pulvinar", 19, null, null },
                    { 7, 14, "dictumst etiam faucibus cursus urna ut tellus", 26, null, null },
                    { 20, 8, "vulputate ut ultrices vel augue vestibulum ante ipsum", 28, null, null },
                    { 4, 8, "vestibulum ante ipsum primis in faucibus", 63, null, null },
                    { 4, 16, "pede venenatis non sodales sed tincidunt eu felis fusce posuere", 12, null, null },
                    { 4, 9, "libero rutrum ac lobortis vel dapibus at diam nam tristique", 8, null, null },
                    { 9, 19, "orci luctus et ultrices posuere cubilia curae", 12, null, null },
                    { 15, 15, "erat quisque erat eros viverra eget congue eget semper rutrum", 37, null, null },
                    { 8, 17, "sem sed sagittis nam congue risus semper porta", 8, null, null },
                    { 18, 17, "turpis nec euismod scelerisque quam turpis adipiscing lorem vitae", 76, null, null },
                    { 17, 1, "nam tristique tortor eu pede", 40, null, null },
                    { 11, 1, "cursus id turpis integer aliquet massa id lobortis", 79, null, null },
                    { 7, 2, "non velit donec diam neque vestibulum eget", 22, null, null },
                    { 8, 18, "et tempus semper est quam pharetra magna ac consequat", 20, null, null }
                });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "IdPrescription", "Date", "DoctorIdDoctor", "DueDate", "IdDoctor", "IdPatient", "PatientIdPatient" },
                values: new object[,]
                {
                    { 20, new DateTime(2019, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 9, null },
                    { 1, new DateTime(2019, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 6, null },
                    { 2, new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 6, null },
                    { 3, new DateTime(2019, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 9, null },
                    { 4, new DateTime(2019, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, null },
                    { 5, new DateTime(2019, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 6, null },
                    { 6, new DateTime(2019, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 2, null },
                    { 7, new DateTime(2019, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 8, null },
                    { 8, new DateTime(2019, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 5, null },
                    { 9, new DateTime(2019, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 8, null },
                    { 11, new DateTime(2019, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 10, null },
                    { 12, new DateTime(2019, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 1, null },
                    { 13, new DateTime(2019, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 7, null },
                    { 14, new DateTime(2019, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 3, null },
                    { 15, new DateTime(2019, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, null },
                    { 16, new DateTime(2019, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 7, null },
                    { 17, new DateTime(2019, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 4, null },
                    { 18, new DateTime(2019, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 3, null },
                    { 19, new DateTime(2019, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 9, null },
                    { 10, new DateTime(2019, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 9, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 1, 19 });

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 3, 15 });

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 4, 9 });

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 4, 16 });

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 7, 10 });

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 7, 14 });

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 8, 17 });

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 8, 18 });

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 9, 19 });

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 14, 7 });

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 14, 11 });

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 15, 15 });

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 16, 3 });

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 17, 1 });

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 18, 17 });

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 20, 8 });

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 20);
        }
    }
}
