using AlumnosBD.contex;
using AlumnosBD.Models;
using System.Linq;
using System.Web.Mvc;

namespace AlumnosBD.Controllers
{
    public class AlumnosController : Controller
    {
        
        private CadenaConexion db = new CadenaConexion();
        // GET: Alumnos
        public ActionResult Index()
        {
            return View(db.AlunosModel.ToList());
        }

        // GET: Alumnos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Alumnos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Alumnos/Create
        [HttpPost]
        public ActionResult Create(AlumnosModel alumnos)
        {
           
            try
            {
                if (ModelState.IsValid)
                {
                    db.AlunosModel.Add(alumnos);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(alumnos);

                
            }
            catch
            {
                return View();
            }
        }

        // GET: Alumnos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Alumnos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alumnos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Alumnos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
