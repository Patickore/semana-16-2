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

        public IActionResult Bienvenida(string name, int numTimes = 1)
        {
            ViewData["name"] = "Hola" + name;
            ViewData["numTimes"] = numTimes;
            return View();
        } 

        public string Parametros(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hola {name}, su numero de intento es: {numTimes}");
        }
    }
}
