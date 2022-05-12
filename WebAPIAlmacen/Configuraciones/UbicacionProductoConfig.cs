using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAPIAlmacen.Entidades;


namespace WebAPIAlmacen.Configuraciones
{
    public class UbicacionProductoConfig : IEntityTypeConfiguration<UbicacionProducto>
    {
        public void Configure(EntityTypeBuilder<UbicacionProducto> builder)
        {
           
        }
    }
}
