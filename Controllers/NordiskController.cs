using Microsoft.AspNetCore.Mvc;
using NordiskLuksusMVC.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace NordiskLuksusMVC.Controllers
{

    public class NordiskController : Controller
    {
        private readonly MatContext _context;


        public NordiskController(MatContext context)
        {
            _context = context;
        }

        //Welcome page
        public async Task<IActionResult> Welcome()
        {
            List<Mat> matList = await _context.Mat.ToListAsync();
            return View(matList);
        }

        //Admin Edit page
        public async Task<IActionResult> AdminEditPage()
        {
            List<Mat> matList = await _context.Mat.ToListAsync();
            return View(matList);
        }

        public async Task<IActionResult> EditMat(int? id)
        {
            Mat mat = await _context.Mat.SingleOrDefaultAsync(_mat => _mat.MatId == id);
            return View(mat);
        }

        //Edit Food item
        [HttpPost]
        public async Task<IActionResult> EditMat(int? id, [Bind("MatId, Name, ImgSrc")] Mat mat)
        {
            _context.Update(mat);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(AdminEditPage));
        }

        //Delete Food item
        public async Task<IActionResult> DeleteMat(int? id)
        {
            Mat mat = await _context.Mat.SingleOrDefaultAsync(_mat => _mat.MatId == id);
            return View(mat);
        }

        [HttpPost, ActionName("DeleteMat")]
        public async Task<IActionResult> DeleteMatConfirm(int? id)
        {
            Mat mat = await _context.Mat.SingleOrDefaultAsync(_mat => _mat.MatId == id);
            _context.Mat.Remove(mat);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(AdminEditPage));
        }

        //Create food item
        public IActionResult CreateMat()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateMat([Bind("MatId, Name, ImgSrc")] Mat mat)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mat);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(AdminEditPage));
            }
            else
            {
                return View(mat);
            }
        }

        //About us page
        public IActionResult AboutUs()
        {
            return View();
        }
        //Login page
        public IActionResult Login()
        {
            return View();
        }

        //Session
        //Set
        [HttpGet]
        public IActionResult GuestLogIn([Bind("Name")] Guest guest)
        {
            HttpContext.Session.SetString("Name", guest.Name);
            ViewData["Session_Name"] = HttpContext.Session.GetString("Name");
            return View();
        }

        //Get
        [HttpGet]
        public IActionResult GuestLogIn()
        {
            if (HttpContext.Session.GetString("Name") != null)
            {
                ViewData["Session_Name"] = HttpContext.Session.GetString("Name");
            }
            return View();
        }
    }
}