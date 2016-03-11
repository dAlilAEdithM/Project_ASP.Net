using System;
using IngresarLogin;

public partial class Login_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    { 

    }

    String tipo = "";


    protected void BtnIngresar_Click(object sender, EventArgs e)
    {
        this.User = txtUser.Text;
        this.Pass = txtPass.Text;
        mtdIngresar("Cliente") ;   
    }
    protected void BtnIngresarE_Click(object sender, EventArgs e)
    {
        this.User = txtUser1.Text;
        this.Pass = txtPass1.Text;
        mtdIngresar("Empleado" );
    }


    protected void BtnRegistrar_Click(object sender, EventArgs e)
    {
        Response.Redirect("RegistroCliente.aspx");
    }

    String User = "";
    String Pass = "";

    private void mtdIngresar(String tipo )
    {

        IngresarLogin.ServiceSoapClient l = new IngresarLogin.ServiceSoapClient();
        int IdUser = 0;


        try {
            IdUser = l.Ingresar(this.User, this.Pass, tipo);
        }
        catch (Exception ex) { }

            if (IdUser > 0)
            {

                if (tipo == "Cliente" )
                {
                Session["IdCliente"] = IdUser;
                    Response.Write("<script>alert('Bienviuido Cliente ');</script>");
                    Response.Redirect("VistaCliente.aspx");
                }
                else if (tipo == "Empleado" )
                {
                Session["IdEmpleado"] = IdUser;
                    Response.Write("<script>alert('Bienviuido Empleado');</script>");
                    Response.Redirect("VistaEmpleado.aspx");
                }
                
            }
            else
            {
                Response.Write("<script>alert('Error');</script>");
                Response.Redirect("Error en sus datos.aspx");
            }

         

    }



}