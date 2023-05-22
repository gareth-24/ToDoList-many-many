using System.Collections.Generic;
using System;

namespace ToDoList.Models
{
  public class Item
  {
    public int ItemId { get; set; }
    public string Description { get; set; }
    public int CategoryId { get; set; }
    public bool Completed { get; set; }
    public DateTime DueDate { get; set; }
    public Category Category { get; set; }
    public List<ItemTag> JoinEntities { get;} //collection navigation property
  }
}