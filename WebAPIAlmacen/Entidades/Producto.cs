﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIAlmacen.Entidades
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        [Precision(precision:9,scale:2)]
        public decimal Precio { get; set; }

        [Column(TypeName ="Date")]
        public DateTime FechaAlta { get; set; }
        public bool Descatalogado { get; set; }
        public string FotoURL { get; set; }
        public UbicacionProducto UbicacionProducto { get; set; }
        public int FamiliaId { get; set; }
        public Familia Familia { get; set; }
        public ICollection<Distribuidor> Distribuidores { get; set; }
        public ICollection<DistribuidorProducto> DistribuidoresProductos { get; set; }
    }
}
