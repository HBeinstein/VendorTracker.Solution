using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;
using System.Collections.Generic;

namespace VendorTracker.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }

    [HttpPost("/orders")]
    public ActionResult Create(string orderDescription, string orderDeliveryDate, string orderTotalPrice, string orderComments)
    {
      Order myOrder = new Order(orderDescription, orderDeliveryDate, orderTotalPrice, orderComments);
      return RedirectToAction("Index");
    }

    [HttpPost("/orders/delete")]
    public ActionResult DeleteAll()
    {
      Order.ClearAll();
      return View();
    }

    [HttpGet("/orders/{id}")]
    public ActionResult Show(int id)
    {
      Order foundOrder = Order.Find(id);
      return View(foundOrder);
    }

    [HttpGet("/vendors/{vendorID}/orders/{orderId}")]
      public ActionResult Show(int vendorId, int orderId)
      {
        Order order = Order.Find(orderId);
        Vendor vendor = Vendor.Find(vendorId);
        Dictionary<string, object> model = new Dictionary<string, object>();
        model.Add("order", order);
        model.Add("vendor", vendor);
        return View(model);
      }
  }
}