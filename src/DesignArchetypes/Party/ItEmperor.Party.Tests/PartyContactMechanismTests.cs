using ItEmperor.Party.Tests.Repositories;
using Xunit;

namespace ItEmperor.Party.Tests;

public class PartyContactMechanismTests
{
    private PartyRepository _partyRepository = new();

    [Fact]
    public void AssignPartyContactMechanism_AssignTelephoneNumber_MechanismAssigned()
    {
        var person = TestData.People.Slowacki;
        person.AddTelephone("Main telephone", "555 666 777", TestData.Date1);

        var company = TestData.Organizations.CesarzIt;
        company.AddTelephone("Main", "6666666", TestData.Date1);
        company.AddTelephone("Secretary", "45354354", TestData.Date1);

        _partyRepository.Add(person);
        _partyRepository.Add(company);
    }
    
    [Fact]
    public void AssignPartyContactMechanisms_AssignMany_MechanismsAssigned()
    {
        var person = TestData.People.Slowacki;
        person.AddTelephone("Main telephone", "555 666 777", TestData.Date1);
        person.AddEmail("test@test.pl", TestData.Date1);

        _partyRepository.Add(person);
    }
}