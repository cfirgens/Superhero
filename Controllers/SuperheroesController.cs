using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Superhero_Project.Models;

namespace Superhero_Project.Controllers
{
    public class SuperheroesController : Controller
    {
        ApplicationDbContext context;
        public SuperheroesController()
        {
            context = new ApplicationDbContext();
        }
        // GET: Superheroes
        public ActionResult Index()
        {
            var superheroList = context.Superheroes.Select(s => s) ;
            return View(superheroList);
        }

        // GET: Superheroes/Details/5
        public ActionResult Details(int id)
        {
            Superhero superhero = context.Superheroes.Where(s => s.Id == id).FirstOrDefault();
            return View(superhero);
        }

        // GET: Superheroes/Create
        public ActionResult Create()
        {
            //Superhero superhero = new Superhero();

            return View();
        }

        // POST: Superheroes/Create
        [HttpPost]
        public ActionResult Create(Superhero superhero)
        {
            try
            {
                // TODO: Add insert logic here
                context.Superheroes.Add(superhero);
                context.SaveChanges();
                return RedirectToAction("Index", "Superheroes");
            }
            catch
            {
                return View();
            }
        }

        // GET: Superheroes/Edit/5
        public ActionResult Edit(int id)
        {
            var superhero = context.Superheroes.Where(s => s.Id == id).FirstOrDefault();
            return View(superhero);
        }

        // POST: Superheroes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Superhero superhero)
        {
            try
            {
                // TODO: Add update logic here
                Superhero editedSuperhero = context.Superheroes.Where(s => s.Id == id).FirstOrDefault();
                editedSuperhero.Id = superhero.Id;
                editedSuperhero.PrimaryAbility = superhero.PrimaryAbility;
                editedSuperhero.SecondaryAbility = superhero.SecondaryAbility;
                editedSuperhero.CatchPhrase = superhero.CatchPhrase;
                editedSuperhero.SuperheroName = superhero.SuperheroName;
                editedSuperhero.AlterEgo = superhero.AlterEgo;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Superheroes/Delete/5
        public ActionResult Delete(int id)
        {
            Superhero superhero = context.Superheroes.Where(s => s.Id == id).First();
            return View();
        }

        // POST: Superheroes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Superhero superhero)
        {
            try
            {
                // TODO: Add delete logic here
                var superheroDelete = context.Superheroes.Where(s => s.Id == id).FirstOrDefault();
                context.Superheroes.Remove(superheroDelete);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
