﻿// <auto-generated />
using System;
using BankSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BankSystem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("BankSystem.Models.Client", b =>
                {
                    b.Property<string>("IDnumber")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("ApartmentNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("Street")
                        .HasColumnType("TEXT");

                    b.HasKey("IDnumber");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("BankSystem.Models.DollarAccount", b =>
                {
                    b.Property<string>("AccountNumber")
                        .HasColumnType("TEXT");

                    b.Property<double>("DollarFunds")
                        .HasColumnType("REAL");

                    b.Property<string>("IDnumberFK")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AccountNumber");

                    b.HasIndex("IDnumberFK")
                        .IsUnique();

                    b.ToTable("DollarAccounts");
                });

            modelBuilder.Entity("BankSystem.Models.EuroAccount", b =>
                {
                    b.Property<string>("AccountNumber")
                        .HasColumnType("TEXT");

                    b.Property<double>("EuroFunds")
                        .HasColumnType("REAL");

                    b.Property<string>("IDnumberFK")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AccountNumber");

                    b.HasIndex("IDnumberFK")
                        .IsUnique();

                    b.ToTable("EuroAccounts");
                });

            modelBuilder.Entity("BankSystem.Models.HistoryOfTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Amount")
                        .HasColumnType("REAL");

                    b.Property<string>("BeneficiaryAccount")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("DollarAccountFK")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EuroAccountFK")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PoundAccountFK")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("TransferFK")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("DollarAccountFK");

                    b.HasIndex("EuroAccountFK");

                    b.HasIndex("PoundAccountFK");

                    b.HasIndex("TransferFK")
                        .IsUnique();

                    b.ToTable("HistoryOfTransactions");
                });

            modelBuilder.Entity("BankSystem.Models.LoanApplication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Amount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ApartmentNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("TEXT");

                    b.Property<string>("EmploymentType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("IDnumberFK")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("MonthToPayOff")
                        .HasColumnType("INTEGER");

                    b.Property<double>("NetIncome")
                        .HasColumnType("REAL");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("IDnumberFK");

                    b.ToTable("LoanApplications");
                });

            modelBuilder.Entity("BankSystem.Models.PoundAccount", b =>
                {
                    b.Property<string>("AccountNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("IDnumberFK")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("PoundFunds")
                        .HasColumnType("REAL");

                    b.HasKey("AccountNumber");

                    b.HasIndex("IDnumberFK")
                        .IsUnique();

                    b.ToTable("PoundAccounts");
                });

            modelBuilder.Entity("BankSystem.Models.Transfer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Amount")
                        .HasColumnType("REAL");

                    b.Property<string>("BeneficiaryAccount")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BeneficiaryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("DollarAccountFK")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EuroAccountFK")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsInstant")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PoundAccountFK")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DollarAccountFK");

                    b.HasIndex("EuroAccountFK");

                    b.HasIndex("PoundAccountFK");

                    b.ToTable("Transfers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BankSystem.Models.DollarAccount", b =>
                {
                    b.HasOne("BankSystem.Models.Client", "_Client")
                        .WithOne("DollarAcc")
                        .HasForeignKey("BankSystem.Models.DollarAccount", "IDnumberFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("_Client");
                });

            modelBuilder.Entity("BankSystem.Models.EuroAccount", b =>
                {
                    b.HasOne("BankSystem.Models.Client", "_Client")
                        .WithOne("EuroAcc")
                        .HasForeignKey("BankSystem.Models.EuroAccount", "IDnumberFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("_Client");
                });

            modelBuilder.Entity("BankSystem.Models.HistoryOfTransaction", b =>
                {
                    b.HasOne("BankSystem.Models.DollarAccount", "DollarAcc")
                        .WithMany("Transaction")
                        .HasForeignKey("DollarAccountFK")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("BankSystem.Models.EuroAccount", "EuroAcc")
                        .WithMany("Transaction")
                        .HasForeignKey("EuroAccountFK")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("BankSystem.Models.PoundAccount", "PoundAcc")
                        .WithMany("Transaction")
                        .HasForeignKey("PoundAccountFK")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("BankSystem.Models.Transfer", "_Transfer")
                        .WithOne("Transaction")
                        .HasForeignKey("BankSystem.Models.HistoryOfTransaction", "TransferFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DollarAcc");

                    b.Navigation("EuroAcc");

                    b.Navigation("PoundAcc");

                    b.Navigation("_Transfer");
                });

            modelBuilder.Entity("BankSystem.Models.LoanApplication", b =>
                {
                    b.HasOne("BankSystem.Models.Client", "_Client")
                        .WithMany("LoanApplications")
                        .HasForeignKey("IDnumberFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("_Client");
                });

            modelBuilder.Entity("BankSystem.Models.PoundAccount", b =>
                {
                    b.HasOne("BankSystem.Models.Client", "_Client")
                        .WithOne("PoundAcc")
                        .HasForeignKey("BankSystem.Models.PoundAccount", "IDnumberFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("_Client");
                });

            modelBuilder.Entity("BankSystem.Models.Transfer", b =>
                {
                    b.HasOne("BankSystem.Models.DollarAccount", "DollarAcc")
                        .WithMany("Transfers")
                        .HasForeignKey("DollarAccountFK")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("BankSystem.Models.EuroAccount", "EuroAcc")
                        .WithMany("Transfers")
                        .HasForeignKey("EuroAccountFK")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("BankSystem.Models.PoundAccount", "PoundAcc")
                        .WithMany("Transfers")
                        .HasForeignKey("PoundAccountFK")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("DollarAcc");

                    b.Navigation("EuroAcc");

                    b.Navigation("PoundAcc");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BankSystem.Models.Client", b =>
                {
                    b.Navigation("DollarAcc")
                        .IsRequired();

                    b.Navigation("EuroAcc")
                        .IsRequired();

                    b.Navigation("LoanApplications");

                    b.Navigation("PoundAcc")
                        .IsRequired();
                });

            modelBuilder.Entity("BankSystem.Models.DollarAccount", b =>
                {
                    b.Navigation("Transaction");

                    b.Navigation("Transfers");
                });

            modelBuilder.Entity("BankSystem.Models.EuroAccount", b =>
                {
                    b.Navigation("Transaction");

                    b.Navigation("Transfers");
                });

            modelBuilder.Entity("BankSystem.Models.PoundAccount", b =>
                {
                    b.Navigation("Transaction");

                    b.Navigation("Transfers");
                });

            modelBuilder.Entity("BankSystem.Models.Transfer", b =>
                {
                    b.Navigation("Transaction")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
