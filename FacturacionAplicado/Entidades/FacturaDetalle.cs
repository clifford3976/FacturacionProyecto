using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FacturacionAplicado.Entidades
{
   public  class FacturaDetalle
    {
        public int Id { get; set; }
        public int FacturaId { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public string Descripcion { get; set; }
        [NotMapped]
        public decimal Importe { get; set; }

        public FacturaDetalle(int id, int facturaId, int productoId, int cantidad, decimal precio, string descripcion, decimal importe)
        {
            this.Id = id;
            this.FacturaId = facturaId;
            this.ProductoId = productoId;
            this.Cantidad = cantidad;
            this.Precio = precio;
            this.Descripcion = descripcion;
            this.Importe = importe;
        }

        public FacturaDetalle()
        {

            this.Id = 0;
            this.FacturaId = 0;
            this.ProductoId = 0;
            this.Cantidad = 0;
            this.Precio = 0;
            this.Descripcion = string.Empty;
            this.Importe = 0;
        }
    }
}
