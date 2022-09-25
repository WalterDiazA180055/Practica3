using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Servicio_web_en.Net
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod(Description = "Calcular el area de un cuadrado")]
        public int ACuadrado(int lado)
        {
            return lado * lado;
        }
        [WebMethod(Description = "Calcular el area de un triangulo")]
        public int ATriangulo(int Base, int altura)
        {
            return Base * altura / 2;
        }
        [WebMethod(Description = "Calcular el area de un circulo")]
        public double ACirculo(int radio)
        {
            return radio * radio *3.1416;
        }
    }
}

