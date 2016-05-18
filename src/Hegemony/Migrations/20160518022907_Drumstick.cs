using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Hegemony.Migrations
{
    public partial class Drumstick : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Nation_Army_ArmyId", table: "Nations");
            migrationBuilder.DropForeignKey(name: "FK_Nation_Economy_EconomyId", table: "Nations");
            migrationBuilder.DropForeignKey(name: "FK_Nation_Geography_GeographyId", table: "Nations");
            migrationBuilder.DropForeignKey(name: "FK_Nation_Government_GovernmentId", table: "Nations");
            migrationBuilder.DropForeignKey(name: "FK_Nation_Technology_TechnologyId", table: "Nations");
            migrationBuilder.DropForeignKey(name: "FK_Outcome_Hazard_HazardId", table: "Outcomes");
            migrationBuilder.DropForeignKey(name: "FK_IdentityRoleClaim<string>_IdentityRole_RoleId", table: "AspNetRoleClaims");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserClaim<string>_ApplicationUser_UserId", table: "AspNetUserClaims");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserLogin<string>_ApplicationUser_UserId", table: "AspNetUserLogins");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserRole<string>_IdentityRole_RoleId", table: "AspNetUserRoles");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserRole<string>_ApplicationUser_UserId", table: "AspNetUserRoles");
            migrationBuilder.AddForeignKey(
                name: "FK_Nation_Army_ArmyId",
                table: "Nations",
                column: "ArmyId",
                principalTable: "Armies",
                principalColumn: "ArmyId",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_Nation_Economy_EconomyId",
                table: "Nations",
                column: "EconomyId",
                principalTable: "Economies",
                principalColumn: "EconomyId",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_Nation_Geography_GeographyId",
                table: "Nations",
                column: "GeographyId",
                principalTable: "Geographies",
                principalColumn: "GeographyId",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_Nation_Government_GovernmentId",
                table: "Nations",
                column: "GovernmentId",
                principalTable: "Governments",
                principalColumn: "GovernmentId",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_Nation_Technology_TechnologyId",
                table: "Nations",
                column: "TechnologyId",
                principalTable: "Technologies",
                principalColumn: "TechnologyId",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_Outcome_Hazard_HazardId",
                table: "Outcomes",
                column: "HazardId",
                principalTable: "Hazards",
                principalColumn: "HazardId",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityRoleClaim<string>_IdentityRole_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserClaim<string>_ApplicationUser_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserLogin<string>_ApplicationUser_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserRole<string>_IdentityRole_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserRole<string>_ApplicationUser_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Nation_Army_ArmyId", table: "Nations");
            migrationBuilder.DropForeignKey(name: "FK_Nation_Economy_EconomyId", table: "Nations");
            migrationBuilder.DropForeignKey(name: "FK_Nation_Geography_GeographyId", table: "Nations");
            migrationBuilder.DropForeignKey(name: "FK_Nation_Government_GovernmentId", table: "Nations");
            migrationBuilder.DropForeignKey(name: "FK_Nation_Technology_TechnologyId", table: "Nations");
            migrationBuilder.DropForeignKey(name: "FK_Outcome_Hazard_HazardId", table: "Outcomes");
            migrationBuilder.DropForeignKey(name: "FK_IdentityRoleClaim<string>_IdentityRole_RoleId", table: "AspNetRoleClaims");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserClaim<string>_ApplicationUser_UserId", table: "AspNetUserClaims");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserLogin<string>_ApplicationUser_UserId", table: "AspNetUserLogins");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserRole<string>_IdentityRole_RoleId", table: "AspNetUserRoles");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserRole<string>_ApplicationUser_UserId", table: "AspNetUserRoles");
            migrationBuilder.AddForeignKey(
                name: "FK_Nation_Army_ArmyId",
                table: "Nations",
                column: "ArmyId",
                principalTable: "Armies",
                principalColumn: "ArmyId",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Nation_Economy_EconomyId",
                table: "Nations",
                column: "EconomyId",
                principalTable: "Economies",
                principalColumn: "EconomyId",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Nation_Geography_GeographyId",
                table: "Nations",
                column: "GeographyId",
                principalTable: "Geographies",
                principalColumn: "GeographyId",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Nation_Government_GovernmentId",
                table: "Nations",
                column: "GovernmentId",
                principalTable: "Governments",
                principalColumn: "GovernmentId",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Nation_Technology_TechnologyId",
                table: "Nations",
                column: "TechnologyId",
                principalTable: "Technologies",
                principalColumn: "TechnologyId",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Outcome_Hazard_HazardId",
                table: "Outcomes",
                column: "HazardId",
                principalTable: "Hazards",
                principalColumn: "HazardId",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityRoleClaim<string>_IdentityRole_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserClaim<string>_ApplicationUser_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserLogin<string>_ApplicationUser_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserRole<string>_IdentityRole_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserRole<string>_ApplicationUser_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
