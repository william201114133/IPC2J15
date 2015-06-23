using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class InfoPaquete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        serverquetzalexpress.Service1 servidor = new serverquetzalexpress.Service1();
        Label1.Text = servidor.codigousuario().ToString();
    }
}