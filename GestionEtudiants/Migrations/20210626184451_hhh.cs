using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionEtudiants.Migrations
{
    public partial class hhh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 1,
                column: "N_fois",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 2,
                column: "id_etudiant",
                value: 2002);

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "N_fois", "id_etudiant" },
                values: new object[] { 6, 2005 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "N_fois", "id_etudiant" },
                values: new object[] { 15, 2002 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "N_fois", "id_etudiant" },
                values: new object[] { 2, 2002 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "N_fois", "id_etudiant" },
                values: new object[] { 13, 2001 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "N_fois", "id_etudiant" },
                values: new object[] { 7, 2004 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 8,
                column: "N_fois",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "N_fois", "id_etudiant" },
                values: new object[] { 8, 2008 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "N_fois", "id_etudiant" },
                values: new object[] { 9, 2002 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "N_fois", "id_etudiant" },
                values: new object[] { 6, 2007 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 12,
                column: "id_etudiant",
                value: 2009);

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "N_fois", "id_etudiant" },
                values: new object[] { 9, 2000 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "N_fois", "id_etudiant" },
                values: new object[] { 6, 2002 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 15,
                column: "N_fois",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "N_fois", "id_etudiant" },
                values: new object[] { 1, 2001 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "N_fois", "id_etudiant" },
                values: new object[] { 2, 2009 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 18,
                column: "id_etudiant",
                value: 2005);

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "N_fois", "id_etudiant" },
                values: new object[] { 9, 2008 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 20,
                column: "id_etudiant",
                value: 2007);

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "N_fois", "id_etudiant" },
                values: new object[] { 14, 2008 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "N_fois", "id_etudiant" },
                values: new object[] { 11, 2004 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "N_fois", "id_etudiant" },
                values: new object[] { 4, 2002 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "N_fois", "id_etudiant" },
                values: new object[] { 15, 2001 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "N_fois", "id_etudiant" },
                values: new object[] { 7, 2001 });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 1,
                column: "id_etudiant",
                value: 2008);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2001, "B" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2002, "C" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 4,
                column: "id_etudiant",
                value: 2009);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2002, "B" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2007, "A" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2005, "B" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2004, "C" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2002, "C" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 12,
                column: "id_etudiant",
                value: 2007);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2005, "B" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2001, "A" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2003, "B" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 16,
                column: "id_etudiant",
                value: 2002);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 17,
                column: "id_etudiant",
                value: 2005);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2009, "C" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2003, "A" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2006, "A" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 22,
                column: "id_etudiant",
                value: 2008);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2001, "B" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 25,
                column: "id_etudiant",
                value: 2005);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2004, "A" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2002, "A" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2001, "A" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 29,
                column: "type",
                value: "A");

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 30,
                column: "id_etudiant",
                value: 2002);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 31,
                column: "id_etudiant",
                value: 2003);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 32,
                column: "id_etudiant",
                value: 2002);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2009, "A" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 34,
                column: "type",
                value: "C");

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 36,
                column: "id_etudiant",
                value: 2009);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 37,
                column: "id_etudiant",
                value: 2004);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 38,
                column: "id_etudiant",
                value: 2005);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2007, "B" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 40,
                column: "id_etudiant",
                value: 2001);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2009, "A" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2000, "C" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 43,
                column: "id_etudiant",
                value: 2006);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2005, "C" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2001, "A" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2009, "A" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2007, "A" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 49,
                column: "id_etudiant",
                value: 2009);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2007, "C" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2003, "A" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2003, "B" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2003, "B" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2008, "A" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2004, "A" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 56,
                column: "id_etudiant",
                value: 2004);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 57,
                column: "id_etudiant",
                value: 2006);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2002, "A" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2003, "B" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2005, "A" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2004, "C" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 62,
                column: "id_etudiant",
                value: 2001);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2009, "C" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 64,
                column: "type",
                value: "C");

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 65,
                column: "id_etudiant",
                value: 2004);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 66,
                column: "id_etudiant",
                value: 2005);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2003, "A" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2008, "C" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 69,
                column: "id_etudiant",
                value: 2004);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 70,
                column: "id_etudiant",
                value: 2007);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 71,
                column: "id_etudiant",
                value: 2001);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 72,
                column: "type",
                value: "B");

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 73,
                column: "id_etudiant",
                value: 2006);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 75,
                column: "id_etudiant",
                value: 2000);

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2000,
                columns: new[] { "cin", "email", "id_inscription", "nom", "prenom" },
                values: new object[] { "EE27342", "Kerry68@gmail.com", 2, "Koelpin", "Kerry" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2001,
                columns: new[] { "cin", "email", "id_inscription", "nom", "prenom" },
                values: new object[] { "EE14977", "Heidi.Paucek@yahoo.com", 2, "Paucek", "Heidi" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2002,
                columns: new[] { "cin", "email", "id_inscription", "nom", "prenom" },
                values: new object[] { "EE46653", "Tara.Sanford@gmail.com", 10, "Sanford", "Tara" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2003,
                columns: new[] { "cin", "email", "id_inscription", "nom", "prenom", "sexe" },
                values: new object[] { "EE42448", "Dallas_Morar@hotmail.com", 10, "Morar", "Dallas", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2004,
                columns: new[] { "cin", "email", "id_inscription", "nom", "prenom", "sexe" },
                values: new object[] { "EE19820", "Boyd.Casper58@yahoo.com", 9, "Casper", "Boyd", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2005,
                columns: new[] { "cin", "email", "id_inscription", "nom", "prenom" },
                values: new object[] { "EE45643", "Antoinette_Olson@yahoo.com", 7, "Olson", "Antoinette" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2006,
                columns: new[] { "cin", "email", "id_inscription", "nom", "prenom" },
                values: new object[] { "EE10455", "Darin64@gmail.com", 6, "Deckow", "Darin" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2007,
                columns: new[] { "cin", "email", "id_inscription", "nom", "prenom" },
                values: new object[] { "EE10078", "Doreen_Nader42@hotmail.com", 6, "Nader", "Doreen" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2008,
                columns: new[] { "cin", "email", "id_inscription", "nom", "prenom" },
                values: new object[] { "EE50887", "Beulah36@hotmail.com", 5, "Kreiger", "Beulah" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2009,
                columns: new[] { "cin", "email", "nom", "prenom", "sexe" },
                values: new object[] { "EE23933", "Matthew_Mueller15@gmail.com", "Mueller", "Matthew", "Male" });

            migrationBuilder.UpdateData(
                table: "FiliereModules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FiliereId", "ModuleId" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "FiliereModules",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModuleId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "FiliereModules",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModuleId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "FiliereModules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FiliereId", "ModuleId" },
                values: new object[] { 2, 11 });

            migrationBuilder.UpdateData(
                table: "FiliereModules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FiliereId", "ModuleId" },
                values: new object[] { 3, 7 });

            migrationBuilder.UpdateData(
                table: "FiliereModules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FiliereId", "ModuleId" },
                values: new object[] { 4, 7 });

            migrationBuilder.UpdateData(
                table: "FiliereModules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FiliereId", "ModuleId" },
                values: new object[] { 3, 8 });

            migrationBuilder.UpdateData(
                table: "FiliereModules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FiliereId", "ModuleId" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "FiliereModules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FiliereId", "ModuleId" },
                values: new object[] { 1, 6 });

            migrationBuilder.UpdateData(
                table: "FiliereModules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FiliereId", "ModuleId" },
                values: new object[] { 1, 9 });

            migrationBuilder.UpdateData(
                table: "FiliereModules",
                keyColumn: "Id",
                keyValue: 11,
                column: "ModuleId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "FiliereModules",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "FiliereId", "ModuleId" },
                values: new object[] { 3, 11 });

            migrationBuilder.UpdateData(
                table: "FiliereModules",
                keyColumn: "Id",
                keyValue: 13,
                column: "ModuleId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "FiliereModules",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "FiliereId", "ModuleId" },
                values: new object[] { 2, 12 });

            migrationBuilder.UpdateData(
                table: "FiliereModules",
                keyColumn: "Id",
                keyValue: 15,
                column: "ModuleId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "FiliereModules",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "FiliereId", "ModuleId" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "Inscriptions",
                keyColumn: "id",
                keyValue: 1,
                column: "id_filiere",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Inscriptions",
                keyColumn: "id",
                keyValue: 2,
                column: "id_filiere",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Inscriptions",
                keyColumn: "id",
                keyValue: 3,
                column: "id_filiere",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Inscriptions",
                keyColumn: "id",
                keyValue: 4,
                column: "id_filiere",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Inscriptions",
                keyColumn: "id",
                keyValue: 5,
                column: "id_filiere",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Inscriptions",
                keyColumn: "id",
                keyValue: 6,
                column: "id_filiere",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Inscriptions",
                keyColumn: "id",
                keyValue: 7,
                column: "id_filiere",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Inscriptions",
                keyColumn: "id",
                keyValue: 8,
                column: "id_filiere",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Inscriptions",
                keyColumn: "id",
                keyValue: 10,
                column: "id_filiere",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "id_professeur", "nom" },
                values: new object[] { 1, "feed Morocco multi-byte" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "id_professeur", "nom" },
                values: new object[] { 23, "parse Awesome Investor" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "id_professeur", "nom" },
                values: new object[] { 19, "calculating port Branding" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "id_professeur", "nom" },
                values: new object[] { 17, "Bedfordshire Zambian Kwacha Quality" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "id_professeur", "nom" },
                values: new object[] { 24, "Sudanese Pound Ergonomic Unbranded" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "id_professeur", "nom" },
                values: new object[] { 1, "full-range IB vortals" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "id_professeur", "nom" },
                values: new object[] { 9, "digital Berkshire Virgin Islands, U.S." });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "id_professeur", "nom" },
                values: new object[] { 7, "Cotton Green evolve" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "id_professeur", "nom" },
                values: new object[] { 2, "engineer Auto Loan Account PCI" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "id_professeur", "nom" },
                values: new object[] { 14, "zero tolerance Buckinghamshire invoice" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "id_professeur", "nom" },
                values: new object[] { 18, "solution-oriented relationships magenta" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "id_professeur", "nom" },
                values: new object[] { 15, "Intelligent Investment Account card" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "evaluation", "id_module", "id_type", "valeur" },
                values: new object[] { "Uzbekistan Sum", 7, 3, "14" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "evaluation", "id_module", "id_type", "semestre", "valeur" },
                values: new object[] { "Designer", 8, 1, "2", "1" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "evaluation", "id_module", "id_type", "semestre", "valeur" },
                values: new object[] { "Designer", 7, 1, "2", "18" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "evaluation", "id_module", "id_type", "semestre", "valeur" },
                values: new object[] { "Delaware", 10, 3, "0", "16" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "evaluation", "id_module", "id_type", "semestre", "valeur" },
                values: new object[] { "logistical", 5, 2, "0", "20" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "evaluation", "id_module", "id_type", "semestre", "valeur" },
                values: new object[] { "Villages", 2, 1, "1", "9" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "evaluation", "id_module", "valeur" },
                values: new object[] { "model", 2, "13" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "evaluation", "id_module", "semestre", "valeur" },
                values: new object[] { "Metal", 6, "1", "3" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "evaluation", "id_type", "semestre", "valeur" },
                values: new object[] { "Oklahoma", 1, "2", "11" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "evaluation", "id_module", "id_type", "semestre", "valeur" },
                values: new object[] { "Health & Music", 10, 2, "2", "13" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "evaluation", "valeur" },
                values: new object[] { "utilize", "10" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "evaluation", "id_module", "id_type", "valeur" },
                values: new object[] { "paradigms", 9, 1, "15" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE360963", "Wayne_Hauck@yahoo.com", "Hauck", "Wayne", "905.906.5853 x35030" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE958322", "Alfredo_Kunde@yahoo.com", "Kunde", "Alfredo", "878-530-2240" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE348965", "Kristina57@gmail.com", "Bergnaum", "Kristina", "1-588-687-9310 x311" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE358690", "Nick_Johnston19@yahoo.com", "Johnston", "Nick", "(570) 681-0178" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE260403", "Allan.Barton90@yahoo.com", "Barton", "Allan", "(262) 790-1517 x3265" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE967424", "Jennie.Russel33@gmail.com", "Russel", "Jennie", "(602) 211-5066 x72655" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE843844", "Grace.Littel72@yahoo.com", "Littel", "Grace", "1-835-334-2333 x282" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE573610", "Darnell.Fahey@gmail.com", "Fahey", "Darnell", "1-275-948-6848" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE937564", "Joey_Lebsack@yahoo.com", "Lebsack", "Joey", "1-568-992-2506 x61749" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE973727", "Jennie66@gmail.com", "Littel", "Jennie", "(740) 607-8435" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE468767", "Katherine.Runolfsson@yahoo.com", "Runolfsson", "Katherine", "233-774-9561 x17292" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE326575", "Carl.Kerluke44@hotmail.com", "Kerluke", "Carl", "818.659.7302 x35116" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE946990", "Erika_Runolfsson@hotmail.com", "Runolfsson", "Erika", "(519) 235-0880" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE522601", "Shane53@yahoo.com", "Mills", "Shane", "958-461-1520 x50205" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE899039", "Robin68@yahoo.com", "Flatley", "Robin", "1-644-461-1573" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE848039", "Marty.Herzog16@gmail.com", "Herzog", "Marty", "(470) 990-6470" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE882451", "Hubert.OHara@yahoo.com", "O'Hara", "Hubert", "504-768-6786 x026" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE928407", "Brooke.Schneider9@gmail.com", "Schneider", "Brooke", "535-670-4619 x52946" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE544370", "Brooke_Yundt@yahoo.com", "Yundt", "Brooke", "269.860.3089" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE22384", "Ella.Kutch4@yahoo.com", "Kutch", "Ella", "1-983-550-5930 x006" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE97510", "Sonia_Wuckert29@gmail.com", "Wuckert", "Sonia", "383-920-9067 x267" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE383023", "Suzanne21@hotmail.com", "Hilpert", "Suzanne", "(297) 330-0581 x96395" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE527471", "Karl.Kovacek25@yahoo.com", "Kovacek", "Karl", "1-866-715-1156" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE948638", "Loren.Toy@gmail.com", "Toy", "Loren", "323-859-8294" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE831556", "Tyrone15@hotmail.com", "Jacobi", "Tyrone", "(882) 370-9035 x76299" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 1,
                column: "N_fois",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 2,
                column: "id_etudiant",
                value: 2005);

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "N_fois", "id_etudiant" },
                values: new object[] { 14, 2006 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "N_fois", "id_etudiant" },
                values: new object[] { 5, 2001 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "N_fois", "id_etudiant" },
                values: new object[] { 7, 2005 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "N_fois", "id_etudiant" },
                values: new object[] { 4, 2003 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "N_fois", "id_etudiant" },
                values: new object[] { 2, 2008 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 8,
                column: "N_fois",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "N_fois", "id_etudiant" },
                values: new object[] { 0, 2006 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "N_fois", "id_etudiant" },
                values: new object[] { 15, 2001 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "N_fois", "id_etudiant" },
                values: new object[] { 1, 2006 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 12,
                column: "id_etudiant",
                value: 2002);

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "N_fois", "id_etudiant" },
                values: new object[] { 6, 2008 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "N_fois", "id_etudiant" },
                values: new object[] { 1, 2000 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 15,
                column: "N_fois",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "N_fois", "id_etudiant" },
                values: new object[] { 4, 2005 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "N_fois", "id_etudiant" },
                values: new object[] { 4, 2005 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 18,
                column: "id_etudiant",
                value: 2001);

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "N_fois", "id_etudiant" },
                values: new object[] { 8, 2004 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 20,
                column: "id_etudiant",
                value: 2006);

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "N_fois", "id_etudiant" },
                values: new object[] { 3, 2007 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "N_fois", "id_etudiant" },
                values: new object[] { 14, 2003 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "N_fois", "id_etudiant" },
                values: new object[] { 2, 2007 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "N_fois", "id_etudiant" },
                values: new object[] { 9, 2009 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "N_fois", "id_etudiant" },
                values: new object[] { 1, 2009 });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 1,
                column: "id_etudiant",
                value: 2000);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2008, "C" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2009, "A" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 4,
                column: "id_etudiant",
                value: 2006);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2000, "A" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2003, "B" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2008, "A" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2006, "A" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2009, "A" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 12,
                column: "id_etudiant",
                value: 2003);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2003, "C" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2002, "C" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2006, "A" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 16,
                column: "id_etudiant",
                value: 2001);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 17,
                column: "id_etudiant",
                value: 2001);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2004, "B" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2006, "B" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2008, "C" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 22,
                column: "id_etudiant",
                value: 2001);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2009, "A" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 25,
                column: "id_etudiant",
                value: 2004);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2009, "B" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2001, "C" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2002, "C" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 29,
                column: "type",
                value: "B");

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 30,
                column: "id_etudiant",
                value: 2006);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 31,
                column: "id_etudiant",
                value: 2002);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 32,
                column: "id_etudiant",
                value: 2004);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2004, "C" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 34,
                column: "type",
                value: "B");

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 36,
                column: "id_etudiant",
                value: 2006);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 37,
                column: "id_etudiant",
                value: 2005);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 38,
                column: "id_etudiant",
                value: 2004);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2002, "A" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 40,
                column: "id_etudiant",
                value: 2009);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2006, "C" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2006, "A" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 43,
                column: "id_etudiant",
                value: 2003);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2007, "B" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2009, "B" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2007, "B" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2004, "B" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 49,
                column: "id_etudiant",
                value: 2008);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2006, "B" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2005, "B" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2001, "A" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2000, "A" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2002, "C" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2003, "C" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 56,
                column: "id_etudiant",
                value: 2003);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 57,
                column: "id_etudiant",
                value: 2000);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2005, "C" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2009, "A" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2003, "B" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2005, "A" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 62,
                column: "id_etudiant",
                value: 2002);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2003, "B" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 64,
                column: "type",
                value: "A");

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 65,
                column: "id_etudiant",
                value: 2007);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 66,
                column: "id_etudiant",
                value: 2004);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2005, "C" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "id_etudiant", "type" },
                values: new object[] { 2001, "B" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 69,
                column: "id_etudiant",
                value: 2000);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 70,
                column: "id_etudiant",
                value: 2000);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 71,
                column: "id_etudiant",
                value: 2000);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 72,
                column: "type",
                value: "C");

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 73,
                column: "id_etudiant",
                value: 2002);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 75,
                column: "id_etudiant",
                value: 2008);

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2000,
                columns: new[] { "cin", "email", "id_inscription", "nom", "prenom" },
                values: new object[] { "EE6406", "Antoinette_Fahey@yahoo.com", 6, "Fahey", "Antoinette" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2001,
                columns: new[] { "cin", "email", "id_inscription", "nom", "prenom" },
                values: new object[] { "EE58834", "Chelsea_Zemlak@gmail.com", 4, "Zemlak", "Chelsea" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2002,
                columns: new[] { "cin", "email", "id_inscription", "nom", "prenom" },
                values: new object[] { "EE39510", "Molly_Bruen@gmail.com", 1, "Bruen", "Molly" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2003,
                columns: new[] { "cin", "email", "id_inscription", "nom", "prenom", "sexe" },
                values: new object[] { "EE24228", "Roberta_Williamson@yahoo.com", 6, "Williamson", "Roberta", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2004,
                columns: new[] { "cin", "email", "id_inscription", "nom", "prenom", "sexe" },
                values: new object[] { "EE34030", "Nichole_Schmitt@gmail.com", 2, "Schmitt", "Nichole", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2005,
                columns: new[] { "cin", "email", "id_inscription", "nom", "prenom" },
                values: new object[] { "EE35969", "Minnie_Langosh66@yahoo.com", 5, "Langosh", "Minnie" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2006,
                columns: new[] { "cin", "email", "id_inscription", "nom", "prenom" },
                values: new object[] { "EE43268", "Wallace49@yahoo.com", 10, "Langosh", "Wallace" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2007,
                columns: new[] { "cin", "email", "id_inscription", "nom", "prenom" },
                values: new object[] { "EE19201", "Sonya.Botsford@gmail.com", 3, "Botsford", "Sonya" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2008,
                columns: new[] { "cin", "email", "id_inscription", "nom", "prenom" },
                values: new object[] { "EE53330", "Delia.Lueilwitz86@yahoo.com", 9, "Lueilwitz", "Delia" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2009,
                columns: new[] { "cin", "email", "nom", "prenom", "sexe" },
                values: new object[] { "EE59426", "Connie_Osinski@yahoo.com", "Osinski", "Connie", "Female" });

            migrationBuilder.UpdateData(
                table: "FiliereModules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FiliereId", "ModuleId" },
                values: new object[] { 2, 5 });

            migrationBuilder.UpdateData(
                table: "FiliereModules",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModuleId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "FiliereModules",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModuleId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "FiliereModules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FiliereId", "ModuleId" },
                values: new object[] { 4, 12 });

            migrationBuilder.UpdateData(
                table: "FiliereModules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FiliereId", "ModuleId" },
                values: new object[] { 4, 10 });

            migrationBuilder.UpdateData(
                table: "FiliereModules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FiliereId", "ModuleId" },
                values: new object[] { 3, 10 });

            migrationBuilder.UpdateData(
                table: "FiliereModules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FiliereId", "ModuleId" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "FiliereModules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FiliereId", "ModuleId" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "FiliereModules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FiliereId", "ModuleId" },
                values: new object[] { 4, 7 });

            migrationBuilder.UpdateData(
                table: "FiliereModules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FiliereId", "ModuleId" },
                values: new object[] { 3, 8 });

            migrationBuilder.UpdateData(
                table: "FiliereModules",
                keyColumn: "Id",
                keyValue: 11,
                column: "ModuleId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "FiliereModules",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "FiliereId", "ModuleId" },
                values: new object[] { 2, 6 });

            migrationBuilder.UpdateData(
                table: "FiliereModules",
                keyColumn: "Id",
                keyValue: 13,
                column: "ModuleId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "FiliereModules",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "FiliereId", "ModuleId" },
                values: new object[] { 3, 9 });

            migrationBuilder.UpdateData(
                table: "FiliereModules",
                keyColumn: "Id",
                keyValue: 15,
                column: "ModuleId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "FiliereModules",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "FiliereId", "ModuleId" },
                values: new object[] { 3, 10 });

            migrationBuilder.UpdateData(
                table: "Inscriptions",
                keyColumn: "id",
                keyValue: 1,
                column: "id_filiere",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Inscriptions",
                keyColumn: "id",
                keyValue: 2,
                column: "id_filiere",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Inscriptions",
                keyColumn: "id",
                keyValue: 3,
                column: "id_filiere",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Inscriptions",
                keyColumn: "id",
                keyValue: 4,
                column: "id_filiere",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Inscriptions",
                keyColumn: "id",
                keyValue: 5,
                column: "id_filiere",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Inscriptions",
                keyColumn: "id",
                keyValue: 6,
                column: "id_filiere",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Inscriptions",
                keyColumn: "id",
                keyValue: 7,
                column: "id_filiere",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Inscriptions",
                keyColumn: "id",
                keyValue: 8,
                column: "id_filiere",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Inscriptions",
                keyColumn: "id",
                keyValue: 10,
                column: "id_filiere",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "id_professeur", "nom" },
                values: new object[] { 12, "Ergonomic Fresh Bacon website New York" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "id_professeur", "nom" },
                values: new object[] { 10, "compressing Guinea-Bissau Operations" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "id_professeur", "nom" },
                values: new object[] { 5, "bus Investment Account orange" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "id_professeur", "nom" },
                values: new object[] { 10, "Assistant PCI eyeballs" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "id_professeur", "nom" },
                values: new object[] { 8, "copy orchid recontextualize" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "id_professeur", "nom" },
                values: new object[] { 12, "Handmade silver JSON" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "id_professeur", "nom" },
                values: new object[] { 1, "customized Communications payment" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "id_professeur", "nom" },
                values: new object[] { 23, "compressing Assurance programming" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "id_professeur", "nom" },
                values: new object[] { 15, "Kids & Games markets Unbranded Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "id_professeur", "nom" },
                values: new object[] { 8, "California deposit Loop" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "id_professeur", "nom" },
                values: new object[] { 19, "deliverables invoice Legacy" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "id_professeur", "nom" },
                values: new object[] { 14, "Iraqi Dinar Program upward-trending" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "evaluation", "id_module", "id_type", "valeur" },
                values: new object[] { "local area network", 5, 1, "17" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "evaluation", "id_module", "id_type", "semestre", "valeur" },
                values: new object[] { "e-markets", 11, 2, "1", "4" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "evaluation", "id_module", "id_type", "semestre", "valeur" },
                values: new object[] { "synergistic", 2, 2, "0", "17" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "evaluation", "id_module", "id_type", "semestre", "valeur" },
                values: new object[] { "Gorgeous Steel Hat", 5, 2, "1", "17" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "evaluation", "id_module", "id_type", "semestre", "valeur" },
                values: new object[] { "Fresh", 9, 3, "1", "0" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "evaluation", "id_module", "id_type", "semestre", "valeur" },
                values: new object[] { "payment", 1, 2, "2", "16" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "evaluation", "id_module", "valeur" },
                values: new object[] { "Louisiana", 8, "5" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "evaluation", "id_module", "semestre", "valeur" },
                values: new object[] { "Money Market Account", 9, "0", "0" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "evaluation", "id_type", "semestre", "valeur" },
                values: new object[] { "Belgium", 3, "0", "19" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "evaluation", "id_module", "id_type", "semestre", "valeur" },
                values: new object[] { "system", 1, 3, "0", "15" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "evaluation", "valeur" },
                values: new object[] { "Massachusetts", "0" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "evaluation", "id_module", "id_type", "valeur" },
                values: new object[] { "Principal", 10, 3, "17" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE345121", "Albert.Pacocha@hotmail.com", "Pacocha", "Albert", "(320) 406-7248 x131" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE315928", "Troy_Howe@gmail.com", "Howe", "Troy", "1-319-432-2020" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE382781", "Roxanne.Welch@hotmail.com", "Welch", "Roxanne", "692.839.1222" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE451528", "Tyrone14@hotmail.com", "Bahringer", "Tyrone", "1-798-699-5942 x85156" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE444675", "Kenneth.Kub@hotmail.com", "Kub", "Kenneth", "798-217-0453 x25460" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE311356", "Shelley_Muller33@gmail.com", "Muller", "Shelley", "1-591-510-2932 x8751" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE52628", "Emma74@gmail.com", "Dooley", "Emma", "413.609.0609" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE47803", "Jackie.Jakubowski@gmail.com", "Jakubowski", "Jackie", "1-672-892-2035 x985" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE815580", "Rene61@yahoo.com", "Bins", "Rene", "633-952-3346 x6017" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE52484", "Terence28@yahoo.com", "Lynch", "Terence", "1-297-663-7980" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE114855", "Krista72@yahoo.com", "Bruen", "Krista", "959-445-9453" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE898851", "Lucas.Kovacek91@hotmail.com", "Kovacek", "Lucas", "613-934-8295 x41143" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE257235", "Melvin_Homenick7@gmail.com", "Homenick", "Melvin", "740.808.8061 x36418" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE983883", "Phillip96@hotmail.com", "Marks", "Phillip", "374-417-5964 x280" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE347967", "Darlene_Konopelski14@hotmail.com", "Konopelski", "Darlene", "773-856-7808 x4427" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE13183", "Roy63@gmail.com", "Parker", "Roy", "1-868-394-8100" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE183659", "Kelli.OConner@gmail.com", "O'Conner", "Kelli", "681.909.4695 x001" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE108048", "Sabrina67@yahoo.com", "Gerlach", "Sabrina", "475.895.0797 x130" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE643092", "Ben83@hotmail.com", "Cremin", "Ben", "689.231.2312" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE171407", "Silvia.Kunze@hotmail.com", "Kunze", "Silvia", "(827) 406-7784 x422" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE625741", "Roxanne_Kiehn@hotmail.com", "Kiehn", "Roxanne", "(248) 901-2008 x45370" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE180197", "Lawrence94@hotmail.com", "Kuvalis", "Lawrence", "505.405.3419 x8823" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE458601", "Willie7@yahoo.com", "Douglas", "Willie", "906.949.5940" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE956597", "Sherry.Pagac@yahoo.com", "Pagac", "Sherry", "755-251-8975" });

            migrationBuilder.UpdateData(
                table: "Proffesseurs",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "cin", "email", "nom", "prenom", "tel" },
                values: new object[] { "EE901454", "Heather.Leannon@hotmail.com", "Leannon", "Heather", "(604) 581-7525 x19466" });
        }
    }
}
