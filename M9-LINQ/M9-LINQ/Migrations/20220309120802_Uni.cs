using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace M9_LINQ.Migrations
{
    public partial class Uni : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    CityID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Population = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.CityID);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    SubjectID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.SubjectID);
                });

            migrationBuilder.CreateTable(
                name: "University",
                columns: table => new
                {
                    UniversityID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_University", x => x.UniversityID);
                    table.ForeignKey(
                        name: "FK_University_City_CityID",
                        column: x => x.CityID,
                        principalTable: "City",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    TeacherID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<int>(type: "int", nullable: false),
                    SubjectID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.TeacherID);
                    table.ForeignKey(
                        name: "FK_Teacher_Subject_SubjectID",
                        column: x => x.SubjectID,
                        principalTable: "Subject",
                        principalColumn: "SubjectID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    GroupID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UniversityID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.GroupID);
                    table.ForeignKey(
                        name: "FK_Group_University_UniversityID",
                        column: x => x.UniversityID,
                        principalTable: "University",
                        principalColumn: "UniversityID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UniversityTeacher",
                columns: table => new
                {
                    UniversityID = table.Column<int>(type: "int", nullable: false),
                    TeacherID = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Wage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniversityTeacher", x => new { x.UniversityID, x.TeacherID });
                    table.ForeignKey(
                        name: "FK_UniversityTeacher_Teacher_TeacherID",
                        column: x => x.TeacherID,
                        principalTable: "Teacher",
                        principalColumn: "TeacherID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UniversityTeacher_University_UniversityID",
                        column: x => x.UniversityID,
                        principalTable: "University",
                        principalColumn: "UniversityID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Bursary = table.Column<int>(type: "int", nullable: false),
                    Bonus = table.Column<int>(type: "int", nullable: false),
                    CityID = table.Column<int>(type: "int", nullable: false),
                    GroupID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentID);
                    table.ForeignKey(
                        name: "FK_Student_City_CityID",
                        column: x => x.CityID,
                        principalTable: "City",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Student_Group_GroupID",
                        column: x => x.GroupID,
                        principalTable: "Group",
                        principalColumn: "GroupID");
                });

            migrationBuilder.CreateTable(
                name: "StudentSubject",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    SubjectID = table.Column<int>(type: "int", nullable: false),
                    Mark = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentSubject", x => new { x.StudentID, x.SubjectID });
                    table.ForeignKey(
                        name: "FK_StudentSubject_Student_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Student",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentSubject_Subject_SubjectID",
                        column: x => x.SubjectID,
                        principalTable: "Subject",
                        principalColumn: "SubjectID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityID", "Name", "Population" },
                values: new object[,]
                {
                    { 1, "Minsk", 123456 },
                    { 2, "Brest", 1234 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "Duration", "Name" },
                values: new object[,]
                {
                    { 1, 60, "Math" },
                    { 2, 80, "Russian" },
                    { 3, 60, "Belarusian" },
                    { 4, 80, "English" }
                });

            migrationBuilder.InsertData(
                table: "Teacher",
                columns: new[] { "TeacherID", "Name", "Phone", "SubjectID" },
                values: new object[,]
                {
                    { 1, "Maria Petrovna", 8757393, 1 },
                    { 2, "Vaniliy Krasnyj", 1286367, 1 },
                    { 3, "Olga Stepanovna", 8545583, 2 },
                    { 4, "Valentina Sergeevna", 98784688, 2 },
                    { 5, "Sergej Petrovich", 8757393, 3 },
                    { 6, "Marina Aleksandrovna", 1286367, 3 },
                    { 7, "Olga Aleksandrovna", 8545583, 4 },
                    { 8, "Valentina Aleksandrovna", 98784688, 4 }
                });

            migrationBuilder.InsertData(
                table: "University",
                columns: new[] { "UniversityID", "Address", "CityID", "Name" },
                values: new object[,]
                {
                    { 1, "address1", 1, "BSUIR" },
                    { 2, "address2", 1, "BSU" },
                    { 3, "address3", 2, "BSUSTT" }
                });

            migrationBuilder.InsertData(
                table: "Group",
                columns: new[] { "GroupID", "Name", "UniversityID" },
                values: new object[,]
                {
                    { 1, "First", 1 },
                    { 2, "Second", 1 },
                    { 3, "Third", 1 },
                    { 4, "First", 2 },
                    { 5, "Second", 2 },
                    { 6, "Third", 3 }
                });

            migrationBuilder.InsertData(
                table: "UniversityTeacher",
                columns: new[] { "TeacherID", "UniversityID", "Id", "Wage" },
                values: new object[,]
                {
                    { 1, 1, 1, 12345 },
                    { 2, 2, 2, 54321 },
                    { 3, 3, 3, 12345 }
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentID", "Birthday", "Bonus", "Bursary", "CityID", "GroupID", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 1000, 1, 1, "Dasha" },
                    { 2, new DateTime(2000, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 120, 1, 1, "Masha" },
                    { 3, new DateTime(2000, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 1200, 1, 1, "Misha" },
                    { 4, new DateTime(2001, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 500, 1, 2, "Oksana" },
                    { 5, new DateTime(2000, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 1000, 1, 3, "Sasha" },
                    { 6, new DateTime(1999, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 120, 1, 3, "Dasha" },
                    { 7, new DateTime(1998, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 1200, 1, 6, "Misha" },
                    { 8, new DateTime(1999, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 500, 1, 6, "Olga" },
                    { 9, new DateTime(2000, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 1000, 1, 2, "Sasha" },
                    { 10, new DateTime(2000, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 120, 1, 6, "Masha" },
                    { 11, new DateTime(2000, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 1200, 1, 4, "Lesha" },
                    { 12, new DateTime(2001, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 500, 1, 4, "Ulyana" },
                    { 13, new DateTime(2000, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 1000, 1, 4, "Sergey" },
                    { 14, new DateTime(1999, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 120, 1, 4, "Danya" },
                    { 15, new DateTime(1998, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 1200, 1, 5, "Valya" },
                    { 16, new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 500, 2, 5, "Petr" }
                });

            migrationBuilder.InsertData(
                table: "StudentSubject",
                columns: new[] { "StudentID", "SubjectID", "Mark" },
                values: new object[] { 1, 1, 8 });

            migrationBuilder.CreateIndex(
                name: "IX_Group_UniversityID",
                table: "Group",
                column: "UniversityID");

            migrationBuilder.CreateIndex(
                name: "IX_Student_CityID",
                table: "Student",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Student_GroupID",
                table: "Student",
                column: "GroupID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubject_StudentID",
                table: "StudentSubject",
                column: "StudentID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubject_SubjectID",
                table: "StudentSubject",
                column: "SubjectID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_SubjectID",
                table: "Teacher",
                column: "SubjectID");

            migrationBuilder.CreateIndex(
                name: "IX_University_CityID",
                table: "University",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_UniversityTeacher_TeacherID",
                table: "UniversityTeacher",
                column: "TeacherID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UniversityTeacher_UniversityID",
                table: "UniversityTeacher",
                column: "UniversityID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentSubject");

            migrationBuilder.DropTable(
                name: "UniversityTeacher");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Teacher");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.DropTable(
                name: "University");

            migrationBuilder.DropTable(
                name: "City");
        }
    }
}
