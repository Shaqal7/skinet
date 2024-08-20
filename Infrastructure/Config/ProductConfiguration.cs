using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Config
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Description).IsRequired();
            builder.Property(p => p.Price).HasColumnType("decimal(18,2)");
            builder.Property(p => p.PictureUrl).IsRequired();
            builder.Property(p => p.Type).IsRequired();
            builder.Property(p => p.Brand).IsRequired();
            builder.Property(p => p.QuantityInStock).IsRequired();
        }
    }
}
