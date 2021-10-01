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
    Order testOrder = new Order(1,"test", 2, "10/1/2021");
    Assert.AreEqual(typeof(Order), testOrder.GetType());
  }

    //test#2
    [TestMethod]
    public void Order_ReturnsDescriptionString_String()
    {
      string description = "test";
      Order testOrder = new Order(1, description, 2, "10/1/2021");
      string result = testOrder.Description;

      Assert.AreEqual("test", result);
    }
    //test#3
    [TestMethod]
    public void Order_SetsDescirptionString_String()
    {
      string description = "test";
      Order testOrder = new Order(1, description, 2, "10/1/2021");
      
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
      Order testOrder = new Order(qty, "test", 2, "10/1/2021");
      int result = testOrder.Quantity;

      Assert.AreEqual(result, qty);
    }
    //test #6
    [TestMethod]
    public void Order_SetsQuantityOfOrder_Int()
    {
      int qty = 1;
      Order testOrder = new Order(qty, "test", 2, "10/1/2021");
      int updatedQty = 3;
      testOrder.Quantity = updatedQty;
      int result = testOrder.Quantity;

      Assert.AreEqual(result, updatedQty);
    }

    //test #7
    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      Order testOrder1 = new Order(1,"test", 2, "10/1/2021");
      Order testOrder2 = new Order(1,"test2", 2, "10/1/2021");
      List<Order> newList = new List<Order> {testOrder1, testOrder2};
      List <Order> result = Order.GetAll();

      CollectionAssert.AreEqual(result, newList);
    }

    //test #8
    [TestMethod]
    public void Find_FindsAndReturnsOrders_Order()
    {
      Order testOrder = new Order(1,"test", 2, "10/1/2021");
      Order testOrder2 = new Order(1,"test2", 2, "10/1/2021");

      Order result = Order.Find(2);

      Assert.AreEqual(result, testOrder2);
    }
    //test #9
    [TestMethod]
    public void Order_GetsPriceAndDateOfOrder_IntString()
    {
      int price = 1;
      string date = "10/1/2021";
      Order testOrder = new Order(1, "test", price, date);
      int resultPrice = testOrder.Price;
      string resultDate = testOrder.Date;

      Assert.AreEqual(resultPrice, price);
      Assert.AreEqual(resultDate, date);
    }
    //test #10
    [TestMethod]
    public void Order_SetsPriceAndDateOfOrder_Int()
    {
      int price = 1;
      string date = "10/1/2021";
      Order testOrder = new Order(1, "test", price, date);
      string newDate = "10/2/2021";
      int newPrice = 2;
      testOrder.Price = newPrice;
      testOrder.Date = newDate;
      int resultPrice = testOrder.Price;
      string resultDate = testOrder.Date;

      Assert.AreEqual(resultPrice, newPrice);
      Assert.AreEqual(resultDate, newDate);
    }
  }
}