using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen3_Gerardo
{
    public partial class Realizaencuesta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarGridView();
            }
        }

        protected void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtCorreoElectronico_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }
        protected void btnGuardarEncuesta_Click(object sender, EventArgs e)
        {
            string Nombre = txtNombre.Text.Trim();
            string CorreoElectronico = txtCorreoElectronico.Text.Trim();
            string Edad = txtEdad.Text.Trim();


            InsertarRealizaencuesta(Nombre, CorreoElectronico, Edad);


            LlenarGridView();
        }

        private void InsertarRealizaencuesta(string nombre, string correoElectronico, string edad)
        {
            throw new NotImplementedException();
        }

        private void LlenarGridView()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["BD_Gerardo"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Partidospoliticos";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);


                        gridRealizaencuesta.DataSource = dt;
                        gridRealizaencuesta.DataBind();
                    }
                }
            }
        }
        private void InsertarRealizaencuesta(string Nombre, string CorreoElectronio, string Edad, object CorreoElectronico)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["BD_Gerardo"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Realizaencuesta (Nombre, CorreoElectronico, Edad) VALUES (@NOmbre, @CorreoElectronico, @Edad)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Nombre", Nombre);
                    cmd.Parameters.AddWithValue("@CorreoElectronico", CorreoElectronico);
                    cmd.Parameters.AddWithValue("@Edad", Edad);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        protected void gridRealizaencuesta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void txtNombre_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void gridRealizaencuesta_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void gridRealizaencuesta_SelectedIndexChanged2(object sender, EventArgs e)
        {

        }
    }
}