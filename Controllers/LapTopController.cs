using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class LapTopController : Controller
    {
        private readonly MvcMovieContext _context;

        public LapTopController(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: LapTop
        public async Task<IActionResult> Index()
        {
            return View(await _context.LapTop.ToListAsync());
        }

        // GET: LapTop/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lapTop = await _context.LapTop
                .FirstOrDefaultAsync(m => m.ID == id);
            if (lapTop == null)
            {
                return NotFound();
            }

            return View(lapTop);
        }

        // GET: LapTop/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LapTop/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NhaSanXuat,Gia,ID,Ten,ThongSo")] LapTop lapTop)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lapTop);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lapTop);
        }

        // GET: LapTop/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lapTop = await _context.LapTop.FindAsync(id);
            if (lapTop == null)
            {
                return NotFound();
            }
            return View(lapTop);
        }

        // POST: LapTop/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("NhaSanXuat,Gia,ID,Ten,ThongSo")] LapTop lapTop)
        {
            if (id != lapTop.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lapTop);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LapTopExists(lapTop.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(lapTop);
        }

        // GET: LapTop/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lapTop = await _context.LapTop
                .FirstOrDefaultAsync(m => m.ID == id);
            if (lapTop == null)
            {
                return NotFound();
            }

            return View(lapTop);
        }

        // POST: LapTop/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var lapTop = await _context.LapTop.FindAsync(id);
            _context.LapTop.Remove(lapTop);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LapTopExists(string id)
        {
            return _context.LapTop.Any(e => e.ID == id);
        }
    }
}
