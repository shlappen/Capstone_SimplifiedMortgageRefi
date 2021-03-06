﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SimplifiedMortgageRefi.Data;
using SimplifiedMortgageRefi.Models;

namespace SimplifiedMortgageRefi.Controllers
{
    public class LendersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LendersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Customers
        public async Task<IActionResult> Index()
        {
            //var applicationDbContext = _context.Applications.Include(c => c.Property);
            var applicationDbContext = _context.Applications_Customers
                .Include(a => a.Application.Property)
                .Include(a => a.Application.Contacts)
                .Include(c => c.Customer);
            int i = 0;
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Lenders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lender = await _context.Customers
                .Include(l => l.IdentityUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lender == null)
            {
                return NotFound();
            }

            return View(lender);
        }

        public async Task<IActionResult> CreateContact(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lender = await _context.Applications
                .Include(l => l.Customers)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lender == null)
            {
                return NotFound();
            }

            return View(lender);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> CreateContact([Bind("Id,Result")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contact);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contact);
        }

        // GET: Lenders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Lenders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,IdentityUserId")] Lender lender)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                lender.IdentityUserId = userId;
                _context.Add(lender);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lender);
        }

        // GET: Lenders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lender = await _context.Customers.FindAsync(id);
            if (lender == null)
            {
                return NotFound();
            }
            return View(lender);
        }

        // POST: Lenders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,IdentityUserId")] Customer customer)
        {
            if (id != customer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LenderExists(customer.Id))
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
            return View(customer);
        }

        // GET: Lenders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lender = await _context.Lenders
                .Include(l => l.IdentityUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lender == null)
            {
                return NotFound();
            }

            return View(lender);
        }

        // POST: Lenders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lender = await _context.Lenders.FindAsync(id);
            _context.Lenders.Remove(lender);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LenderExists(int id)
        {
            return _context.Lenders.Any(e => e.Id == id);
        }
    }
}
