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

    DataSetTableAdapters.ClienteTableAdapter objCliente = new DataSetTableAdapters.ClienteTableAdapter();

    public Service () {}

    
    [WebMethod]
    public int Ingresar(String user , String passs)
    {

        String idUser = objCliente.InicioSesionnCliente(user, passs).ToString();

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