using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;  //-----Conexão com o Banco de Dados MySQL
using MySql.Data; //----Conexão com o Banco de Dados MySQL
using MySql.Data.MySqlClient; //----Conexão com o Banco de Dados MySQL
using System.Windows.Forms;
//using System.Data;
//using System.Data.SqlClient;

namespace TattoSystemManager
{
    class Conexao
    {

        //public static SqlConnection conn = new SqlConnection();

        public static MySqlConnection conMySQL = new MySqlConnection(); //---- objeto de conexão


        //public static SqlCommand cmd = new SqlCommand();

        public static MySqlCommand cmdMySQL = new MySqlCommand(); //-----objeto de comandos

        
        public static MySqlDataReader reader; //---- objeto de leitura de dados do banco
        

        
        public static void Conectar()
        {

            try
            {
                
                
               conMySQL.ConnectionString = "Server = localhost; User Id = root; Persist Security Info = True; database = tsm";
                
                
                cmdMySQL.Connection = conMySQL;

                conMySQL.Open();
            }

            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        
    }
}


    

