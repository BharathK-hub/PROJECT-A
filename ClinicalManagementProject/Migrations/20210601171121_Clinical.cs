using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicalManagementProject.Migrations
{
    public partial class Clinical : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.CreateTable(
                name: "DoctorsTable",
                columns: table => new
                {
                    DoctorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoctorLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specialization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorsTable", x => x.DoctorId);
                });

            migrationBuilder.CreateTable(
                name: "LoginTable",
                columns: table => new
                {
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginTable", x => x.UserName);
                });

            migrationBuilder.CreateTable(
                name: "PatientsTable",
                columns: table => new
                {
                    PatientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientsTable", x => x.PatientId);
                });

            migrationBuilder.CreateTable(
               name: "AppointmentsTable",
               columns: table => new
               {
                   AppointmentId = table.Column<int>(type: "int", nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                   PatientId = table.Column<int>(type: "int", nullable: false),
                   Specialization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   VisitDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                   StartTime = table.Column<DateTime>(type: "datetime2", nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_AppointmentsTable", x => x.AppointmentId);
                   table.ForeignKey(
                      name: "FK_AppointmentsTable_PatientsTable_PatientId",
                      column: x => x.PatientId,
                      principalTable: "PatientsTable",
                      principalColumn: "PatientId",
                      onDelete: ReferentialAction.Restrict);
               });

            migrationBuilder.CreateTable(
                name: "StaffsTable",
                columns: table => new
                {
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StaffFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffsTable", x => x.UserName);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppointmentsTable");

            migrationBuilder.DropTable(
                name: "DoctorsTable");

            migrationBuilder.DropTable(
                name: "LoginTable");

            migrationBuilder.DropTable(
                name: "PatientsTable");

            migrationBuilder.DropTable(
                name: "StaffsTable");
        }
    }
}
