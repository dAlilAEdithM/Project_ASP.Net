using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


public partial class Login_Login : System.Web.UI.Page
{

    
    protected void Page_Load(object sender, EventArgs e)
    {
      
    }




    protected void BtnIngresar_Click(object sender, EventArgs e)
    {


        string nombre = TxtUsuario.Text;
        string pass = TxtContrasena.Text;


        SqlConnection conexion = new SqlConnection(@"");
        conexion.Open();
        SqlCommand comando = new SqlCommand("SELECT * FROM Usuario WHERE email = '" + nombre + "' AND password = '" + pass + "'");
        comando.Connection = conexion;
        SqlDataReader dr = comando.ExecuteReader();

        if (dr.Read())
        {
            System.Diagnostics.Debug.WriteLine(dr["IdUsuario"].ToString());
            Session["User"] = dr["IdCliente"].ToString();
            Response.Redirect("principal.aspx");
        }
        else
        {
            Response.Write("<script>alert('No has digitado correctamente tus datos')</script>");
        }
    }
}