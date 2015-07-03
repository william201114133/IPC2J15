using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RegistraCliente : System.Web.UI.Page
{
    string local;
    string estado = "pendiente";
    int casilla = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        serverquetzalexpress.Service1 servidor = new serverquetzalexpress.Service1();
        local = "INSERT INTO Cliente VALUES ('"+TextBox2.Text+"','"+TextBox1.Text+"',"+TextBox3.Text+","+TextBox4.Text+","+TextBox5.Text+",'"+TextBox6.Text+"',"+TextBox7.Text+","+casilla+","+Convert.ToInt32(DropDownList1.SelectedValue)+",'"+estado+"','"+TextBox1.Text+"')";
        Label1.Text = servidor.guardar(local);
    }
}