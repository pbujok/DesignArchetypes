﻿// <auto-generated />
using System;
using ItEmperor.Party.Tests;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ItEmperor.Party.Tests.Migrations
{
    [DbContext(typeof(PartyDbContext))]
    partial class PartyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ItEmperor.Party.Addresses.Simple.SimpleAddress", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("PersonId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("SimpleAddress");
                });

            modelBuilder.Entity("ItEmperor.Party.Classifications.PartyClassification", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset?>("EndDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("FromDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("PartyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TypeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PartyId");

                    b.HasIndex("TypeId");

                    b.ToTable("PartyClassification");
                });

            modelBuilder.Entity("ItEmperor.Party.Classifications.PartyType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PartyType", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("PartyType");
                });

            modelBuilder.Entity("ItEmperor.Party.Organizations.Position", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HourSalaryFrom")
                        .HasColumnType("int");

                    b.Property<int>("HourSalaryTo")
                        .HasColumnType("int");

                    b.Property<Guid>("OrganizationId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.ToTable("Position");
                });

            modelBuilder.Entity("ItEmperor.Party.Party", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Party");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Party");
                });

            modelBuilder.Entity("ItEmperor.Party.Relationships.PartyRelationship", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("EndDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("PartyAId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PartyBId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("StartDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("PartyAId");

                    b.HasIndex("PartyBId");

                    b.ToTable("PartyRelationship");

                    b.HasDiscriminator<string>("Discriminator").HasValue("PartyRelationship");
                });

            modelBuilder.Entity("ItEmperor.Party.Roles.PartyRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("DateFrom")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DateTo")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("PartyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PartyId");

                    b.HasIndex("RoleTypeId");

                    b.ToTable("PartyRole", (string)null);
                });

            modelBuilder.Entity("ItEmperor.Party.Roles.RoleType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RoleType", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("RoleType");
                });

            modelBuilder.Entity("ItEmperor.Party.Classifications.Organizations.IncomePartyType", b =>
                {
                    b.HasBaseType("ItEmperor.Party.Classifications.PartyType");

                    b.ToTable("PartyType", (string)null);

                    b.HasDiscriminator().HasValue("IncomePartyType");
                });

            modelBuilder.Entity("ItEmperor.Party.Classifications.Persons.SexPartyType", b =>
                {
                    b.HasBaseType("ItEmperor.Party.Classifications.PartyType");

                    b.ToTable("PartyType", (string)null);

                    b.HasDiscriminator().HasValue("SexPartyType");
                });

            modelBuilder.Entity("ItEmperor.Party.Organizations.Organization", b =>
                {
                    b.HasBaseType("ItEmperor.Party.Party");

                    b.Property<string>("TaxId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Party", (string)null);

                    b.HasDiscriminator().HasValue("Organization");
                });

            modelBuilder.Entity("ItEmperor.Party.Persons.Person", b =>
                {
                    b.HasBaseType("ItEmperor.Party.Party");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Party", (string)null);

                    b.HasDiscriminator().HasValue("Person");
                });

            modelBuilder.Entity("ItEmperor.Party.Relationships.Employments.PositionAssignmentEmployment", b =>
                {
                    b.HasBaseType("ItEmperor.Party.Relationships.PartyRelationship");

                    b.Property<Guid>("PositionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasIndex("PositionId");

                    b.ToTable("PartyRelationship", (string)null);

                    b.HasDiscriminator().HasValue("PositionAssignmentEmployment");
                });

            modelBuilder.Entity("ItEmperor.Party.Relationships.Employments.SimpleEmployment", b =>
                {
                    b.HasBaseType("ItEmperor.Party.Relationships.PartyRelationship");

                    b.Property<string>("PostName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("PartyRelationship", (string)null);

                    b.HasDiscriminator().HasValue("SimpleEmployment");
                });

            modelBuilder.Entity("ItEmperor.Party.Roles.PartyRoleType", b =>
                {
                    b.HasBaseType("ItEmperor.Party.Roles.RoleType");

                    b.HasDiscriminator().HasValue("PartyRoleType");
                });

            modelBuilder.Entity("ItEmperor.Party.Addresses.Simple.SimpleAddress", b =>
                {
                    b.HasOne("ItEmperor.Party.Persons.Person", null)
                        .WithMany("Addresses")
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("ItEmperor.Party.Classifications.PartyClassification", b =>
                {
                    b.HasOne("ItEmperor.Party.Party", "Party")
                        .WithMany("PartyClassifications")
                        .HasForeignKey("PartyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ItEmperor.Party.Classifications.PartyType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Party");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("ItEmperor.Party.Organizations.Position", b =>
                {
                    b.HasOne("ItEmperor.Party.Organizations.Organization", "Organization")
                        .WithMany("Positions")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("ItEmperor.Party.Party", b =>
                {
                    b.OwnsMany("ItEmperor.Party.TelephoneNumber", "TelephoneNumbers", b1 =>
                        {
                            b1.Property<Guid>("PartyId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b1.Property<int>("Id"), 1L, 1);

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("PartyId", "Id");

                            b1.ToTable("TelephoneNumber");

                            b1.WithOwner()
                                .HasForeignKey("PartyId");
                        });

                    b.Navigation("TelephoneNumbers");
                });

            modelBuilder.Entity("ItEmperor.Party.Relationships.PartyRelationship", b =>
                {
                    b.HasOne("ItEmperor.Party.Party", "PartyA")
                        .WithMany()
                        .HasForeignKey("PartyAId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ItEmperor.Party.Party", "PartyB")
                        .WithMany()
                        .HasForeignKey("PartyBId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("PartyA");

                    b.Navigation("PartyB");
                });

            modelBuilder.Entity("ItEmperor.Party.Roles.PartyRole", b =>
                {
                    b.HasOne("ItEmperor.Party.Party", "Party")
                        .WithMany("PartyRoles")
                        .HasForeignKey("PartyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ItEmperor.Party.Roles.PartyRoleType", "RoleType")
                        .WithMany()
                        .HasForeignKey("RoleTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Party");

                    b.Navigation("RoleType");
                });

            modelBuilder.Entity("ItEmperor.Party.Classifications.Organizations.IncomePartyType", b =>
                {
                    b.OwnsOne("ItEmperor.Party.Classifications.Organizations.Income", "IncomeFrom", b1 =>
                        {
                            b1.Property<Guid>("IncomePartyTypeId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Currency")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("MillionsCount")
                                .HasColumnType("int");

                            b1.HasKey("IncomePartyTypeId");

                            b1.ToTable("PartyType");

                            b1.WithOwner()
                                .HasForeignKey("IncomePartyTypeId");
                        });

                    b.OwnsOne("ItEmperor.Party.Classifications.Organizations.Income", "IncomeTo", b1 =>
                        {
                            b1.Property<Guid>("IncomePartyTypeId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Currency")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("MillionsCount")
                                .HasColumnType("int");

                            b1.HasKey("IncomePartyTypeId");

                            b1.ToTable("PartyType");

                            b1.WithOwner()
                                .HasForeignKey("IncomePartyTypeId");
                        });

                    b.Navigation("IncomeFrom");

                    b.Navigation("IncomeTo");
                });

            modelBuilder.Entity("ItEmperor.Party.Organizations.Organization", b =>
                {
                    b.OwnsMany("ItEmperor.Party.Addresses.Complex.Placement", "Placements", b1 =>
                        {
                            b1.Property<Guid>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("uniqueidentifier");

                            b1.Property<DateTimeOffset>("EffectiveDate")
                                .HasColumnType("datetimeoffset");

                            b1.Property<DateTimeOffset?>("EndDate")
                                .HasColumnType("datetimeoffset");

                            b1.Property<Guid>("OrganizationId")
                                .HasColumnType("uniqueidentifier");

                            b1.HasKey("Id");

                            b1.HasIndex("OrganizationId");

                            b1.ToTable("Placement");

                            b1.WithOwner()
                                .HasForeignKey("OrganizationId");

                            b1.OwnsOne("ItEmperor.Party.Addresses.Complex.Site", "Site", b2 =>
                                {
                                    b2.Property<Guid>("PlacementId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<string>("AddressText")
                                        .IsRequired()
                                        .HasColumnType("nvarchar(max)");

                                    b2.Property<string>("Purpose")
                                        .IsRequired()
                                        .HasColumnType("nvarchar(max)");

                                    b2.HasKey("PlacementId");

                                    b2.ToTable("Placement");

                                    b2.WithOwner()
                                        .HasForeignKey("PlacementId");

                                    b2.OwnsOne("ItEmperor.Party.Addresses.Complex.GeographicLocation", "GeographicLocation", b3 =>
                                        {
                                            b3.Property<Guid>("SitePlacementId")
                                                .HasColumnType("uniqueidentifier");

                                            b3.Property<int>("Type")
                                                .HasColumnType("int");

                                            b3.HasKey("SitePlacementId");

                                            b3.ToTable("Placement");

                                            b3.WithOwner()
                                                .HasForeignKey("SitePlacementId");
                                        });

                                    b2.Navigation("GeographicLocation")
                                        .IsRequired();
                                });

                            b1.Navigation("Site")
                                .IsRequired();
                        });

                    b.Navigation("Placements");
                });

            modelBuilder.Entity("ItEmperor.Party.Relationships.Employments.PositionAssignmentEmployment", b =>
                {
                    b.HasOne("ItEmperor.Party.Organizations.Position", "Position")
                        .WithMany()
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Position");
                });

            modelBuilder.Entity("ItEmperor.Party.Party", b =>
                {
                    b.Navigation("PartyClassifications");

                    b.Navigation("PartyRoles");
                });

            modelBuilder.Entity("ItEmperor.Party.Organizations.Organization", b =>
                {
                    b.Navigation("Positions");
                });

            modelBuilder.Entity("ItEmperor.Party.Persons.Person", b =>
                {
                    b.Navigation("Addresses");
                });
#pragma warning restore 612, 618
        }
    }
}
