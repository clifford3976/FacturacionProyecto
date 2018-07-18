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
    public class ClienteBLL
    {


        public static DataTable Consultar()
        {


            DataTable dt = new DataTable();

            MySqlDataAdapter con = new MySqlDataAdapter("select * from Clientes",  ConexionGlobal.ConexionGlobalDb.RetornarConexion());
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

                dater.DeleteCommand = new MySqlCommand(" delete from Clientes where IdCliente=" + id,  ConexionGlobal.ConexionGlobalDb.RetornarConexion());

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


        public static bool Guardar(Cliente cliente)
        {
            MySqlDataAdapter dater = new MySqlDataAdapter();
            bool estado = true;
            try
            {

                dater.InsertCommand = new MySqlCommand("insert into Clientes (Nombre,Direccion,Cedula,Telefono) values ('" + cliente.Nombre + "','" + cliente.Direccion + "','" + cliente.Cedula + "','" + cliente.Telefono + "')",  ConexionGlobal.ConexionGlobalDb.RetornarConexion());

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
        public static List<Cliente> Buscar()
        {

            DataTable dt = new DataTable();


            MySqlDataAdapter con = new MySqlDataAdapter("select * from Clientes",  ConexionGlobal.ConexionGlobalDb.RetornarConexion());
            try
            {


                con.Fill(dt);



            }
            catch (Exception)
            {

                throw;
            }



            List<Cliente> listName = dt.AsEnumerable().Select(m => new Cliente()
            {
                IdCliente = m.Field<int>("IdCliente"),
                Nombre = m.Field<string>("Nombre"),
                Direccion = m.Field<string>("Direccion"),
                Cedula = m.Field<string>("Cedula"),
                Telefono = m.Field<string>("Cedula")
            }).ToList();


            return listName;
        }

      
        public static bool Modificar(Cliente cliente)
        {
            MySqlDataAdapter dater = new MySqlDataAdapter();
            bool estado = true;
            try
            {


                dater.UpdateCommand = new MySqlCommand("update Clientes set Nombre= '" + cliente.Nombre + "', Direccion = '" + cliente.Direccion + "', Cedula = '" + cliente.Cedula + "', Telefono = '" + cliente.Telefono + "'where IdCliente = '" + cliente.IdCliente + "'",  ConexionGlobal.ConexionGlobalDb.RetornarConexion());

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
