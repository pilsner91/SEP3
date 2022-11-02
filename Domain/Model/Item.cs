namespace Shared.Model; 

public class Item {

    public itemType? Type { get; set; }
    public int Uid { get; set; }
    public User? Owner { get; set; }
    public Shelf? Shelf { get; set; }

}