using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_InstantiatesInstanceOfVendor_True()
    {
      Vendor testVendor = new Vendor("test", "test2", "test3");
      Assert.AreEqual(typeof(Vendor), testVendor.GetType());
    }

    [TestMethod]
    public void VendorConstructor_InstantiatesInstanceOfVendorWithProperties_True()
    {
      Vendor testVendor = new Vendor("name", "description", "place");
      int testVendorID = 1;
      Assert.AreEqual("name", testVendor.Name);
      Assert.AreEqual("description", testVendor.Description);
      Assert.AreEqual("place", testVendor.Place);
      Assert.AreEqual(testVendorID, testVendor.ID);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_True()
    {
      Vendor testVendor1 = new Vendor("Jeff", "Jeff's Grocery", "Houston");
      Vendor testVendor2 = new Vendor("Steve", "Steve's Test Store", "Austin");
      List<Vendor> testList = new List<Vendor> { testVendor1, testVendor2 };

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(testList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_True()
    {
      string name1 = "Bakery";
      string name2 = "Grocery";
      Vendor testVendor1 = new Vendor(name1, "test", "test2");
      Vendor testVendor2 = new Vendor(name2, "test3", "test4");

      Vendor result = Vendor.Find(2);

      Assert.AreEqual(testVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_True()
    {
      string description = "bread";
      Order testOrder = new Order("title", description, "date", "price", "comment");
      List<Order> testList = new List<Order> { testOrder };
      Vendor testVendor = new Vendor("work", "description", "location");
      testVendor.AddOrder(testOrder);
      
      List<Order> result = testVendor.Orders;
      
      CollectionAssert.AreEqual(testList, result);
    }
  }
}