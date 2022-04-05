using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using DvdLibrary.Models;
using DvdLibrary.Repository;

namespace DvdLibrary.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class DVDController : Controller
    {
        private DvdLibraryRepository db = new DvdLibraryRepository();
        
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
        public ActionResult Edit(int id)
        {
            return View(db.GetByID(id));
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