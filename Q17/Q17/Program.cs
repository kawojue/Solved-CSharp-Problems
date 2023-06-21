public class Program
{
    public static void Main(string[] args)
    {
        // Item_name list
        List<ItemName> itemNames = new List<ItemName>
        {
            new ItemName { Iname = "Milk", Id = 1, SNo = "S56" },
            new ItemName { Iname = "Bread", Id = 2, SNo = "B24" },
            new ItemName { Iname = "Egg", Id = 3, SNo = "BN24" },
            new ItemName { Iname = "Noodles", Id = 4, SNo = "4242" }
        };

        // Item_price list
        List<ItemPrice> itemPrices = new List<ItemPrice>
        {
            new ItemPrice { Id = 1, Price = 5.23 },
            new ItemPrice { Id = 2, Price = 9.05 },
            new ItemPrice { Id = 3, Price = 19.14 },
            new ItemPrice { Id = 4, Price = 23.15 },
        };

        Console.Write("Enter the item name: ");
        string input = Console.ReadLine();

        // Perform the join query to get the item name with its price
        var query = from itemName in itemNames
                    join itemPrice in itemPrices on itemName.Id equals itemPrice.Id
                    where itemName.Iname == input
                    select new { itemName.Iname, itemPrice.Price };

        // Print the item name and its price
        foreach (var result in query)
        {
            Console.WriteLine("Item Name: " + result.Iname);
            Console.WriteLine("Price: ${0}", result.Price);
        }
    }
}

// Item_name class
public class ItemName
{
    public string Iname { get; set; }
    public int Id { get; set; }
    public string SNo { get; set; }
}

// Item_price class
public class ItemPrice
{
    public int Id { get; set; }
    public double Price { get; set; }
}