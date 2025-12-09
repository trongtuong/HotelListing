using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.Api.Data.Configurations;

public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
{
    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
        builder.HasData(
            new IdentityRole
            {
                Id = "B832EB48-54FE-4B01-8348-F551552C9E59",
                ConcurrencyStamp = null,
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR"
            },
            new IdentityRole
            {
                Id = "C3FD359A-7CDC-46C6-BD44-FB65938BB639",
                ConcurrencyStamp = null,
                Name = "User",
                NormalizedName = "USER"
            },
            new IdentityRole
            {
                Id = "E74DF3CD-3540-4E55-8B74-C3BBD580E46A",
                ConcurrencyStamp = null,
                Name = "Hotel Admin",
                NormalizedName = "HOTEL ADMIN"
            }
        );
    }
}