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
    public ActionResult Create(string vendorName, string vendorDescription, string vendorPlace)
    {
      Vendor newVendor = new Vendor(vendorName, vendorDescription, vendorPlace);
      return RedirectToAction("Index");
    }

  [HttpPost("/vendors/{vendorID}/orders")]
    public ActionResult Create(int vendorId, string orderTitle, string orderDescription, string orderDeliveryDate, string orderTotalPrice, string orderComments)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(orderTitle, orderDescription, orderDeliveryDate, orderTotalPrice, orderComments);
      foundVendor.AddOrder(newOrder);
      List<Order> vendorOrders = foundVendor.Orders;
      model.Add("orders", vendorOrders);
      model.Add("vendor", foundVendor);
      return View("Show", model);
    }

  [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> vendorOrders = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      model.Add("orders", vendorOrders);
      return View(model);
    }
  }
}