using ItEmperor.Party.Roles;
using ItEmperor.Party.Roles.PartyRoles;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItEmperor.Party.Tests.Configurations.Roles;

public class PartyRoleConfiguration : PartyRoleConfigurationBase<PartyRole>
{
    protected override void ConfigureDerivedType(EntityTypeBuilder<PartyRole> builder)
    {
        builder.HasKey(x => x.Id);
    }
}

public abstract class PartyRoleConfigurationBase<T> : IEntityTypeConfiguration<T>
    where T : PartyRole
{
    public void Configure(EntityTypeBuilder<T> builder)
    {
        builder.ToTable("PartyRole");
        
        ConfigureDerivedType(builder);
    }

    protected abstract void ConfigureDerivedType(EntityTypeBuilder<T> builder);
}