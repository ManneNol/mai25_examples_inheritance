using App;

List<Item> inventory = new List<Item>();

inventory.Add(new Item("Potion"));
inventory.Add(new Weapon("Mace", 4));

bool running = true;
while(running)
{
    Console.WriteLine("1. Show full inventory");
    Console.WriteLine("2. Show all weapons");
    string input = Console.ReadLine();

    switch(input)
    {
        case "1":
            foreach(Item item in inventory)
            {
                Console.WriteLine(item.Name);
            }
        break;

        case "2":
            foreach(Item item in inventory)
            {
                if(item is Weapon w)
                {
                    Console.WriteLine(w.Name + " " + w.Damage);
                }
            }
        break;
    }
}

foreach(Item item in inventory)
{
    Console.WriteLine(item.Name);
    
    if(item is Weapon w)
    {
        w.Attack();
    }
}
