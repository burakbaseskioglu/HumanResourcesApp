using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HumanResources.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UserUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Certificates_UserDetails_UserDetailId",
                table: "Certificates");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_UserDetails_UserDetailId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Educations_UserDetails_UserDetailId",
                table: "Educations");

            migrationBuilder.DropForeignKey(
                name: "FK_Languages_UserDetails_UserDetailId",
                table: "Languages");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_UserDetails_UserDetailId",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_Works_UserDetails_UserDetailId",
                table: "Works");

            migrationBuilder.DropIndex(
                name: "IX_Works_UserDetailId",
                table: "Works");

            migrationBuilder.DropIndex(
                name: "IX_Skills_UserDetailId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Languages_UserDetailId",
                table: "Languages");

            migrationBuilder.DropIndex(
                name: "IX_Educations_UserDetailId",
                table: "Educations");

            migrationBuilder.DropIndex(
                name: "IX_Courses_UserDetailId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Certificates_UserDetailId",
                table: "Certificates");

            migrationBuilder.DropColumn(
                name: "UserDetailId",
                table: "Works");

            migrationBuilder.DropColumn(
                name: "UserDetailId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "UserDetailId",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "UserDetailId",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "UserDetailId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "UserDetailId",
                table: "Certificates");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserDetailId",
                table: "Works",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserDetailId",
                table: "Skills",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserDetailId",
                table: "Languages",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserDetailId",
                table: "Educations",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserDetailId",
                table: "Courses",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserDetailId",
                table: "Certificates",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Works_UserDetailId",
                table: "Works",
                column: "UserDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_UserDetailId",
                table: "Skills",
                column: "UserDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_UserDetailId",
                table: "Languages",
                column: "UserDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_UserDetailId",
                table: "Educations",
                column: "UserDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_UserDetailId",
                table: "Courses",
                column: "UserDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Certificates_UserDetailId",
                table: "Certificates",
                column: "UserDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_Certificates_UserDetails_UserDetailId",
                table: "Certificates",
                column: "UserDetailId",
                principalTable: "UserDetails",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_UserDetails_UserDetailId",
                table: "Courses",
                column: "UserDetailId",
                principalTable: "UserDetails",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_UserDetails_UserDetailId",
                table: "Educations",
                column: "UserDetailId",
                principalTable: "UserDetails",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Languages_UserDetails_UserDetailId",
                table: "Languages",
                column: "UserDetailId",
                principalTable: "UserDetails",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_UserDetails_UserDetailId",
                table: "Skills",
                column: "UserDetailId",
                principalTable: "UserDetails",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Works_UserDetails_UserDetailId",
                table: "Works",
                column: "UserDetailId",
                principalTable: "UserDetails",
                principalColumn: "Id");
        }
    }
}
