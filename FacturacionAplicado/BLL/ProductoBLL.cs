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
    public class ProductoBLL
    {


        public static DataTable Consultar()
        {


            DataTable dt = new DataTable();

            MySqlDataAdapter con = new MySqlDataAdapter("select * from Productoes",  ConexionGlobal.ConexionGlobalDb.RetornarConexion());
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

                dater.DeleteCommand = new MySqlCommand(" delete from Productoes where Idproducto=" + id,  ConexionGlobal.ConexionGlobalDb.RetornarConexion());

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


        public static bool Guardar(Producto productos)
        {
            MySqlDataAdapter dater = new MySqlDataAdapter();
            bool estado = true;
            try
            {

                dater.InsertCommand = new MySqlCommand("insert into Productoes (Idproducto,Descripcion,Precio,DepartamentoId,Cantidad) values ('" + productos.Idproducto + "','" + productos.Descripcion + "','" + productos.Precio + "','" + productos.DepartamentoId + "','" + productos.Cantidad + "')",  ConexionGlobal.ConexionGlobalDb.RetornarConexion());

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
        public static List<Producto> Buscar()
        {

            DataTable dt = new DataTable();


            MySqlDataAdapter con = new MySqlDataAdapter("select * from Productoes",  ConexionGlobal.ConexionGlobalDb.RetornarConexion());
            try
            {


                con.Fill(dt);



            }
            catch (Exception)
            {

                throw;
            }



            List<Producto> listName = dt.AsEnumerable().Select(m => new Producto()
            {
                Idproducto = m.Field<int>("Idproducto"),
                Descripcion = m.Field<string>("Descripcion"),
                Precio = m.Field<decimal>("Precio"),
                DepartamentoId = m.Field<int>("DepartamentoId"),
                Cantidad = m.Field<int>("Cantidad")
            }).ToList();


            return listName;
        }

        public static List<Producto> Buscar(string id)
        {

            DataTable dt = new DataTable();


            MySqlDataAdapter con = new MySqlDataAdapter("select * from Productoes where Idproducto=" + id,  ConexionGlobal.ConexionGlobalDb.RetornarConexion());
            try
            {


                con.Fill(dt);



            }
            catch (Exception)
            {

                throw;
            }



            List<Producto> listName = dt.AsEnumerable().Select(m => new Producto()
            {
                Idproducto = m.Field<int>("Idproducto"),
                Descripcion = m.Field<string>("Descripcion"),
                Precio = m.Field<decimal>("Precio"),
                DepartamentoId = m.Field<int>("DepartamentoId"),
                Cantidad = m.Field<int>("Cantidad")
            }).ToList();


            return listName;
        }



        public static bool Modificar(Producto producto)
        {
            MySqlDataAdapter dater = new MySqlDataAdapter();
            bool estado = true;
            try
            {


                dater.UpdateCommand = new MySqlCommand("update Productoes set Idproducto= '" + producto.Idproducto + "', Descripcion = '" + producto.Descripcion + "', Precio = '" + producto.Precio + "', DepartamentoId = '" + producto.DepartamentoId + "', Cantidad= '" + producto.Cantidad + "'where Idproducto = '" + producto.Idproducto + "'",  ConexionGlobal.ConexionGlobalDb.RetornarConexion());

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
    }
}
