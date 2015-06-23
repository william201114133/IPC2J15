using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cotizacion : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        serverquetzalexpress.Service1 servidor = new serverquetzalexpress.Service1();
        double impuesto = Convert.ToDouble(DropDownList1.SelectedValue)/100;
        Label1.Text = servidor.calculocosto(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text),impuesto).ToString();
    }
}