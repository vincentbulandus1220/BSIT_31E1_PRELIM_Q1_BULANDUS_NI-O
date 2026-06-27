# Reflection: Object-Oriented Programming Concepts

### 1. Why did you use inheritance?
Inheritance is used to establish an **"is-a" relationship** between a parent class and a child class. It allows the child class to reuse or extend behavior defined in the parent class. By inheriting `Vehicle`, we avoid code duplication and ensure consistency (keeping the codebase DRY).

### 2. Why did you use interfaces?
Interfaces are used to define a strict contract for what a class **can do** ("can-do" relationship). They contain method signatures but no implementation. This allows unrelated classes (like a `Boat` and a `Submarine`) to share the same capabilities (like `ISailable`) without needing the same parent class.

### 3. Can Helicopter inherit from both Vehicle and Airplane? Why or why not?
**No**, a `Helicopter` cannot inherit from both `Vehicle` and `Airplane`. C# does not support **multiple inheritance** for classes to avoid the **Diamond Problem**—a structural ambiguity where the compiler doesn't know which parent's method to execute if both implement a method with the same name. 

### 4. Why can Helicopter implement both IFlyable and IDriveable?
C# explicitly allows a class to implement **multiple interfaces**. Because interfaces only declare methods without providing the actual code implementation, the `Helicopter` class itself is responsible for writing the logic. Therefore, there is no risk of ambiguity or conflicting parent code.

### 5. If a Submarine can both sail and dive, how would you design it?
1. **Base Class:** Have `Submarine` inherit from a base `Vehicle` class for core identity.
2. **Interfaces:** Create two distinct interfaces: `ISailable` and `IDivable`.
3. **Implementation:** Have the `Submarine` class implement both interfaces and provide the specific string outputs for `Move()`.