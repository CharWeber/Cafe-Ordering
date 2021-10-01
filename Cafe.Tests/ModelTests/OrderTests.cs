using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Cafe.Models;

namespace Cafe.Test
{
  [TestClass]
  public class ItemTests :IDisposable
  {
    public void Dispose()
  {
    Order.ClearAll();
  }

    //test#1
    [TestMethod]
    public void Order_CreatesInstanceOfOrder_True()
  {
    Order testOrder = new Order(1,"test");
    Assert.AreEqual(typeof(Order), testOrder.GetType());
  }

    //test#2
    [TestMethod]
    public void Order_ReturnsDescriptionString_String()
    {
      string description = "test";
      Order testOrder = new Order(1, description);
      string result = testOrder.Description;

      Assert.AreEqual("test", result);
    }
    //test#3
    [TestMethod]
    public void Order_SetsDescirptionString_String()
    {
      string description = "test";
      Order testOrder = new Order(1, description);
      
      string updatedDescription = "updated tests";
      testOrder.Description = updatedDescription;
      string result = testOrder.Description;

      Assert.AreEqual(updatedDescription, result);
    }
    //test#4
    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> testList = new List<Order>();
      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(result, testList);
    }
    //test #5
    [TestMethod]
    public void Order_GetsQuantityOfOrder_Int()
    {
      int qty = 1;
      Order testOrder = new Order(qty,"test");
      int result = testOrder.Quantity;

      Assert.AreEqual(result, qty);

    }
  }
}