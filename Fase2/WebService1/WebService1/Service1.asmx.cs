using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Configuration;

namespace WebService1
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class Service1 : System.Web.Services.WebService
    {
        int codusuario = 0;
        int depto = 0;
        int sucursal = 0;
        string puesto = "";
        string query;
        Conexion con = new Conexion();
        SqlCommand comando;
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        
       /* public string loginempleado(string nombre,string contraseña) {
            login log = new login();
            if (log.verificarDatos(nombre, contraseña).Equals(true))
            {
                codusuario = login.codigoempleado;
                depto = login.departamento;
                sucursal = login.sucursal;
                puesto = login.puesto.ToString();
                return "aceptado";
            }
            else { return "negado"; }
        }*/
        [WebMethod]
        public Boolean loginempleado(String nombres, String cone)
        {
            try
            {

                query = "SELECT idEmpleado FROM Empleado" +
                   " WHERE nombres = '" + nombres + "'" +
                   " and contraseña = '" + cone + "'";

                DataTable dt = new DataTable();
                //DataTable dt = Buscar(use);
                comando = new SqlCommand(query, con.getConexion());
                comando.Parameters.AddWithValue("@nombres", nombres);
                SqlDataAdapter adap = new SqlDataAdapter(comando);
                adap.Fill(dt);
                DataRow row = dt.Rows[0];
                codusuario = Convert.ToInt32(row["idEmpleado"]);
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

        [WebMethod]
        public string logincliente(string nombre, string contraseña)
        {
            login log = new login();
            if (log.verificarcliente(nombre, contraseña).Equals(true))
            {
                codusuario = login.codigoempleado;
                puesto = login.puesto;
                return "aceptado";
            }
            else { return "negado"; }
        }

        [WebMethod]
        public string guardar(string dato) {
            SqlConnection com = new SqlConnection("Data Source=WILLIAM-PC;Initial Catalog=QuetzalExpress;Integrated Security=True");
            SqlCommand comand = new SqlCommand(dato, com);
            com.Open();
            comand.ExecuteNonQuery();
            com.Close();
            return "informacion guardada";
        }

        [WebMethod]
        public int codigousuario() {
            return codusuario;
        }

        [WebMethod]
        public int coddepto()
        {
            return depto;
        }
        [WebMethod]
        public int codsucursal()
        {
            return sucursal;
        }
        [WebMethod]
        public string verpuesto()
        {
            return puesto;
        }
        [WebMethod]
        public double calculocosto(int precio, int peso, double porcentaje) {
            int costo = peso * 5;
            double impuesto = precio * porcentaje;
            double suma = costo + impuesto;
            double comision = suma * 0.05;
            double total = costo + impuesto + comision;
            return total;
        }


    }
}