using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace semana_16_2.Controllers
{
    public class HelloWordController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Welcome()
        {
            return "Esta es la acción de bienvenida";
        } 

        public string Parametros(string name, int edad)
        {
            return HtmlEncoder.Default.Encode($"Hola {name}, tu edad es: {edad} años");
        }
    }
}
