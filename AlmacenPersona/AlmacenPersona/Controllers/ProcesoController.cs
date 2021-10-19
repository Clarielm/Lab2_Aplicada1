using AlmacenPersona.Models;
using AlmacenPersona.Models.ViewModels;
using AlmacenPersona.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlmacenPersona.Controllers
{
    public class ProcesoController : Controller
    {
        // GET: Proceso
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Resultado(String edad, String nombre, String descripcion)
        {
            ViewBag.edad = edad;
            ViewBag.nombre = nombre;
            ViewBag.descripcion = descripcion;

            PersonaRepository perRepo = new PersonaRepository();
            var List = perRepo.ListDataPersona();
            using (AlmacenPersonaEntities bd = new AlmacenPersonaEntities())
            {
                PersonaRepository persona = new PersonaRepository();
                Persona pers = new Persona();
                pers.NombrePersona = nombre;
                pers.EdadPersona = int.Parse(edad);
                pers.DescripcionPersona = descripcion;
                persona.Create(pers);

            }


            return View(List);
        }

        public ActionResult Validacion(String edad, String nombre, String descripcion)
        {

            ViewBag.edad = edad;
            ViewBag.nombre = nombre;            
            ViewBag.descripcion = descripcion;


            if (int.Parse(edad) >= 18)
            {          
                return Redirect("/Proceso/Resultado");
            }
            else
            {
                return Redirect("/Proceso/Index");
            }



        }


        public ActionResult IndexSegundo(PersonaViewModel per, String edad)
        {
                       
           
            ViewBag.edad = edad;
           

            if (!ModelState.IsValid)
            {

                return View("Index", per);

            }
            else
            {
                if (int.Parse(edad) >= 18)
                {
                    return View("Resultado");
                }
                return View("Index");

            }

        }


    }
}