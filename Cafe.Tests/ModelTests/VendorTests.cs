using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Cafe.Models;

namespace Cafe.Test
{
  [TestClass]
  public class VendorTests
  {
    //test #1
    [TestMethod]
    public void Vendor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor testVendor = new Vendor("testVendor", "testdesciption");
      Assert.AreEqual(typeof(Vendor), testVendor.GetType());
    }
  }
}