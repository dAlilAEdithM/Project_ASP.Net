using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;



[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]


public class Service : System.Web.Services.WebService
{

    public Service()
    { }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hola a todos";
    }

    DataSetTableAdapters.EmpleadoTableAdapter objEmpleado = new DataSetTableAdapters.EmpleadoTableAdapter();
    DataSetTableAdapters.ClienteTableAdapter objCliente = new DataSetTableAdapters.ClienteTableAdapter();

    [WebMethod]
    public int Ingresar(String user, String passs  , String tipo)
    {

        String idUser = "";

        if (tipo == "Empleado")
        {
            idUser = objEmpleado.ReturnLogin(user, passs).ToString();
        }
        else if (tipo == "Cliente")
        {
            idUser = objCliente.IngresarLoginCl(user, passs).ToString();
        }
        else
        {
            return 0;
        }


        if (idUser != null || idUser == "")
        {
            return int.Parse(idUser);
        }
        else
        {
            return 0;
        }

    }



}
