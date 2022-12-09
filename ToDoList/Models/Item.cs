using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    public string Description { get; set; }
    private static List<Item> _instances = new List<Item> {};

    public Item(string description)
    {
      Description = description;
      _instances.Add(this);
    }
    //we call this with Item.GetAll() as we target the entire class
    public static List<Item> GetAll() 
    {
      return _instances;
    }
    // Add function to clear data for fresh test cycling
    public static void ClearAll()
    {
      _instances.Clear();
    }
}
}