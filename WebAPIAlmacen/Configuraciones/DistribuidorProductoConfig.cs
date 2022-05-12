using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAPIAlmacen.Entidades;


namespace WebAPIAlmacen.Configuraciones
{
    public class DistribuidorProductoConfig : IEntityTypeConfiguration<DistribuidorProducto>
    {
        public void Configure(EntityTypeBuilder<DistribuidorProducto> builder)
        {
            builder.HasKey(x => new { x.DistribuidorId, x.ProductoId });
        }
    }
}
