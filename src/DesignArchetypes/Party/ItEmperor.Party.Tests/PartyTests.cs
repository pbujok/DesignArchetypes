using System;
using System.Linq;
using ItEmperor.Party.Address.Complex;
using ItEmperor.Party.Organization;
using Xunit;

namespace ItEmperor.Party.Tests;

public class PartyTests
{
    private DateTimeOffset _dateFrom = new DateTimeOffset(new DateTime(2022, 9, 11));

    private DateTimeOffset _dateTo = new DateTimeOffset(new DateTime(2022, 10, 11));

    [Fact]
    public void Parties_create()
    {
        var person = new Person.Person("Adam", "Mickiewicz");
        var company = new Organization.Organization(new TaxId("1234"), "Cesarz Id Sp.z o.o.");

        using var context = new PartyDbContext();
        context.Set<Person.Person>().Add(person);
        context.Set<Organization.Organization>().Add(company);
        context.SaveChanges();
    }

    [Fact]
    public void Parties_Employment_SimpleModel()
    {
        var person = new Person.Person("Juliusz", "Słowacki");
        var company = new Organization.Organization(new TaxId("1235"), "Wacki S.A.");

        using var context = new PartyDbContext();
        context.Set<Person.Person>().Add(person);
        context.Set<Organization.Organization>().Add(company);

        person.AddSimpleEmployment(company, _dateFrom, _dateTo, "Writer");
        context.SaveChanges();
    }

    [Fact]
    public void Parties_Employment_ComplexModel()
    {
        var person = new Person.Person("Juliusz", "Słowacki");
        var company = new Organization.Organization(new TaxId("1235"), "Wacki S.A.");
        company.AddPosition("Writer", 10, 100);

        person.AddComplexEmployment(company.Positions.First(), _dateFrom, _dateTo);

        using var context = new PartyDbContext();
        context.Set<Person.Person>().Add(person);
        context.Set<Organization.Organization>().Add(company);

        context.SaveChanges();
    }

    [Fact]
    public void Parties_Address_SimpleModel()
    {
        var person = new Person.Person("Juliusz", "Słowacki");
        person.AddAddress("Ul. Poetycka 1", "Toruń", "Kujawskie", "21-037", "Main office");

        var company = new Organization.Organization(new TaxId("1235"), "Wacki S.A.");

        var geoLocationStructure = new GeographicLocation("31-037", GeographicLocationType.PostalCode,
            new GeographicLocation("Toruń", GeographicLocationType.City,
                new GeographicLocation("Poland", GeographicLocationType.Country)));

        var site = new Site("Headquoters", "Pl. Kaczora 21/37", geoLocationStructure);

        company.AddPlacement(_dateFrom, null, site);

        using var context = new PartyDbContext();
        context.Set<Person.Person>().Add(person);
        context.Set<Organization.Organization>().Add(company);

        context.SaveChanges();
    }
}