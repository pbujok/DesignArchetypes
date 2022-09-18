using ItEmperor.Party.Classifications;
using ItEmperor.Party.Roles;
using ItEmperor.Party.Roles.RoleTypes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItEmperor.Party.Tests.Configurations.Roles;

public class RoleTypeConfiguration : RoleTypeConfigurationBase<RoleType>
{
    protected override void ConfigureDerivedType(EntityTypeBuilder<RoleType> builder)
    {
        builder.HasKey(x => x.Id);
    }
}

public abstract class RoleTypeConfigurationBase<T> : IEntityTypeConfiguration<T>
    where T : RoleType
{
    public void Configure(EntityTypeBuilder<T> builder)
    {
        builder.ToTable("RoleType");
        
        ConfigureDerivedType(builder);
    }

    protected abstract void ConfigureDerivedType(EntityTypeBuilder<T> builder);
}