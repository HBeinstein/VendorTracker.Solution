using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {
    public void Dispose()
    {
      Item.ClearAll();
    }
  
    [TestMethod]
    public void ItemConstructor_InstantiatesInstanceOfItem_True()
    {
      Item testItem = new Item("test");
      Assert.AreEqual(typeof(Item), testItem.GetType());
    }



  }
}