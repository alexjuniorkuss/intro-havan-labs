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
  
            // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            List<Usuario> model = new List<Usuario>();
            using (var contest = new HavanLabsContest())
            {
                model = contest.Usuarios.ToList();
            }
                return View(model);
            
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Usuario model)
        {
            using (var contest = new HavanLabsContest())
            {
                contest.Usuarios.Add(model);
                contest.SaveChanges();
            }
                return RedirectToAction("List");
        }
        public ActionResult Update(int id)
        {
            Usuario model = new Usuario();
            using (var context = new HavanLabsContest())
            {
                model = context.Usuarios.Find(id);
            }
                return View(model);
        }
        [HttpPost]
        public ActionResult Update(Usuario model)
        {
            using (var contest = new HavanLabsContest())
            {
                contest.Entry(model).State = System.Data.Entity.EntityState.Modified;
                contest.SaveChanges();
            }
            return RedirectToAction("List");
        }
        public ActionResult Delete(int id)
        {
            using (var context = new HavanLabsContest())
            {
                Usuario model = context.Usuarios.Find(id);
                context.Usuarios.Remove(model);
                context.SaveChanges();
            }
                return RedirectToAction("List");
        }
    }
}