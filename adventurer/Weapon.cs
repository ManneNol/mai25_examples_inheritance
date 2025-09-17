namespace App;

class Weapon : Item
{
    public int Damage;

    public Weapon(string name, int damage) : base(name)
    {
        Damage = damage;
    }

    public void Attack()
    {
        Console.WriteLine("Attacking with " + Name + " for " + Damage +" HP");
    }
}
