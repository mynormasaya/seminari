using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace seminarito
{
    public partial class Control1 : System.Web.UI.UserControl
    {
        SqlConnection connection = new SqlConnection();
        String connectionString="Server=sem220180511043449dbserver.database.windows.net; Database=basemasaya; Uid=mynormasaya; Pwd=Mynorjuarez.1;";
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int Id;
            Id = RandomNumber(1, 300000);
            string Nombre;
            string Comentario;
            Nombre = TextBox1.Text;
            Comentario = TextBox2.Text;
            iniciarConexion();
            connection.Open();
            string query = "INSERT INTO dbo.Tablita(Id, Nombre, Comentario) VALUES(@Id, @Nombre, @Comentario)";
            SqlCommand comando = new SqlCommand(query, connection);

            comando.Parameters.AddWithValue("@Id", Id);
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Comentario", Comentario);

            comando.ExecuteNonQuery();


            connection.Close();
        }



        static int RandomNumber(int min, int max)
        {
            Random random = new Random(); return random.Next(min, max);

        }

        private void iniciarConexion()
        {
            try
            {
                connectionString = "Server=sem220180511043449dbserver.database.windows.net; Database=basemasaya; Uid=mynormasaya; Pwd=Mynorjuarez.1;";
                connection.ConnectionString = connectionString;
                

                //MessageBox.Show("Conexion Exitosa, Bien Castillo");
            }
            catch (SqlException)
            {
               
            }
        }

    }
}