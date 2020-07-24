using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;
using System.Collections.Generic;

namespace VendorTracker.Controllers
{
  public class ItemsController : Controller
  {
    [HttpGet("/vendors/{vendorId}/items/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }

    [HttpPost("/items")]
    public ActionResult Create(string description)
    {
      Item myItem = new Item(description);
      return RedirectToAction("Index");
    }

    [HttpPost("/items/delete")]
    public ActionResult DeleteAll()
    {
      Item.ClearAll();
      return View();
    }

    [HttpGet("/items/{id}")]
    public ActionResult Show(int id)
    {
      Item foundItem = Item.Find(id);
      return View(foundItem);
    }

    [HttpGet("/categories/{categoryId}/items/{itemId}")]
      public ActionResult Show(int vendorId, int itemId)
      {
        Item item = Item.Find(itemId);
        Vendor vendor = Vendor.Find(vendorId);
        Dictionary<string, object> model = new Dictionary<string, object>();
        model.Add("item", item);
        model.Add("vendor", vendor);
        return View(model);
      }
  }
}