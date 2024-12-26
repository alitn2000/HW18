using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopUI.Models.Entities;
using System.Reflection.Emit;

namespace Shop.InferaStructers.Configs;

public class ProductConfig : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasMany(p => p.Orders)
               .WithOne(o => o.Product)
               .HasForeignKey(o => o.ProductId)
               .OnDelete(DeleteBehavior.Restrict);
    }
}
