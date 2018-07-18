using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using FacturacionAplicado.Entidades;

namespace FacturacionAplicado.BLL
{
    public class FacturacionBLL
    {

        private static Usuario user = new Usuario();



        public static DataTable Consultar()
        {


            DataTable dt = new DataTable();

            MySqlDataAdapter con = new MySqlDataAdapter("select * from Facturas",  ConexionGlobal.ConexionGlobalDb.RetornarConexion());
            try
            {


                con.Fill(dt);



            }
            catch (Exception)
            {

                throw;
            }
            return dt;
        }

        public static bool Eliminar(string id)
        {

            MySqlDataAdapter dater = new MySqlDataAdapter();
            bool estado = true;
            try
            {

                dater.DeleteCommand = new MySqlCommand(" delete from Facturas where FacturaId=" + id,  ConexionGlobal.ConexionGlobalDb.RetornarConexion());

                dater.DeleteCommand.Connection =  ConexionGlobal.ConexionGlobalDb.RetornarConexion();
                dater.DeleteCommand.ExecuteNonQuery();

            }
            catch (Exception)
            {
                estado = false;
                throw;

            }

            return estado;
        }

        public static bool Guardar(Factura factura)
        {
            MySqlDataAdapter dater = new MySqlDataAdapter();
            bool estado = true;
            try
            {

                dater.InsertCommand = new MySqlCommand("insert into Facturas (Monto,UsuarioId,ClienteId,Fecha,Descripcion,FormaDePago,Devuelta,EfectivoRecibido) values" +
                    " ('" + factura.Monto + "','" + factura.UsuarioId + "','" + factura.ClienteId + "','" + factura.Fecha + "','" + factura.Descripcion + "','" + factura.FormaDePago + "','" + factura.Devuelta + "','" + factura.EfectivoRecibido + "')",  ConexionGlobal.ConexionGlobalDb.RetornarConexion());

                dater.InsertCommand.Connection =  ConexionGlobal.ConexionGlobalDb.RetornarConexion();
                dater.InsertCommand.ExecuteNonQuery();

            }
            catch (Exception)
            {
                estado = false;
                throw;

            }

            return estado;
        }

        //asi se pone un datatable en una lista 
        public static List<Factura> Buscar()
        {

            DataTable dt = new DataTable();


            MySqlDataAdapter con = new MySqlDataAdapter("select * from Facturas",  ConexionGlobal.ConexionGlobalDb.RetornarConexion());
            try
            {


                con.Fill(dt);



            }
            catch (Exception)
            {

                throw;
            }



            List<Factura> listName = dt.AsEnumerable().Select(m => new Factura()
            {
                FacturaId = m.Field<int>("FacturaId"),
                Monto = m.Field<decimal>("Monto"),
                UsuarioId = m.Field<int>("UsuarioId"),
                ClienteId = m.Field<int>("ClienteId"),
                Fecha = m.Field<string>("Fecha"),
                Descripcion = m.Field<string>("Descripcion"),
                FormaDePago = m.Field<string>("FormaDePago"),
                Devuelta = m.Field<decimal>("Devuelta"),
                EfectivoRecibido = m.Field<decimal>("EfectivoRecibido")

            }).ToList();


            return listName;
        }

        public static List<Factura> Buscar(string id)
        {

            DataTable dt = new DataTable();


            MySqlDataAdapter con = new MySqlDataAdapter("select * from Facturas where FacturaId=" + id,  ConexionGlobal.ConexionGlobalDb.RetornarConexion());
            try
            {


                con.Fill(dt);
                 ConexionGlobal.ConexionGlobalDb.RetornarConexion().Close();


            }
            catch (Exception)
            {

                throw;
            }



            List<Factura> listName = dt.AsEnumerable().Select(m => new Factura()
            {
                FacturaId = m.Field<int>("FacturaId"),
                Monto = m.Field<decimal>("Monto"),
                UsuarioId = m.Field<int>("UsuarioId"),
                ClienteId = m.Field<int>("ClienteId"),
                Fecha = m.Field<string>("Fecha"),
                Descripcion = m.Field<string>("Descripcion"),
                FormaDePago = m.Field<string>("FormaDePago"),
                Devuelta = m.Field<decimal>("Devuelta"),
                EfectivoRecibido = m.Field<decimal>("EfectivoRecibido")

            }).ToList();


            return listName;
        }

        public static bool Modificar(Factura depart)
        {
            MySqlDataAdapter dater = new MySqlDataAdapter();
            bool estado = true;
            try
            {


                dater.UpdateCommand = new MySqlCommand("update Facturas set Monto= '" + depart.Monto + "',UsuarioId= '" +
                    depart.UsuarioId + "', ClienteId ='" + depart.ClienteId + "', Fecha='" + depart.Fecha + "', Descripcion = '" + depart.Descripcion + "', FormaDePago='" + depart.FormaDePago + "', Devuelta='" + depart.Devuelta + "',  EfectivoRecibido='" + depart.EfectivoRecibido + "' where FacturaId = '" + depart.FacturaId + "'",  ConexionGlobal.ConexionGlobalDb.RetornarConexion());

                dater.UpdateCommand.Connection =  ConexionGlobal.ConexionGlobalDb.RetornarConexion();
                dater.UpdateCommand.ExecuteNonQuery();

            }
            catch (Exception)
            {
                estado = false;
                throw;

            }

            return estado;

        }
        // Esto calcula la devuelta.
        public static decimal devuelta(decimal monto, decimal efectivo)
        {
            decimal devuelta = 0;

            devuelta = efectivo - monto;
            return devuelta;
        }
        // Esto calcula el monto total.
        public static decimal CalcularMonto(decimal importe)
        {
            decimal monto = 0;
            monto += importe;

            return monto;
        }
        // Esto calcula el importe y algo mas .
        public static decimal Importe(decimal cantidadDefecto, decimal cantidad, decimal precio, int id, int ID)
        {
            decimal importe = 0;
            if (ID == id)
            {

                importe = cantidad * precio;
            }
            else
            {
                importe = cantidadDefecto * precio;
            }


            return importe;
        }
        // Esto calcula el importe.
        public static decimal Importedemas(decimal cantidad, decimal precio)
        {
            decimal importe = 0;


            importe = cantidad * precio;



            return importe;
        }
        //descuenta al producto
        public static void DescontarProductos(List<FacturaDetalle> bill)
        {
            // Descontar cantidad a productos


            foreach (var item in bill)
            {
                Producto producto = new Producto();
                foreach (var items in ProductoBLL.Buscar())
                {
                    if (items.Idproducto == item.ProductoId)
                    {
                        producto.Cantidad = items.Cantidad;
                        producto.DepartamentoId = items.DepartamentoId;
                        producto.Descripcion = items.Descripcion;
                        producto.Idproducto = items.Idproducto;
                        producto.Precio = items.Precio;
                        producto.Cantidad -= item.Cantidad;

                        BLL.ProductoBLL.Modificar(producto);

                    }
                }




            }

        }

        public static void DescontarProductos(FacturaDetalle bill)
        {
            // Descontar cantidad a productos

            foreach (var items in ProductoBLL.Buscar())
            {
                if (items.Idproducto == bill.ProductoId)
                {

                    items.Cantidad -= bill.Cantidad;

                    BLL.ProductoBLL.Modificar(items);

                }
            }

        }
        //descuenta al producto de una lista
        public static void DescontarProducto(FacturaDetalle item, FacturaDetalle ite)
        {
            var producto = ProductoBLL.Buscar(item.ProductoId.ToString());

            foreach (var items in producto)
            {
                items.Cantidad += ite.Cantidad;
                items.Cantidad -= item.Cantidad;
                ProductoBLL.Modificar(items);
            }

        }
        //agrega al producto la cantidad eliminada
        public static void ArreglarProducto(string bill)
        {
            foreach (var item in FacturaDetalleBLL.BuscarFacturaID(bill))
            {
                Producto producto = new Producto();
                foreach (var items in ProductoBLL.Buscar())
                {
                    if (items.Idproducto == item.ProductoId)
                    {
                        producto.Cantidad = items.Cantidad;
                        producto.DepartamentoId = items.DepartamentoId;
                        producto.Descripcion = items.Descripcion;
                        producto.Idproducto = items.Idproducto;
                        producto.Precio = items.Precio;
                        producto.Cantidad += item.Cantidad;
                        ProductoBLL.Modificar(producto);
                    }
                }


            }
        }

        public static void ArreglarProducto(FacturaDetalle bill)
        {

            foreach (var items in ProductoBLL.Buscar())
            {
                if (items.Idproducto == bill.ProductoId)
                {

                    items.Cantidad += bill.Cantidad;
                    ProductoBLL.Modificar(items);
                }
            }



        }
        //agrega al producto la cantidad eliminada de una lista
        public static void ArreglarProductoList(List<FacturaDetalle> bill)
        {
            foreach (var item in bill)
            {
                //var producto = BLL.ProductoBLL.Buscar(item.ProductoId);
                Producto producto = new Producto();
                foreach (var items in ProductoBLL.Buscar())
                {
                    if (items.Idproducto == item.ProductoId)
                    {
                        producto.Cantidad = items.Cantidad;
                        producto.DepartamentoId = items.DepartamentoId;
                        producto.Descripcion = items.Descripcion;
                        producto.Idproducto = items.Idproducto;
                        producto.Precio = items.Precio;
                        producto.Cantidad += item.Cantidad;
                        BLL.ProductoBLL.Modificar(producto);

                    }
                }

            }


        }
        // Edita la cantidad de una lista 
        public static List<FacturaDetalle> Editar(List<FacturaDetalle> list, FacturaDetalle factura)
        {
            foreach (var item in list)
            {
                if (item.Id == factura.Id)
                {
                    item.Cantidad = factura.Cantidad;
                }

            }

            return list;
        }
        // descuenta el importe al monto total
        public static decimal DescontarImporte(List<FacturaDetalle> list, int id)
        {
            decimal monto = 0;

            foreach (var item in list)
            {
                if (item.Id == id)
                {
                    item.Importe = item.Cantidad * item.Precio;
                    monto = item.Importe;
                }

            }



            return monto;
        }
        // Recalcula el importe
        public static decimal RecalcularImporte(List<FacturaDetalle> list, int row)
        {
            decimal monto = 0;
            FacturaDetalle factura = list.ElementAt(row);
            factura.Importe = factura.Cantidad * factura.Precio;
            monto = factura.Importe;
            return monto;
        }
        // calcula la devueltas otra vez
        public static decimal CalcularDevuelta(decimal efectivo, decimal monto)
        {
            decimal devuelta = 0;

            devuelta = efectivo - monto;
            return devuelta;
        }
        // devuelve cual es el ultimo elemento de una lista
        public static int Mayor(List<Factura> bill)
        {
            int mayor = 0;
            foreach (var item in bill)
            {
                if (mayor == 0)
                {
                    mayor = item.FacturaId;
                }
                else
                {
                    if (mayor < item.FacturaId)
                    {
                        mayor = item.FacturaId;
                    }
                }

            }

            return mayor;
        }
        // busca el nombre de el usuario que hizo login
        public static void NombreLogin(string nombre, int id)
        {
            user.Nombre = nombre;
            user.IdUsuario = id;
        }
        // esto retorna el nombre
        public static Usuario returnUsuario()
        {
            return user;
        }
        // esto retorna la devuelta
        public static decimal RetornarDevuelta(decimal efectivo, decimal monto)
        {
            decimal devuelta = CalcularDevuelta(efectivo, monto);

            return devuelta;
        }
        //Esto descuenta cantidad del producto al modificar
        public static void DescontarBuscando(List<FacturaDetalle> facturaDetalles, string id)
        {
            var detalle = FacturaDetalleBLL.BuscarFacturaID(id);
            foreach (var item in detalle)
            {
                foreach (var items in facturaDetalles)
                {
                    if (item.ProductoId == items.ProductoId)
                        if (item.Cantidad != items.Cantidad)
                        {
                            DescontarProducto(items, item);
                        }
                }
            }
        }
    }
}
