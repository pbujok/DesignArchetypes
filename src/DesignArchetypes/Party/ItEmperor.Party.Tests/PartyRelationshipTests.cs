using System.Linq;
using ItEmperor.Party.Organizations;
using ItEmperor.Party.Persons;
using ItEmperor.Party.Relationships;
using ItEmperor.Party.Relationships.Employments;
using ItEmperor.Party.Roles.PartyRoles;
using ItEmperor.Party.Roles.RoleTypes;
using ItEmperor.Party.Tests.Repositories;
using Xunit;

namespace ItEmperor.Party.Tests;

public class PartyRelationshipTests
{
    PartyRepository _partyRepo = new PartyRepository();

    PartyRelationshipRepository _repo = new PartyRelationshipRepository();

    [Fact]
    public void PartyRelationship_ComplexEmploymentModel_PositionAssignedToPersonInCompany()
    {
        // Arrange
        AddIfNotExists(PartyRoleType.Employee);
        AddIfNotExists(PartyRoleType.Employer);
        AddIfNotExists(PartyRelationshipType.Employment);

        var person = TestData.People.Slowacki;
        var company = TestData.Organizations.CesarzIt;
        company.AddPosition("Writer", 10, 100);

        _partyRepo.Add(person);
        _partyRepo.Add(company);

        var employeeRole = new EmployeePartyRole(TestData.Date1, null, person, PartyRoleType.Employee);
        var employerRole = new EmployerPartyRole(TestData.Date1, null, company, PartyRoleType.Employer);

        // Act

        var employmentRelation =
            new PositionAssignmentEmployment(employerRole, employeeRole, TestData.Date1, null,
                company.Positions.First());

        _repo.Add(employmentRelation);
    }

    [Fact]
    public void CustomerRelationship_CompaniesRelationship_RelationAssigned()
    {
        // Arrange
        AddIfNotExists(PartyRoleType.Customer);
        AddIfNotExists(PartyRoleType.Provider);
        AddIfNotExists(PartyRelationshipType.Customer);

        var company1 = TestData.Organizations.CesarzIt;
        var company2 = TestData.Organizations.JablkoSa;

        _partyRepo.Add(company1);
        _partyRepo.Add(company2);

        var customerRole = new CustomerPartyRole(TestData.Date1, null, company1);
        var providerRole = new ProviderPartyRole(TestData.Date1, null, company2);

        // Act

        _repo.Add(new CustomerPartyRelationship(customerRole, providerRole, TestData.Date1, TestData.Date2,
            "Buys apples"));
    }

    private static void AddIfNotExists(PartyRelationshipType type)
    {
        using var context = new PartyDbContext();
        if (!context.Set<PartyRelationshipType>().Any(x => x.Id == type.Id))
        {
            context.Attach(type.From);
            context.Attach(type.To);
            context.Set<PartyRelationshipType>().Add(type);
        }

        context.SaveChanges();
    }

    private static void AddIfNotExists(PartyRoleType type)
    {
        using var context = new PartyDbContext();
        if (!context.Set<PartyRoleType>().Any(x => x.Id == type.Id))
        {
            context.Set<PartyRoleType>().Add(type);
        }

        context.SaveChanges();
    }
}