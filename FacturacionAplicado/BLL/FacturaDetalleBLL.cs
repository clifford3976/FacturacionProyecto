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
    public class FacturaDetalleBLL
    {
        public static List<FacturaDetalle> Buscar()
        {

            DataTable dt = new DataTable();


            MySqlDataAdapter con = new MySqlDataAdapter("select * from FacturaDetalles ",  ConexionGlobal.ConexionGlobalDb.RetornarConexion());
            try
            {


                con.Fill(dt);



            }
            catch (Exception)
            {

                throw;
            }



            List<FacturaDetalle> listName = dt.AsEnumerable().Select(m => new FacturaDetalle()
            {
                Id = m.Field<int>("Id"),
                FacturaId = m.Field<int>("FacturaId"),
                ProductoId = m.Field<int>("ProductoId"),
                Cantidad = m.Field<int>("Cantidad"),
                Precio = m.Field<decimal>("Precio"),
                Descripcion = m.Field<string>("Descripcion")

            }).ToList();


            return listName;
        }

        public static List<FacturaDetalle> Buscar(string id)
        {

            DataTable dt = new DataTable();


            MySqlDataAdapter con = new MySqlDataAdapter("select * from FacturaDetalles where Id=" + id,  ConexionGlobal.ConexionGlobalDb.RetornarConexion());
            try
            {


                con.Fill(dt);



            }
            catch (Exception)
            {

                throw;
            }



            List<FacturaDetalle> listName = dt.AsEnumerable().Select(m => new FacturaDetalle()
            {
                Id = m.Field<int>("Id"),
                FacturaId = m.Field<int>("FacturaId"),
                ProductoId = m.Field<int>("ProductoId"),
                Cantidad = m.Field<int>("Cantidad"),
                Precio = m.Field<decimal>("Precio"),
                Descripcion = m.Field<string>("Descripcion")

            }).ToList();


            return listName;
        }

        public static List<FacturaDetalle> BuscarFacturaID(string id)
        {

            DataTable dt = new DataTable();


            MySqlDataAdapter con = new MySqlDataAdapter("select * from FacturaDetalles where FacturaId=" + id,  ConexionGlobal.ConexionGlobalDb.RetornarConexion());
            try
            {


                con.Fill(dt);



            }
            catch (Exception)
            {

                throw;
            }



            List<FacturaDetalle> listName = dt.AsEnumerable().Select(m => new FacturaDetalle()
            {
                Id = m.Field<int>("Id"),
                FacturaId = m.Field<int>("FacturaId"),
                ProductoId = m.Field<int>("ProductoId"),
                Cantidad = m.Field<int>("Cantidad"),
                Precio = m.Field<decimal>("Precio"),
                Descripcion = m.Field<string>("Descripcion")

            }).ToList();


            return listName;
        }

        public static bool Eliminar(string id)
        {

            MySqlDataAdapter dater = new MySqlDataAdapter();
            bool estado = true;
            try
            {

                dater.DeleteCommand = new MySqlCommand(" delete from FacturaDetalles where Id=" + id,  ConexionGlobal.ConexionGlobalDb.RetornarConexion());

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

        public static bool Eliminar(List<FacturaDetalle> facturaDetalles)
        {

            MySqlDataAdapter dater = new MySqlDataAdapter();
            bool estado = true;
            try
            {

                foreach (var item in facturaDetalles)
                {

                    dater.DeleteCommand = new MySqlCommand(" delete from FacturaDetalles where Id=" + item.Id,  ConexionGlobal.ConexionGlobalDb.RetornarConexion());

                    dater.DeleteCommand.Connection =  ConexionGlobal.ConexionGlobalDb.RetornarConexion();
                    dater.DeleteCommand.ExecuteNonQuery();
                }

            }
            catch (Exception)
            {
                estado = false;
                throw;

            }

            return estado;
        }

        public static bool Modificar(List<FacturaDetalle> factura)
        {
            MySqlDataAdapter dater = new MySqlDataAdapter();
            bool estado = true;
            try
            {


                foreach (var item in factura)
                {

                    if (item.Id == 0)
                    {
                        Guardar(item);

                        FacturacionBLL.DescontarProductos(item);
                    }
                    else
                    {
                     //var detalle = Buscar(item.Id.ToString());
                     //var cDetalle = detalle.ElementAt(0);
                     //if (item.Cantidad != cDetalle.Cantidad)
                     //{

                        //    FacturacionBLL.ArreglarProducto(cDetalle);
                        //    FacturacionBLL.DescontarProductos(item);
                        //}
                        dater.UpdateCommand = new MySqlCommand("update FacturaDetalles set Id= '" + item.Id + "', FacturaId = '" + item.FacturaId + "', ProductoId = '" + item.ProductoId + "', Cantidad = '" + item.Cantidad + "', Precio= '" + item.Precio + "',Descripcion='" + item.Descripcion + "'where Id = '" + item.Id + "'",  ConexionGlobal.ConexionGlobalDb.RetornarConexion());

                        dater.UpdateCommand.Connection =  ConexionGlobal.ConexionGlobalDb.RetornarConexion();
                        dater.UpdateCommand.ExecuteNonQuery();
                    }


                }

            }
            catch (Exception)
            {
                estado = false;
                throw;

            }

            return estado;

        }

        public static bool Guardar(List<FacturaDetalle> factura)
        {
            MySqlDataAdapter dater = new MySqlDataAdapter();
            bool estado = true;
            try
            {

                var Id = FacturacionBLL.Buscar();
                var IDfactura = Id.ElementAt(Id.Count() - 1);

                foreach (var item in factura)
                {

                    dater.InsertCommand = new MySqlCommand("insert into FacturaDetalles (Id,FacturaId,ProductoId,Cantidad,Precio,Descripcion) values ('" + item.Id + "','" + IDfactura.FacturaId + "','" + item.ProductoId + "','" + item.Cantidad + "','" + item.Precio + "','" + item.Descripcion + "')",  ConexionGlobal.ConexionGlobalDb.RetornarConexion());

                    dater.InsertCommand.Connection =  ConexionGlobal.ConexionGlobalDb.RetornarConexion();
                    dater.InsertCommand.ExecuteNonQuery();
                }

            }
            catch (Exception)
            {
                estado = false;
                throw;

            }

            return estado;
        }

        public static bool Guardar(FacturaDetalle factura)
        {
            MySqlDataAdapter dater = new MySqlDataAdapter();
            bool estado = true;
            try
            {

                var Id = FacturacionBLL.Buscar();
                var IDfactura = Id.ElementAt(Id.Count() - 1);



                dater.InsertCommand = new MySqlCommand("insert into FacturaDetalles (Id,FacturaId,ProductoId,Cantidad,Precio,Descripcion) values ('" + factura.Id + "','" + factura.FacturaId + "','" + factura.ProductoId + "','" + factura.Cantidad + "','" + factura.Precio + "','" + factura.Descripcion + "')",  ConexionGlobal.ConexionGlobalDb.RetornarConexion());

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

        public static DataTable Consultar()
        {


            DataTable dt = new DataTable();

            MySqlDataAdapter con = new MySqlDataAdapter("select * from FacturaDetalles",  ConexionGlobal.ConexionGlobalDb.RetornarConexion());
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

        //Todo: Poner todas las ventanas bonitas
    }
}
