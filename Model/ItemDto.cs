namespace Model;

public class ItemDto{
    public string Name{ get; set; }
    public bool IsDone{ get; set; }

    public Item ToItem(){
        return new Item{
            Name = this.Name,
            IsDone = this.IsDone
        };
    }
}