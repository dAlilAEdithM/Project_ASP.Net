using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["IdCliente"].ToString() != null || Session["IdCliente"].ToString() != "")
        {
            Response.Redirect("VistaCliente.aspx");
        }
        else if (Session["IdEmpleado"].ToString() != null || Session["IdEmpleado"].ToString() != "")
        {
            Response.Redirect("VistaEmpleado.aspx");
        }
        else
        {
            Response.Redirect("~/Login/Login.aspx");
        }



    }
}