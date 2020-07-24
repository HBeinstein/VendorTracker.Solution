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

    [TestMethod]
    public void GetAll_ReturnsItemsList_True()
    {
      Item cat = new Item("walk the cat");
      Item dog = new Item("walk the dog");
      List<Item> listToCompare = new List<Item> {dog};
      List<Item> newList = new List<Item> {cat, dog};
      List<Item> result = Item.GetAll();
      CollectionAssert.AreEqual(listToCompare, result);
    }

  }
}