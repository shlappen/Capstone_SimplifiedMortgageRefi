using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SimplifiedMortgageRefi.Data;
using SimplifiedMortgageRefi.Models;

namespace SimplifiedMortgageRefi.Controllers
{
    public class LiabilitiesController : Controller
    {
        // GET: Liabilities
        public ActionResult Index()
        {
            return View();
        }

        // GET: Liabilities/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Liabilities/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Liabilities/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Liabilities/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Liabilities/Edit/5
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

        // GET: Liabilities/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Liabilities/Delete/5
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