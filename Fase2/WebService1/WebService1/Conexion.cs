using System;
using System.Collections.Generic;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Conexion
/// </summary>
public class Conexion
{
    SqlConnection conexion;
    string coneccion = "Data Source=WILLIAM-PC;Initial Catalog=QuetzalExpress;Integrated Security=True";

    public Conexion()
    {
        //
        // TODO: Add constructor logic here
        //
        conexion = new SqlConnection("Data Source=WILLIAM-PC;Initial Catalog=QuetzalExpress;Integrated Security=True");

    }
    public SqlConnection getConexion()
    {
        try
        {
            SqlConnection conexion = new SqlConnection("Data Source=WILLIAM-PC;Initial Catalog=QuetzalExpress;Integrated Security=True");
            return conexion;
        }
        catch
        {
            return null;
        }
    }

    public void abrir()
    {
        try
        {
            conexion.Open();
        }
        catch { }
    }

    public void cerrar()
    {
        try
        {
            conexion.Close();
        }
        catch
        {

        }
    }
    public void conectar(string dato)
    {
        SqlConnection com = new SqlConnection(coneccion);
        SqlCommand comand = new SqlCommand(dato, com);
        com.Open();
        comand.ExecuteNonQuery();
        com.Close();
    }
}