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

    [TestMethod]
    public void ItemConstructor_GetDescriptionandID_True()
    {
      string testDescription = "test";
      Item testItem = new Item("test");
      Assert.AreEqual(testDescription, testItem.Description);
      Assert.AreEqual(1, testItem.ID);
    }

    [TestMethod]
    public void ItemConstructor_SetDescription_True()
    {
      string testDescription = "test";
      Item testItem = new Item(testDescription);
      string testDescription2 = "cat";
      testItem.Description = testDescription2;
      Assert.AreEqual("cat", testItem.Description);
    }

  }
}