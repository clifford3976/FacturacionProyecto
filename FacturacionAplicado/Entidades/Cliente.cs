using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionAplicado.Entidades
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }

        public Cliente(int idCliente, string nombre, string direccion, string cedula, string telefono)
        {
            this.IdCliente = idCliente;
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Cedula = cedula;
            this.Telefono = telefono;
        }

        public Cliente()
        {
            this.IdCliente = 0;
            this.Nombre = string.Empty;
            this.Direccion = string.Empty;
            this.Cedula = string.Empty;
            this.Telefono = string.Empty;
        }
    }
}
