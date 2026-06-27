public class Submarine : Watercraft, ISailable, IDiveable
{
    public Submarine(string model, int speed) : base(model, speed) { }

    public void Sail()
    {
        Console.WriteLine($"{Model} is sailing on the water surface");
    }

    public void Dive()
    {
        Console.WriteLine($"{Model} is diving deep underwater");
    }
}
