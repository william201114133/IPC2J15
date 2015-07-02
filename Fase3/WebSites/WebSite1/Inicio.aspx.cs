using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Inicio : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        serverquetzalexpress.Service1 servidor = new serverquetzalexpress.Service1();
        if ("aceptado".Equals(servidor.logincliente(TextBox2.Text, TextBox4.Text)))
        {
            if ("aceptado".Equals(servidor.verpuesto()))
            {
                Response.Redirect("EditaCliente.aspx");
            }
            else
            {
                Label2.Text = "Su usuario aun no ha sido aceptado";
            }
        }
        else {
            Label2.Text = "Usuario o contraseña es inconrrecto";
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        serverquetzalexpress.Service1 servidor = new serverquetzalexpress.Service1();
        if (servidor.LoginEmpleado(TextBox1.Text,TextBox3.Text).Equals(true))
        {
            Label1.Text = DropDownList1.SelectedValue.ToString() + "," + servidor.coddepto().ToString();
            if (servidor.verpuesto().Equals("Director"))
            {
                Response.Redirect("RegistrarEmpleado.aspx");
            }
            else
            {
                if (Convert.ToInt32(DropDownList1.SelectedValue) == servidor.coddepto())
                {
                    Response.Redirect("RegistroPaquete.aspx");
                }
                if (Convert.ToInt32(DropDownList1.SelectedValue)==servidor.coddepto())
                {
                    Response.Redirect("ReportePerdido");
                }
                if (Convert.ToInt32(DropDownList1.SelectedValue)==servidor.coddepto())
                {
                    Response.Redirect("Facturacion.aspx");
                }
                if (Convert.ToInt32(DropDownList1.SelectedValue)==servidor.coddepto())
                {
                    Response.Redirect("CargarCSV");
                }
            }
        }
        else {
            Label1.Text = DropDownList1.SelectedValue.ToString()+","+servidor.coddepto().ToString();
        }

    }
}