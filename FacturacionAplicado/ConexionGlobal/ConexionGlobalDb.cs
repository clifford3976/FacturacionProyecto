using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FacturacionAplicado.ConexionGlobal
{
    public class ConexionGlobalDb
    {
        public static MySqlConnection db;

        public static bool TestConnectiong()
        {
            bool paso = true;
            try
            {
                db = new MySqlConnection("server = db4free.net; database = facturaciondb; user id = facturacionucne; password = root12345");
                //db = new MySqlConnection("server=localhost; database = FacturacionDb; user id=root ;password=root");
                db.Open();
                GC.KeepAlive(db);



            }
            catch (Exception)
            {
                paso = false;
                throw;
            }

            return paso;
        }

        public static MySqlConnection RetornarConexion()
        {
            // db.Open();
            return db;
        }
    }
}
