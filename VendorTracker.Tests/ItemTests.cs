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
      List<Item> newList = new List<Item> {cat, dog};
      List<Item> result = Item.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyItemsList_True()
    {
      List<Item> newList = new List<Item> {};
      List<Item> result = Item.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectItem_Item()
    {
      string description1 = "Walk the dog";
      string description2 = "Walk the cat";
      Item testItem1 = new Item(description1);
      Item testItem2 = new Item(description2);

      Item result = Item.Find(1);

      Assert.AreEqual(testItem2, result);
    }

  }
}