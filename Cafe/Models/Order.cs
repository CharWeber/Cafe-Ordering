using System.Collections.Generic;

namespace Cafe.Models
{
  public class Order
  {
    public string Description {get;set;}
    public int Quantity {get; set;}
    public int Id {get;}
    public static List<Order> _instances = new List <Order>();

    public Order(int qty, string description)
    {
      Description = description;
      Quantity = qty;
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

  }
}
