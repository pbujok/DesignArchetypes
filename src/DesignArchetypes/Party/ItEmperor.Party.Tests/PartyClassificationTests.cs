using System;
using System.Linq;
using ItEmperor.Party.Classifications;
using ItEmperor.Party.Classifications.Organizations;
using ItEmperor.Party.Classifications.Persons;
using ItEmperor.Party.Organizations;
using ItEmperor.Party.Persons;
using Xunit;

namespace ItEmperor.Party.Tests;

public class PartyClassificationTests
{
    [Fact]
    public void PartyClassification_ProgressingIncomeClassification_MultipleClassificationsInTimeline()
    {
        var company = TestData.Organizations.CesarzIt;

        company.AddIncomeClassification(TestData.Date1, TestData.Date2, IncomePartyType.MicroCompany);
        company.AddIncomeClassification(TestData.Date2, TestData.Date3, IncomePartyType.MediumCompany);
        company.AddIncomeClassification(TestData.Date3, null, IncomePartyType.LargeCompany);

        using var context = new PartyDbContext();
        AttachOrAddIfExists(context, IncomePartyType.MicroCompany);
        AttachOrAddIfExists(context, IncomePartyType.MediumCompany);
        AttachOrAddIfExists(context, IncomePartyType.LargeCompany);

        context.Set<Organization>().Add(company);
        context.SaveChanges();
    }

    [Fact]
    public void PartyClassification_PersonSexClassification()
    {
        var person = TestData.People.Slowacki;
        var sexPartyType = SexPartyType.Female;
        person.SetSex(TestData.Date1, sexPartyType);

        using var context = new PartyDbContext();
        AttachOrAddIfExists(context, sexPartyType);
        context.Set<Person>().Add(person);
        context.SaveChanges();
    }

    [Fact]
    public void PartyClassification_CustomClassifications()
    {
        var person = TestData.People.StevenSeagal;
        var birthDate = new DateTimeOffset(new DateTime(1952, 4, 10));
        var becomeRusDate = new DateTimeOffset(new DateTime(2016, 11, 3));

        var usNationality = new PartyType("USA Nationality")
        {
            Id = new Guid("f6f530e7-d9f5-45da-9dc7-dff91d5e0506")
        };

        var rusNationality = new PartyType("Ruska onuca")
        {
            Id = new Guid("15249d9a-2bd7-4975-9135-00f0cdddd9ad")
        };

        var classification = new PartyClassification(birthDate, becomeRusDate, person, usNationality);
        var classificationUpdate = new PartyClassification(becomeRusDate, null, person, rusNationality);

        using var context = new PartyDbContext();
        AttachOrAddIfExists(context, rusNationality);
        AttachOrAddIfExists(context, usNationality);

        context.Set<Person>().Add(person);
        context.Set<PartyClassification>().Add(classification);
        context.Set<PartyClassification>().Add(classificationUpdate);
        context.SaveChanges();
    }

    private static void AttachOrAddIfExists(PartyDbContext context, PartyType type)
    {
        if (context.Set<PartyType>().Any(x => x.Id == type.Id))
        {
            context.Attach(type);
        }
        else
        {
            context.Set<PartyType>().Add(type);
        }
    }
    
}