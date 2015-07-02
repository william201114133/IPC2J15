using System;
using System.Collections.Generic;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// Summary description for login
/// </summary>
public class login
{
    //instancio la clase de conexion
    Conexion con = new Conexion();
    SqlCommand comando;
    String query;

    public login()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public Boolean verificarDatos(String use, String cone)
    {
        try
        {

            query = "USE QuetzalExpress SELECT * FROM Empleado" +
                    " WHERE nombres = '" + use + "'" +
                    " and contraseña = '" + cone + "'";


            comando = new SqlCommand(query, con.getConexion());
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