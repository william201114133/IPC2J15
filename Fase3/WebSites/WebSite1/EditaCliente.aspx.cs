using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class EditaCliente : System.Web.UI.Page
{
    int usuario;
    string query;
    string local;
    serverquetzalexpress.Service1 servidor = new serverquetzalexpress.Service1();
    Conexion con = new Conexion();
    SqlCommand comando;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        usuario=servidor.codigousuario();
        datoscliente(usuario);
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        local = "UPDATE Cliente SET apellidos='" + TextBox1.Text + "', nombres='" + TextBox2.Text + "',dpi=" + TextBox3.Text + ",nit=" + TextBox4.Text + ",telefono=" + TextBox5.Text + ",direccion='" + TextBox6.Text + "',tarjeta=" + TextBox7.Text + ",contraseña='"+TextBox8.Text+"'"+
                "WHERE idCliente="+usuario+"";
        Label1.Text=servidor.guardar(local);
    }
    public Boolean datoscliente(int user)
    {
        try
        {

            query = "SELECT idCliente, apellidos, nombres, dpi, nit, telefono, direccion, tarjeta, contraseña FROM Cliente" +
                    " WHERE idCliente = " + user + "";

            DataTable dt = new DataTable();
            comando = new SqlCommand(query, con.getConexion());
            comando.Parameters.AddWithValue("@idCliente", user);
            SqlDataAdapter adap = new SqlDataAdapter(comando);
            adap.Fill(dt);
            DataRow row = dt.Rows[0];
            TextBox1.Text = Convert.ToString(row["apellidos"]);
            TextBox2.Text = Convert.ToString(row["nombres"]);
            TextBox3.Text = Convert.ToString(row["dpi"]);
            TextBox4.Text = Convert.ToString(row["nit"]);
            TextBox5.Text = Convert.ToString(row["telefono"]);
            TextBox6.Text = Convert.ToString(row["direccion"]);
            TextBox7.Text = Convert.ToString(row["tarjeta"]);
            TextBox8.Text = Convert.ToString(row["contraseña"]);
            con.abrir();
            Object ob = comando.ExecuteScalar();

            if (ob == null)
            {
                con.cerrar();
                return false;
            }
            else
            {
                con.cerrar();
                return true;
            }

        }
        catch {
            return false;
        }
    }
}