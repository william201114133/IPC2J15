using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CargarCSV : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {

            try
            {
                string filename = Path.GetFileName(FileUpload1.FileName);
                FileUpload1.SaveAs(Server.MapPath("~/") + filename);
                string dir = Server.MapPath("~/") + filename;
                serverquetzalexpress.Service1 servicio = new serverquetzalexpress.Service1();
                List<string[]> lista = new List<string[]>();
                lista = servicio.CargaCSV(dir).ToList();// envia el path y regresa la lista

                DataTable tabla = new DataTable();
                
                tabla.Columns.Add("nombre", typeof(string));
                tabla.Columns.Add("precio", typeof(string));
                string local;
                string estado = "Habilitado";
                for (int i = 0; i < lista.Count; i++)
                {
                    DataRow Fila = tabla.NewRow();
                    Fila[0] = lista[i][0];
                    Fila[1] = lista[i][1];
                    local = "INSERT INTO Impuesto VALUES('" + lista[i][0] + "'," + lista[i][1] + ",'" + estado + "')";
                    servicio.guardar(local);
                    tabla.Rows.Add(Fila);
                }
                
                GridView1.DataSource = tabla;
                GridView1.DataBind();

                Label1.Text ="Archivo Cargado";
            }
            catch (Exception ex)
            {
                Label1.Text = "El archivo no se ha podido subir. el siguiente error ocurrio: " + ex.Message;
            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (FileUpload2.HasFile)
        {

            try
            {
                string filename = Path.GetFileName(FileUpload2.FileName);
                FileUpload2.SaveAs(Server.MapPath("~/") + filename);
                string dir = Server.MapPath("~/") + filename;
                serverquetzalexpress.Service1 servicio = new serverquetzalexpress.Service1();
                List<string[]> lista = new List<string[]>();
                lista = servicio.CargaCSV(dir).ToList();// envia el path y regresa la lista

                DataTable tabla = new DataTable();

                tabla.Columns.Add("Apellidos", typeof(string));
                tabla.Columns.Add("Nombres", typeof(string));
                tabla.Columns.Add("Sueldo", typeof(string));
                tabla.Columns.Add("Sucursal", typeof(string));
                tabla.Columns.Add("Departamento", typeof(string));
                string local;
                for (int i = 0; i < lista.Count; i++)
                {
                    DataRow Fila = tabla.NewRow();
                    Fila[0] = lista[i][0];
                    Fila[1] = lista[i][1];
                    Fila[2] = lista[i][2];
                    Fila[3] = lista[i][3];
                    Fila[4] = lista[i][4];
                    if (servicio.VerificarSucursal(lista[i][3]).Equals(true))
                    {
                        if (servicio.VerificarDepto(lista[i][4]).Equals(true))
                        {
                            local = "INSERT INTO Empleado VALUES('" + lista[i][0] + "','" + lista[i][1] + "'," + lista[i][2] + "," + servicio.codsucursal() + "," + servicio.coddepto() + ",'" + "pendiente" + "','" + lista[i][1] + "','" + "Habilitado" + "')";
                            servicio.guardar(local);
                            tabla.Rows.Add(Fila);
                        }
                        else {
                            local = "INSERT INTO Departamento VALUES('" + lista[i][4] + "')";
                            servicio.guardar(local);
                            servicio.VerificarDepto(lista[i][4]);
                            local = "INSERT INTO Empleado VALUES('" + lista[i][0] + "','" + lista[i][1] + "'," + lista[i][2] + "," + servicio.codsucursal() + "," + servicio.coddepto() + ",'" + "pendiente" + "','" + lista[i][1] + "','" + "Habilitado" + "')";
                            servicio.guardar(local);
                            tabla.Rows.Add(Fila);
                        }
                    }
                    else
                    {
                        local = "INSERT INTO Sucursal VALUES('" + lista[i][3] + "','" + "Pendiente" + "'," + 0 + "," + 0 + ")";
                        servicio.guardar(local);
                        servicio.VerificarSucursal(lista[i][3]);
                        if (servicio.VerificarDepto(lista[i][4]).Equals(true))
                        {
                            local = "INSERT INTO Empleado VALUES('" + lista[i][0] + "','" + lista[i][1] + "'," + lista[i][2] + "," + servicio.codsucursal() + "," + servicio.coddepto() + ",'" + "pendiente" + "','" + lista[i][1] + "','" + "Habilitado" + "')";
                            servicio.guardar(local);
                            tabla.Rows.Add(Fila);
                        }
                        else
                        {
                            local = "INSERT INTO Departamento VALUES('" + lista[i][4] + "')";
                            servicio.guardar(local);
                            servicio.VerificarDepto(lista[i][4]);
                            local = "INSERT INTO Empleado VALUES('" + lista[i][0] + "','" + lista[i][1] + "'," + lista[i][2] + "," + servicio.codsucursal() + "," + servicio.coddepto() + ",'" + "pendiente" + "','" + lista[i][1] + "','" + "Habilitado" + "')";
                            servicio.guardar(local);
                            tabla.Rows.Add(Fila);
                        }
                    }
                }

                GridView2.DataSource = tabla;
                GridView2.DataBind();

                Label2.Text = "Archivo Cargado";
            }
            catch (Exception ex)
            {
                Label2.Text = "El archivo no se ha podido subir. el siguiente error ocurrio: " + ex.Message;
            }
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        if (FileUpload3.HasFile)
        {

            try
            {
                string filename = Path.GetFileName(FileUpload3.FileName);
                FileUpload3.SaveAs(Server.MapPath("~/") + filename);
                string dir = Server.MapPath("~/") + filename;
                serverquetzalexpress.Service1 servicio = new serverquetzalexpress.Service1();
                List<string[]> lista = new List<string[]>();
                lista = servicio.CargaCSV(dir).ToList();// envia el path y regresa la lista

                DataTable tabla = new DataTable();

                tabla.Columns.Add("Categoria", typeof(string));
                tabla.Columns.Add("Casilla", typeof(string));
                tabla.Columns.Add("Peso", typeof(string));
                tabla.Columns.Add("Precio", typeof(string));
                string local;
                string estado = "Registrado";
                for (int i = 0; i < lista.Count; i++)
                {
                    DataRow Fila = tabla.NewRow();
                    Fila[0] = lista[i][0];
                    Fila[1] = lista[i][1];
                    Fila[2] = lista[i][2];
                    Fila[3] = lista[i][3];
                    local = "INSERT INTO Paquete VALUES('" + lista[i][0] + "'," + lista[i][1] + "," + lista[i][3] + ","+lista[i][2]+",'"+estado+"','"+"USA"+"',"+"NULL"+","+"NULL"+","+"NULL"+")";
                    servicio.guardar(local);
                    tabla.Rows.Add(Fila);
                }

                GridView3.DataSource = tabla;
                GridView3.DataBind();

                Label3.Text = "Archivo Cargado";
            }
            catch (Exception ex)
            {
                Label3.Text = "El archivo no se ha podido subir. el siguiente error ocurrio: " + ex.Message;
            }
        }
    }
}