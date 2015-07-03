using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Configuration;
using System.IO;

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
        static int codusuario = 0;
        static int depto = 0;
        static int sucursal = 0;
        static string puesto = "";
        Conexion con = new Conexion();
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
       

        public Boolean LoginEmpleado(String nombre, String contra)
        {
            SqlConnection con = new SqlConnection("Data Source=WILLIAM-PC;Initial Catalog=QuetzalExpress;Integrated Security=True");
            SqlCommand comando;
            String query;

            try
            {

                query = "SELECT * FROM Empleado WHERE nombres = '" + nombre + "' and contraseña='"+contra+"'";

                DataTable dt = new DataTable();
                comando = new SqlCommand(query, con);
                comando.Parameters.AddWithValue("@nombres", nombre);
                SqlDataAdapter adap = new SqlDataAdapter(comando);
                adap.Fill(dt);
                DataRow row = dt.Rows[0];
                puesto = Convert.ToString(row["puesto"]);
                depto = Convert.ToInt32(row["iddepartamento"]);
                codusuario = Convert.ToInt32(row["idEmpleado"]);
                sucursal = Convert.ToInt32(row["idsucursal"]);
                con.Open();
                Object ob = comando.ExecuteScalar();

                if (ob == null)
                {
                    con.Close();
                    return false;
                }
                else
                {
                    con.Close();
                    return true;
                }

            }
            catch
            {
                return false;
            }
        }

       [WebMethod]
        public Boolean logincliente(string nombre, string contra)
        {
            SqlConnection con = new SqlConnection("Data Source=WILLIAM-PC;Initial Catalog=QuetzalExpress;Integrated Security=True");
            SqlCommand comando;
            String query;

            try
            {

                query = "SELECT * FROM Cliente WHERE nombres = '" + nombre + "' and contraseña='" + contra + "'";

                DataTable dt = new DataTable();
                comando = new SqlCommand(query, con);
                comando.Parameters.AddWithValue("@nombres", nombre);
                SqlDataAdapter adap = new SqlDataAdapter(comando);
                adap.Fill(dt);
                DataRow row = dt.Rows[0];
                codusuario = Convert.ToInt32(row["idCliente"]);
                puesto = Convert.ToString(row["estado"]);
                con.Open();
                Object ob = comando.ExecuteScalar();

                if (ob == null)
                {
                    con.Close();
                    return false;
                }
                else
                {
                    con.Close();
                    return true;
                }

            }
            catch
            {
                return false;
            }
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

        [WebMethod]
        public List<string[]> CargaCSV(string dato)
        {



            List<string[]> parsedData = new List<string[]>();

            try
            {
                using (StreamReader readFile = new StreamReader(dato))
                {
                    string line;
                    string[] row;

                    while ((line = readFile.ReadLine()) != null)
                    {
                        row = line.Split(',');
                        parsedData.Add(row);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return parsedData;
        }
        [WebMethod]
        public Boolean VerificarDepto(string depton) {
            SqlConnection con = new SqlConnection("Data Source=WILLIAM-PC;Initial Catalog=QuetzalExpress;Integrated Security=True");
            SqlCommand comando;
            String query;

            try
            {

                query = "SELECT * FROM Departamento WHERE nombre = '" + depton +"'";

                DataTable dt = new DataTable();
                comando = new SqlCommand(query, con);
                comando.Parameters.AddWithValue("@nombre", depton);
                SqlDataAdapter adap = new SqlDataAdapter(comando);
                adap.Fill(dt);
                DataRow row = dt.Rows[0];
                depto = Convert.ToInt32(row["idDepartamento"]);
                con.Open();
                Object ob = comando.ExecuteScalar();

                if (ob == null)
                {
                    con.Close();
                    return false;
                }
                else
                {
                    con.Close();
                    return true;
                }

            }
            catch
            {
                return false;
            }
        }
        [WebMethod]
        public Boolean VerificarSucursal(string sucur)
        {
            SqlConnection con = new SqlConnection("Data Source=WILLIAM-PC;Initial Catalog=QuetzalExpress;Integrated Security=True");
            SqlCommand comando;
            String query;

            try
            {

                query = "SELECT * FROM Sucursal WHERE pais = '" + sucur + "'";

                DataTable dt = new DataTable();
                comando = new SqlCommand(query, con);
                comando.Parameters.AddWithValue("@pais", sucur);
                SqlDataAdapter adap = new SqlDataAdapter(comando);
                adap.Fill(dt);
                DataRow row = dt.Rows[0];
                sucursal = Convert.ToInt32(row["idSucursal"]);
                con.Open();
                Object ob = comando.ExecuteScalar();

                if (ob == null)
                {
                    con.Close();
                    return false;
                }
                else
                {
                    con.Close();
                    return true;
                }

            }
            catch
            {
                return false;
            }
        }

    }
}