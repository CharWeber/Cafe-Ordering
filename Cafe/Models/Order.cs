using System.Collections.Generic;

namespace Cafe.Models
{
  public class Order
  {
    public string Description {get;set;}
    public string Date {get;set;}
    public int Quantity {get; set;}
    public int Price {get; set;}
    public int Id {get;}
    public static List<Order> _instances = new List <Order>();

    public Order(int qty, string description, int price, string date)
    {
      Description = description;
      Date = date;
      Quantity = qty;
      Price = price;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
