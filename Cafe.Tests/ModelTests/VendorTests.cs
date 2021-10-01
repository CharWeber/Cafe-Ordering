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

    //test#2
    [TestMethod]
    public void Vendor_GetsPropertiesOfVendor_IntString()
    {
      string testName = "testvendor";
      string testDescription = "testdescription";
      Vendor testVendor = new Vendor(testname, testDescription);

      string resultName = testVendor.Name;
      string resultDescription = testVendor.Description;
      int resultID = 1;

      Assert.AreEqual(resultName, testName);
      Assert.AreEqual(resultDescription, testDesciption);
      Assert.AreEqual(resultID, 1);
    }
  }
}