using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Cafe.Models;

namespace Cafe.Test
{
  [TestClass]
  public class ItemTests
  {
    //test#1
    [TestMethod]
    public void Order_CreatesInstanceOfOrder_True()
  {
    Order testOrder = new Order("test");
    Assert.AreEqual(typeof(Order), testOrder.GetType());
  }

    //test#2
    [TestMethod]
    public void Order_ReturnsDescriptionString_String()
    {
      string description = "test";
      Order testOrder = new Order(description);
      string result = testOrder.Description;

      Assert.AreEqual("test", result);
    }
  }
}