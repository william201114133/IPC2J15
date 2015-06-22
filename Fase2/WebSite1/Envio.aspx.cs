using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Envio : System.Web.UI.Page
{
    string local;
    string estado = "pendiente";
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        serverquetzalexpress.Service1 servidor = new serverquetzalexpress.Service1();
        local = "INSERT INTO Lote Values("+estado+")";
        Label1.Text = servidor.guardar(local);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        serverquetzalexpress.Service1 servidor = new serverquetzalexpress.Service1();
        local = "INSERT INTO Envio Values('" +TextBox2.Text+"',"+DropDownList2.SelectedValue+","+DropDownList3.SelectedValue+ ")";
        Label2.Text = servidor.guardar(local);
    }
}