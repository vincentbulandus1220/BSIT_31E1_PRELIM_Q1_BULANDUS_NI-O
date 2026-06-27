public class Helicopter : Vehicle, IFlyable, IDriveable
{
    public Helicopter(string model, int speed) : base(model, speed) { }

    public void Fly()
    {
        Console.WriteLine($"{Model} is hovering and flying at {Speed} km/h");
    }

    public void Drive()
    {
        Console.WriteLine($"{Model} is taxiing on land at {Speed / 2} km/h");
    }
}
