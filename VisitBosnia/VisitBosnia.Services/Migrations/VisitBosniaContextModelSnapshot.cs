﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VisitBosnia.Services.Database;

#nullable disable

namespace VisitBosnia.Services.Migrations
{
    [DbContext(typeof(VisitBosniaContext))]
    partial class VisitBosniaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("VisitBosnia.Services.Database.Agency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResponsiblePerson")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "CityId" }, "IX_Agency_CityId");

                    b.ToTable("Agency", (string)null);
                });

            modelBuilder.Entity("VisitBosnia.Services.Database.AgencyMember", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AgencyId")
                        .HasColumnType("int");

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AgencyId");

                    b.HasIndex("AppUserId");

                    b.ToTable("AgencyMember", (string)null);
                });

            modelBuilder.Entity("VisitBosnia.Services.Database.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("IsBlocked")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Phone")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("TempPass")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("AppUser", (string)null);
                });

            modelBuilder.Entity("VisitBosnia.Services.Database.AppUserFavourite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.Property<int>("TouristFacilityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("TouristFacilityId");

                    b.ToTable("AppUserFavourite", (string)null);
                });

            modelBuilder.Entity("VisitBosnia.Services.Database.AppUserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("RoleId");

                    b.ToTable("AppUserRole", (string)null);
                });

            modelBuilder.Entity("VisitBosnia.Services.Database.Attraction", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<decimal>("GeoLat")
                        .HasColumnType("decimal(10,6)");

                    b.Property<decimal>("GeoLong")
                        .HasColumnType("decimal(10,6)");

                    b.HasKey("Id");

                    b.ToTable("Attraction", (string)null);
                });

            modelBuilder.Entity("VisitBosnia.Services.Database.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category", (string)null);
                });

            modelBuilder.Entity("VisitBosnia.Services.Database.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("County")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("City", (string)null);
                });

            modelBuilder.Entity("VisitBosnia.Services.Database.Event", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("AgencyId")
                        .HasColumnType("int");

                    b.Property<int>("AgencyMemberId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("FromTime")
                        .HasColumnType("int");

                    b.Property<int>("MaxNumberOfParticipants")
                        .HasColumnType("int");

                    b.Property<string>("PlaceOfDeparture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PricePerPerson")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ToTime")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AgencyMemberId");

                    b.HasIndex(new[] { "AgencyId" }, "IX_Event_AgencyId");

                    b.ToTable("Event", (string)null);
                });

            modelBuilder.Entity("VisitBosnia.Services.Database.EventOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("EventId");

                    b.ToTable("EventOrder", (string)null);
                });

            modelBuilder.Entity("VisitBosnia.Services.Database.Forum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Forum", (string)null);
                });

            modelBuilder.Entity("VisitBosnia.Services.Database.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime");

                    b.Property<int>("ForumId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("ForumId");

                    b.ToTable("Post", (string)null);
                });

            modelBuilder.Entity("VisitBosnia.Services.Database.PostReply", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("PostId");

                    b.ToTable("PostReply", (string)null);
                });

            modelBuilder.Entity("VisitBosnia.Services.Database.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("TouristFacilityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("TouristFacilityId");

                    b.ToTable("Review", (string)null);
                });

            modelBuilder.Entity("VisitBosnia.Services.Database.ReviewGallery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<byte[]>("Image")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ImageType")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("ReviewId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ReviewId");

                    b.ToTable("ReviewGallery", (string)null);
                });

            modelBuilder.Entity("VisitBosnia.Services.Database.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Role", (string)null);
                });

            modelBuilder.Entity("VisitBosnia.Services.Database.TouristFacility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "CategoryId" }, "IX_TouristFacility_CategoryId");

                    b.HasIndex(new[] { "CityId" }, "IX_TouristFacility_CityId");

                    b.ToTable("TouristFacility", (string)null);
                });

            modelBuilder.Entity("VisitBosnia.Services.Database.TouristFacilityGallery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<byte[]>("Image")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ImageType")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool?>("Thumbnail")
                        .HasColumnType("bit");

                    b.Property<int>("TouristFacilityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TouristFacilityId");

                    b.ToTable("TouristFacilityGallery", (string)null);
                });

            modelBuilder.Entity("VisitBosnia.Services.Database.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ChargeId")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime");

                    b.Property<int>("EventOrderId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("EventOrderId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("VisitBosnia.Services.Database.Agency", b =>
                {
                    b.HasOne("VisitBosnia.Services.Database.City", "City")
                        .WithMany("Agencies")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("VisitBosnia.Services.Database.AgencyMember", b =>
                {
                    b.HasOne("VisitBosnia.Services.Database.Agency", "Agency")
                        .WithMany("AgencyMembers")
                        .HasForeignKey("AgencyId")
                        .IsRequired()
                        .HasConstraintName("FK_AgencyMemberAgency");

                    b.HasOne("VisitBosnia.Services.Database.AppUser", "AppUser")
                        .WithMany("AgencyMembers")
                        .HasForeignKey("AppUserId")
                        .IsRequired()
                        .HasConstraintName("FK_AgencyMemberAppUser");

                    b.Navigation("Agency");

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("VisitBosnia.Services.Database.AppUserFavourite", b =>
                {
                    b.HasOne("VisitBosnia.Services.Database.AppUser", "AppUser")
                        .WithMany("AppUserFavourites")
                        .HasForeignKey("AppUserId")
                        .IsRequired()
                        .HasConstraintName("FK_AppUserFavouriteAppUser");

                    b.HasOne("VisitBosnia.Services.Database.TouristFacility", "TouristFacility")
                        .WithMany("AppUserFavourites")
                        .HasForeignKey("TouristFacilityId")
                        .IsRequired()
                        .HasConstraintName("FK_AppUserFavouriteTouristFacility");

                    b.Navigation("AppUser");

                    b.Navigation("TouristFacility");
                });

            modelBuilder.Entity("VisitBosnia.Services.Database.AppUserRole", b =>
                {
                    b.HasOne("VisitBosnia.Services.Database.AppUser", "AppUser")
                        .WithMany("AppUserRoles")
                        .HasForeignKey("AppUserId")
                        .IsRequired()
                        .HasConstraintName("FK_AppUserRoleAppUser");

                    b.HasOne("VisitBosnia.Services.Database.Role", "Role")
                        .WithMany("AppUserRoles")
                        .HasForeignKey("RoleId")
                        .IsRequired()
                        .HasConstraintName("FK_AppUserRoleRole");

                    b.Navigation("AppUser");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("VisitBosnia.Services.Database.Attraction", b =>
                {
                    b.HasOne("VisitBosnia.Services.Database.TouristFacility", "IdNavigation")
                        .WithOne("Attraction")
                        .HasForeignKey("VisitBosnia.Services.Database.Attraction", "Id")
                        .IsRequired();

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("VisitBosnia.Services.Database.Event", b =>
                {
                    b.HasOne("VisitBosnia.Services.Database.Agency", "Agency")
                        .WithMany("Events")
                        .HasForeignKey("AgencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VisitBosnia.Services.Database.AgencyMember", "AgencyMember")
                        .WithMany("Events")
                        .HasForeignKey("AgencyMemberId")
                        .IsRequired()
                        .HasConstraintName("FK_EventAgencyMember");

                    b.HasOne("VisitBosnia.Services.Database.TouristFacility", "IdNavigation")
                        .WithOne("Event")
                        .HasForeignKey("VisitBosnia.Services.Database.Event", "Id")
                        .IsRequired();

                    b.Navigation("Agency");

                    b.Navigation("AgencyMember");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("VisitBosnia.Services.Database.EventOrder", b =>
                {
                    b.HasOne("VisitBosnia.Services.Database.AppUser", "AppUser")
                        .WithMany("EventOrders")
                        .HasForeignKey("AppUserId")
                        .IsRequired()
                        .HasConstraintName("FK_EventOrderAppUser");

                    b.HasOne("VisitBosnia.Services.Database.Event", "Event")
                        .WithMany("EventOrders")
                        .HasForeignKey("EventId")
                        .IsRequired()
                        .HasConstraintName("FK_EventOrderEvent");

                    b.Navigation("AppUser");

                    b.Navigation("Event");
                });

            modelBuilder.Entity("VisitBosnia.Services.Database.Forum", b =>
                {
                    b.HasOne("VisitBosnia.Services.Database.City", "City")
                        .WithMany("Forums")
                        .HasForeignKey("CityId")
                        .IsRequired()
                        .HasConstraintName("FK_ForumCity");

                    b.Navigation("City");
                });

            modelBuilder.Entity("VisitBosnia.Services.Database.Post", b =>
                {
                    b.HasOne("VisitBosnia.Services.Database.AppUser", "AppUser")
                        .WithMany("Posts")
                        .HasForeignKey("AppUserId")
                        .IsRequired()
                        .HasConstraintName("FK_PostAppUser");

                    b.HasOne("VisitBosnia.Services.Database.Forum", "Forum")
                        .WithMany("Posts")
                        .HasForeignKey("ForumId")
                        .IsRequired()
                        .HasConstraintName("FK_PostForum");

                    b.Navigation("AppUser");

                    b.Navigation("Forum");
                });

            modelBuilder.Entity("VisitBosnia.Services.Database.PostReply", b =>
                {
                    b.HasOne("VisitBosnia.Services.Database.AppUser", "AppUser")
                        .WithMany("PostReplies")
                        .HasForeignKey("AppUserId")
                        .IsRequired()
                        .HasConstraintName("FK_PostReplyAppUser");

                    b.HasOne("VisitBosnia.Services.Database.Post", "Post")
                        .WithMany("PostReplies")
                        .HasForeignKey("PostId")
                        .IsRequired()
                        .HasConstraintName("FK_PostReplyPost");

                    b.Navigation("AppUser");

                    b.Navigation("Post");
                });

            modelBuilder.Entity("VisitBosnia.Services.Database.Review", b =>
                {
                    b.HasOne("VisitBosnia.Services.Database.AppUser", "AppUser")
                        .WithMany("Reviews")
                        .HasForeignKey("AppUserId")
                        .IsRequired()
                        .HasConstraintName("FK_ReviewAppUser");

                    b.HasOne("VisitBosnia.Services.Database.TouristFacility", "TouristFacility")
                        .WithMany("Reviews")
                        .HasForeignKey("TouristFacilityId")
                        .IsRequired()
                        .HasConstraintName("FK_ReviewTouristFacility");

                    b.Navigation("AppUser");

                    b.Navigation("TouristFacility");
                });

            modelBuilder.Entity("VisitBosnia.Services.Database.ReviewGallery", b =>
                {
                    b.HasOne("VisitBosnia.Services.Database.Review", "Review")
                        .WithMany("ReviewGalleries")
                        .HasForeignKey("ReviewId")
                        .IsRequired()
                        .HasConstraintName("FK_ReviewGalleryReview");

                    b.Navigation("Review");
                });

            modelBuilder.Entity("VisitBosnia.Services.Database.TouristFacility", b =>
                {
                    b.HasOne("VisitBosnia.Services.Database.Category", "Category")
                        .WithMany("TouristFacilities")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VisitBosnia.Services.Database.City", "City")
                        .WithMany("TouristFacilities")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("City");
                });

            modelBuilder.Entity("VisitBosnia.Services.Database.TouristFacilityGallery", b =>
                {
                    b.HasOne("VisitBosnia.Services.Database.TouristFacility", "TouristFacility")
                        .WithMany("TouristFacilityGalleries")
                        .HasForeignKey("TouristFacilityId")
                        .IsRequired()
                        .HasConstraintName("FK_TouristFacilityGalleryTouristFacility");

                    b.Navigation("TouristFacility");
                });

            modelBuilder.Entity("VisitBosnia.Services.Database.Transaction", b =>
                {
                    b.HasOne("VisitBosnia.Services.Database.EventOrder", "EventOrder")
                        .WithMany("Transactions")
                        .HasForeignKey("EventOrderId")
                        .IsRequired()
                        .HasConstraintName("FK_TransactionsEventOrder");

                    b.Navigation("EventOrder");
                });

            modelBuilder.Entity("VisitBosnia.Services.Database.Agency", b =>
                {
                    b.Navigation("AgencyMembers");

                    b.Navigation("Events");
                });

            modelBuilder.Entity("VisitBosnia.Services.Database.AgencyMember", b =>
                {
                    b.Navigation("Events");
                });

            modelBuilder.Entity("VisitBosnia.Services.Database.AppUser", b =>
                {
                    b.Navigation("AgencyMembers");

                    b.Navigation("AppUserFavourites");

                    b.Navigation("AppUserRoles");

                    b.Navigation("EventOrders");

                    b.Navigation("PostReplies");

                    b.Navigation("Posts");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("VisitBosnia.Services.Database.Category", b =>
                {
                    b.Navigation("TouristFacilities");
                });

            modelBuilder.Entity("VisitBosnia.Services.Database.City", b =>
                {
                    b.Navigation("Agencies");

                    b.Navigation("Forums");

                    b.Navigation("TouristFacilities");
                });

            modelBuilder.Entity("VisitBosnia.Services.Database.Event", b =>
                {
                    b.Navigation("EventOrders");
                });

            modelBuilder.Entity("VisitBosnia.Services.Database.EventOrder", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("VisitBosnia.Services.Database.Forum", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("VisitBosnia.Services.Database.Post", b =>
                {
                    b.Navigation("PostReplies");
                });

            modelBuilder.Entity("VisitBosnia.Services.Database.Review", b =>
                {
                    b.Navigation("ReviewGalleries");
                });

            modelBuilder.Entity("VisitBosnia.Services.Database.Role", b =>
                {
                    b.Navigation("AppUserRoles");
                });

            modelBuilder.Entity("VisitBosnia.Services.Database.TouristFacility", b =>
                {
                    b.Navigation("AppUserFavourites");

                    b.Navigation("Attraction")
                        .IsRequired();

                    b.Navigation("Event")
                        .IsRequired();

                    b.Navigation("Reviews");

                    b.Navigation("TouristFacilityGalleries");
                });
#pragma warning restore 612, 618
        }
    }
}
