using ItEmperor.Party.Contact;
using ItEmperor.Party.Contact.ContactMechanisms;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItEmperor.Party.Tests.Configurations.Contacts;

public class EmailContactMechanismConfiguration : ContactMechanismConfigurationBase<EmailContactMechanism>
{
    protected override void ConfigureEntity(EntityTypeBuilder<ContactMechanism> builder)
    {
    }
}