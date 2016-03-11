using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class VistaCliente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["IdCliente"].ToString() != null || Session["IdCliente"].ToString() != "")
        {
            
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