using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ItEmperor.Party.Tests.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "TelephoneNumber",
                columns: table => new
                {
                    PartyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelephoneNumber", x => new { x.PartyId, x.Id });
                    table.ForeignKey(
                        name: "FK_TelephoneNumber_Party_PartyId",
                        column: x => x.PartyId,
                        principalTable: "Party",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PartyRelationship",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PartyAId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PartyBId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    EndDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PositionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PostName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartyRelationship", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PartyRelationship_Party_PartyAId",
                        column: x => x.PartyAId,
                        principalTable: "Party",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PartyRelationship_Party_PartyBId",
                        column: x => x.PartyBId,
                        principalTable: "Party",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PartyRelationship_Position_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Position",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PartyRelationship_PartyAId",
                table: "PartyRelationship",
                column: "PartyAId");

            migrationBuilder.CreateIndex(
                name: "IX_PartyRelationship_PartyBId",
                table: "PartyRelationship",
                column: "PartyBId");

            migrationBuilder.CreateIndex(
                name: "IX_PartyRelationship_PositionId",
                table: "PartyRelationship",
                column: "PositionId");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PartyRelationship");

            migrationBuilder.DropTable(
                name: "Placement");

            migrationBuilder.DropTable(
                name: "SimpleAddress");

            migrationBuilder.DropTable(
                name: "TelephoneNumber");

            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropTable(
                name: "Party");
        }
    }
}
