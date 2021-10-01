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
    Order newOrder = new Order("Test");
    Assert.AreEqual(typeof(Order), newOrder.GetType());
  }
  }
}