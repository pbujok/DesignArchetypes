using ItEmperor.Party.Addresses.Complex;
using ItEmperor.Party.Organizations;
using ItEmperor.Party.Persons;
using ItEmperor.Party.Tests.Repositories;
using Xunit;

namespace ItEmperor.Party.Tests;

public class PartyTests
{
    [Fact]
    public void Parties_create()
    {
        var person = new Person("Adam", "Mickiewicz");
        var company = new Organization(new TaxId("1234"), "Cesarz Id Sp.z o.o.");
        
        var repo = new PartyRepository();
        repo.Add(person);
        repo.Add(company);
    }

    [Fact]
    public void Parties_Employment_SimpleModel()
    {
        var person = new Person("Juliusz", "Słowacki");
        var company = new Organization(new TaxId("1235"), "Wacki S.A.");

        var relation = new SimpleEmployment(company, person, TestData.Date1, TestData.Date2, "Writer");

        var repo = new PartyRepository();
        repo.Add(person);
        repo.Add(company);

        using var context = new PartyDbContext();
        context.Attach(person);
        context.Attach(company);
        context.Set<SimpleEmployment>().Add(relation);
        context.SaveChanges();
    }
    
    [Fact]
    public void Parties_Address_SimpleModel()
    {
        var person = new Person("Juliusz", "Słowacki");
        person.AddAddress("Ul. Poetycka 1", "Toruń", "Kujawskie", "21-037", "Main office");

        var company = new Organization(new TaxId("1235"), "Wacki S.A.");

        var geoLocationStructure = new GeographicLocation("31-037", GeographicLocationType.PostalCode,
            new GeographicLocation("Toruń", GeographicLocationType.City,
                new GeographicLocation("Poland", GeographicLocationType.Country)));

        var site = new Site("Headquoters", "Pl. Kaczora 21/37", geoLocationStructure);

        company.AddPlacement(TestData.Date1, null, site);

        var repo = new PartyRepository();
        repo.Add(person);
        repo.Add(company);
    }
}