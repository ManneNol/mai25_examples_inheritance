namespace App;

class Utils
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static void ShowNames(List<string> names)
    {
        foreach(string name in names)
        {
            Console.WriteLine(name);
        }
    }
}
