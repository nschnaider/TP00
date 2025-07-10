using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP00.Models;

namespace TP00.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // VISTA DE INICIO (LOGIN)
        public IActionResult Index()
        {
            return View(); // Login.cshtml
        }

        // POST: LOGIN
        [HttpPost]
        public IActionResult Index(string nombre, string password)
        {
            Integrante integrante = BD.Login(nombre, password);
           
            if (integrante != null)
            {
                // Guardamos solo datos necesarios (sin ID)
                HttpContext.Session.SetString("Nombre", integrante.Nombre);
                HttpContext.Session.SetString("Direccion", integrante.Direccion);
                HttpContext.Session.SetString("Telefono", integrante.Telefono);
                HttpContext.Session.SetString("Tiempo", integrante.Tiempo);
                HttpContext.Session.SetString("Edad", integrante.Edad.ToString());
                HttpContext.Session.SetString("Fecha", integrante.Fecha.ToShortDateString());

                return RedirectToAction("Perfil");
            }

            ViewBag.Error = "Usuario o contraseña incorrectos";
            return View();
        }

        // VISTA DE PERFIL (Solo si está logueado)
           public IActionResult Perfil()
        {
            string nombre = HttpContext.Session.GetString("Nombre");
            if (nombre == null){
                return RedirectToAction("Index");
            }
            // Crear objeto con los datos guardados en Session
            Integrante i = new Integrante
            {
                Nombre = nombre,
                Direccion = HttpContext.Session.GetString("Direccion"),
                Telefono = HttpContext.Session.GetString("Telefono"),
                Tiempo = HttpContext.Session.GetString("Tiempo"),
                Edad = HttpContext.Session.GetString("Edad"),
                Fecha = DateTime.Parse(HttpContext.Session.GetString("Fecha") ?? DateTime.Now.ToString())
            };
            ViewBag.i= i;

            return View();
        }

        // LOGOUT
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        // VISTA DE REGISTRO
        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Integrante nuevo)
        {
            BD.Registrar(nuevo); // El ID se genera solo en la BD
            return RedirectToAction("Index");
        }
    }
}
