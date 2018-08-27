using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UmbracoClassLibary.Models;
using UmbracoHomework.Models;

namespace UmbracoHomework.Controllers
{
    public class HomeController : Controller
    {
        private readonly PrizeDrawContext _context;

        public HomeController(PrizeDrawContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index([Bind("Id,FirstName,LastName,Email,SerialNumber,BirthDay")] Submission submission)
        {
            if (!(_context.SerialNumbers.Any(o => o.Id == submission.SerialNumber)))
            {
                ModelState.AddModelError("","invalid serial number");
            }

            if (ValidateBirthDate(submission.BirthDay) > 0)
            {
                ModelState.AddModelError("","To enter this draw you must be at least 18 years old");
            }

            if (_context.Submissions.Count(c => c.SerialNumber == submission.SerialNumber) >= 2)
            {
                ModelState.AddModelError("","You can only enter the draw two times with the same serial number");
            }

            if (ModelState.IsValid)
            {
                _context.Add(submission);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(submission);
        }

        public async Task<IActionResult> Submissions()
        {
            return View(await _context.Submissions.ToListAsync());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public int ValidateBirthDate(DateTime birthday)
        {
            DateTime today = DateTime.Now;
            DateTime validDate = new DateTime(today.Year - 18, today.Month, today.Day);
            TimeSpan validAge = today.Subtract(validDate);
            TimeSpan actualAge = today.Subtract(birthday);
            return TimeSpan.Compare(validAge, actualAge);
        }
    }
}
