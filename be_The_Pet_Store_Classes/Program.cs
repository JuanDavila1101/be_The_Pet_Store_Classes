using be_The_Pet_Store_Classes.Pets;
using System;
// using be_The_Pet_Store_Classes.Pets;


// OOP Object Oriented Programming 
// In C# Everything can be an object
namespace be_The_Pet_Store_Classes
{
  class Program
  {
    static void Main(string[] args)
    {
      //var melba = new Dog();
      //melba.Name = "Melba";
      //melba.Size = "Medium";
      //melba.Weight = 60;
      var melba = new Dog("Melba", "Medium", 60);
      melba.Bark();
      Console.WriteLine($"{melba.Name}'s weight is: {melba.Weight}");
      melba.Eat("healthy food");

      //var gunner = new Dog();
      //gunner.Name = "Gunner";
      //gunner.Size = "Large";
      //gunner.Weight = 80;
      var gunner = new Dog("Gunner", "Large", 80);
      gunner.Bark();
      Console.WriteLine($"{gunner.Name}'s weight is: {gunner.Weight}");
      gunner.Eat("bad food");

      // instance methods have to be called on an instance of an object
      // Dog.Bark("Gunner")
      // but it's only good for one intance for all objects
      // Static vs Shared 

    }
  }



}
