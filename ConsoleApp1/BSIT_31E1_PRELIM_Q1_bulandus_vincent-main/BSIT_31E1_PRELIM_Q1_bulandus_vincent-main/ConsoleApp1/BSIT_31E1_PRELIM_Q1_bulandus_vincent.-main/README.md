# 🚁 Transport Resolver Challenge

## Interfaces, Inheritance, and Polymorphism in C#

Welcome to the **Transport Resolver Challenge**.

In this activity, you will repair and complete an existing application by implementing the correct use of:

* Classes and Objects
* Inheritance
* Interfaces
* Polymorphism
* Factory/Resolver Pattern
* Design Thinking

---

# 🎯 Learning Objectives

By the end of this activity, you should be able to:

✅ Determine when to use **inheritance**.

✅ Determine when to use **interfaces**.

✅ Create classes that share common behavior through a base class.

✅ Create classes that implement multiple capabilities through interfaces.

✅ Use polymorphism to treat different objects as the same type.

✅ Build a simple object resolver/factory.

---

# 📖 Scenario

A transportation company has a system that receives a text input such as:

```text
car
plane
boat
helicopter
```

The system should automatically create the correct object.

For example:

```csharp
var vehicle = TransportResolver.Resolve("car");
```

should return a `Car` object.

---

# ⚠️ Rules

## Rule #1

**DO NOT MODIFY `Program.cs`.**

The instructor will replace your `Program.cs` during checking.

Any solution that requires changes to `Program.cs` is considered incorrect.

---

## Rule #2

You may modify:

* Vehicle.cs
* Car.cs
* Airplane.cs
* Boat.cs
* Helicopter.cs
* Interfaces
* TransportResolver.cs
* Any additional files you need

---

## Rule #3

All tests in `Program.cs` must pass.

Your goal is to make the output look similar to:

```text
[PASS]
[PASS]
[PASS]
...
Passed: 20/20
```

---

# 🧩 Requirements

Your program must support the following transports:

| Input          | Expected Object |
| -------------- | --------------- |
| `"car"`        | Car             |
| `"plane"`      | Airplane        |
| `"boat"`       | Boat            |
| `"helicopter"` | Helicopter      |

---

# 🚗 Car

A car:

* is a Vehicle
* can Drive

---

# ✈️ Airplane

An airplane:

* is a Vehicle
* can Fly

---

# 🚤 Boat

A boat:

* is a Vehicle
* can Sail

---

# 🚁 Helicopter

A helicopter:

* is a Vehicle
* can Fly
* can Drive

This requirement is intentional.

A helicopter should demonstrate that:

> A class can inherit from only ONE class but can implement MULTIPLE interfaces.

---

# 🧠 Think Before Coding

Ask yourself:

### Is this an "IS-A" relationship?

Examples:

```text
Car IS A Vehicle
Boat IS A Vehicle
Helicopter IS A Vehicle
```

If yes, inheritance may be appropriate.

---

### Is this a "CAN-DO" relationship?

Examples:

```text
Car CAN Drive
Airplane CAN Fly
Boat CAN Sail
Helicopter CAN Fly
Helicopter CAN Drive
```

If yes, an interface may be appropriate.

---

# 📦 Expected Behavior

The following code should work:

```csharp
var car = TransportResolver.Resolve("car");
var plane = TransportResolver.Resolve("plane");
var boat = TransportResolver.Resolve("boat");
var helicopter = TransportResolver.Resolve("helicopter");
```

The following should also work:

```csharp
List<Vehicle> vehicles =
[
    (Vehicle)car!,
    (Vehicle)plane!,
    (Vehicle)boat!,
    (Vehicle)helicopter!
];
```

---

# ❌ Invalid Input

The resolver should handle invalid inputs.

Example:

```csharp
var x = TransportResolver.Resolve("banana");
```

The application should not crash.

---

# 💡 Hints

## Hint #1

You may need an **abstract class**.

---

## Hint #2

You may need **abstract methods** or **virtual methods**.

---

## Hint #3

A resolver usually decides which object to create based on input.

---

## Hint #4

Polymorphism allows this:

```csharp
Vehicle vehicle = new Car();
```

and also this:

```csharp
Vehicle vehicle = new Helicopter();
```

---

# 🏆 Bonus Challenge

Without changing `Program.cs`, add support for:

```text
motorcycle
submarine
drone
```

Try to design your solution so that adding a new transport requires minimal changes.

---

# 📚 Reflection Questions

After completing the challenge, answer the following:

1. Why did you use inheritance?
2. Why did you use interfaces?
3. Could `Helicopter` inherit from both `Vehicle` and `Airplane`? Why or why not?
4. Why can `Helicopter` implement both `IFlyable` and `IDriveable`?
5. If a `Submarine` can both sail and dive, how would you design it?

---

# Submission

Submit:

* Complete source code
* All tests passing
* Reflection answers

Good luck, and remember:

> **Inheritance answers:** "What are you?"

```text
Car IS A Vehicle.
```

> **Interfaces answer:** "What can you do?"

```text
Car CAN Drive.
Helicopter CAN Fly.
Helicopter CAN Drive.
```
