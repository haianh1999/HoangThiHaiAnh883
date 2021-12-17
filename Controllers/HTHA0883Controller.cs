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
    public class HTHA0883Controller : Controller
    {
        private readonly MvcMovieContext _context;

        public HTHA0883Controller(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: HTHA0883
        public async Task<IActionResult> Index()
        {
            return View(await _context.HTHA0883.ToListAsync());
        }

        // GET: HTHA0883/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hTHA0883 = await _context.HTHA0883
                .FirstOrDefaultAsync(m => m.HTHAID == id);
            if (hTHA0883 == null)
            {
                return NotFound();
            }

            return View(hTHA0883);
        }

        // GET: HTHA0883/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HTHA0883/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HTHAID,HTHAName,HTHAgender")] HTHA0883 hTHA0883)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hTHA0883);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hTHA0883);
        }

        // GET: HTHA0883/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hTHA0883 = await _context.HTHA0883.FindAsync(id);
            if (hTHA0883 == null)
            {
                return NotFound();
            }
            return View(hTHA0883);
        }

        // POST: HTHA0883/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("HTHAID,HTHAName,HTHAgender")] HTHA0883 hTHA0883)
        {
            if (id != hTHA0883.HTHAID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hTHA0883);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HTHA0883Exists(hTHA0883.HTHAID))
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
            return View(hTHA0883);
        }

        // GET: HTHA0883/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hTHA0883 = await _context.HTHA0883
                .FirstOrDefaultAsync(m => m.HTHAID == id);
            if (hTHA0883 == null)
            {
                return NotFound();
            }

            return View(hTHA0883);
        }

        // POST: HTHA0883/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var hTHA0883 = await _context.HTHA0883.FindAsync(id);
            _context.HTHA0883.Remove(hTHA0883);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HTHA0883Exists(string id)
        {
            return _context.HTHA0883.Any(e => e.HTHAID == id);
        }
    }
}
