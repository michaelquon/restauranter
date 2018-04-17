using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rest.Models;
using Microsoft.EntityFrameworkCore;

namespace Rest.Controllers
{
    public class RestController : Controller
    {
        private RestContext _context;
        public RestController(RestContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View("Index");
        }
        [HttpPost]
        [Route("addReview")]
        public  IActionResult addReview(RestViewModel reviewer)
        {
            if(ModelState.IsValid)
            {
                Reviewer newReviewer = new Reviewer
                {
                    name = reviewer.name,
                    stars = reviewer.stars,
                    rest_name = reviewer.rest_name,
                    review = reviewer.review,
                    date = reviewer.date
                };
                _context.Add(newReviewer);
                _context.SaveChanges();
                return RedirectToAction("Reviews");
            }
            else
            {
                return View ("Index");
            }
        }
        [HttpGet]
        [Route("Reviews")]
        public IActionResult Reviews()
        {
            List<Reviewer> allReviews = _context.reviewers.OrderByDescending(reviewers => reviewers.created_at).ToList();
           
                ViewBag.reviews = allReviews;
         
                return View ("Reviews");
        }
    }
}
