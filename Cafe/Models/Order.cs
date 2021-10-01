using System.Collections.Generic;

namespace Cafe.Models
{
  public class Order
  {
    public string Description {get;set;}
    public int Id {get;}
    public static List<Order> _instances = new List <Order>();

    public Order(string description)
    {
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
    }


  }
}
