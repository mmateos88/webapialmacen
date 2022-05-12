using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAPIAlmacen.Entidades;

namespace WebAPIAlmacen.Configuraciones
{
    public class ProductoConfig: IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.Property(x => x.Nombre).HasMaxLength(150).IsRequired();
            builder.Property(x => x.Precio).HasPrecision(precision: 9, scale: 2);
            builder.Property(x => x.FechaAlta).HasColumnType("date");
        }
    }
}
