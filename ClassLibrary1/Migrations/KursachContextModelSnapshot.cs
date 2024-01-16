﻿// <auto-generated />
using System;
using ClassLibrary1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ClassLibrary1.Migrations
{
    [DbContext(typeof(KursachContext))]
    partial class KursachContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ClassLibrary1.Entity.Allergy", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AgeOfOnset")
                        .HasColumnType("integer");

                    b.Property<Guid?>("AllergyesId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uuid");

                    b.Property<string>("TypeReaction")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AllergyesId");

                    b.HasIndex("StudentId");

                    b.ToTable("Allergyes");
                });

            modelBuilder.Entity("ClassLibrary1.Entity.ClassVaccination", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("NameClassVaccination")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ClassVaccinations");
                });

            modelBuilder.Entity("ClassLibrary1.Entity.DirectoryOfAllergy", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("NameAllergen")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("DirectoryOfAllergys");
                });

            modelBuilder.Entity("ClassLibrary1.Entity.DirectoryOfDiagnoses", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("NameDiagnoses")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("DirectoryOfDiagnoseses");
                });

            modelBuilder.Entity("ClassLibrary1.Entity.DirectoryOfMedicalInstitution", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("AddressMedInst")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameMedInst")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("DirectoryOfMedicalInstitutions");
                });

            modelBuilder.Entity("ClassLibrary1.Entity.DirectoryOfRepresentation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("NameRepresentation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("DirectoryOfRepresentations");
                });

            modelBuilder.Entity("ClassLibrary1.Entity.InformationOfHospitalization", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateOnly>("DateHospitalization")
                        .HasColumnType("date");

                    b.Property<DateOnly?>("DateReturn")
                        .HasColumnType("date");

                    b.Property<Guid?>("DirectoryOfDiagnosessId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("DirectoryOfMedicalInstitutionsId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("StudentsId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("DirectoryOfDiagnosessId");

                    b.HasIndex("DirectoryOfMedicalInstitutionsId");

                    b.HasIndex("StudentsId");

                    b.ToTable("InformationOfHospitalizations");
                });

            modelBuilder.Entity("ClassLibrary1.Entity.Nurse", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateOnly>("Birthday")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<char>("Gender")
                        .HasColumnType("character(1)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Patronymic")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("PostesId")
                        .HasColumnType("uuid");

                    b.Property<string>("Privilege")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("PostesId");

                    b.ToTable("Nurses");
                });

            modelBuilder.Entity("ClassLibrary1.Entity.Parent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateOnly>("Birthday")
                        .HasColumnType("date");

                    b.Property<char>("Gender")
                        .HasColumnType("character(1)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Patronymic")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Parents");
                });

            modelBuilder.Entity("ClassLibrary1.Entity.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("NamePost")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Powers")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Salary")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("Postes");
                });

            modelBuilder.Entity("ClassLibrary1.Entity.PreviousIllness", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateOnly>("DateBegin")
                        .HasColumnType("date");

                    b.Property<DateOnly?>("DateEnd")
                        .HasColumnType("date");

                    b.Property<Guid>("DirectoryOfDiagnosesId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("DirectoryOfDiagnosesId");

                    b.HasIndex("StudentId");

                    b.ToTable("PreviousIllnesses");
                });

            modelBuilder.Entity("ClassLibrary1.Entity.SchoolClass", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("NameClass")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Quantity_Students")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("SchoolClasses");
                });

            modelBuilder.Entity("ClassLibrary1.Entity.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateOnly>("Birthday")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<char>("Gender")
                        .HasColumnType("character(1)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Patronymic")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Privilege")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("SchoolClassId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("SchoolClassId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("ClassLibrary1.Entity.StudentAndParent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("ParentId")
                        .HasColumnType("uuid");

                    b.Property<string>("Representation")
                        .HasColumnType("text");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.HasIndex("StudentId");

                    b.ToTable("Students_Parents");
                });

            modelBuilder.Entity("ClassLibrary1.Entity.Vaccination", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ClassVaccinationId")
                        .HasColumnType("uuid");

                    b.Property<TimeSpan?>("IntervalVaccination")
                        .HasColumnType("interval");

                    b.Property<string>("NameVaccination")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ClassVaccinationId");

                    b.ToTable("Vaccinations");
                });

            modelBuilder.Entity("ClassLibrary1.Entity.VaccinationAndCertificate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateOnly>("DateVaccine")
                        .HasColumnType("date");

                    b.Property<string>("ReactionOfVaccine")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("VaccinationCertificateId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("VaccinationId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("VaccinationCertificateId");

                    b.HasIndex("VaccinationId");

                    b.ToTable("VaccinationsAndCertificates");
                });

            modelBuilder.Entity("ClassLibrary1.Entity.VaccinationCertificate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateOnly>("DateOfIssue")
                        .HasColumnType("date");

                    b.Property<Guid?>("DirectoryOfMedicalInstitutionId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ID_Student")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("DirectoryOfMedicalInstitutionId");

                    b.HasIndex("ID_Student")
                        .IsUnique();

                    b.ToTable("VaccinationCertificates");
                });

            modelBuilder.Entity("ParentStudent", b =>
                {
                    b.Property<Guid>("ParentsId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("StudentsId")
                        .HasColumnType("uuid");

                    b.HasKey("ParentsId", "StudentsId");

                    b.HasIndex("StudentsId");

                    b.ToTable("ParentStudent");
                });

            modelBuilder.Entity("ClassLibrary1.Entity.Allergy", b =>
                {
                    b.HasOne("ClassLibrary1.Entity.DirectoryOfAllergy", "Allergyes")
                        .WithMany("Allergies")
                        .HasForeignKey("AllergyesId");

                    b.HasOne("ClassLibrary1.Entity.Student", "Student")
                        .WithMany("Allergies")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Allergyes");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ClassLibrary1.Entity.InformationOfHospitalization", b =>
                {
                    b.HasOne("ClassLibrary1.Entity.DirectoryOfDiagnoses", "DirectoryOfDiagnosess")
                        .WithMany("InformationOfHospitalizations")
                        .HasForeignKey("DirectoryOfDiagnosessId");

                    b.HasOne("ClassLibrary1.Entity.DirectoryOfMedicalInstitution", "DirectoryOfMedicalInstitutions")
                        .WithMany("InformationOfHospitalizations")
                        .HasForeignKey("DirectoryOfMedicalInstitutionsId");

                    b.HasOne("ClassLibrary1.Entity.Student", "Students")
                        .WithMany("Hospitalizations")
                        .HasForeignKey("StudentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DirectoryOfDiagnosess");

                    b.Navigation("DirectoryOfMedicalInstitutions");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("ClassLibrary1.Entity.Nurse", b =>
                {
                    b.HasOne("ClassLibrary1.Entity.Post", "Postes")
                        .WithMany("Nurses")
                        .HasForeignKey("PostesId");

                    b.Navigation("Postes");
                });

            modelBuilder.Entity("ClassLibrary1.Entity.PreviousIllness", b =>
                {
                    b.HasOne("ClassLibrary1.Entity.DirectoryOfDiagnoses", "DirectoryOfDiagnoses")
                        .WithMany("PreviousIllnesses")
                        .HasForeignKey("DirectoryOfDiagnosesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassLibrary1.Entity.Student", "Student")
                        .WithMany("PreviousIllnesses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DirectoryOfDiagnoses");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ClassLibrary1.Entity.Student", b =>
                {
                    b.HasOne("ClassLibrary1.Entity.SchoolClass", "SchoolClass")
                        .WithMany("Students")
                        .HasForeignKey("SchoolClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SchoolClass");
                });

            modelBuilder.Entity("ClassLibrary1.Entity.StudentAndParent", b =>
                {
                    b.HasOne("ClassLibrary1.Entity.Parent", "Parent")
                        .WithMany("Students_Parents")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassLibrary1.Entity.Student", "Student")
                        .WithMany("Students_Parents")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Parent");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ClassLibrary1.Entity.Vaccination", b =>
                {
                    b.HasOne("ClassLibrary1.Entity.ClassVaccination", "ClassVaccination")
                        .WithMany("Vaccination")
                        .HasForeignKey("ClassVaccinationId");

                    b.Navigation("ClassVaccination");
                });

            modelBuilder.Entity("ClassLibrary1.Entity.VaccinationAndCertificate", b =>
                {
                    b.HasOne("ClassLibrary1.Entity.VaccinationCertificate", "VaccinationCertificate")
                        .WithMany("VaccinationAndCertificates")
                        .HasForeignKey("VaccinationCertificateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassLibrary1.Entity.Vaccination", "Vaccination")
                        .WithMany("VaccinationAndCertificates")
                        .HasForeignKey("VaccinationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vaccination");

                    b.Navigation("VaccinationCertificate");
                });

            modelBuilder.Entity("ClassLibrary1.Entity.VaccinationCertificate", b =>
                {
                    b.HasOne("ClassLibrary1.Entity.DirectoryOfMedicalInstitution", "DirectoryOfMedicalInstitution")
                        .WithMany("VaccinationCertificates")
                        .HasForeignKey("DirectoryOfMedicalInstitutionId");

                    b.HasOne("ClassLibrary1.Entity.Student", "student")
                        .WithOne("vaccinationCertificate")
                        .HasForeignKey("ClassLibrary1.Entity.VaccinationCertificate", "ID_Student")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DirectoryOfMedicalInstitution");

                    b.Navigation("student");
                });

            modelBuilder.Entity("ParentStudent", b =>
                {
                    b.HasOne("ClassLibrary1.Entity.Parent", null)
                        .WithMany()
                        .HasForeignKey("ParentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassLibrary1.Entity.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClassLibrary1.Entity.ClassVaccination", b =>
                {
                    b.Navigation("Vaccination");
                });

            modelBuilder.Entity("ClassLibrary1.Entity.DirectoryOfAllergy", b =>
                {
                    b.Navigation("Allergies");
                });

            modelBuilder.Entity("ClassLibrary1.Entity.DirectoryOfDiagnoses", b =>
                {
                    b.Navigation("InformationOfHospitalizations");

                    b.Navigation("PreviousIllnesses");
                });

            modelBuilder.Entity("ClassLibrary1.Entity.DirectoryOfMedicalInstitution", b =>
                {
                    b.Navigation("InformationOfHospitalizations");

                    b.Navigation("VaccinationCertificates");
                });

            modelBuilder.Entity("ClassLibrary1.Entity.Parent", b =>
                {
                    b.Navigation("Students_Parents");
                });

            modelBuilder.Entity("ClassLibrary1.Entity.Post", b =>
                {
                    b.Navigation("Nurses");
                });

            modelBuilder.Entity("ClassLibrary1.Entity.SchoolClass", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("ClassLibrary1.Entity.Student", b =>
                {
                    b.Navigation("Allergies");

                    b.Navigation("Hospitalizations");

                    b.Navigation("PreviousIllnesses");

                    b.Navigation("Students_Parents");

                    b.Navigation("vaccinationCertificate");
                });

            modelBuilder.Entity("ClassLibrary1.Entity.Vaccination", b =>
                {
                    b.Navigation("VaccinationAndCertificates");
                });

            modelBuilder.Entity("ClassLibrary1.Entity.VaccinationCertificate", b =>
                {
                    b.Navigation("VaccinationAndCertificates");
                });
#pragma warning restore 612, 618
        }
    }
}