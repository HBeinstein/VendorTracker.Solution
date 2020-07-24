using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Vendor
  {
    // properties
    private static List<Vendor> _itemsList = new List<Vendor> {};
    public string Name { get; set; }
    public int ID { get; }
    public List<Item> Items { get; set; }

    // constructor
    public Vendor (string name)
    {
      Name = name;
      _itemsList.Add(this);
      ID = _itemsList.Count;
      Items = new List<Item>{};
    }

    // methods
    public static void ClearAll()
    {
      _itemsList.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _itemsList;
    }

    public static Vendor Find(int searchId)
    {
      return _itemsList[searchId-1];
    }

    public void AddItem(Item item)
    {
      Items.Add(item);
    }
  }
}