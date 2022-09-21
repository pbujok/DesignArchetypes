using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ItEmperor.Party.Tests.Migrations
{
    public partial class PartyInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactMechanism",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContactMechanismType = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactMechanism", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Party",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaxId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Party", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PartyType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IncomeFrom_MillionsCount = table.Column<int>(type: "int", nullable: true),
                    IncomeFrom_Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IncomeTo_MillionsCount = table.Column<int>(type: "int", nullable: true),
                    IncomeTo_Currency = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartyType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PartyContactMechanism",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContactMechanismId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PartyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FromDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ToDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartyContactMechanism", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PartyContactMechanism_ContactMechanism_ContactMechanismId",
                        column: x => x.ContactMechanismId,
                        principalTable: "ContactMechanism",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartyContactMechanism_Party_PartyId",
                        column: x => x.PartyId,
                        principalTable: "Party",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Placement",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EffectiveDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    EndDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Site_Purpose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Site_AddressText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Site_GeographicLocation_Type = table.Column<int>(type: "int", nullable: false),
                    OrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Placement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Placement_Party_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Party",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HourSalaryFrom = table.Column<int>(type: "int", nullable: false),
                    HourSalaryTo = table.Column<int>(type: "int", nullable: false),
                    OrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Position_Party_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Party",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SimpleAddress",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SimpleAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SimpleAddress_Party_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Party",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SimpleEmployment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PostName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SimpleEmployment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SimpleEmployment_Party_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Party",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SimpleEmployment_Party_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Party",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PartyClassification",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FromDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    EndDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    PartyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartyClassification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PartyClassification_Party_PartyId",
                        column: x => x.PartyId,
                        principalTable: "Party",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartyClassification_PartyType_TypeId",
                        column: x => x.TypeId,
                        principalTable: "PartyType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PartyRelationshipType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FromId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ToId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartyRelationshipType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PartyRelationshipType_RoleType_FromId",
                        column: x => x.FromId,
                        principalTable: "RoleType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PartyRelationshipType_RoleType_ToId",
                        column: x => x.ToId,
                        principalTable: "RoleType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PartyRole",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateFrom = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DateTo = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    PartyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartyRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PartyRole_Party_PartyId",
                        column: x => x.PartyId,
                        principalTable: "Party",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartyRole_RoleType_RoleTypeId",
                        column: x => x.RoleTypeId,
                        principalTable: "RoleType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PartyRelationship",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FromId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ToId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    EndDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    PartyRelationshipTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PositionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartyRelationship", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PartyRelationship_PartyRelationshipType_PartyRelationshipTypeId",
                        column: x => x.PartyRelationshipTypeId,
                        principalTable: "PartyRelationshipType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PartyRelationship_PartyRole_FromId",
                        column: x => x.FromId,
                        principalTable: "PartyRole",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PartyRelationship_PartyRole_ToId",
                        column: x => x.ToId,
                        principalTable: "PartyRole",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PartyRelationship_Position_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Position",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PartyClassification_PartyId",
                table: "PartyClassification",
                column: "PartyId");

            migrationBuilder.CreateIndex(
                name: "IX_PartyClassification_TypeId",
                table: "PartyClassification",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PartyContactMechanism_ContactMechanismId",
                table: "PartyContactMechanism",
                column: "ContactMechanismId");

            migrationBuilder.CreateIndex(
                name: "IX_PartyContactMechanism_PartyId",
                table: "PartyContactMechanism",
                column: "PartyId");

            migrationBuilder.CreateIndex(
                name: "IX_PartyRelationship_FromId",
                table: "PartyRelationship",
                column: "FromId");

            migrationBuilder.CreateIndex(
                name: "IX_PartyRelationship_PartyRelationshipTypeId",
                table: "PartyRelationship",
                column: "PartyRelationshipTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PartyRelationship_PositionId",
                table: "PartyRelationship",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_PartyRelationship_ToId",
                table: "PartyRelationship",
                column: "ToId");

            migrationBuilder.CreateIndex(
                name: "IX_PartyRelationshipType_FromId",
                table: "PartyRelationshipType",
                column: "FromId");

            migrationBuilder.CreateIndex(
                name: "IX_PartyRelationshipType_ToId",
                table: "PartyRelationshipType",
                column: "ToId");

            migrationBuilder.CreateIndex(
                name: "IX_PartyRole_PartyId",
                table: "PartyRole",
                column: "PartyId");

            migrationBuilder.CreateIndex(
                name: "IX_PartyRole_RoleTypeId",
                table: "PartyRole",
                column: "RoleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Placement_OrganizationId",
                table: "Placement",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Position_OrganizationId",
                table: "Position",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_SimpleAddress_PersonId",
                table: "SimpleAddress",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_SimpleEmployment_OrganizationId",
                table: "SimpleEmployment",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_SimpleEmployment_PersonId",
                table: "SimpleEmployment",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PartyClassification");

            migrationBuilder.DropTable(
                name: "PartyContactMechanism");

            migrationBuilder.DropTable(
                name: "PartyRelationship");

            migrationBuilder.DropTable(
                name: "Placement");

            migrationBuilder.DropTable(
                name: "SimpleAddress");

            migrationBuilder.DropTable(
                name: "SimpleEmployment");

            migrationBuilder.DropTable(
                name: "PartyType");

            migrationBuilder.DropTable(
                name: "ContactMechanism");

            migrationBuilder.DropTable(
                name: "PartyRelationshipType");

            migrationBuilder.DropTable(
                name: "PartyRole");

            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropTable(
                name: "RoleType");

            migrationBuilder.DropTable(
                name: "Party");
        }
    }
}
