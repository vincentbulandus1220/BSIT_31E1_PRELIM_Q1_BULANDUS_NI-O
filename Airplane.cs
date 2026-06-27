public class Airplane : Vehicle, IFlyable
{
    public Airplane(string model, int speed) : base(model, speed) { }

    public void Fly()
    {
        Console.WriteLine($"{Model} is flying at {Speed} km/h");
    }
}
