# OOPS

## Before OOPS

## Procedural oriented programming paradigm

Procedural Programming is a programming paradigm that follows a linear, top-down approach to solving a problem. In procedural programming, the program is divided into procedures or functions, and these procedures are executed sequentially.

        using System;

        class Program
        {
            // This is a procedure 

            static void GreetUser(string name)
            {
                Console.WriteLine("Hello, " + name + "!");
            }

            // Another procedure
            static int AddNumbers(int a, int b)
            {
                return a + b;
            }

            static void Main()
            {
                // Calling procedures to perform tasks
                GreetUser("John");

                int result = AddNumbers(5, 3);
                Console.WriteLine("The sum is: " + result);
            }
        }

## What is OOPS?

- OOPS stands for object oriented programming.
- Procedural programming is about writing procedures or methods that perform operations on the data, while object-oriented programming is about creating objects that contain both data and methods.

Object-oriented programming has several advantages over procedural programming:

- OOP is faster and easier to execute.
- OOP follows DRY principle.
- "Don't Repeat Yourself" (DRY) principle is about reducing the repetition of code. You should extract out the codes that are common for the application, and place them at a single place and reuse them instead of repeating it.

## Class

- Classes and objects are the two main aspects of object-oriented programming.
  - Class FRUIT
  - Object=>Apple,Orange,banana.....
- So, a class is a template for objects, and an object is an instance of a class.
- When the individual objects are created, they inherit all the variables and methods from the class.
- Class is a collection of methods and attributes(variables).

            class Car 
            {
            string color = "red";
            }   
            Create a class named "Car" with a variable color.

## Objects

- Object is an instance of a class.
- To create an object of Car, specify the class name, followed by the object name, and use the keyword new:

## Class Members

- Fields and methods inside classes are often referred to as "Class Members":
  
## Constructors

- A constructor is a special method that is used to initialize objects.
- The advantage of a constructor, is that it is called when an object of a class is created
- constructor name must match the class name, and it cannot have a return type (like void or int).
- constructor is called when the object is created.
- Constructors can also take parameters, which is used to initialize fields.

## Acess Modifiers

1. Public
   - Code can be acessed for all classes
2. private
   - The code is only accessible within the same class
3. Protected
    - The code is accessible within the same class, or in a class that is inherited from that class
4. Internal
   - The code is only accessible within its own assembly, but not from another assembly.
  
## Pillers of OOPS

1. ### Encapsulation 

2. ### Abstraction

3. ### Inheritance

4. ### Polymorphism