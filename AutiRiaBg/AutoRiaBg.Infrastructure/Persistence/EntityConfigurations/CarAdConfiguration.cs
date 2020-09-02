namespace AutoRiaBg.Infrastructure.Persistence.EntityConfigurations
{
    using AutoRiaBg.Domain.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System;
    public class CarAdConfiguration : IEntityTypeConfiguration<CarAd>
    {
        public void Configure(EntityTypeBuilder<CarAd> builder)
        {
            //builder.Property()
        }
    }
}
