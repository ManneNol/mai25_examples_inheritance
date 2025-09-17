using TreeOfLife;

BoneyFish b_fish = new BoneyFish();

b_fish.Name = "Wanja";

Console.WriteLine(b_fish.Name);

Fish fish = new Salmon();

List<Fish> fishes = new List<Fish>();

fishes.Add(new Salmon());
fishes.Add(new Linus());

foreach(Fish f in fishes)
{
    Console.Write(f + ": ");
    f.Vocalize();
}
