using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Migrations
{
    public partial class ss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbDays",
                columns: table => new
                {
                    DayID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbDays", x => x.DayID);
                });

            migrationBuilder.CreateTable(
                name: "tbSchools",
                columns: table => new
                {
                    SchoolID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbSchools", x => x.SchoolID);
                });

            migrationBuilder.CreateTable(
                name: "tbSubjects",
                columns: table => new
                {
                    SubjectsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbSubjects", x => x.SubjectsID);
                });

            migrationBuilder.CreateTable(
                name: "tbTeachers",
                columns: table => new
                {
                    TeacherID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbTeachers", x => x.TeacherID);
                });

            migrationBuilder.CreateTable(
                name: "tbSchoolClass",
                columns: table => new
                {
                    SchoolClassID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassName = table.Column<string>(nullable: false),
                    SchoolID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbSchoolClass", x => x.SchoolClassID);
                    table.ForeignKey(
                        name: "FK_tbSchoolClass_tbSchools_SchoolID",
                        column: x => x.SchoolID,
                        principalTable: "tbSchools",
                        principalColumn: "SchoolID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbTeachersAndSubject",
                columns: table => new
                {
                    TeachersAndSubjectID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherID = table.Column<int>(nullable: false),
                    SubjectsID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbTeachersAndSubject", x => x.TeachersAndSubjectID);
                    table.ForeignKey(
                        name: "FK_tbTeachersAndSubject_tbSubjects_SubjectsID",
                        column: x => x.SubjectsID,
                        principalTable: "tbSubjects",
                        principalColumn: "SubjectsID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbTeachersAndSubject_tbTeachers_TeacherID",
                        column: x => x.TeacherID,
                        principalTable: "tbTeachers",
                        principalColumn: "TeacherID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbStudents",
                columns: table => new
                {
                    StudentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(nullable: false),
                    SchoolClassID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbStudents", x => x.StudentID);
                    table.ForeignKey(
                        name: "FK_tbStudents_tbSchoolClass_SchoolClassID",
                        column: x => x.SchoolClassID,
                        principalTable: "tbSchoolClass",
                        principalColumn: "SchoolClassID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbSubjectTable",
                columns: table => new
                {
                    SubjectTableID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayID = table.Column<int>(nullable: true),
                    TeachersAndSubjectID = table.Column<int>(nullable: true),
                    SchoolClassID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbSubjectTable", x => x.SubjectTableID);
                    table.ForeignKey(
                        name: "FK_tbSubjectTable_tbDays_DayID",
                        column: x => x.DayID,
                        principalTable: "tbDays",
                        principalColumn: "DayID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tbSubjectTable_tbSchoolClass_SchoolClassID",
                        column: x => x.SchoolClassID,
                        principalTable: "tbSchoolClass",
                        principalColumn: "SchoolClassID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tbSubjectTable_tbTeachersAndSubject_TeachersAndSubjectID",
                        column: x => x.TeachersAndSubjectID,
                        principalTable: "tbTeachersAndSubject",
                        principalColumn: "TeachersAndSubjectID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "tbDays",
                columns: new[] { "DayID", "DayName" },
                values: new object[,]
                {
                    { 1, "Saturday" },
                    { 2, "Sunday" },
                    { 3, "Monday" },
                    { 4, "Tuesday" },
                    { 5, "Wednesday" },
                    { 6, "Thursday" },
                    { 7, "Friday" }
                });

            migrationBuilder.InsertData(
                table: "tbSchools",
                columns: new[] { "SchoolID", "SchoolName" },
                values: new object[,]
                {
                    { 4, "School4" },
                    { 3, "School3" },
                    { 1, "School1" },
                    { 2, "School2" }
                });

            migrationBuilder.InsertData(
                table: "tbSubjects",
                columns: new[] { "SubjectsID", "SubjectName" },
                values: new object[,]
                {
                    { 1, "Sub 1" },
                    { 2, "Sub 2" },
                    { 3, "Sub 3" },
                    { 4, "Sub 4" }
                });

            migrationBuilder.InsertData(
                table: "tbTeachers",
                columns: new[] { "TeacherID", "TeacherName" },
                values: new object[,]
                {
                    { 3, "Teacher 3" },
                    { 1, "Teacher 1" },
                    { 2, "Teacher 2" },
                    { 4, "Teacher 4" }
                });

            migrationBuilder.InsertData(
                table: "tbSchoolClass",
                columns: new[] { "SchoolClassID", "ClassName", "SchoolID" },
                values: new object[,]
                {
                    { 1, "Class 1", 1 },
                    { 2, "Class 2", 1 },
                    { 3, "Class 3", 1 },
                    { 4, "Class 4", 1 },
                    { 5, "Class 5", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbSchoolClass_SchoolID",
                table: "tbSchoolClass",
                column: "SchoolID");

            migrationBuilder.CreateIndex(
                name: "IX_tbStudents_SchoolClassID",
                table: "tbStudents",
                column: "SchoolClassID");

            migrationBuilder.CreateIndex(
                name: "IX_tbSubjectTable_DayID",
                table: "tbSubjectTable",
                column: "DayID");

            migrationBuilder.CreateIndex(
                name: "IX_tbSubjectTable_SchoolClassID",
                table: "tbSubjectTable",
                column: "SchoolClassID");

            migrationBuilder.CreateIndex(
                name: "IX_tbSubjectTable_TeachersAndSubjectID",
                table: "tbSubjectTable",
                column: "TeachersAndSubjectID");

            migrationBuilder.CreateIndex(
                name: "IX_tbTeachersAndSubject_SubjectsID",
                table: "tbTeachersAndSubject",
                column: "SubjectsID");

            migrationBuilder.CreateIndex(
                name: "IX_tbTeachersAndSubject_TeacherID",
                table: "tbTeachersAndSubject",
                column: "TeacherID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbStudents");

            migrationBuilder.DropTable(
                name: "tbSubjectTable");

            migrationBuilder.DropTable(
                name: "tbDays");

            migrationBuilder.DropTable(
                name: "tbSchoolClass");

            migrationBuilder.DropTable(
                name: "tbTeachersAndSubject");

            migrationBuilder.DropTable(
                name: "tbSchools");

            migrationBuilder.DropTable(
                name: "tbSubjects");

            migrationBuilder.DropTable(
                name: "tbTeachers");
        }
    }
}
