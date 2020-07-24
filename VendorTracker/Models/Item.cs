using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Item
  {

    // properties
    public string Description { get; set; }

    public int ID { get; }

    private static List<Item> _itemsList = new List<Item> {};

    // constructor
    public Item(string description) 
    {
      // Description = description;
      // _itemsList.Add(this);
      // ID = _itemsList.Count;
    }

    // methods
    public static void ClearAll()
    {
      _itemsList.Clear();
    }

  }
}