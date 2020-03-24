using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Spice.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spice.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SubCategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public SubCategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        // Get Index
        public async Task<IActionResult> Index()
        {
            var subCategories = await _db.SubCategory
                                        .Include(s => s.Category)
                                        .ToListAsync();

            return View(subCategories);
        }
    }
}
