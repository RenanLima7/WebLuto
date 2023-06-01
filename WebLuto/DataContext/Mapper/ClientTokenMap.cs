﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebLuto.Common;
using WebLuto.Models;

namespace WebLuto.DataContext.Mapper
{
    public class ClientTokenMap : BaseMapper<ClientToken>
    {
        public ClientTokenMap()
        { }

        public override void Configure(EntityTypeBuilder<ClientToken> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Token).IsRequired().HasMaxLength(10);

            //builder.Property(x => x.ClientId).IsRequired();
            //builder.HasOne(x => x.Client)
            //       .WithOne(c => c.ClientToken)
            //       .HasForeignKey<Client>(c => c.Id);
        }
    }
}
