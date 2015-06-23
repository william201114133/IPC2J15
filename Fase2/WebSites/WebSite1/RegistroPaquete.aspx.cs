using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RegistroPaquete : System.Web.UI.Page
{
    string local;
    serverquetzalexpress.Service1 servidor = new serverquetzalexpress.Service1();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string estado = "Registrado";
        string ubicacion = "USA";
        double costo = servidor.calculocosto(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text), Convert.ToDouble(DropDownList2.SelectedValue));
        local = "INSERT INTO Paquete VALUES("+ DropDownList2.SelectedItem + "," + TextBox1.Text + "," + TextBox2.Text + ",'"+estado+"','"+ubicacion+"'," + DropDownList3.SelectedValue+ ","+costo+")";
        servidor.guardar(local);
        
    }
}