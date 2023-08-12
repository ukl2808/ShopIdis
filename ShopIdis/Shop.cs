enum ShopType
{
    Grocery,
    Household,
    Clothing,
    Shoes
}

partial class Shop : IDisposable
{
    private string name;
    private string address;
    private ShopType type;

    public Shop(string name, string address, ShopType type)
    {
        this.name = name;
        this.address = address;
        this.type = type;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Address
    {
        get { return address; }
        set { address = value; }
    }

    public ShopType Type
    {
        get { return type; }
        set { type = value; }
    }

    public void Dispose()
    {
        Console.WriteLine($"Resource cleanup: Shop \"{Name}\".");
    }
}
