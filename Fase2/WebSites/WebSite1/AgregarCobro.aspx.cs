using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AgregarCobro : System.Web.UI.Page
{
    string local;
    string estado = "habilitado";
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        serverquetzalexpress.Service1 servidor = new serverquetzalexpress.Service1();
        if (DropDownList1.SelectedItem.ToString().Equals("Impuesto"))
        {
            local = "INSERT INTO Impuesto Values ('" + TextBox1.Text + "'," + TextBox2.Text + "," + estado + ")";
            Label1.Text = servidor.guardar(local);
        }
        if (DropDownList1.SelectedItem.ToString().Equals("Costo Envio"))
        {
            local = "INSERT INTO CostoEnvio Values ('" + TextBox1.Text + "'," + TextBox2.Text + "," + estado + ")";
            Label1.Text = servidor.guardar(local);
        }
        if (DropDownList1.SelectedItem.ToString().Equals("Comision"))
        {
            local = "INSERT INTO Comision Values ('" + TextBox1.Text + "'," + TextBox2.Text + "," + estado + ")";
            Label1.Text = servidor.guardar(local);
        }
    }
}