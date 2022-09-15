using System;
using System.Linq;
using ItEmperor.Party.Organizations;
using ItEmperor.Party.Persons;
using ItEmperor.Party.Roles;
using Xunit;

namespace ItEmperor.Party.Tests;

public class PartyRoleTests
{
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

        using var context = new PartyDbContext();
        AttachOrAddIfExists(context, customerRole);
        context.Set<Person>().Add(person);
        context.Set<Organization>().Add(organization);
        context.SaveChanges();
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