using Data.Entities.IdentityEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.OwnsOne(address => address.Address, x =>
            {
                x.WithOwner();
            });

        }
    }
}
