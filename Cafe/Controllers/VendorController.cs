using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Cafe.Models;

namespace Cafe.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List <Vendor> AllVendors = Vendor.GetAll();
      return View(AllVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{Id}")]
    public ActionResult Show(int Id)
    {
      Dictionary<string, object> model = new Dictionary <string, object>();
      Vendor selectedVendor = Vendor.Find(Id);
      List<Order> vendorOrders = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      model.Add("orders", vendorOrders);
      return View(model);
    }

    [HttpPost("/vendors/{Id}/orders")]
    public ActionResult Create(int Id, string description, int qty, int price, string date)
    {
      Dictionary<string, object> model = new Dictionary <string, object>();
      Vendor selectedVendor = Vendor.Find(Id);
      Order newOrder = new Order(qty, description, price, date);
      selectedVendor.AddOrder(newOrder);
      List<Order> vendorOrders = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      model.Add("orders", vendorOrders);
      return View("Show", model);
    }
  }
}