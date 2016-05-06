using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using Hegemony.Models;

namespace Hegemony.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20160506171129_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Hegemony.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasAnnotation("Relational:Name", "EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .HasAnnotation("Relational:Name", "UserNameIndex");

                    b.HasAnnotation("Relational:TableName", "AspNetUsers");
                });

            modelBuilder.Entity("Hegemony.Models.Army", b =>
                {
                    b.Property<int>("ArmyId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<decimal>("NegativeModifier");

                    b.Property<decimal>("PositiveModifier");

                    b.HasKey("ArmyId");

                    b.HasAnnotation("Relational:TableName", "Armies");
                });

            modelBuilder.Entity("Hegemony.Models.Economy", b =>
                {
                    b.Property<int>("EconomyId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<decimal>("NegativeModifier");

                    b.Property<decimal>("PositiveModifier");

                    b.HasKey("EconomyId");

                    b.HasAnnotation("Relational:TableName", "Economies");
                });

            modelBuilder.Entity("Hegemony.Models.Geography", b =>
                {
                    b.Property<int>("GeographyId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<decimal>("NegativeModifier");

                    b.Property<decimal>("PositiveModifier");

                    b.HasKey("GeographyId");

                    b.HasAnnotation("Relational:TableName", "Geographies");
                });

            modelBuilder.Entity("Hegemony.Models.Government", b =>
                {
                    b.Property<int>("GovernmentId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<decimal>("NegativeModifier");

                    b.Property<decimal>("PositiveModifier");

                    b.HasKey("GovernmentId");

                    b.HasAnnotation("Relational:TableName", "Governments");
                });

            modelBuilder.Entity("Hegemony.Models.Hazard", b =>
                {
                    b.Property<int>("HazardId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int>("OutcomeId");

                    b.HasKey("HazardId");

                    b.HasAnnotation("Relational:TableName", "Hazards");
                });

            modelBuilder.Entity("Hegemony.Models.Nation", b =>
                {
                    b.Property<int>("NationId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ArmyId");

                    b.Property<int>("ArmyValue");

                    b.Property<int>("EconomyId");

                    b.Property<int>("EconomyValue");

                    b.Property<int>("GeographyId");

                    b.Property<int>("GeographyValue");

                    b.Property<int>("GovernmentId");

                    b.Property<int>("GovernmentValue");

                    b.Property<string>("Name");

                    b.Property<int>("TechnologyId");

                    b.Property<int>("TechnologyValue");

                    b.Property<string>("UserId");

                    b.HasKey("NationId");

                    b.HasAnnotation("Relational:TableName", "Nations");
                });

            modelBuilder.Entity("Hegemony.Models.Outcome", b =>
                {
                    b.Property<int>("OutcomeId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AVModifer");

                    b.Property<int>("CVModifier");

                    b.Property<int>("Description");

                    b.Property<int>("HVModifier");

                    b.Property<int>("HazardId");

                    b.Property<string>("Name");

                    b.Property<int>("PVModifier");

                    b.Property<int>("RVModifier");

                    b.HasKey("OutcomeId");

                    b.HasAnnotation("Relational:TableName", "Outcomes");
                });

            modelBuilder.Entity("Hegemony.Models.Technology", b =>
                {
                    b.Property<int>("TechnologyId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<decimal>("NegativeModifier");

                    b.Property<decimal>("PositiveModifier");

                    b.HasKey("TechnologyId");

                    b.HasAnnotation("Relational:TableName", "Technologies");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasAnnotation("Relational:Name", "RoleNameIndex");

                    b.HasAnnotation("Relational:TableName", "AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasAnnotation("Relational:TableName", "AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasAnnotation("Relational:TableName", "AspNetUserRoles");
                });

            modelBuilder.Entity("Hegemony.Models.Nation", b =>
                {
                    b.HasOne("Hegemony.Models.Army")
                        .WithMany()
                        .HasForeignKey("ArmyId");

                    b.HasOne("Hegemony.Models.Economy")
                        .WithMany()
                        .HasForeignKey("EconomyId");

                    b.HasOne("Hegemony.Models.Geography")
                        .WithMany()
                        .HasForeignKey("GeographyId");

                    b.HasOne("Hegemony.Models.Government")
                        .WithMany()
                        .HasForeignKey("GovernmentId");

                    b.HasOne("Hegemony.Models.Technology")
                        .WithMany()
                        .HasForeignKey("TechnologyId");

                    b.HasOne("Hegemony.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Hegemony.Models.Outcome", b =>
                {
                    b.HasOne("Hegemony.Models.Hazard")
                        .WithMany()
                        .HasForeignKey("HazardId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Hegemony.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Hegemony.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.HasOne("Hegemony.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
        }
    }
}
