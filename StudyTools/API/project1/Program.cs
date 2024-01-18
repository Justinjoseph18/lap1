// // METHODS
// using System;

// namespace MyApplication
// {
//   class Program
//   {
//     // method declaration
//     static void MyMethod(string name,int age)// parameter
//     {
//       Console.WriteLine( name + " is "+ age + " years old");//code to be executed
//     }
//     static void dog(){
//         Console.WriteLine("boww boww");
//     }

//     static void Main(string[] args)
//     {
//         // method calling
//       MyMethod("justin",23);// Argument
//       dog();
//     }
//   }
// }


// Return Argument















// // Class
// using System;
// class Person{
//   // attribute
//   string name="justin";
//   // method 
//   public void job()
//   {
//     Console.WriteLine("Assosiate developer");
//   }
// // main method
// static void Main(string[] args){
//   // Creating object of the class inside the same class
//   Person myperson=new Person();
//   myperson.job();
//   Console.WriteLine(myperson.name);
// }
// }

// Acessing a class from another class
// using System;
// class A{
//   public string names;
//   public int age;
//   public void speak(){
//     Console.WriteLine("I am Justin joseph");
//   }
// }
// class B{
//   static void Main(string[] args){
//     A myA=new A();
//     myA.names="Deena";
//     myA.speak();
//     Console.WriteLine(myA.names);
//   }
// }



// Acess modifiers

// using System;
// namespace MyApplication{
//     class Car
//   {
//    string model;
//   static void Main(string[] args)
//     {
//      Car mycar=new Car();
//      mycar.model="mastang";
//      Console.WriteLine(mycar.model);
//   }
  
// }
// }

// Constructor

// using System;
// class Car{
//   public string Brand;
//   public string Model;
//   public int Price;
//   public int Year;
//   public string Color;
  

//   public Car(string brand,string model,int price,int year,string color){
//     Brand=brand;
//     Model=model;
//     Price=price;
//     Year=year;
//     Color=color;
//   }
//   static void Main(string[] args)
//   {
//     Car mycar1=new Car("toyota","fortuner",1000000,2012,"black");
//     Car mycar2=new Car("honda","amaze",1500000,2021,"red");
//     Console.WriteLine(mycar2.Color);
//   }

// }


// // Inheritance
// using System;
// class vechicle{
//     public void horn(){
//         Console.WriteLine("pee pee pee");
//     }
//     public string brand="ford";
// }
// class car:vechicle{
// public string modelname="mustang";
// }
// class Program{
// static void Main(string[] args){
//     car mycar=new car();
//     mycar.horn();
//     Console.WriteLine(mycar.brand);
//         Console.WriteLine(mycar.modelname);

// }
// }


//Polymorphism

// using System;
// class Animal  // Base class (parent) 
// {
//   public virtual void animalSound() 
//   {
//     Console.WriteLine("The animal makes a sound");
//   }
// }

// class Pig : Animal  // Derived class (child) 
// {
//   public override void animalSound() 
//   { 
//     Console.WriteLine("The pig says: wee wee");
//   }
// }

// class Dog : Animal  // Derived class (child) 
// {
//   public  void dogSound() 
//   {
//     Console.WriteLine("The dog says: bow wow");
//   }
// }

// class Program 
// {
//   static void Main(string[] args) 
//   {
//     Animal myAnimal = new Animal();  // Create a Animal object
//     Animal myPig = new Pig();  // Create a Pig object
//     Animal myDog = new Dog();  // Create a Dog object
//     Dog mydig=new Dog();

//     myAnimal.animalSound();
//     myPig.animalSound();
//     mydig.dogSound();
//     myDog.animalSound();
//   }
// }

// Abstraction

// using System;
//  abstract class A{
//     public void bark(){
//         Console.WriteLine("boww boww");
//     }
// public string name="justin";
// public abstract void walk(); 
// }
// class B:A{
//     public void talk(){
//         Console.WriteLine("hai");
//     }
//     public override void walk()
//     {
//         Console.WriteLine("tup tup");
//     }

// }
// class Program{
//     static void Main(string[] args){
//         B myB=new B();
//         myB.bark();
//         myB.walk();

//     }
// }


//GENERICS

// Without generics
// class Swapper
// {
//     public void SwapInts(int a,int b)
//     {
//         int temp = a;
//         a = b;
//         b = temp;
//     }
// }
// class Program{
//     static void Main(string[] args){
//         Swapper swapper = new Swapper();
//         swapper.SwapInts(4,8);
// }
// }
