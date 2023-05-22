namespace ToDoList.Models
{
  public class ItemTag
    {       
        public int ItemTagId { get; set; }  //primary key
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public int TagId { get; set; }  //foreign key
        public Tag Tag { get; set; }  //navigation property (reference navigation property)
    }
}