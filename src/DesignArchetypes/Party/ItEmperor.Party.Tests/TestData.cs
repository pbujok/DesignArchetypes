using System;
using ItEmperor.Party.Organizations;
using ItEmperor.Party.Persons;

namespace ItEmperor.Party.Tests;

public static class TestData
{
    public static readonly DateTimeOffset Date1 = new DateTimeOffset(new DateTime(2000, 9, 11));

    public static readonly DateTimeOffset Date2 = new DateTimeOffset(new DateTime(2019, 11, 11));
    
    public static readonly DateTimeOffset Date3 = new DateTimeOffset(new DateTime(2022, 9, 15));

    public static class Organizations
    {
        public static Organization CesarzIt => new Organization(new TaxId("1234"), "Cesarz It Sp.z o.o.");
    }

    public static class People
    {
        public static Person Slowacki => new Person("Juliusz", "Słowacki");
        
        public static Person StevenSeagal => new Person("Steven", "Seagal");
    }
    
}