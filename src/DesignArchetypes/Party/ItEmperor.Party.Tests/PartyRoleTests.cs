using System;
using System.Linq;
using ItEmperor.Party.Organizations;
using ItEmperor.Party.Persons;
using ItEmperor.Party.Roles;
using ItEmperor.Party.Tests.Repositories;
using Xunit;

namespace ItEmperor.Party.Tests;

public class PartyRoleTests
{
    private PartyRepository _partyRepository = new();
    
    [Fact]
    public void AssignPartyRole_AssignRole_RoleAssigned()
    {
        var customerRole = new PartyRoleType("Customer")
        {
            Id = new Guid("fb69ef56-647a-43d7-850c-10727613a249")
        };

        var person = TestData.People.Slowacki;
        person.AddRole(TestData.Date1, null, customerRole);

        var organization = TestData.Organizations.CesarzIt;
        organization.AddRole(TestData.Date1, null, customerRole);
        
        
        _partyRepository.Add(person);
        _partyRepository.Add(organization);
    }

    private static void AttachOrAddIfExists(PartyDbContext context, RoleType type)
    {
        if (context.Set<RoleType>().Any(x => x.Id == type.Id))
        {
            context.Attach(type);
        }
        else
        {
            context.Set<RoleType>().Add(type);
        }
    }
}