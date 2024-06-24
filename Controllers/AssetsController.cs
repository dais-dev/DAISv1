using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DAISv1.Data;
using DAISv1.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DAISv1.Controllers
{
    public class AssetsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AssetsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Assets
        public async Task<IActionResult> Index()
        {
            return View(await _context.Asset.ToListAsync());
        }

        // Added methods for Asset App
public IActionResult AdminActions()
        {
            return View();
        }

        public IActionResult ViewAssets()
        {
            return View();
        }

        public IActionResult Maintenance()
        {
            return View();
        }
        public IActionResult Onboard()
        {
            return View();
        }
        public async Task<IActionResult> Reports()
        {
      //    var asset = await _context.Asset.FindAsync(444);
      //          _context.Asset.Remove(asset);

      //      await _context.SaveChangesAsync();
            return View();
        }

        public List<string> GetEquipmentTypesFromMaster()
        {
            // This method should retrieve the list of equipment types defined by the admin
            // For example, it could retrieve the list from a database or configuration file
            return new List<string> { "EquipType1", "EquipType2", "EquipType3" };
        }

        public async Task<IActionResult> DeleteAssetTable()
        {
        // this is added for cleaning out the db table since sometimes after adding fields, sqlite db gets messed up. Use Caution

        _context.Database.ExecuteSqlRaw("DELETE FROM Asset");

        //       var rows = _context.Asset.ToList();
        //       foreach (var row in rows)
        //       {
        //           _context.Asset.Remove(row);
        //       }
        //       _context.SaveChanges();
         _context.Database.ExecuteSqlRaw("VACUUM");

        return View();
        }


        // end methods Asset App

        // GET: Assets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var asset = await _context.Asset
                .FirstOrDefaultAsync(m => m.TagId == id);
            if (asset == null)
            {
                return NotFound();
            }

            return View(asset);
        }

        // GET: Assets/Create
        public IActionResult Create()
        {
            
                var equipmentTypes = GetEquipmentTypesFromMaster();

         //       ViewData["EquipmentTypes"] = new SelectList(new string[] {EquipmentTypes });
                ViewData["EquipmentTypes"] = new SelectList(equipmentTypes);
            
            // This should come from your data source or business logic
            return View();
        }

        // POST: Assets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TagId,AssetMaterialType,EquipmentType,AssetCode,AssetQuantity,AssetRegion,LocationOfOperation,LocationWithRFID,Division,PurchaseDate,YearOfInstallation,DesignLifeDate,EndOfPeriodLifeDate,ManufacturerName,SupplierName,ModelSerialNumber")] Asset asset)
        {
            if (ModelState.IsValid)
            {   
                asset.AssetCode = 9999;
                _context.Add(asset);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else {
                asset.AssetCode = 5555;
            }
            return View(asset);
        }

        // GET: Assets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var asset = await _context.Asset.FindAsync(id);
            if (asset == null)
            {
                return NotFound();
            }
            return View(asset);
        }

        // POST: Assets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TagId,SerialNumber,Name,Location,PlantName,EquipmentType,MaterialType,PurchaseDate,RenewalDate,ManufacturerName,Price")] Asset asset)
        {
            if (id != asset.TagId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(asset);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AssetExists(asset.TagId))
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
            return View(asset);
        }

        // GET: Assets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var asset = await _context.Asset
                .FirstOrDefaultAsync(m => m.TagId == id);
            if (asset == null)
            {
                return NotFound();
            }

            return View(asset);
        }

        // POST: Assets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var asset = await _context.Asset.FindAsync(id);
            if (asset != null)
            {
                _context.Asset.Remove(asset);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AssetExists(int id)
        {
            return _context.Asset.Any(e => e.TagId == id);
        }
    }
}
