using System.Linq;
using ItEmperor.Party.Addresses.Complex;
using ItEmperor.Party.Organizations;
using ItEmperor.Party.Persons;
using ItEmperor.Party.Relationships;
using ItEmperor.Party.Relationships.Employments;
using Xunit;

namespace ItEmperor.Party.Tests;

public class PartyTests
{
    [Fact]
    public void Parties_create()
    {
        var person = new Person("Adam", "Mickiewicz");
        person.AddTelephone("Mobile", "0700880777");
        var company = new Organization(new TaxId("1234"), "Cesarz Id Sp.z o.o.");
        company.AddTelephone("Office", "555 555 22");
        company.AddTelephone("Boss", "021 333 777");

        using var context = new PartyDbContext();
        context.Set<Person>().Add(person);
        context.Set<Organization>().Add(company);
        context.SaveChanges();
    }

    [Fact]
    public void Parties_Employment_SimpleModel()
    {
        var person = new Person("Juliusz", "Słowacki");
        var company = new Organization(new TaxId("1235"), "Wacki S.A.");

        var relation = new SimpleEmployment(company, person, TestData.Date1, TestData.Date2, "Writer");

        using var context = new PartyDbContext();
        context.Set<Person>().Add(person);
        context.Set<Organization>().Add(company);
        context.Set<PartyRelationship>().Add(relation);
        context.SaveChanges();
    }

    [Fact]
    public void Parties_Employment_ComplexModel()
    {
        var person = new Person("Juliusz", "Słowacki");
        var company = new Organization(new TaxId("1235"), "Wacki S.A.");
        company.AddPosition("Writer", 10, 100);

        var employmentRelation =
            new PositionAssignmentEmployment(company, person, TestData.Date1, null, company.Positions.First());

        using var context = new PartyDbContext();
        context.Set<Person>().Add(person);
        context.Set<Organization>().Add(company);
        context.Set<PartyRelationship>().Add(employmentRelation);

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

        using var context = new PartyDbContext();
        context.Set<Person>().Add(person);
        context.Set<Organization>().Add(company);
        context.SaveChanges();
    }
}