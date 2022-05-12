using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAPIAlmacen.Entidades;


namespace WebAPIAlmacen.Configuraciones
{
    public class DistribuidorConfig : IEntityTypeConfiguration<Distribuidor>
    {
        public void Configure(EntityTypeBuilder<Distribuidor> builder)
        {
            builder.Property(x => x.Nombre).HasMaxLength(150).IsRequired();        
        }
    }
}
