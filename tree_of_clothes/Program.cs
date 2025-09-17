using TreeOfClothing;

List<Clothing> wardrobe = new List<Clothing>();

wardrobe.Add(new Shirt("Old Stained TShirt", "H&M", "Beige"));

foreach(Clothing item in wardrobe)
{
    //Console.WriteLine(item.Label + " " + item.Brand);
    Console.WriteLine(item);
}
