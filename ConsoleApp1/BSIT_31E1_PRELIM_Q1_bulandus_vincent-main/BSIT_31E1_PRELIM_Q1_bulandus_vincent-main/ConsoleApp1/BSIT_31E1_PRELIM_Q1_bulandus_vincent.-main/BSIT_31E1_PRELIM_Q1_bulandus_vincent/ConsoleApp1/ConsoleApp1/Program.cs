using TransportChallenge;

Console.WriteLine("=== Transport Resolver Challenge ===");

int passed = 0;
int total = 16;

void Assert(bool condition, string message)
{
    if (condition)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"[PASS] {message}");
        passed++;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"[FAIL] {message}");
    }

    Console.ResetColor();
}

// ---------- CAR ----------
var car = TransportResolver.Resolve("car");

Assert(car != null, "Resolver returns car.");
Assert(car is Car, "Resolver creates Car.");
Assert(car is Vehicle, "Car inherits Vehicle.");
Assert(car is IDriveable, "Car implements IDriveable.");
Assert(car!.Move() == "Driving on the road.", "Car can move.");

// ---------- PLANE ----------
var plane = TransportResolver.Resolve("plane");

Assert(plane is Airplane, "Resolver creates Airplane.");
Assert(plane is Vehicle, "Airplane inherits Vehicle.");
Assert(plane is IFlyable, "Airplane implements IFlyable.");
Assert(plane!.Move() == "Flying in the sky.", "Airplane can move.");

// ---------- BOAT ----------
var boat = TransportResolver.Resolve("boat");

Assert(boat is Boat, "Resolver creates Boat.");
Assert(boat is Vehicle, "Boat inherits Vehicle.");
Assert(boat is ISailable, "Boat implements ISailable.");
Assert(boat!.Move() == "Sailing on the water.", "Boat can move.");

// ---------- POLYMORPHISM ----------
List<Vehicle> vehicles =
[
    (Vehicle)car!,
    (Vehicle)plane!,
    (Vehicle)boat!
];

Assert(vehicles.Count == 3,
    "All transports can be stored as Vehicles.");

Assert(vehicles[0].Move() == "Driving on the road.",
    "Vehicle polymorphism works.");

Assert(vehicles[1].Move() == "Flying in the sky.",
    "Vehicle polymorphism works.");

Assert(vehicles[2].Move() == "Sailing on the water.",
    "Vehicle polymorphism works.");

// ---------- INVALID INPUT ----------
var unknown = TransportResolver.Resolve("banana");

Assert(unknown == null,
    "Invalid transport returns null.");

Console.WriteLine();
Console.WriteLine($"Passed: {passed}/{total}");

//---------- EXTRA CHALLENGE --------
var helicopter = TransportResolver.Resolve("helicopter");

Assert(helicopter is IFlyable, "");
Assert(helicopter is IDriveable, "");
Assert(helicopter!.Move() == "Flying in the sky.", "");