using GigHub.Models;
using GigHub.ViewModels;
using Microsoft.AspNet.Identity;
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
            var gig = new Gig()
            {
                ArtistId = User.Identity.GetUserId(),
                Venue = viewModel.Venue,
                DateTime = viewModel.DataTime(),
                GenreId = viewModel.Genre
            };

            _context.Gigs.Add( gig );
            _context.SaveChanges();
            return RedirectToAction( "Index", "Home" );
        }
    }
}