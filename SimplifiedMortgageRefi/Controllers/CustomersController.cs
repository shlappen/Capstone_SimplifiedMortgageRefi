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
using SimplifiedMortgageRefi.ViewModels;

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
            IndexCustomerViewModel indexCustomerViewModel = new IndexCustomerViewModel();
            
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = _context.Customers.Where(c => c.IdentityUserId == userId).FirstOrDefault();

            indexCustomerViewModel.Customer = customer;
            var application = await _context.Applications_Customers.Where(c => c.CustomerId == customer.Id).Select(d => d.Application).FirstOrDefaultAsync();
            var loanProfiles = await _context.LoanProfiles.Where(c => c.ApplicationId == application.Id).ToListAsync();
            var propertyInDb = await _context.Customers_Properties.Where(p => p.CustomerId == customer.Id).Select(q => q.Property).FirstOrDefaultAsync();
            var liabilities = await _context.Liabilities.Where(l => l.ApplicationId == application.Id).ToListAsync();

            indexCustomerViewModel.Property = propertyInDb;
            indexCustomerViewModel.Application = application;
            indexCustomerViewModel.LoanProfiles = loanProfiles;
            indexCustomerViewModel.Liabilities = liabilities;
            return View(indexCustomerViewModel);
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
            [Bind("FirstName,LastName,CreditScore,MonthlyIncome")] Customer customer,
            [Bind("AssessedValue")] Property property,
            [Bind("Street, City, StateId, ZipCode")] Address address,
            [Bind("PurposeId")] LoanProfile loanProfile)
        {
            if (ModelState.IsValid)
            {

                //Get customer role
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                customer.IdentityUserId = userId;

                _context.Add(customer); //Add customer to DB

                _context.Add(address); //Add address to DB
                _context.SaveChanges(); //Customer and Address get PK

                property.AddressId = address.Id; //Add AddressId as FK to property
                property.OccupancyTypeId = 1;
                property.PropertyTypeId = 1;
                _context.Add(property); // 
                _context.SaveChanges(); //give Property a PK

                Customers_Properties customers_Properties = new Customers_Properties();
                customers_Properties.CustomerId = customer.Id;
                customers_Properties.PropertyId = property.Id;
                _context.Add(customers_Properties);
                _context.SaveChanges(); //Add FKs to Customers_Properties junction

                Application application = new Application();
                application.ApplicationStartDate = DateTime.Now; //Timestamp application
                application.PropertyId = property.Id;
                _context.Add(application); //Add application to DB
                _context.SaveChanges(); //give application PK

                Applications_Customers applications_Customers = new Applications_Customers();
                applications_Customers.CustomerId = customer.Id;  //for Junction table
                applications_Customers.ApplicationId = application.Id; //for Junction table
                _context.Add(applications_Customers);


                loanProfile.Originator = "Customer";
                loanProfile.ApplicationId = application.Id;
                if (loanProfile.PurposeId == 2)
                {
                    loanProfile.IsCashOut = true;
                }
                _context.Add(loanProfile);

                _context.SaveChanges();


                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(EditCurrentMortgage));
            }
            return View(customer);
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
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        public async Task<IActionResult> EditCurrentMortgage()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = await _context.Customers.Where(c => c.IdentityUserId == userId)
                .FirstOrDefaultAsync();

            if (customer == null)
            {
                return NotFound();
            }

            IndexCustomerViewModel indexCustomerViewModel = new IndexCustomerViewModel()
            {
                Customer = customer
            };

            return View(indexCustomerViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditCurrentMortgage(
        [Bind("OriginalMortgageBalance, Rate, Term, MonthlyPropertyTax, MonthlyHOIPremium, Id, OriginationDate")] Property property)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = _context.Customers.Where(c => c.IdentityUserId == userId).FirstOrDefault();
            if (ModelState.IsValid)
            {
                //Get customer
                var propertyInDb = _context.Customers_Properties.Where(p => p.CustomerId == customer.Id).Select(q => q.Property).FirstOrDefault();
                propertyInDb.MortgageBalance = property.MortgageBalance;
                propertyInDb.OriginalMortgageBalance = property.OriginalMortgageBalance;
                propertyInDb.Rate = property.Rate;
                propertyInDb.Term = property.Term;
                propertyInDb.MonthlyPropertyTax = property.MonthlyPropertyTax;
                propertyInDb.MonthlyHOIPremium = property.MonthlyHOIPremium;
                propertyInDb.OriginationDate = property.OriginationDate;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }


        // GET: Customers/Edit/5
        public async Task<IActionResult> EditLoanProfile(int? id)
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

            return View(loanProfile);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditLoanProfile(int id, [Bind("Id,Term,ClosingCost,LoanAmount,Rate")] LoanProfile loanProfile)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = await _context.Customers.Where(c => c.IdentityUserId == userId)
                .FirstOrDefaultAsync();

            var loanProfileInDb = _context.LoanProfiles.Where(c => c.Id == loanProfile.Id).SingleOrDefault();
            if (id != loanProfile.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    loanProfileInDb.Rate = loanProfile.Rate;
                    loanProfileInDb.Term = loanProfile.Term;
                    loanProfileInDb.LoanAmount = loanProfile.LoanAmount;
                    loanProfileInDb.ClosingCost = loanProfile.ClosingCost;
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
            return View(customer);
        }


        // GET: Customers/Edit/5
        public async Task<IActionResult> EditIncome(int? id)
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
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditIncome(int id, [Bind("MonthlyIncome")] Customer customer)
        {

                    var customerInDb = _context.Customers.Where(c => c.Id == id).FirstOrDefault();
                    customerInDb.MonthlyIncome = customer.MonthlyIncome;
                    _context.Update(customerInDb);
                    await _context.SaveChangesAsync();
          
                return RedirectToAction(nameof(Index));
            
        }
        public async Task<IActionResult> EditPropertyValue(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var property = await _context.Properties.FindAsync(id);
            if (property == null)
            {
                return NotFound();
            }
            return View(property);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPropertyValue(int id, [Bind("AssessedValue")] Property property)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = _context.Customers.Where(c => c.IdentityUserId == userId).FirstOrDefault();
            if (ModelState.IsValid)
            {
                //Get customer
                var propertyInDb = _context.Customers_Properties.Where(p => p.CustomerId == customer.Id).Select(q => q.Property).FirstOrDefault();
                propertyInDb.AssessedValue = property.AssessedValue;

                _context.Update(propertyInDb);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(customer);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditCreditScore(int id, [Bind("CreditScore")] Customer customer)
        {

            var customerInDb = _context.Customers.Where(c => c.Id == id).FirstOrDefault();
            customerInDb.CreditScore = customer.CreditScore;
            _context.Update(customerInDb);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        public IActionResult CreateLiabilities(int id)
        {

            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = _context.Customers.Where(c => c.IdentityUserId == userId).FirstOrDefault();

            IndexCustomerViewModel indexCustomerViewModel = new IndexCustomerViewModel();


            var applicationInDb = _context.Applications.Where(c => c.Id == id).SingleOrDefault();
            var liabilities = _context.Liabilities.Where(l => l.ApplicationId == id).ToList();
            indexCustomerViewModel.Liabilities = liabilities;

            if(!liabilities.Any())
            {
                applicationInDb.Liabilities = null;
            }
            Liability newLiability = new Liability();
            indexCustomerViewModel.Application = applicationInDb;
            indexCustomerViewModel.Liability = newLiability;
            indexCustomerViewModel.Customer = customer;
            ViewData["LiabilityTypes"] = new SelectList(_context.LiabilityTypes, "Id", "Name");

            return View(indexCustomerViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateLiabilities(int id, [Bind("LenderName,Balance,Payment,IsConsolidated,LiabilityTypeId")] Liability liability)
        {

            var applicationInDb = _context.Applications.Where(c => c.Id == id).SingleOrDefault();
            var loanProfiles = _context.LoanProfiles.Where(a => a.ApplicationId == id).ToList();
            liability.ApplicationId = id;
            _context.Add(liability);
            _context.SaveChanges();

            Liabilities_LoanProfiles liabilitiesLoanProfiles = new Liabilities_LoanProfiles();
            foreach (var item in loanProfiles)
            {
                liabilitiesLoanProfiles.LoanProfileId = item.Id;
                liabilitiesLoanProfiles.LiabilityId = liability.Id;
                _context.Liabilities_LoanProfiles.Add(liabilitiesLoanProfiles);
            }
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(CreateLiabilities));

        }
        public async Task<IActionResult> EditLiabilities(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            IndexCustomerViewModel indexCustomerViewModel = new IndexCustomerViewModel();
            var application = await _context.Applications.FindAsync(id);
            var liabilities = await _context.Liabilities.Where(a => a.ApplicationId == application.Id).ToListAsync();
            if (application == null)
            {
                return NotFound();
            }
            indexCustomerViewModel.Application = application;
            indexCustomerViewModel.Application.Liabilities = liabilities;
            return View(indexCustomerViewModel);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditLiabilities(int id, [Bind("LenderName,Balance,Payment")] Liability liability)
        {

            var applicationInDb = _context.Applications.Where(c => c.Id == id).SingleOrDefault();

            //indexCustomer
            //        _context.Update(application);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

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
