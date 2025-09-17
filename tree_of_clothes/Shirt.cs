namespace TreeOfClothing;

class Shirt : Clothing
{
    public string Color;

    public Shirt(string l, string b, string c) : base(l, b)
    {
        Color = c;
    }

    public override string Info()
    {
        return Label + " " + Brand + " " + Color;
    }
}
