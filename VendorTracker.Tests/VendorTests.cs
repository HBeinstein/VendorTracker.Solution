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
      Vendor testVendor = new Vendor("test");
      Assert.AreEqual(typeof(Vendor), testVendor.GetType());
    }

    [TestMethod]
    public void VendorConstructor_InstantiatesInstanceOfVendorWithProperties_True()
    {
      Vendor testVendor = new Vendor("test");
      int testVendorID = 1;
      Assert.AreEqual("test", testVendor.Name);
      Assert.AreEqual(testVendorID, testVendor.ID);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_True()
    {
      string name1 = "Steve";
      string name2 = "Jim";
      Vendor testVendor1 = new Vendor(name1);
      Vendor testVendor2 = new Vendor(name2);
      List<Vendor> testList = new List<Vendor> { testVendor1, testVendor2 };

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(testList, result);
    }

    [TestMethod]
      public void Find_ReturnsCorrectVendor_True()
      {
        string name1 = "Bakery";
        string name2 = "Grocery";
        Vendor testVendor1 = new Vendor(name1);
        Vendor testVendor2 = new Vendor(name2);

        Vendor result = Vendor.Find(2);

        Assert.AreEqual(testVendor2, result);
      }
  }
}