﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SudokuCollective.Data.Models;

#nullable disable

namespace SudokuCollective.Api.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("SudokuCollective.Core.Models.App", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessDuration")
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "accessDuration");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<string>("CustomEmailConfirmationAction")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "customEmailConfirmationAction");

                    b.Property<string>("CustomPasswordResetAction")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "customPasswordResetAction");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp with time zone")
                        .HasAnnotation("Relational:JsonPropertyName", "dateCreated");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("timestamp with time zone")
                        .HasAnnotation("Relational:JsonPropertyName", "dateUpdated");

                    b.Property<bool>("DisableCustomUrls")
                        .HasColumnType("boolean")
                        .HasAnnotation("Relational:JsonPropertyName", "disableCustomUrls");

                    b.Property<bool>("DisplayInGallery")
                        .HasColumnType("boolean")
                        .HasAnnotation("Relational:JsonPropertyName", "displayInGallery");

                    b.Property<int>("Environment")
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "environment");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean")
                        .HasAnnotation("Relational:JsonPropertyName", "isActive");

                    b.Property<string>("License")
                        .HasColumnType("text");

                    b.Property<string>("LocalUrl")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "localUrl");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "name");

                    b.Property<int>("OwnerId")
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "ownerId");

                    b.Property<bool>("PermitCollectiveLogins")
                        .HasColumnType("boolean")
                        .HasAnnotation("Relational:JsonPropertyName", "permitCollectiveLogins");

                    b.Property<bool>("PermitSuperUserAccess")
                        .HasColumnType("boolean")
                        .HasAnnotation("Relational:JsonPropertyName", "permitSuperUserAccess");

                    b.Property<string>("ProdUrl")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "prodUrl");

                    b.Property<string>("SourceCodeUrl")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "sourceCodeUrl");

                    b.Property<string>("StagingUrl")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "stagingUrl");

                    b.Property<string>("TestUrl")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "TestUrl");

                    b.Property<int>("TimeFrame")
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "timeFrame");

                    b.Property<bool>("UseCustomSMTPServer")
                        .HasColumnType("boolean")
                        .HasAnnotation("Relational:JsonPropertyName", "useCustomSMTPServer");

                    b.HasKey("Id");

                    b.ToTable("Apps");
                });

            modelBuilder.Entity("SudokuCollective.Core.Models.AppAdmin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AppId")
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "appId");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean")
                        .HasAnnotation("Relational:JsonPropertyName", "isActive");

                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "userId");

                    b.HasKey("Id");

                    b.ToTable("AppAdmins");
                });

            modelBuilder.Entity("SudokuCollective.Core.Models.Difficulty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("DifficultyLevel")
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "difficultyLevel");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "displayName");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "name");

                    b.HasKey("Id");

                    b.ToTable("Difficulties");

                    b.HasAnnotation("Relational:JsonPropertyName", "difficulty");
                });

            modelBuilder.Entity("SudokuCollective.Core.Models.EmailConfirmation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AppId")
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "appId");

                    b.Property<int>("ConfirmationType")
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "confirmationType");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("timestamp with time zone")
                        .HasAnnotation("Relational:JsonPropertyName", "expirationDate");

                    b.Property<string>("NewEmailAddress")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "newEmailAddress");

                    b.Property<string>("OldEmailAddress")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "oldEmailAddress");

                    b.Property<bool?>("OldEmailAddressConfirmed")
                        .HasColumnType("boolean")
                        .HasAnnotation("Relational:JsonPropertyName", "oldEmailAddress");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "token");

                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "userId");

                    b.HasKey("Id");

                    b.HasIndex("Token")
                        .IsUnique();

                    b.ToTable("EmailConfirmations");
                });

            modelBuilder.Entity("SudokuCollective.Core.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AppId")
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "appId");

                    b.Property<bool>("ContinueGame")
                        .HasColumnType("boolean")
                        .HasAnnotation("Relational:JsonPropertyName", "continueGame");

                    b.Property<DateTime>("DateCompleted")
                        .HasColumnType("timestamp with time zone")
                        .HasAnnotation("Relational:JsonPropertyName", "dateCompleted");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp with time zone")
                        .HasAnnotation("Relational:JsonPropertyName", "dateCreated");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("timestamp with time zone")
                        .HasAnnotation("Relational:JsonPropertyName", "dateUpdated");

                    b.Property<bool>("KeepScore")
                        .HasColumnType("boolean")
                        .HasAnnotation("Relational:JsonPropertyName", "keepScore");

                    b.Property<int>("Score")
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "score");

                    b.Property<int>("SudokuMatrixId")
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "sudokuMatrixId");

                    b.Property<int>("SudokuSolutionId")
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "sudokuSolutionId");

                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "userId");

                    b.HasKey("Id");

                    b.HasIndex("SudokuMatrixId")
                        .IsUnique();

                    b.HasIndex("SudokuSolutionId");

                    b.HasIndex("UserId");

                    b.ToTable("Games");

                    b.HasAnnotation("Relational:JsonPropertyName", "games");
                });

            modelBuilder.Entity("SudokuCollective.Core.Models.PasswordReset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AppId")
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "appId");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("timestamp with time zone")
                        .HasAnnotation("Relational:JsonPropertyName", "expirationDate");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "token");

                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "userId");

                    b.HasKey("Id");

                    b.HasIndex("Token")
                        .IsUnique();

                    b.ToTable("PasswordResets");
                });

            modelBuilder.Entity("SudokuCollective.Core.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "name");

                    b.Property<int>("RoleLevel")
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "roleLevel");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasAnnotation("Relational:JsonPropertyName", "role");
                });

            modelBuilder.Entity("SudokuCollective.Core.Models.SMTPServerSettings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AppId")
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "appId");

                    b.Property<string>("FromEmail")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "fromEmail");

                    b.Property<string>("Password")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "Password");

                    b.Property<int>("Port")
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "port");

                    b.Property<string>("SmtpServer")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "smtpServer");

                    b.Property<string>("UserName")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "userName");

                    b.HasKey("Id");

                    b.HasIndex("AppId")
                        .IsUnique();

                    b.ToTable("SMTPServerSettings");

                    b.HasAnnotation("Relational:JsonPropertyName", "smtpServerSettings");
                });

            modelBuilder.Entity("SudokuCollective.Core.Models.SudokuCell", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Column")
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "column");

                    b.Property<int>("DisplayedValue")
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "displayedValue");

                    b.Property<bool>("Hidden")
                        .HasColumnType("boolean")
                        .HasAnnotation("Relational:JsonPropertyName", "hidden");

                    b.Property<int>("Index")
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "index");

                    b.Property<int>("Region")
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "region");

                    b.Property<int>("Row")
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "row");

                    b.Property<int>("SudokuMatrixId")
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "sudokuMatrixId");

                    b.Property<int>("Value")
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "value");

                    b.HasKey("Id");

                    b.HasIndex("SudokuMatrixId");

                    b.ToTable("SudokuCells");

                    b.HasAnnotation("Relational:JsonPropertyName", "sudokuCells");
                });

            modelBuilder.Entity("SudokuCollective.Core.Models.SudokuMatrix", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("DifficultyId")
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "difficultyId");

                    b.HasKey("Id");

                    b.HasIndex("DifficultyId");

                    b.ToTable("SudokuMatrices");

                    b.HasAnnotation("Relational:JsonPropertyName", "sudokuMatrix");
                });

            modelBuilder.Entity("SudokuCollective.Core.Models.SudokuSolution", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp with time zone")
                        .HasAnnotation("Relational:JsonPropertyName", "dateCreated");

                    b.Property<DateTime>("DateSolved")
                        .HasColumnType("timestamp with time zone")
                        .HasAnnotation("Relational:JsonPropertyName", "dateSolved");

                    b.Property<string>("SolutionList")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "solutionList");

                    b.HasKey("Id");

                    b.ToTable("SudokuSolutions");

                    b.HasAnnotation("Relational:JsonPropertyName", "sudokuSolution");
                });

            modelBuilder.Entity("SudokuCollective.Core.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp with time zone")
                        .HasAnnotation("Relational:JsonPropertyName", "dateCreated");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("timestamp with time zone")
                        .HasAnnotation("Relational:JsonPropertyName", "dateUpdated");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "firstName");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean")
                        .HasAnnotation("Relational:JsonPropertyName", "isActive");

                    b.Property<bool>("IsEmailConfirmed")
                        .HasColumnType("boolean")
                        .HasAnnotation("Relational:JsonPropertyName", "isEmailConfirmed");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "lastName");

                    b.Property<string>("NickName")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "nickName");

                    b.Property<string>("Password")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "password");

                    b.Property<bool>("ReceivedRequestToUpdateEmail")
                        .HasColumnType("boolean")
                        .HasAnnotation("Relational:JsonPropertyName", "receivedRequestToUpdateEmail");

                    b.Property<bool>("ReceivedRequestToUpdatePassword")
                        .HasColumnType("boolean")
                        .HasAnnotation("Relational:JsonPropertyName", "receivedRequestToUpdatePassword");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "userName");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SudokuCollective.Core.Models.UserApp", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AppId")
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "appId");

                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "userId");

                    b.HasKey("Id");

                    b.HasIndex("AppId");

                    b.HasIndex("UserId");

                    b.ToTable("UsersApps");

                    b.HasAnnotation("Relational:JsonPropertyName", "apps");
                });

            modelBuilder.Entity("SudokuCollective.Core.Models.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("RoleId")
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "roleId");

                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "userId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UsersRoles");

                    b.HasAnnotation("Relational:JsonPropertyName", "roles");
                });

            modelBuilder.Entity("SudokuCollective.Core.Models.Game", b =>
                {
                    b.HasOne("SudokuCollective.Core.Models.SudokuMatrix", "SudokuMatrix")
                        .WithOne("Game")
                        .HasForeignKey("SudokuCollective.Core.Models.Game", "SudokuMatrixId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SudokuCollective.Core.Models.SudokuSolution", "SudokuSolution")
                        .WithMany()
                        .HasForeignKey("SudokuSolutionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SudokuCollective.Core.Models.User", "User")
                        .WithMany("Games")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SudokuMatrix");

                    b.Navigation("SudokuSolution");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SudokuCollective.Core.Models.SMTPServerSettings", b =>
                {
                    b.HasOne("SudokuCollective.Core.Models.App", null)
                        .WithOne("SMTPServerSettings")
                        .HasForeignKey("SudokuCollective.Core.Models.SMTPServerSettings", "AppId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SudokuCollective.Core.Models.SudokuCell", b =>
                {
                    b.HasOne("SudokuCollective.Core.Models.SudokuMatrix", "SudokuMatrix")
                        .WithMany("SudokuCells")
                        .HasForeignKey("SudokuMatrixId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SudokuMatrix");
                });

            modelBuilder.Entity("SudokuCollective.Core.Models.SudokuMatrix", b =>
                {
                    b.HasOne("SudokuCollective.Core.Models.Difficulty", "Difficulty")
                        .WithMany("Matrices")
                        .HasForeignKey("DifficultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Difficulty");
                });

            modelBuilder.Entity("SudokuCollective.Core.Models.UserApp", b =>
                {
                    b.HasOne("SudokuCollective.Core.Models.App", "App")
                        .WithMany("UserApps")
                        .HasForeignKey("AppId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SudokuCollective.Core.Models.User", "User")
                        .WithMany("Apps")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("App");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SudokuCollective.Core.Models.UserRole", b =>
                {
                    b.HasOne("SudokuCollective.Core.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SudokuCollective.Core.Models.User", "User")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SudokuCollective.Core.Models.App", b =>
                {
                    b.Navigation("SMTPServerSettings");

                    b.Navigation("UserApps");
                });

            modelBuilder.Entity("SudokuCollective.Core.Models.Difficulty", b =>
                {
                    b.Navigation("Matrices");
                });

            modelBuilder.Entity("SudokuCollective.Core.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("SudokuCollective.Core.Models.SudokuMatrix", b =>
                {
                    b.Navigation("Game");

                    b.Navigation("SudokuCells");
                });

            modelBuilder.Entity("SudokuCollective.Core.Models.User", b =>
                {
                    b.Navigation("Apps");

                    b.Navigation("Games");

                    b.Navigation("Roles");
                });
#pragma warning restore 612, 618
        }
    }
}
