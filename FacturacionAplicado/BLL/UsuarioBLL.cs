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
    public class UsuarioBLL
    {

        public static DataTable Consultar()
        {


            DataTable dt = new DataTable();

            MySqlDataAdapter con = new MySqlDataAdapter("select * from usuarios",  ConexionGlobal.ConexionGlobalDb.RetornarConexion());
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

                dater.DeleteCommand = new MySqlCommand(" delete from usuarios where IdUsuario=" + id,  ConexionGlobal.ConexionGlobalDb.RetornarConexion());

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


        public static bool Guardar(Usuario user)
        {
            MySqlDataAdapter dater = new MySqlDataAdapter();
            bool estado = true;
            try
            {

                dater.InsertCommand = new MySqlCommand("insert into Usuarios (Nombre,Clave,NombreUsuario,Fecha,Comentario) values ('" + user.Nombre + "','" + user.Clave + "','" + user.NombreUsuario + "','" + user.Fecha + "','" + user.Comentario + "')",  ConexionGlobal.ConexionGlobalDb.RetornarConexion());

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
        public static List<Usuario> Buscar()
        {

            DataTable dt = new DataTable();


            MySqlDataAdapter con = new MySqlDataAdapter("select * from Usuarios",  ConexionGlobal.ConexionGlobalDb.RetornarConexion());
            try
            {


                con.Fill(dt);



            }
            catch (Exception)
            {

                throw;
            }



            List<Usuario> listName = dt.AsEnumerable().Select(m => new Usuario()
            {
                IdUsuario = m.Field<int>("IdUsuario"),
                Nombre = m.Field<string>("Nombre"),
                Clave = m.Field<string>("Clave"),
                NombreUsuario = m.Field<string>("NombreUsuario"),
                Fecha = m.Field<string>("Fecha"),
                Comentario = m.Field<string>("Comentario")
            }).ToList();


            return listName;
        }

        public static List<Usuario> Buscar(string id)
        {

            DataTable dt = new DataTable();


            MySqlDataAdapter con = new MySqlDataAdapter("select * from Usuarios where IdUsuario=" + id,  ConexionGlobal.ConexionGlobalDb.RetornarConexion());
            try
            {


                con.Fill(dt);



            }
            catch (Exception)
            {

                throw;
            }



            List<Usuario> listName = dt.AsEnumerable().Select(m => new Usuario()
            {
                IdUsuario = m.Field<int>("IdUsuario"),
                Nombre = m.Field<string>("Nombre"),
                Clave = m.Field<string>("Clave"),
                NombreUsuario = m.Field<string>("NombreUsuario"),
                Fecha = m.Field<string>("Fecha"),
                Comentario = m.Field<string>("Comentario")
            }).ToList();


            return listName;
        }



        public static bool Modificar(Usuario user)
        {
            MySqlDataAdapter dater = new MySqlDataAdapter();
            bool estado = true;
            try
            {


                dater.UpdateCommand = new MySqlCommand("update Usuarios set IdUsuario= '" + user.IdUsuario + "', Nombre = '" + user.Nombre + "', Clave = '" + user.Clave + "', NombreUsuario = '" + user.NombreUsuario + "', Fecha= '" + user.Fecha + "',Comentario='" + user.Comentario + "'where Idproducto = '" + user.IdUsuario + "'",  ConexionGlobal.ConexionGlobalDb.RetornarConexion());

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
