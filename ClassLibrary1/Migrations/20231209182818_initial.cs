using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassLibrary1.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClassVaccinations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NameClassVaccination = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassVaccinations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DirectoryOfAllergys",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NameAllergen = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectoryOfAllergys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DirectoryOfDiagnoseses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NameDiagnoses = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectoryOfDiagnoseses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DirectoryOfMedicalInstitutions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NameMedInst = table.Column<string>(type: "text", nullable: false),
                    AddressMedInst = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectoryOfMedicalInstitutions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DirectoryOfRepresentations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NameRepresentation = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectoryOfRepresentations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Lastname = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Patronymic = table.Column<string>(type: "text", nullable: true),
                    Gender = table.Column<char>(type: "character(1)", nullable: false),
                    Birthday = table.Column<DateOnly>(type: "date", nullable: false),
                    Phone = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Postes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NamePost = table.Column<string>(type: "text", nullable: false),
                    Salary = table.Column<double>(type: "double precision", nullable: false),
                    Powers = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Postes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SchoolClasses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NameClass = table.Column<string>(type: "text", nullable: false),
                    Quantity_Students = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolClasses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vaccinations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NameVaccination = table.Column<string>(type: "text", nullable: false),
                    IntervalVaccination = table.Column<TimeSpan>(type: "interval", nullable: true),
                    ClassVaccinationId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaccinations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vaccinations_ClassVaccinations_ClassVaccinationId",
                        column: x => x.ClassVaccinationId,
                        principalTable: "ClassVaccinations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Nurses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PostesId = table.Column<Guid>(type: "uuid", nullable: true),
                    Lastname = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Patronymic = table.Column<string>(type: "text", nullable: true),
                    Gender = table.Column<char>(type: "character(1)", nullable: false),
                    Birthday = table.Column<DateOnly>(type: "date", nullable: false),
                    Phone = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Privilege = table.Column<string>(type: "text", nullable: false),
                    Login = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nurses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nurses_Postes_PostesId",
                        column: x => x.PostesId,
                        principalTable: "Postes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SchoolClassId = table.Column<Guid>(type: "uuid", nullable: false),
                    Lastname = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Patronymic = table.Column<string>(type: "text", nullable: true),
                    Gender = table.Column<char>(type: "character(1)", nullable: false),
                    Birthday = table.Column<DateOnly>(type: "date", nullable: false),
                    Phone = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Privilege = table.Column<string>(type: "text", nullable: false),
                    Login = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_SchoolClasses_SchoolClassId",
                        column: x => x.SchoolClassId,
                        principalTable: "SchoolClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Allergyes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    AgeOfOnset = table.Column<int>(type: "integer", nullable: false),
                    TypeReaction = table.Column<string>(type: "text", nullable: false),
                    AllergyesId = table.Column<Guid>(type: "uuid", nullable: true),
                    StudentId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allergyes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Allergyes_DirectoryOfAllergys_AllergyesId",
                        column: x => x.AllergyesId,
                        principalTable: "DirectoryOfAllergys",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Allergyes_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InformationOfHospitalizations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DateHospitalization = table.Column<DateOnly>(type: "date", nullable: false),
                    DateReturn = table.Column<DateOnly>(type: "date", nullable: true),
                    DirectoryOfDiagnosessId = table.Column<Guid>(type: "uuid", nullable: true),
                    DirectoryOfMedicalInstitutionsId = table.Column<Guid>(type: "uuid", nullable: true),
                    StudentsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformationOfHospitalizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InformationOfHospitalizations_DirectoryOfDiagnoseses_Direct~",
                        column: x => x.DirectoryOfDiagnosessId,
                        principalTable: "DirectoryOfDiagnoseses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InformationOfHospitalizations_DirectoryOfMedicalInstitution~",
                        column: x => x.DirectoryOfMedicalInstitutionsId,
                        principalTable: "DirectoryOfMedicalInstitutions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InformationOfHospitalizations_Students_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParentStudent",
                columns: table => new
                {
                    ParentsId = table.Column<Guid>(type: "uuid", nullable: false),
                    StudentsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParentStudent", x => new { x.ParentsId, x.StudentsId });
                    table.ForeignKey(
                        name: "FK_ParentStudent_Parents_ParentsId",
                        column: x => x.ParentsId,
                        principalTable: "Parents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParentStudent_Students_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PreviousIllnesses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DateBegin = table.Column<DateOnly>(type: "date", nullable: false),
                    DateEnd = table.Column<DateOnly>(type: "date", nullable: true),
                    StudentId = table.Column<Guid>(type: "uuid", nullable: false),
                    DirectoryOfDiagnosesId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreviousIllnesses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PreviousIllnesses_DirectoryOfDiagnoseses_DirectoryOfDiagnos~",
                        column: x => x.DirectoryOfDiagnosesId,
                        principalTable: "DirectoryOfDiagnoseses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PreviousIllnesses_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students_Parents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    StudentId = table.Column<Guid>(type: "uuid", nullable: false),
                    ParentId = table.Column<Guid>(type: "uuid", nullable: false),
                    Representation = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students_Parents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Parents_Parents_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Parents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_Parents_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VaccinationCertificates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ID_Student = table.Column<Guid>(type: "uuid", nullable: false),
                    DateOfIssue = table.Column<DateOnly>(type: "date", nullable: false),
                    DirectoryOfMedicalInstitutionId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaccinationCertificates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VaccinationCertificates_DirectoryOfMedicalInstitutions_Dire~",
                        column: x => x.DirectoryOfMedicalInstitutionId,
                        principalTable: "DirectoryOfMedicalInstitutions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VaccinationCertificates_Students_ID_Student",
                        column: x => x.ID_Student,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VaccinationsAndCertificates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    VaccinationId = table.Column<Guid>(type: "uuid", nullable: false),
                    VaccinationCertificateId = table.Column<Guid>(type: "uuid", nullable: false),
                    DateVaccine = table.Column<DateOnly>(type: "date", nullable: false),
                    ReactionOfVaccine = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaccinationsAndCertificates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VaccinationsAndCertificates_VaccinationCertificates_Vaccina~",
                        column: x => x.VaccinationCertificateId,
                        principalTable: "VaccinationCertificates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VaccinationsAndCertificates_Vaccinations_VaccinationId",
                        column: x => x.VaccinationId,
                        principalTable: "Vaccinations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Allergyes_AllergyesId",
                table: "Allergyes",
                column: "AllergyesId");

            migrationBuilder.CreateIndex(
                name: "IX_Allergyes_StudentId",
                table: "Allergyes",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_InformationOfHospitalizations_DirectoryOfDiagnosessId",
                table: "InformationOfHospitalizations",
                column: "DirectoryOfDiagnosessId");

            migrationBuilder.CreateIndex(
                name: "IX_InformationOfHospitalizations_DirectoryOfMedicalInstitution~",
                table: "InformationOfHospitalizations",
                column: "DirectoryOfMedicalInstitutionsId");

            migrationBuilder.CreateIndex(
                name: "IX_InformationOfHospitalizations_StudentsId",
                table: "InformationOfHospitalizations",
                column: "StudentsId");

            migrationBuilder.CreateIndex(
                name: "IX_Nurses_PostesId",
                table: "Nurses",
                column: "PostesId");

            migrationBuilder.CreateIndex(
                name: "IX_ParentStudent_StudentsId",
                table: "ParentStudent",
                column: "StudentsId");

            migrationBuilder.CreateIndex(
                name: "IX_PreviousIllnesses_DirectoryOfDiagnosesId",
                table: "PreviousIllnesses",
                column: "DirectoryOfDiagnosesId");

            migrationBuilder.CreateIndex(
                name: "IX_PreviousIllnesses_StudentId",
                table: "PreviousIllnesses",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_SchoolClassId",
                table: "Students",
                column: "SchoolClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Parents_ParentId",
                table: "Students_Parents",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Parents_StudentId",
                table: "Students_Parents",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_VaccinationCertificates_DirectoryOfMedicalInstitutionId",
                table: "VaccinationCertificates",
                column: "DirectoryOfMedicalInstitutionId");

            migrationBuilder.CreateIndex(
                name: "IX_VaccinationCertificates_ID_Student",
                table: "VaccinationCertificates",
                column: "ID_Student",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vaccinations_ClassVaccinationId",
                table: "Vaccinations",
                column: "ClassVaccinationId");

            migrationBuilder.CreateIndex(
                name: "IX_VaccinationsAndCertificates_VaccinationCertificateId",
                table: "VaccinationsAndCertificates",
                column: "VaccinationCertificateId");

            migrationBuilder.CreateIndex(
                name: "IX_VaccinationsAndCertificates_VaccinationId",
                table: "VaccinationsAndCertificates",
                column: "VaccinationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Allergyes");

            migrationBuilder.DropTable(
                name: "DirectoryOfRepresentations");

            migrationBuilder.DropTable(
                name: "InformationOfHospitalizations");

            migrationBuilder.DropTable(
                name: "Nurses");

            migrationBuilder.DropTable(
                name: "ParentStudent");

            migrationBuilder.DropTable(
                name: "PreviousIllnesses");

            migrationBuilder.DropTable(
                name: "Students_Parents");

            migrationBuilder.DropTable(
                name: "VaccinationsAndCertificates");

            migrationBuilder.DropTable(
                name: "DirectoryOfAllergys");

            migrationBuilder.DropTable(
                name: "Postes");

            migrationBuilder.DropTable(
                name: "DirectoryOfDiagnoseses");

            migrationBuilder.DropTable(
                name: "Parents");

            migrationBuilder.DropTable(
                name: "VaccinationCertificates");

            migrationBuilder.DropTable(
                name: "Vaccinations");

            migrationBuilder.DropTable(
                name: "DirectoryOfMedicalInstitutions");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "ClassVaccinations");

            migrationBuilder.DropTable(
                name: "SchoolClasses");
        }
    }
}
