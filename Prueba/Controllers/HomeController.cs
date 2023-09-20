using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Prueba.Models;

namespace Prueba.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

      public IActionResult Index()
    {
        ViewBag.ListaAlumnos = BD.SeleccionarAlumnos();
        ViewBag.ListaAlumnosAprobados = BD.ElegirAlumnoAprobado();
        ViewBag.ListaAlumnosDesaprobados = BD.ElegirAlumnoDesaprobado();
        return View();
    }

     public IActionResult VerDetalleAlumno(int IdAlumno)
    {
        Alumno alumno = BD.AlumnoElegido(IdAlumno);

        if (alumno == null)
        {
            return NotFound(); // Devuelve una respuesta 404 si el alumno no se encuentra
        }
        string resultadoNota = alumno.Promedio >= 6 ? "Aprobado" : "Desaprobado";
        ViewBag.Alumno = alumno;
        ViewBag.ResultadoNota= resultadoNota; 
    return View();
}
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}


