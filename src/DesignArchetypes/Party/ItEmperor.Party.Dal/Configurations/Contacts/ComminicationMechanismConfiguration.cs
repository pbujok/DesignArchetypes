using ItEmperor.Party.Contact;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItEmperor.Party.Tests.Configurations.Contacts;

public class ContactMechanismConfiguration : ContactMechanismConfigurationBase<ContactMechanism>
{
    protected override void ConfigureEntity(EntityTypeBuilder<ContactMechanism> builder)
    {
        builder.HasKey(x => x.Id);
    }
}

public abstract class ContactMechanismConfigurationBase<T> : IEntityTypeConfiguration<ContactMechanism>
    where T : ContactMechanism
{
    public void Configure(EntityTypeBuilder<ContactMechanism> builder)
    {
        builder.ToTable("ContactMechanism");
    }

    protected abstract void ConfigureEntity(EntityTypeBuilder<ContactMechanism> builder);
}