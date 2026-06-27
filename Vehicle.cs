public class Vehicle
{
    public string Model { get; set; }
    public int Speed { get; set; }

    public Vehicle(string model, int speed)
    {
        Model = model;
        Speed = speed;
    }

    public virtual void Move()
    {
        Console.WriteLine($"{Model} is moving at {Speed} km/h");
    }
}
