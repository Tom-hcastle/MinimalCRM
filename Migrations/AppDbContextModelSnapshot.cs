﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SuperCRM.DataModels;

namespace SuperCRM.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SuperCRM.DataModels.DbBusinessDetails", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address1")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.HasKey("UserId");

                    b.ToTable("BusinessDetails");
                });

            modelBuilder.Entity("SuperCRM.DataModels.DbContact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AcquiredFrom")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.Property<string>("Address1")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<Guid>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(75)")
                        .HasMaxLength(75);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("OwnerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("OwnerId");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("SuperCRM.DataModels.DbImpliedPermission", b =>
                {
                    b.Property<string>("PermissionCode")
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("ImpliedPermissionCode")
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.HasKey("PermissionCode", "ImpliedPermissionCode");

                    b.HasIndex("ImpliedPermissionCode");

                    b.ToTable("ImpliedPermission");
                });

            modelBuilder.Entity("SuperCRM.DataModels.DbInteraction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ContactId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InteractionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Method")
                        .HasColumnType("int");

                    b.Property<string>("MethodDetails")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContactId");

                    b.HasIndex("CreatedById");

                    b.ToTable("Interaction");
                });

            modelBuilder.Entity("SuperCRM.DataModels.DbPermission", b =>
                {
                    b.Property<string>("PermissionCode")
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("EntityTypeCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<int>("Kind")
                        .HasColumnType("int");

                    b.HasKey("PermissionCode");

                    b.ToTable("Permission");
                });

            modelBuilder.Entity("SuperCRM.DataModels.DbUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("HashedPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<Guid?>("ParentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("PasswordBlocked")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("PasswordBlockedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PasswordBlockedReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PasswordExpiredAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("PasswordResetToken")
                        .HasColumnType("nvarchar(36)")
                        .HasMaxLength(36);

                    b.Property<DateTime?>("PasswordResetTokenExpiredAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Suspended")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("SuspensionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SuspensionReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("VerificationToken")
                        .IsRequired()
                        .HasColumnType("nvarchar(36)")
                        .HasMaxLength(36);

                    b.Property<bool>("Verified")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("User");
                });

            modelBuilder.Entity("SuperCRM.DataModels.DbUserPermit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PermissionCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<Guid>("UserPermitGroupId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PermissionCode");

                    b.HasIndex("UserPermitGroupId", "PermissionCode", "EntityId")
                        .IsUnique()
                        .HasName("UK_UserPermit_UserPermitGroupId_PermissionCode_EntityId");

                    b.ToTable("UserPermit");
                });

            modelBuilder.Entity("SuperCRM.DataModels.DbUserPermitGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId", "GroupName")
                        .IsUnique()
                        .HasName("UK_UserPermitGroup_UserId_GroupName");

                    b.ToTable("UserPermitGroup");
                });

            modelBuilder.Entity("SuperCRM.DataModels.DbUserSession", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Device")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("EffectiveFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ExpiredOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ImpersonatedUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ip")
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Secret")
                        .IsRequired()
                        .HasColumnType("nvarchar(44)")
                        .HasMaxLength(44);

                    b.Property<int?>("SlideByDurationInMinutes")
                        .HasColumnType("int");

                    b.Property<bool>("SlidingExpiration")
                        .HasColumnType("bit");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("Secret")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("UserSession");
                });

            modelBuilder.Entity("SuperCRM.DataModels.DbBusinessDetails", b =>
                {
                    b.HasOne("SuperCRM.DataModels.DbUser", "User")
                        .WithOne("BusinessDetails")
                        .HasForeignKey("SuperCRM.DataModels.DbBusinessDetails", "UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("SuperCRM.DataModels.DbContact", b =>
                {
                    b.HasOne("SuperCRM.DataModels.DbUser", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SuperCRM.DataModels.DbUser", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("SuperCRM.DataModels.DbImpliedPermission", b =>
                {
                    b.HasOne("SuperCRM.DataModels.DbPermission", "Implied")
                        .WithMany("IAmImplied")
                        .HasForeignKey("ImpliedPermissionCode")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SuperCRM.DataModels.DbPermission", "Permission")
                        .WithMany("MyImplied")
                        .HasForeignKey("PermissionCode")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("SuperCRM.DataModels.DbInteraction", b =>
                {
                    b.HasOne("SuperCRM.DataModels.DbContact", "Contact")
                        .WithMany("Interactions")
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SuperCRM.DataModels.DbUser", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("SuperCRM.DataModels.DbUser", b =>
                {
                    b.HasOne("SuperCRM.DataModels.DbUser", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.NoAction);
                });

            modelBuilder.Entity("SuperCRM.DataModels.DbUserPermit", b =>
                {
                    b.HasOne("SuperCRM.DataModels.DbPermission", "Permission")
                        .WithMany("Permits")
                        .HasForeignKey("PermissionCode")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SuperCRM.DataModels.DbUserPermitGroup", "UserPermitGroup")
                        .WithMany("Permits")
                        .HasForeignKey("UserPermitGroupId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("SuperCRM.DataModels.DbUserPermitGroup", b =>
                {
                    b.HasOne("SuperCRM.DataModels.DbUser", "User")
                        .WithMany("PermitGroups")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("SuperCRM.DataModels.DbUserSession", b =>
                {
                    b.HasOne("SuperCRM.DataModels.DbUser", "User")
                        .WithMany("Sessions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
