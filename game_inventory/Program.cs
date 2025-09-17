using GameInventory;

List<Item> inventory = new List<Item>();

inventory.Add(new Item("Potion"));
inventory.Add(new Weapon("Rusty Sword", 2));

foreach(Item item in inventory)
{
    Console.WriteLine(item.Info());
}

bool running = true;
while(running)
{
    Console.Clear();
    Console.WriteLine("add\nshow\nquit");
    switch(Console.ReadLine())
    {
        case "add":
            Console.Clear();
            Console.WriteLine("1. Add new item");
            Console.WriteLine("2. Add new weapon");
            switch(Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("enter the name of the item");
                    inventory.Add(new Item(Console.ReadLine()));
                break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("enter the name of the weapon");
                    inventory.Add(new Weapon(Console.ReadLine(), 1));
                break;
            }
        break;
        case "show":
            Console.Clear();
            foreach(Item item in inventory)
            {
                Console.WriteLine(item.Info());
            }
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadLine();
        break;
        case "quit":
            running = false;
        break;

    }
}
