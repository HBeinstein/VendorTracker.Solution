using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;

namespace VendorTracker.Controllers
{
  public class VendorController : Controller
  {
  [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

  [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

  [HttpPost("/vendors")]
    public ActionResult Create(string vendorName)
    {
      Vendor newVendor = new Vendor(vendorName);
      return RedirectToAction("Index");
    }

  [HttpPost("/vendors/{categoryId}/items")]
    public ActionResult Create(int vendorId, string itemDescription)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Item newItem = new Item(itemDescription);
      foundVendor.AddItem(newItem);
      List<Item> vendorItems = foundVendor.Items;
      model.Add("items", vendorItems);
      model.Add("vendor", foundVendor);
      return View("Show", model);
    }

  [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Item> vendorItems = selectedVendor.Items;
      model.Add("vendor", selectedVendor);
      model.Add("items", vendorItems);
      return View(model);
    }
  }
}