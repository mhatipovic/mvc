using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicStore.Models;
using MusicStore.Models.Repositories;

namespace MusicStore.Controllers
{
    public class ArtistsController : Controller
    {
        //MusicStoreDataContext context = new MusicStoreDataContext();
        ArtistRepository repository = new ArtistRepository();

        // GET: Artists
        public ActionResult Index()
        {
            return View(repository.GetAll());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Artist a)
        {
            if (!ModelState.IsValid) return View(a);

            repository.Add(a);
            repository.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}