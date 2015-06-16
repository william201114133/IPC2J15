using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Conexion
/// </summary>
public class Conexion
{
    string coneccion = "Data Source=William-PC;Initial Catalog=biblioteca;Integrated Security=True";
        

    public Conexion()
    { }
       public void conectar(string dato){
        SqlConnection com = new SqlConnection(coneccion);
        SqlCommand comand = new SqlCommand(dato, com);
        com.Open();
        comand.ExecuteNonQuery();
        com.Close();
       }
}