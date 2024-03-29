﻿using ItEmperor.Party.Addresses.Complex;
using ItEmperor.Party.Organizations;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItEmperor.Party.Tests.Configurations;

public class OrganizationConfiguration : PartyConfigurationBase<Organization>
{
    public override void Configure(EntityTypeBuilder<Organization> builder)
    {
        base.Configure(builder);
        
        builder.Property(x => x.TaxId)
            .HasConversion(x => x.Value, val => new TaxId(val));
        
        builder.OwnsMany(x=>x.Placements, navigationBuilder =>
        {
            navigationBuilder.HasKey(x => x.Id);

            navigationBuilder.OwnsOne(x => x.Site, siteBuilder =>
            {
                siteBuilder.OwnsOne(x => x.GeographicLocation, location =>
                {
                    location.Property(p => p.Type).HasConversion<int>(
                        c => (int)c,
                        c => (GeographicLocationType)c);
                });
            });
        });
    }
}