using GigHub.Models;
using GigHub.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Linq;
using System.Web.Mvc;

namespace GigHub.Controllers
{
    [Authorize]
    public class GigsController : Controller
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();



        // GET: Gigs/Create
        public ActionResult Create()
        {
            var viewModel = new GigFormViewModel()
            {
                Genres = _context.Genres.ToList()
            };
            return View( viewModel );
        }

        [HttpPost]
        public ActionResult Create( GigFormViewModel viewModel )
        {
            var userId = User.Identity.GetUserId();
            var gig = new Gig()
            {
                ArtistId = userId,
                Venue = viewModel.Venue,
                DateTime = DateTime.Parse( $"{viewModel.Date} {viewModel.Time}" ),
                GenreId = viewModel.Genre
            };

            _context.Gigs.Add( gig );
            _context.SaveChanges();
            return RedirectToAction( "Index", "Home" );
        }
    }
}