using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionAplicado.Entidades
{
   public  class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public string NombreUsuario { get; set; }
        public string Fecha { get; set; }
        public string Comentario { get; set; }

        public Usuario(int idUsuario, string nombre, string clave, string nombreUsuario, string fecha, string comentario)
        {
            this.IdUsuario = idUsuario;
            this.Nombre = nombre;
            this.Clave = clave;
            this.NombreUsuario = nombreUsuario;
            this.Fecha = fecha;
            this.Comentario = comentario;
        }

        public Usuario()
        {
            this.IdUsuario = 0;
            this.Nombre = string.Empty;
            this.Clave = string.Empty;
            this.NombreUsuario = string.Empty;
            this.Fecha = string.Empty;
            this.Comentario = string.Empty;
        }
    }
}
