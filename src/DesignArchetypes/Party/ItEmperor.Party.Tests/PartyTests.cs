using ItEmperor.Shared;
using Xunit;

namespace ItEmperor.Party.Tests;

public class PartyTests
{
    [Fact]
    public void AddParties()
    {
        var person = new Person("Adam", "Mickiewicz");
        var company = new Organization(new TaxId("1234"), "Cesarz Id Sp.z o.o.");

        using var context = new PartyDbContext();
        context.Set<Party>().Add(person);
        context.Set<Party>().Add(company);
        context.SaveChanges();
    }

    [Fact]
    public void PartiesEmployment()
    {
        var person = new Person("Juliusz", "Słowacki");
        var company = new Organization(new TaxId("1235"), "Wacki S.A.");
        

        using var context = new PartyDbContext();
        context.Set<Party>().Add(person);
        context.Set<Party>().Add(company);
        context.SaveChanges();
    }
}