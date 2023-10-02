namespace Sds.Inn.DoNotChange;

public class ItemProvider : IItemProvider
{
    private

    IList<Item> _items = new List<Item>
    {
        new("+5 Dexterity Vest", 10, 20),
        new("Aged Brie", 2, 0),
        new("Elixir of the Mongoose", 5, 7),
        new("Sulfuras", 0, 80),
        new("Backstage passes", 15, 20),
        new("Conjured", 3, 6)
    };
    public IEnumerable<Item> GetItems()
    {
        return _items.ToArray();
    }

    int IItemProvider.AddItems()
    {

        Console.WriteLine("Enter how many items you wish to add");
        int? NoOfItems = Console.Read();

        Console.WriteLine("Enter enter item name");
        string? ItemName= Console.ReadLine();

        Console.WriteLine("Enter Item Sell In");
        int SellIn = Console.Read();

        Console.WriteLine("Enter Item Quality");
        int Quality = Console.Read();
        
        if(NoOfItems != 0 && !string.IsNullOrWhiteSpace(ItemName) && ! (SellIn <0) && ! (Quality < 0))
        {
            for(int i=0;i<NoOfItems;i++)
            {
                _items = new List<Item>
                {
                    new(ItemName,SellIn,Quality)
                };
            }
            return 0;
        }
        else
            return 1;
    }
}
