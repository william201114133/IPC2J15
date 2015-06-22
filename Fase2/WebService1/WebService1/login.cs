using System;
using System.Collections.Generic;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


/// <summary>
/// Summary description for login
/// </summary>
public class login
{
    //instancio la clase de conexion
    Conexion con = new Conexion();
    SqlCommand comando;
    String query;
    public static int codigoempleado=0;
    public login()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public Boolean verificarDatos(String nombre, String puesto)
    {
        try
        {

            query = "SELECT codempleado FROM Empleado" +
                    " WHERE nombres = '" +nombre + "'" +
                    " and puestos = '" + puesto + "'";

            DataTable dt = new DataTable();
            //DataTable dt = Buscar(use);
            comando = new SqlCommand(query, con.getConexion());
            comando.Parameters.AddWithValue("@nombre", nombre);
            SqlDataAdapter adap = new SqlDataAdapter(comando);
            adap.Fill(dt);
            DataRow row = dt.Rows[0];
            codigoempleado = Convert.ToInt32(row["idEmpleado"]);
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
        catch
        {
            return false;
        }
    }
  

    public Boolean verificarcliente(String nombre)
    {
        try
        {

            query = "SELECT idcliente FROM Cliente" +
                    " WHERE nombres = '" + nombre + "'";
            DataTable dt = new DataTable();
            //DataTable dt = Buscar(use);
            comando = new SqlCommand(query, con.getConexion());
            comando.Parameters.AddWithValue("@nombres", nombre);
            SqlDataAdapter adap = new SqlDataAdapter(comando);
            adap.Fill(dt);
            DataRow row = dt.Rows[0];
            codigoempleado = Convert.ToInt32(row["idCliente"]);
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
        catch
        {
            return false;
        }
    }
}