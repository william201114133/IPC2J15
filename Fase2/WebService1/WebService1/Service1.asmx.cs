using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;

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

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string loginempleado(string nombre, string depto) {
            login log = new login();
            log.verificarDatos(nombre, depto);
            codusuario = login.codigoempleado;
            return "aceptado";
        }

        [WebMethod]
        public string logincliente(string nombre)
        {
            login log = new login();
            log.verificarcliente(nombre);
            codusuario = login.codigoempleado;
            return "aceptado";
        }

        [WebMethod]
        public string guardar(string dato) {
            Conexion coneccion = new Conexion();
            coneccion.conectar(dato);
            return "informacion guardada";
        }

        [WebMethod]
        public int codigousuario() {
            return codusuario;
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