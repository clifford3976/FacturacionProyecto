using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionAplicado.Entidades
{
    public class Producto
    {
        public int Idproducto { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int DepartamentoId { get; set; }
        public int Cantidad { get; set; }

        public Producto(int idproducto, string descripcion, decimal precio, int departamentoId, int cantidad)
        {
            this.Idproducto = idproducto;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.DepartamentoId = departamentoId;
            this.Cantidad = cantidad;
        }

        public Producto()
        {
            this.Idproducto = 0;
            this.Descripcion = string.Empty;
            this.Precio = 0;
            this.DepartamentoId = 0;
            this.Cantidad = 0;
        }
    }
}
