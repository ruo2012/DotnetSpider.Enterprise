﻿// <auto-generated />
using DotnetSpider.Enterprise.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;

namespace DotnetSpider.Enterprise.EntityFrameworkCore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DotnetSpider.Enterprise.Domain.Entities.ApplicationRole", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("DotnetSpider.Enterprise.Domain.Entities.ApplicationUser", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<long?>("ApplicationRoleId");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("IsActive");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("ApplicationRoleId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("DotnetSpider.Enterprise.Domain.Entities.Logs.Exception", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<string>("Message");

                    b.Property<string>("Path");

                    b.Property<string>("QueryString");

                    b.Property<string>("SessionId");

                    b.Property<long?>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Exceptions");
                });

            modelBuilder.Entity("DotnetSpider.Enterprise.Domain.Entities.Node", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<bool>("IsEnable");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<string>("NodeId")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Nodes");
                });

            modelBuilder.Entity("DotnetSpider.Enterprise.Domain.Entities.NodeHeartBeat", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AgentId")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("CountOfProcess");

                    b.Property<int>("CpuLoad");

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<long>("FreeMemory");

                    b.Property<string>("Ip")
                        .HasMaxLength(20);

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<string>("Os")
                        .HasMaxLength(20);

                    b.Property<long>("Timestamp");

                    b.Property<long>("TotalMemory");

                    b.Property<string>("Version")
                        .HasMaxLength(12);

                    b.HasKey("Id");

                    b.ToTable("NodeHeartBeats");
                });

            modelBuilder.Entity("DotnetSpider.Enterprise.Domain.Entities.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Client")
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<string>("Executive")
                        .HasMaxLength(50);

                    b.Property<bool>("IsEnabled");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Note")
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("DotnetSpider.Enterprise.Domain.Entities.Task", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AssemblyName")
                        .HasMaxLength(100);

                    b.Property<DateTime>("BuildTime");

                    b.Property<string>("Client")
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<string>("Cron")
                        .HasMaxLength(100);

                    b.Property<string>("Executive")
                        .HasMaxLength(50);

                    b.Property<string>("ExtraArguments")
                        .HasMaxLength(100);

                    b.Property<string>("Framework")
                        .HasMaxLength(20);

                    b.Property<bool>("IsEnabled");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("NodesCount");

                    b.Property<string>("Note")
                        .HasMaxLength(500);

                    b.Property<string>("Programmer")
                        .HasMaxLength(50);

                    b.Property<int>("ProjectId");

                    b.Property<string>("TaskName")
                        .HasMaxLength(100);

                    b.Property<string>("Version")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<long>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.ToTable("AspNetUserClaims");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUserClaim<long>");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<long>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("ProviderDisplayName");

                    b.Property<long>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.ToTable("AspNetUserLogins");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUserLogin<long>");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<long>", b =>
                {
                    b.Property<long>("UserId");

                    b.Property<long>("RoleId");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUserRole<long>");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<long>", b =>
                {
                    b.Property<long>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("DotnetSpider.Enterprise.Domain.Entities.ApplicationUserClaim", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUserClaim<long>");

                    b.Property<long?>("ApplicationRoleId");

                    b.HasIndex("ApplicationRoleId");

                    b.HasIndex("UserId");

                    b.ToTable("ApplicationUserClaim");

                    b.HasDiscriminator().HasValue("ApplicationUserClaim");
                });

            modelBuilder.Entity("DotnetSpider.Enterprise.Domain.Entities.ApplicationUserLogin", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUserLogin<long>");


                    b.HasIndex("UserId");

                    b.ToTable("ApplicationUserLogin");

                    b.HasDiscriminator().HasValue("ApplicationUserLogin");
                });

            modelBuilder.Entity("DotnetSpider.Enterprise.Domain.Entities.ApplicationUserRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUserRole<long>");


                    b.ToTable("ApplicationUserRole");

                    b.HasDiscriminator().HasValue("ApplicationUserRole");
                });

            modelBuilder.Entity("DotnetSpider.Enterprise.Domain.Entities.ApplicationUser", b =>
                {
                    b.HasOne("DotnetSpider.Enterprise.Domain.Entities.ApplicationRole")
                        .WithMany("Users")
                        .HasForeignKey("ApplicationRoleId");
                });

            modelBuilder.Entity("DotnetSpider.Enterprise.Domain.Entities.Task", b =>
                {
                    b.HasOne("DotnetSpider.Enterprise.Domain.Entities.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>", b =>
                {
                    b.HasOne("DotnetSpider.Enterprise.Domain.Entities.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<long>", b =>
                {
                    b.HasOne("DotnetSpider.Enterprise.Domain.Entities.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<long>", b =>
                {
                    b.HasOne("DotnetSpider.Enterprise.Domain.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DotnetSpider.Enterprise.Domain.Entities.ApplicationUserClaim", b =>
                {
                    b.HasOne("DotnetSpider.Enterprise.Domain.Entities.ApplicationRole")
                        .WithMany("Claims")
                        .HasForeignKey("ApplicationRoleId");

                    b.HasOne("DotnetSpider.Enterprise.Domain.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DotnetSpider.Enterprise.Domain.Entities.ApplicationUserLogin", b =>
                {
                    b.HasOne("DotnetSpider.Enterprise.Domain.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DotnetSpider.Enterprise.Domain.Entities.ApplicationUserRole", b =>
                {
                    b.HasOne("DotnetSpider.Enterprise.Domain.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}