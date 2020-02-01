using System;
using Microsoft.EntityFrameworkCore.Migrations;
#pragma warning disable 1591
#pragma warning disable SA1600
#pragma warning disable SA1601

namespace Vacandum.EF.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<byte[]>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ExternalId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Salary",
                columns: table => new
                {
                    Id = table.Column<byte[]>(nullable: false),
                    From = table.Column<float>(nullable: true),
                    To = table.Column<float>(nullable: true),
                    Currency = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salary", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vacancies",
                columns: table => new
                {
                    Id = table.Column<byte[]>(nullable: false),
                    ExternalId = table.Column<string>(nullable: true),
                    SavingDate = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    SalaryId = table.Column<byte[]>(nullable: true),
                    Experience = table.Column<int>(nullable: false),
                    PublicationDate = table.Column<DateTime>(nullable: false),
                    CompanyId = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacancies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vacancies_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vacancies_Salary_SalaryId",
                        column: x => x.SalaryId,
                        principalTable: "Salary",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vacancies_CompanyId",
                table: "Vacancies",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Vacancies_SalaryId",
                table: "Vacancies",
                column: "SalaryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vacancies");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Salary");
        }
    }
}
