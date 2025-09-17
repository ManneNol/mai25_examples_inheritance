namespace GameInventory;

class Item
{
    public string Name;

    public Item(string name)
    {
        Name = name;
    }

    public virtual string Info()
    {
        return Name;
    }
}
