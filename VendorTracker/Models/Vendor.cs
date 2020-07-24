using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Vendor
  {
    // properties
    private static List<Vendor> _ordersList = new List<Vendor> {};
    public string Name { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
    public int ID { get; }
    public List<Order> Orders { get; set; }

    // constructor
    public Vendor (string name, string description, string location)
    {
      Name = name;
      Description = description;
      Location = location;
      _ordersList.Add(this);
      ID = _ordersList.Count;
      Orders = new List<Order>{};
    }

    // methods
    public static void ClearAll()
    {
      _ordersList.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _ordersList;
    }

    public static Vendor Find(int searchId)
    {
      return _ordersList[searchId-1];
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  }
}