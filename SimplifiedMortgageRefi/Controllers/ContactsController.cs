using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore;
using SimplifiedMortgageRefi.Data;
using SimplifiedMortgageRefi.Models;
using SimplifiedMortgageRefi.ViewModels;

namespace SimplifiedMortgageRefi.Controllers
{
    public class ContactsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactsController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: Contacts
        public ActionResult Index()
        {
            return View();
        }

        // GET: Contacts/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Contacts/Create
        public async Task<IActionResult> Create(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var lender = _context.Lenders.Where(c => c.IdentityUserId == userId).FirstOrDefault();

            ContactCustomerViewModel contactCustomerViewModel = new ContactCustomerViewModel();
            contactCustomerViewModel.Lender = lender;
            contactCustomerViewModel.Application = await _context.Applications.Include(a => a.Property).Include(a => a.Liabilities).Include(a => a.LoanProfiles).FirstOrDefaultAsync(m => m.Id == id);
            contactCustomerViewModel.Customers = _context.Customers.Where(c => c.Id == contactCustomerViewModel.Application.Id).ToList();
            contactCustomerViewModel.Contacts = _context.Contacts.Where(c => c.ApplicationId == contactCustomerViewModel.Application.Id).ToList();
            contactCustomerViewModel.Customer = contactCustomerViewModel.Customers.FirstOrDefault();
            contactCustomerViewModel.Property = contactCustomerViewModel.Application.Property;
            contactCustomerViewModel.Liabilities = contactCustomerViewModel.Application.Liabilities.ToList();
            contactCustomerViewModel.LoanProfiles = contactCustomerViewModel.Application.LoanProfiles.ToList();
            if (contactCustomerViewModel.Application == null)
            {
                return NotFound(); 
            }

            return View(contactCustomerViewModel);
        }

        // POST: Contacts/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int id, [Bind("Result")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var lender = _context.Lenders.Where(c => c.IdentityUserId == userId).FirstOrDefault();

                contact.LenderId = lender.Id;
                contact.ApplicationId = id;
                contact.DateTime = DateTime.Now;
                _context.Add(contact);
                await _context.SaveChangesAsync();


                return RedirectToAction("Create", new { id = id });
            }
            return View(contact);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateLoanProfile([Bind("Id")] Application application,
[Bind("Term,Rate,LoanAmount,ClosingCost")] LoanProfile loanProfile)
        {

            if (ModelState.IsValid)
            {
                var purposeId = _context.LoanProfiles.Where(l => l.ApplicationId == application.Id).Select(p => p.PurposeId).FirstOrDefault();
                loanProfile.Originator = "Customer";
                loanProfile.ApplicationId = application.Id;
                loanProfile.PurposeId = purposeId;


                _context.Add(loanProfile);
                await _context.SaveChangesAsync();
                return RedirectToAction("Create", "Contacts", new { id = application.Id });
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditLoanProfile(int id, [Bind("Id,Term,ClosingCost,LoanAmount,Rate")] LoanProfile loanProfile)
        
        {


            var loanProfileInDb = _context.LoanProfiles.Where(c => c.Id == loanProfile.Id).SingleOrDefault();
            if (id != loanProfile.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                //try
                //{
                    loanProfileInDb.Rate = loanProfile.Rate;
                    loanProfileInDb.Term = loanProfile.Term;
                    loanProfileInDb.LoanAmount = loanProfile.LoanAmount;
                    loanProfileInDb.ClosingCost = loanProfile.ClosingCost;
                    _context.Update(loanProfileInDb);
                    await _context.SaveChangesAsync();
                //};
                //catch (DbUpdateConcurrencyException)
                //{
                //    if (!CustomerExists(customer.Id))
                //    {
                //        return NotFound();
                //    }
                //    else
                //    {$"{id}"
                //        throw;
                //    }
                //}
                return RedirectToAction("Create", "Contacts", new { id = loanProfileInDb.ApplicationId });
            }
            return View();
        }

        // GET: Contacts/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Contacts/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Contacts/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Contacts/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}