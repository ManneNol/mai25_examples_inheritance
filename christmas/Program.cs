using App;

int c = Utils.Add(3, 5);

Console.WriteLine(c);

List<string> names = new List<string>();

Utils.ShowNames(names);


Show(names);


static void Show(List<string> bananas)
{
    foreach(string name in bananas)
    {
        Console.WriteLine(name);
    }
}
