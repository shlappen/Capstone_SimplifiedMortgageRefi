using System;
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
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Customers
        public async Task<IActionResult> Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = await _context.Customers.Where(c => c.IdentityUserId == userId).FirstOrDefaultAsync();
            return View(customer);
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .Include(c => c.IdentityUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            //var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            //var customerInDb = _context.Customers.Where(c => c.IdentityUserId == userId).FirstOrDefaultAsync();
            CreateCustomerViewModel createCustomerViewModel = new CreateCustomerViewModel();

            ViewData["States"] = new SelectList(_context.States, "Id", "Name", "Select State");
            ViewData["Purposes"] = new SelectList(_context.Purposes, "Id", "Name", "Select");
            ViewData["PropertyTypes"] = new SelectList(_context.PropertyTypes, "Id", "Name");
            ViewData["OccupancyTypes"] = new SelectList(_context.OccupancyTypes, "Id", "Name");
            return View(createCustomerViewModel);
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
            [Bind("FirstName,LastName")] Customer customer,
            [Bind("PropertyTypeId, OccupancyTypeId")] Property property,
            [Bind("Street, City, StateId, ZipCode")] Address address,
            [Bind("PurposeId")] LoanProfile loanProfile)
        {
            if (ModelState.IsValid)
            {
                
                //Get customer
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                customer.IdentityUserId = userId;
                
                _context.Add(customer); //Add customer to DB

                _context.Add(address); //Add address to DB
                Application application = new Application();
                application.ApplicationStartDate = DateTime.Now; //Timestamp application
                _context.Add(application); //Add application to DB

                _context.SaveChanges(); //give application, customer and address PKs

                Applications_Customers applications_Customers = new Applications_Customers();
                applications_Customers.CustomerId = customer.Id;  //for Junction table
                applications_Customers.ApplicationId = application.Id; //for Junction table
                _context.Add(applications_Customers);

                property.AddressId = address.AddressId; //Add AddressId as FK to property
                _context.Add(property); // give Property a PK

                
                loanProfile.Originator = "Customer";
                loanProfile.ApplicationId = application.Id;
                if(loanProfile.PurposeId == 2)
                { loanProfile.IsCashOut = true;
                }
                _context.Add(loanProfile);

                _context.SaveChanges();

                Customers_Properties customers_Properties = new Customers_Properties();
                customers_Properties.CustomerId = customer.Id;
                customers_Properties.PropertyId = property.Id;
                _context.Add(customers_Properties);
                

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", customer.IdentityUserId);
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,IdentityUserId")] Customer customer)
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
                    if (!CustomerExists(customer.Id))
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
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", customer.IdentityUserId);
            return View(customer);
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .Include(c => c.IdentityUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(int id)
        {
            return _context.Customers.Any(e => e.Id == id);
        }
    }
}
