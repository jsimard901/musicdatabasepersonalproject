using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bands.Models;
using Bands.Data;
using Microsoft.AspNetCore.Authorization;

namespace Bands.Controllers
{
    public class BandController : Controller
    {
        // reference to our dbcontext
        private readonly ApplicationDbContext _context;

        public BandController(ApplicationDbContext context)
        {
            _context = context;
        }

        // action to view all shows
        [Authorize]
        public IActionResult viewAll()
        {
            return View(_context);

        }
        
        // action to view show details from list
        [Authorize]
         public IActionResult showDetails(int showID)
        {
            ShowModel mathcingShow = _context.shows.FirstOrDefault(a => a.id == showID);

            if(mathcingShow != null)
            {
                return View(mathcingShow);
            }
                else
                {
                    return Content("No Matching Show Found!");
                }
        }

        // action to create a new show
        [HttpPost]
        [Authorize]
        public IActionResult createShow (ShowModel newShow)
        {
            if(ModelState.IsValid)
            {
                _context.shows.Add(newShow);
                _context.SaveChanges();
                return RedirectToAction("viewAll", "Band");
            }
                else
                {
                    return View("createForm", newShow);
                }

        }

        // acction that pulls up the form to create a new show
        [Authorize]
        public IActionResult createForm()
        {
            return View();
        }

        // action to edit a show
        [HttpPost]
        [Authorize]
         public IActionResult editShow (ShowModel updateShow)
        {
            ShowModel mathcingShow = _context.shows.FirstOrDefault(a => a.id == updateShow.id);

            if(mathcingShow != null)
            {
                if(ModelState.IsValid)
                {
                    mathcingShow.showDate = updateShow.showDate;
                    mathcingShow.showVenue = updateShow.showVenue;
                    mathcingShow.showRating = updateShow.showRating;
                    mathcingShow.showDescription = updateShow.showDescription;

                    _context.SaveChanges();

                    return RedirectToAction("viewAll", "Band");

                }
                    else
                    {
                        return View("editForm", mathcingShow);
                    }
            }
                else
                {
                    return Content("No Matching Show Found");
                }
        }

        // edit form to edit a show
        [Authorize]
         public IActionResult editForm(int showID)
        {
            ShowModel matchingShow = _context.shows.FirstOrDefault(a => a.id == showID);

            if(matchingShow != null)
            {
                return View(matchingShow);
            }
                else
                {
                    return Content("No Match Found");
                }
        }

       





    }

}