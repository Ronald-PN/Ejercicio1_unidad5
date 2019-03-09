using Diplomado_MVC_UASD_Estudiante_ImageUpload.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;



namespace Diplomado_MVC_UASD_Estudiante_ImageUpload.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult FileUpload(HttpPostedFileBase file) {
            if (file != null)
            {
                EstudianteDBEntities db = new EstudianteDBEntities();
                string ImageName = System.IO.Path.GetFileName(file.FileName);
                string physicalPath = Server.MapPath("~/Images/" + ImageName);

                file.SaveAs(physicalPath);
            
                tblEstudiante estudiante = new tblEstudiante();
                estudiante.Nombres = Request.Form["Nombres"];
                estudiante.Apellidos = Request.Form["Apellidos"];
                estudiante.Direccion = Request.Form["Direccion"];
                estudiante.Telefono = Request.Form["Telefono"];
                estudiante.Cedula = Request.Form["Cedula"];
                estudiante.ImageUrl = ImageName;

                db.tblEstudiantes.Add(estudiante);
                db.SaveChanges();
            }
            return RedirectToAction("/Home/Detalle/");
        }
        public ActionResult Detalle()
        {
            return View();
        }
        public ActionResult Estudiantes()
        {
            return View();
        }
        public ActionResult Abaut()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }
       
    }
}