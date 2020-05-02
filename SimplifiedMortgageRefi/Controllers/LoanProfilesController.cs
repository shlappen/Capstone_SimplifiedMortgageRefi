using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SimplifiedMortgageRefi.Data;
using SimplifiedMortgageRefi.Models;

namespace SimplifiedMortgageRefi.Controllers
{
    public class LoanProfilesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LoanProfilesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: LoanProfiles
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.LoanProfiles.Include(l => l.Application).Include(l => l.Purpose);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: LoanProfiles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loanProfile = await _context.LoanProfiles
                .Include(l => l.Application)
                .Include(l => l.Purpose)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (loanProfile == null)
            {
                return NotFound();
            }

            return View(loanProfile);
        }

        // GET: LoanProfiles/Create
        public IActionResult Create()
        {
            ViewData["ApplicationId"] = new SelectList(_context.Applications, "Id", "Id");
            ViewData["PurposeId"] = new SelectList(_context.Purposes, "Id", "Id");
            return View();
        }

        // POST: LoanProfiles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Term,Originator,Rate,LoanAmount,EstimatedValue,ApplicationId,IsCashOut,ClosingCost,IsCurrentMortgage,DebtToIncome,LoanToValue,PurposeId")] LoanProfile loanProfile)
        {
            if (ModelState.IsValid)
            {
                _context.Add(loanProfile);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ApplicationId"] = new SelectList(_context.Applications, "Id", "Id", loanProfile.ApplicationId);
            ViewData["PurposeId"] = new SelectList(_context.Purposes, "Id", "Id", loanProfile.PurposeId);
            return View(loanProfile);
        }

        // GET: LoanProfiles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loanProfile = await _context.LoanProfiles.FindAsync(id);
            if (loanProfile == null)
            {
                return NotFound();
            }
            ViewData["ApplicationId"] = new SelectList(_context.Applications, "Id", "Id", loanProfile.ApplicationId);
            ViewData["PurposeId"] = new SelectList(_context.Purposes, "Id", "Id", loanProfile.PurposeId);
            return View(loanProfile);
        }

        // POST: LoanProfiles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Term,Originator,Rate,LoanAmount,EstimatedValue,ApplicationId,IsCashOut,ClosingCost,IsCurrentMortgage,DebtToIncome,LoanToValue,PurposeId")] LoanProfile loanProfile)
        {
            if (id != loanProfile.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loanProfile);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoanProfileExists(loanProfile.Id))
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
            ViewData["ApplicationId"] = new SelectList(_context.Applications, "Id", "Id", loanProfile.ApplicationId);
            ViewData["PurposeId"] = new SelectList(_context.Purposes, "Id", "Id", loanProfile.PurposeId);
            return View(loanProfile);
        }

        // GET: LoanProfiles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loanProfile = await _context.LoanProfiles
                .Include(l => l.Application)
                .Include(l => l.Purpose)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (loanProfile == null)
            {
                return NotFound();
            }

            return View(loanProfile);
        }

        // POST: LoanProfiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var loanProfile = await _context.LoanProfiles.FindAsync(id);
            _context.LoanProfiles.Remove(loanProfile);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoanProfileExists(int id)
        {
            return _context.LoanProfiles.Any(e => e.Id == id);
        }
    }
}
