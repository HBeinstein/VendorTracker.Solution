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


    

  }
}