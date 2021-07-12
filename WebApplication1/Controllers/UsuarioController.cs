using System;
using Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class UsuarioController : Controller
    {
        List<Usuario> ListaUsuario = new List<Usuario>();
            // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
           
            return View(ListaUsuario);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Usuario model)
        {
            ListaUsuario.Add(model);
            return RedirectToAction("List");
        }

    }
}