using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HoangThiHaiAnh883.Models;

namespace HoangThiHaiAnh883.Controllers
{
    public class CompamyHthA883Controller : Controller
    {
        private readonly MvcMovieContext _context;

        public CompamyHthA883Controller(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: CompamyHthA883
        public async Task<IActionResult> Index()
        {
            return View(await _context.CompamyHthA883.ToListAsync());
        }

        // GET: CompamyHthA883/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compamyHthA883 = await _context.CompamyHthA883
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (compamyHthA883 == null)
            {
                return NotFound();
            }

            return View(compamyHthA883);
        }

        // GET: CompamyHthA883/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CompamyHthA883/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompanyId,CompanyName")] CompamyHthA883 compamyHthA883)
        {
            if (ModelState.IsValid)
            {
                _context.Add(compamyHthA883);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(compamyHthA883);
        }

        // GET: CompamyHthA883/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compamyHthA883 = await _context.CompamyHthA883.FindAsync(id);
            if (compamyHthA883 == null)
            {
                return NotFound();
            }
            return View(compamyHthA883);
        }

        // POST: CompamyHthA883/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CompanyId,CompanyName")] CompamyHthA883 compamyHthA883)
        {
            if (id != compamyHthA883.CompanyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(compamyHthA883);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompamyHthA883Exists(compamyHthA883.CompanyId))
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
            return View(compamyHthA883);
        }

        // GET: CompamyHthA883/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compamyHthA883 = await _context.CompamyHthA883
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (compamyHthA883 == null)
            {
                return NotFound();
            }

            return View(compamyHthA883);
        }

        // POST: CompamyHthA883/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var compamyHthA883 = await _context.CompamyHthA883.FindAsync(id);
            _context.CompamyHthA883.Remove(compamyHthA883);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompamyHthA883Exists(string id)
        {
            return _context.CompamyHthA883.Any(e => e.CompanyId == id);
        }
    }
}
