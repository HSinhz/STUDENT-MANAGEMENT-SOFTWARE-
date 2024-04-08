using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project_Windows.Migrations
{
    /// <inheritdoc />
    public partial class migrationAccount123 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    BranchID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameBranch = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.BranchID);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    ClassID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BranchID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.ClassID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameStudent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SexStudent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressStudent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDay = table.Column<DateTime>(type: "Date", nullable: false),
                    Phone = table.Column<string>(type: "nchar(10)", maxLength: 10, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ClassID = table.Column<int>(type: "int", nullable: false),
                    BranchID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentID);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    SubjectID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubjectCredit = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.SubjectID);
                });

            migrationBuilder.CreateTable(
                name: "BranchClass",
                columns: table => new
                {
                    BranchesBranchID = table.Column<long>(type: "bigint", nullable: false),
                    ClassesClassID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchClass", x => new { x.BranchesBranchID, x.ClassesClassID });
                    table.ForeignKey(
                        name: "FK_BranchClass_Branches_BranchesBranchID",
                        column: x => x.BranchesBranchID,
                        principalTable: "Branches",
                        principalColumn: "BranchID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BranchClass_Classes_ClassesClassID",
                        column: x => x.ClassesClassID,
                        principalTable: "Classes",
                        principalColumn: "ClassID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BranchStudent",
                columns: table => new
                {
                    BranchesBranchID = table.Column<long>(type: "bigint", nullable: false),
                    StudentsStudentID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchStudent", x => new { x.BranchesBranchID, x.StudentsStudentID });
                    table.ForeignKey(
                        name: "FK_BranchStudent_Branches_BranchesBranchID",
                        column: x => x.BranchesBranchID,
                        principalTable: "Branches",
                        principalColumn: "BranchID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BranchStudent_Students_StudentsStudentID",
                        column: x => x.StudentsStudentID,
                        principalTable: "Students",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassStudent",
                columns: table => new
                {
                    ClassesClassID = table.Column<long>(type: "bigint", nullable: false),
                    StudentsStudentID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassStudent", x => new { x.ClassesClassID, x.StudentsStudentID });
                    table.ForeignKey(
                        name: "FK_ClassStudent_Classes_ClassesClassID",
                        column: x => x.ClassesClassID,
                        principalTable: "Classes",
                        principalColumn: "ClassID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassStudent_Students_StudentsStudentID",
                        column: x => x.StudentsStudentID,
                        principalTable: "Students",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubjectScoreDetails",
                columns: table => new
                {
                    SubjectScoreID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectID = table.Column<int>(type: "int", nullable: false),
                    StudentID = table.Column<long>(type: "bigint", nullable: false),
                    NameStudent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Score1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Score2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectScoreDetails", x => x.SubjectScoreID);
                    table.ForeignKey(
                        name: "FK_SubjectScoreDetails_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubjectScoreDetails_Subjects_SubjectID",
                        column: x => x.SubjectID,
                        principalTable: "Subjects",
                        principalColumn: "SubjectID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Terms",
                columns: table => new
                {
                    TermID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectID = table.Column<int>(type: "int", nullable: false),
                    StudentID = table.Column<long>(type: "bigint", nullable: false),
                    NameStudent = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terms", x => x.TermID);
                    table.ForeignKey(
                        name: "FK_Terms_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Terms_Subjects_SubjectID",
                        column: x => x.SubjectID,
                        principalTable: "Subjects",
                        principalColumn: "SubjectID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Id", "Password", "RoleID", "Username" },
                values: new object[,]
                {
                    { 2, "123456", 1, "sinh123" },
                    { 3, "123456", 2, "sinhdeptrai" },
                    { 4, "123456", 1, "sinh1" }
                });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchID", "NameBranch" },
                values: new object[,]
                {
                    { 1L, "Công nghệ thông tin" },
                    { 2L, "Quản trị kinh doanh" },
                    { 3L, "Kế toán" },
                    { 4L, "Ngôn ngữ Anh" },
                    { 5L, "Quản trị nhân lực" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassID", "BranchID", "NameClass" },
                values: new object[,]
                {
                    { 1L, 1L, "21DHTT01" },
                    { 2L, 1L, "21DHTT02" },
                    { 3L, 2L, "21QTKD01" },
                    { 4L, 2L, "21QTKD02" },
                    { 5L, 3L, "21KT01" },
                    { 6L, 3L, "21KT01" },
                    { 7L, 4L, "21DHNA01" },
                    { 8L, 4L, "21DHNA02" },
                    { 9L, 5L, "21QTNL01" },
                    { 10L, 5L, "21QTNL02" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentID", "AddressStudent", "BirthDay", "BranchID", "ClassID", "Email", "NameStudent", "Phone", "SexStudent" },
                values: new object[,]
                {
                    { 7777777L, "Potural", new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "cristianoronaldo@vaa.edu.vn", "Cristiano Ronaldo", "7777777777", "Nam" },
                    { 21588477L, "Nghê An", new DateTime(2003, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, "2154810100@vaa.edu.vn", "Lê Công Phượng", "0933516029", "Nam" },
                    { 215888488L, "Cà Mau", new DateTime(2003, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "2154810083@vaa.edu.vn", "Trần Nguyễn Khánh TRang", "0933516029", "Nữ" },
                    { 2154810083L, "Bình Thuận", new DateTime(2003, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "2154810083@vaa.edu.vn", "Võ Hiếu Sinh", "0933516029", "Nam" },
                    { 21588812234L, "Argentina", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "lionelmessi@vaa.edu.vn", "Lionel Messi", "0382080567", "Nam" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "SubjectID", "SubjectCredit", "SubjectName" },
                values: new object[,]
                {
                    { 1, 3, "Lập trình Windows" },
                    { 2, 3, "Lập trình di động" },
                    { 3, 3, "Lập trình Web" },
                    { 4, 3, "Trí tuệ nhân tạo" },
                    { 5, 3, "Công nghệ phần mềm" },
                    { 6, 3, "Đồ án cơ sở ngành" },
                    { 7, 3, "Đồ án chuyên ngành" },
                    { 8, 3, "Lập trình python" },
                    { 9, 2, "Phân tích và thiết kế giải thuật" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BranchClass_ClassesClassID",
                table: "BranchClass",
                column: "ClassesClassID");

            migrationBuilder.CreateIndex(
                name: "IX_BranchStudent_StudentsStudentID",
                table: "BranchStudent",
                column: "StudentsStudentID");

            migrationBuilder.CreateIndex(
                name: "IX_ClassStudent_StudentsStudentID",
                table: "ClassStudent",
                column: "StudentsStudentID");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectScoreDetails_StudentID",
                table: "SubjectScoreDetails",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectScoreDetails_SubjectID",
                table: "SubjectScoreDetails",
                column: "SubjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Terms_StudentID",
                table: "Terms",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Terms_SubjectID",
                table: "Terms",
                column: "SubjectID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "BranchClass");

            migrationBuilder.DropTable(
                name: "BranchStudent");

            migrationBuilder.DropTable(
                name: "ClassStudent");

            migrationBuilder.DropTable(
                name: "SubjectScoreDetails");

            migrationBuilder.DropTable(
                name: "Terms");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Subjects");
        }
    }
}
