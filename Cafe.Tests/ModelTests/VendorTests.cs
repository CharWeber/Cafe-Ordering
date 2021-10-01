using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Cafe.Models;

namespace Cafe.Test
{
  [TestClass]
  public class VendorTests :IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
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
      Vendor testVendor = new Vendor(testName, testDescription);

      string resultName = testVendor.Name;
      string resultDescription = testVendor.Description;
      int resultID = 1;

      Assert.AreEqual(resultName, testName);
      Assert.AreEqual(resultDescription, testDescription);
      Assert.AreEqual(resultID, 1);
    }

    //test#3
    [TestMethod]
    public void GetAll_returnsAllVendorObjects_VendorList()
    {
      Vendor testVendor = new Vendor("testVendor", "testdesciption");
      Vendor testVendor2 = new Vendor("testVendor2", "testdesciption2");
      List<Vendor> testList = new List <Vendor> {testVendor};

      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(result, testList);
    }
  }
}