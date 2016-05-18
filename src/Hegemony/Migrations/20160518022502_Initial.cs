using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace Hegemony.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    SecurityStamp = table.Column<string>(nullable: true),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUser", x => x.Id);
                });
            migrationBuilder.CreateTable(
                name: "Armies",
                columns: table => new
                {
                    ArmyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NegativeModifier = table.Column<decimal>(nullable: false),
                    PositiveModifier = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Army", x => x.ArmyId);
                });
            migrationBuilder.CreateTable(
                name: "Economies",
                columns: table => new
                {
                    EconomyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NegativeModifier = table.Column<decimal>(nullable: false),
                    PositiveModifier = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Economy", x => x.EconomyId);
                });
            migrationBuilder.CreateTable(
                name: "Geographies",
                columns: table => new
                {
                    GeographyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NegativeModifier = table.Column<decimal>(nullable: false),
                    PositiveModifier = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Geography", x => x.GeographyId);
                });
            migrationBuilder.CreateTable(
                name: "Governments",
                columns: table => new
                {
                    GovernmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NegativeModifier = table.Column<decimal>(nullable: false),
                    PositiveModifier = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Government", x => x.GovernmentId);
                });
            migrationBuilder.CreateTable(
                name: "Hazards",
                columns: table => new
                {
                    HazardId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    OutcomeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hazard", x => x.HazardId);
                });
            migrationBuilder.CreateTable(
                name: "Technologies",
                columns: table => new
                {
                    TechnologyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NegativeModifier = table.Column<decimal>(nullable: false),
                    PositiveModifier = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technology", x => x.TechnologyId);
                });
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NormalizedName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRole", x => x.Id);
                });
            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserClaim<string>", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IdentityUserClaim<string>_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserLogin<string>", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_IdentityUserLogin<string>_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
            migrationBuilder.CreateTable(
                name: "Outcomes",
                columns: table => new
                {
                    OutcomeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AVModifer = table.Column<int>(nullable: false),
                    CVModifier = table.Column<int>(nullable: false),
                    Description = table.Column<int>(nullable: false),
                    HVModifier = table.Column<int>(nullable: false),
                    HazardId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PVModifier = table.Column<int>(nullable: false),
                    RVModifier = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Outcome", x => x.OutcomeId);
                    table.ForeignKey(
                        name: "FK_Outcome_Hazard_HazardId",
                        column: x => x.HazardId,
                        principalTable: "Hazards",
                        principalColumn: "HazardId",
                        onDelete: ReferentialAction.Cascade);
                });
            migrationBuilder.CreateTable(
                name: "Nations",
                columns: table => new
                {
                    NationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ArmyId = table.Column<int>(nullable: false),
                    ArmyValue = table.Column<int>(nullable: false),
                    CapitalValue = table.Column<int>(nullable: false),
                    EconomyId = table.Column<int>(nullable: false),
                    GeographyId = table.Column<int>(nullable: false),
                    GovernmentId = table.Column<int>(nullable: false),
                    HappinessValue = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PopulationValue = table.Column<int>(nullable: false),
                    ResourceValue = table.Column<int>(nullable: false),
                    TechnologyId = table.Column<int>(nullable: false),
                    TechnologyValue = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nation", x => x.NationId);
                    table.ForeignKey(
                        name: "FK_Nation_Army_ArmyId",
                        column: x => x.ArmyId,
                        principalTable: "Armies",
                        principalColumn: "ArmyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Nation_Economy_EconomyId",
                        column: x => x.EconomyId,
                        principalTable: "Economies",
                        principalColumn: "EconomyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Nation_Geography_GeographyId",
                        column: x => x.GeographyId,
                        principalTable: "Geographies",
                        principalColumn: "GeographyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Nation_Government_GovernmentId",
                        column: x => x.GovernmentId,
                        principalTable: "Governments",
                        principalColumn: "GovernmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Nation_Technology_TechnologyId",
                        column: x => x.TechnologyId,
                        principalTable: "Technologies",
                        principalColumn: "TechnologyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Nation_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });
            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRoleClaim<string>", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IdentityRoleClaim<string>_IdentityRole_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserRole<string>", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_IdentityUserRole<string>_IdentityRole_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IdentityUserRole<string>_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");
            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName");
            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Nations");
            migrationBuilder.DropTable("Outcomes");
            migrationBuilder.DropTable("AspNetRoleClaims");
            migrationBuilder.DropTable("AspNetUserClaims");
            migrationBuilder.DropTable("AspNetUserLogins");
            migrationBuilder.DropTable("AspNetUserRoles");
            migrationBuilder.DropTable("Armies");
            migrationBuilder.DropTable("Economies");
            migrationBuilder.DropTable("Geographies");
            migrationBuilder.DropTable("Governments");
            migrationBuilder.DropTable("Technologies");
            migrationBuilder.DropTable("Hazards");
            migrationBuilder.DropTable("AspNetRoles");
            migrationBuilder.DropTable("AspNetUsers");
        }
    }
}
