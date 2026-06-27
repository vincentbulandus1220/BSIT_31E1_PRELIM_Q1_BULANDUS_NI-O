using System;

// ------------------------------
// Base Class
// ------------------------------
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

// ------------------------------
// Interfaces
// ------------------------------
public interface IFlyable
{
    void Fly();
}

public interface IDriveable
{
    void Drive();
}

public interface ISailable
{
    void Sail();
}

public interface IDiveable
{
    void Dive();
}

// ------------------------------
// Derived Classes
// ------------------------------
public class Airplane : Vehicle, IFlyable
{
    public Airplane(string model, int speed) : base(model, speed) { }

    public void Fly()
    {
        Console.WriteLine($"{Model} is flying at {Speed} km/h");
    }
}

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

public class Watercraft : Vehicle
{
    public Watercraft(string model, int speed) : base(model, speed) { }
}

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

// ------------------------------
// Main Program to Test
// ------------------------------
class Program
{
    static void Main(string[] args)
    {
        Helicopter myHeli = new Helicopter("Black Hawk", 280);
        myHeli.Move();
        myHeli.Fly();
        myHeli.Drive();

        Console.WriteLine("--------------------------------");

        Submarine mySub = new Submarine("Nautilus", 50);
        mySub.Move();
        mySub.Sail();
        mySub.Dive();
    }
}
