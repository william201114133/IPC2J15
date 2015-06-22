using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Devolucion : System.Web.UI.Page
{
    string local;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        serverquetzalexpress.Service1 servidor = new serverquetzalexpress.Service1();
        local = "INSERT INTO Devoulucion Values ('" + TextBox1.Text + "'," + DropDownList1.SelectedValue + "," + DropDownList2.SelectedItem + ",'" + TextBox2.Text + "')";
        Label1.Text = servidor.guardar(local);
    }
}