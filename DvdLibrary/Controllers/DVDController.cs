using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using DvdLibrary.Interfaces;
using DvdLibrary.Models;
using DvdLibrary.Repositories;

namespace DvdLibrary.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class DVDController : Controller
    {
        private IDVDRepository db = DVDLibraryRepositoryFactory.CreateDvdRepository();
        
        [HttpGet]
        public ActionResult List()
        {
            return View(db.GetAll());
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            return View(db.GetByID(id));
        }

        [HttpGet]
        public ActionResult GetByTitle(string searchText)
        {
            return View("List", db.GetByTitle(searchText));
        }

        [HttpGet]
        public ActionResult GetByReleaseYear(string searchText)
        {
            return View("List", db.GetByReleaseYear(searchText));
        }

        [HttpGet]
        public ActionResult GetByDirector(string searchText)
        {
            return View("List", db.GetByDirector(searchText));
        }

        [HttpGet]
        public ActionResult GetByRating(string searchText)
        {
            return View("List", db.GetByRating(searchText));
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(db.GetByID(id));
        }

        [HttpPost]
        public ActionResult Edit(Dvd dvd)
        {
            db.Update(dvd);
            return View(db.GetByID(dvd.DvdID));
        }

        [HttpGet]
        public ActionResult Create()
        {
            Dvd dvd = new Dvd();
            return View(dvd);
        }

        [HttpPost]
        public ActionResult Create(Dvd dvd)
        {
            dvd.DvdID = db.Create(dvd);
            return View("Details", dvd);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(db.GetByID(id));
        }

        public ActionResult DeleteDVD(int id)
        {
            db.Delete(id);
            return View("List", db.GetAll());
        }
    }
}