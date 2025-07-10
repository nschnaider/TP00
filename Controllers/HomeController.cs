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
                HttpContext.Session.SetString("n", integrante.Nombre);
                HttpContext.Session.SetString("d", integrante.Direccion);
                HttpContext.Session.SetString("tel", integrante.Telefono);
                HttpContext.Session.SetString("t", integrante.Tiempo);
                HttpContext.Session.SetString("edad", integrante.Edad);
                HttpContext.Session.SetString("f", integrante.Fecha.ToShortDateString());

                return RedirectToAction("Perfil");
            }

            ViewBag.Error = "Usuario o contraseña incorrectos";
            return View();
        }

        // VISTA DE PERFIL (Solo si está logueado)
        public IActionResult Perfil()
{
        ViewBag.nombre = HttpContext.Session.GetString("n");
    if (HttpContext.Session.GetString("n") == null)
    {
        return RedirectToAction("Index");
    }

    
    ViewBag.direccion = HttpContext.Session.GetString("d");
    ViewBag.telefono = HttpContext.Session.GetString("tel");
    ViewBag.tiempo = HttpContext.Session.GetString("t");
    ViewBag.edad = HttpContext.Session.GetString("edad");
    ViewBag.fecha = HttpContext.Session.GetString("f");
    

    
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
        public IActionResult Registrar(string n, string p, string edad, DateTime f, string t, string d, string tel)
{
    BD.Registrar(new Integrante(n, p, edad, f, t, d, tel));
    return RedirectToAction("Index");
}
    }
}
