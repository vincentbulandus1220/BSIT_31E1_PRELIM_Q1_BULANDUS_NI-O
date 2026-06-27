1. Why did you use inheritance?
I used inheritance to create a clear "is-a" relationship between classes and avoid repeating code. Common properties and behaviors like Model, Speed, and the Move() method are defined once in the base Vehicle class. Child classes such as Airplane, Helicopter, and Watercraft automatically inherit these features. This makes the code shorter, easier to maintain, and more organized, since changes only need to be made in one place.
2. Why did you use interfaces?
I used interfaces to define common capabilities or "can-do" behaviors without writing the actual code implementation. Interfaces act as contracts — for example, IFlyable means "can fly" and IDriveable means "can drive". They allow different classes to share the same actions even if they are not related by inheritance. Interfaces also help achieve abstraction, make the code more flexible, and let us add multiple behaviors safely.
3. Can Helicopter inherit from both Vehicle and Airplane? Why or why not?
No, it cannot.In languages like C# and Java, only single class inheritance is allowed — a class can only have one direct parent class. If multiple inheritance were allowed, it could cause the "Diamond Problem": if both parent classes have methods or properties with the same name, the compiler would not know which one to use, leading to confusion and errors. Therefore, we choose the most logical single parent (in this case, Vehicle or Airplane) and use interfaces for extra actions.
4. Why can Helicopter implement both IFlyable and IDriveable?
Yes, it can implement both.There is no limit to how many interfaces a class can have. Unlike classes, interfaces only declare what methods should exist, not how they work. The Helicopter class simply provides its own unique implementation for each method required by the interfaces. Since each behavior is defined separately, there is no conflict or ambiguity, making this safe and allowed.
5. If a Submarine can both sail and dive, how would you design it?
I would design it following proper OOP principles like this:
Create a base class Watercraft that inherits from Vehicle to hold common features for all water vehicles.
Create two interfaces:
ISailable: declares the method Sail()
IDiveable: declares the method Dive()
Make the Submarine class inherit from Watercraft and implement both interfaces.
Write the specific code inside Submarine for both actions.
