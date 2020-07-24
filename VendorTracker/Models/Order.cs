using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Order
  {

    // properties
    public string Description { get; set; }

    public int ID { get; }

    private static List<Order> _ordersList = new List<Order> {};

    // constructor
    public Order(string description) 
    {
      Description = description;
      _ordersList.Add(this);
      ID = _ordersList.Count;
    }

    // methods
    public static void ClearAll()
    {
      _ordersList.Clear();
    }

    public static List<Order> GetAll()
    {
      return _ordersList;
    }

    public static Order Find(int searchID)
    {
      return _ordersList[searchID - 1];
    }

  }
}