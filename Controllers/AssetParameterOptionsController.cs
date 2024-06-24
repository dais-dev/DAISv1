using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DAISv1.Data;
using DAISv1.Models;

namespace DAISv1.Controllers
{
    public class AssetParameterOptionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AssetParameterOptionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AssetParameterOptions
        public async Task<IActionResult> Index()
        {
            return View(await _context.AssetParameterOptions.ToListAsync());
        }

        // GET: AssetParameterOptions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assetParameterOptions = await _context.AssetParameterOptions
                .FirstOrDefaultAsync(m => m.ParaId == id);
            if (assetParameterOptions == null)
            {
                return NotFound();
            }

            return View(assetParameterOptions);
        }

        // GET: AssetParameterOptions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AssetParameterOptions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ParaId,EquipmentTypes,AssetMaterialTypes,AssetRegions,LocationsOfOperation,LocationsWithRFID,Divisions,ManufacturerNames,SupplierNames")] AssetParameterOptions assetParameterOptions)
        {
            if (ModelState.IsValid)
            {
                _context.Add(assetParameterOptions);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(assetParameterOptions);
        }

        // GET: AssetParameterOptions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assetParameterOptions = await _context.AssetParameterOptions.FindAsync(id);
            if (assetParameterOptions == null)
            {
                return NotFound();
            }
            return View(assetParameterOptions);
        }

        // POST: AssetParameterOptions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ParaId,EquipmentTypes,AssetMaterialTypes,AssetRegions,LocationsOfOperation,LocationsWithRFID,Divisions,ManufacturerNames,SupplierNames")] AssetParameterOptions assetParameterOptions)
        {
            if (id != assetParameterOptions.ParaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(assetParameterOptions);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AssetParameterOptionsExists(assetParameterOptions.ParaId))
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
            return View(assetParameterOptions);
        }

        // GET: AssetParameterOptions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assetParameterOptions = await _context.AssetParameterOptions
                .FirstOrDefaultAsync(m => m.ParaId == id);
            if (assetParameterOptions == null)
            {
                return NotFound();
            }

            return View(assetParameterOptions);
        }

        // POST: AssetParameterOptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var assetParameterOptions = await _context.AssetParameterOptions.FindAsync(id);
            if (assetParameterOptions != null)
            {
                _context.AssetParameterOptions.Remove(assetParameterOptions);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AssetParameterOptionsExists(int id)
        {
            return _context.AssetParameterOptions.Any(e => e.ParaId == id);
        }
    ///////////////////// Added Methods
    // GET: AssetParameterOptions/Edit/5
        public async Task<IActionResult> EditAssetMaterialType(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assetParameterOptions = await _context.AssetParameterOptions.FindAsync(id);
            if (assetParameterOptions == null)
            {
                return NotFound();
            }
            return View(assetParameterOptions);
        }

        // POST: AssetParameterOptions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAssetMaterialType(int id, [Bind("ParaId,EquipmentTypes,AssetMaterialTypes,AssetRegions,LocationsOfOperation,LocationsWithRFID,Divisions,ManufacturerNames,SupplierNames")] AssetParameterOptions assetParameterOptions)
        {
            if (id != assetParameterOptions.ParaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(assetParameterOptions);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AssetParameterOptionsExists(assetParameterOptions.ParaId))
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
            return View(assetParameterOptions);
        }






    }
}
