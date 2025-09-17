namespace TreeOfClothing;

class Clothing
{
    public string Label;
    public string Brand;

    public Clothing(string l, string b)
    {
        Label = l;
        Brand = b;
    }

    public virtual string Info()
    {
        return Label + " " + Brand;
    }
}
