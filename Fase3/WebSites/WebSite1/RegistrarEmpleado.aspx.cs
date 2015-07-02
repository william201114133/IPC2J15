using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RegistrarEmpleado : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        serverquetzalexpress.Service1 servidor = new serverquetzalexpress.Service1();
        string puesto="no definido";
        string local="INSERT INTO Empleado VALUES('"+TextBox1.Text+"','"+TextBox2.Text+"',"+TextBox3.Text+","+Convert.ToInt32(DropDownList1.SelectedValue)+","+Convert.ToInt32(DropDownList2.SelectedValue)+",'"+puesto+"','"+TextBox1.Text+"')";
        Label1.Text = servidor.guardar(local);
    }
}