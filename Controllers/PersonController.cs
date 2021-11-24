using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using oratiqueVuesFortementTypées.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oratiqueVuesFortementTypées.Controllers
{
    public class PersonController : Controller
    {
        private static List<Person> persons = new List<Person>()
        {
            new Person("Leroux","Gilles",25,"sss@hotmail.com"),
            new Person("Flou Flou","Michel",22,"hhh@hotmail.com"),
            new Person("Fafou","Adnil",40,"fff@hotmail.com"),
            new Person("Cailloux","Mystere",38,"aaaa@gmail.com")
        };

        // GET: PersonController
        public ActionResult Index()
        {
            return View(persons);
        }

        // GET: PersonController/Details/5
        public ActionResult Details(string id)
        {
            Person per = persons.Find(p => p.firstName == id);
            return View(per);
        }

        // GET: PersonController/Create
        public ActionResult Create()
        {
            Person p = new Person(); // il faut ajouter un constructeur par défaut
            return View(p);
        }

        // POST: PersonController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Person p)
        {
            try
            {
                persons.Add(p);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonController/Edit/5
        public ActionResult Edit(string id)
        {
            Person per = persons.Find(p => p.firstName == id);
            return View(per);
        }

        // POST: PersonController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, Person p)
//        public ActionResult Edit(string id, Person pe) Lambda
        {
            try
            {
                Person per = persons.Find(p => p.firstName == id);
//                Person per = persons.Find(p => p.firstName == pe.firstName);  Lambda expression
                persons.Remove(per);
                persons.Add(p);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonController/Delete/5
        public ActionResult Delete(string id)
        {
            Person per = persons.Find(p => p.firstName == id);
            persons.Remove(per);
            return View();
        }

        // POST: PersonController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
