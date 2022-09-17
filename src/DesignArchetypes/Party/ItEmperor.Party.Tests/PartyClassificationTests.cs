using System;
using System.Linq;
using ItEmperor.Party.Classifications;
using ItEmperor.Party.Classifications.Organizations;
using ItEmperor.Party.Classifications.Persons;
using ItEmperor.Party.Tests.Repositories;
using Xunit;

namespace ItEmperor.Party.Tests;

public class PartyClassificationTests
{
    private PartyRepository _partyRepository = new();
    
    [Fact]
    public void PartyClassification_ProgressingIncomeClassification_MultipleClassificationsInTimeline()
    {
        AddIfNotExists(IncomePartyType.MicroCompany);
        AddIfNotExists(IncomePartyType.MediumCompany);
        AddIfNotExists(IncomePartyType.LargeCompany);
        
        var company = TestData.Organizations.CesarzIt;

        company.AddIncomeClassification(TestData.Date1, TestData.Date2, IncomePartyType.MicroCompany);
        company.AddIncomeClassification(TestData.Date2, TestData.Date3, IncomePartyType.MediumCompany);
        company.AddIncomeClassification(TestData.Date3, null, IncomePartyType.LargeCompany);

        _partyRepository.Add(company);
    }

    [Fact]
    public void PartyClassification_PersonSexClassification()
    {
        AddIfNotExists(SexPartyType.Female);
        
        var person = TestData.People.Slowacki;
        person.SetSex(TestData.Date1, SexPartyType.Female);
        
        _partyRepository.Add(person);
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

        
        AddIfNotExists(usNationality);
        AddIfNotExists(rusNationality);

        _partyRepository.Add(person);
        
        using var context = new PartyDbContext();
        context.Attach(person);
        context.Attach(rusNationality);
        context.Attach(usNationality);
        context.Set<PartyClassification>().Add(classification);
        context.Set<PartyClassification>().Add(classificationUpdate);
        context.SaveChanges();
    }

    private static void AddIfNotExists(PartyType type)
    {
        using var context = new PartyDbContext();
        if (!context.Set<PartyType>().Any(x => x.Id == type.Id))
        {
            context.Set<PartyType>().Add(type);
        }
    }
    
}