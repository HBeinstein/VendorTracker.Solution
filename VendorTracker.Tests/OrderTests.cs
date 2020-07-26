using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
  
    [TestMethod]
    public void OrderConstructor_InstantiatesInstanceOfOrder_True()
    {
      Order testOrder = new Order("test", "october", "$10", "none");
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }

    [TestMethod]
    public void OrderConstructor_GetDescriptionandID_True()
    {
      Order testOrder = new Order("test", "october", "$10", "none");
      Assert.AreEqual("test", testOrder.Description);
      Assert.AreEqual("october", testOrder.Date);
      Assert.AreEqual("$10", testOrder.Price);
      Assert.AreEqual("none", testOrder.Comments);
      Assert.AreEqual(1, testOrder.ID);
    }

    [TestMethod]
    public void OrderConstructor_SetDescription_True()
    {
      string testDescription = "test";
      Order testOrder = new Order(testDescription, "october", "$10", "none");
      string testDescription2 = "test";
      Assert.AreEqual(testDescription2, testOrder.Description);
    }

    [TestMethod]
    public void OrderConstructor_SetPrice_True()
    {
      string testPrice = "$20";
      Order testOrder = new Order("test", "test", testPrice, "none");
      string testPrice2 = "$20";
      Assert.AreEqual(testPrice2, testOrder.Price);
    }

    [TestMethod]
    public void OrderConstructor_SetDate_True()
    {
      string testDate = "May 10";
      Order testOrder = new Order("test", testDate, "test", "none");
      string testDate2 = "May 10";
      Assert.AreEqual(testDate2, testOrder.Date);
    }

    [TestMethod]
    public void OrderConstructor_SetComments_True()
    {
      string testComment = "comment";
      Order testOrder = new Order("test", "test", "test", testComment);
      string testComment2 = "comments";
      Assert.AreEqual(testComment2, testOrder.Comments);
    }

    [TestMethod]
    public void GetAll_ReturnsOrdersList_True()
    {
      Order cat = new Order("walk the cat", "test", "test2", "test3");
      Order dog = new Order("walk the dog", "test4", "test5", "test6");
      List<Order> newList = new List<Order> {cat, dog};
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyOrdersList_True()
    {
      List<Order> newList = new List<Order> {};
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string description1 = "Walk the dog";
      string description2 = "Walk the cat";
      Order testOrder1 = new Order(description1, "test", "test2", "test3");
      Order testOrder2 = new Order(description2, "test3", "test4", "test5");

      Order result = Order.Find(2);

      Assert.AreEqual(testOrder2, result);
    }

  }
}