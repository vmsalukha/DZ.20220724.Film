using DZ._20220724.Film.Interfaces;
using DZ._20220724.Film.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DZ._20220724.Film.Controllers
{
    public class HomeController : Controller
    {
        IRepository repository;
        public HomeController(IRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult Index()
        {
            return View(repository.Show());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Movie movie)
        {
            repository.AddMovie(movie);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int Id)
        {
            return View(repository.DetailsMovie(Id));
        }

        public IActionResult Edit(int Id)
        {
            return View(repository.DetailsMovie(Id));
        }
        [HttpPost]
        public IActionResult Edit(Movie movie)
        {
            repository.EditMovie(movie);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int Id)
        {
            return View(repository.DetailsMovie(Id));
        }
        [HttpPost]
        public IActionResult Delete(Movie movie)
        {
            repository.DelMovie(movie.Id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult SearchMovie(string filter,string searchMovie)
        {
            IEnumerable<Movie> movieList = repository.SearchMovie(filter, searchMovie); 
            return View(movieList);
            //return View();
        }
        public IActionResult EditSessionList(int Id)
        {
            return View(repository.DetailsMovie(Id));
        }
       
        public IActionResult AddSession(int Id)
        {
            return View(repository.DetailsMovie(Id));
        }
        [HttpPost]
        public IActionResult AddSession(int Id, string addSession)
        {
            repository.AddSessionList(Id, addSession);
            return View(repository.DetailsMovie(Id));
        }
        public IActionResult DelSession(int Id)
        {
            return View(repository.DetailsMovie(Id));
        }
        [HttpPost]
        public IActionResult DelSession(int Id, string delSession)
        {
            repository.DelSessionList(Id, delSession);
            return View(repository.DetailsMovie(Id));
        }
    }
}
