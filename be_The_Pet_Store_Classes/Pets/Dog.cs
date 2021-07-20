using System;

// The namespace provide: Organization, Specifisity
// In general the namespaces will follow folder structures but is not enforced
// Classes are containers for Behavior = verbs
// Classes has Data Spesificity like Dogs have a name, a color
// Also things like an age for the dog, 
// Classes have:
// Behavior = methods that expose the statefullnes
// State = properties 
// Fields = is the internal data
namespace be_The_Pet_Store_Classes.Pets
{
  // Class names are Capitalized 
  class Dog // they are implicitly = Internal, they are only accesible in this project
  {
    // What kind of data are needed for the dog
    // What are the properties
    // Properties have accecibility modifier 
    // who has access to this property
    // Most access are going to be Publlic
    // public is an access modifier
    // 

    // Access Modifier:
    // Private: only things in this class can use it, default in a class 
    // Public: everything that can see the class can access it 
    // Internal: anything in this project can access it 
    // Protected: anything that inherits from me can access it. It's like a modified version of private

    // properties
    // Properties Capital case names
    // Access modifier = public
    // Type = string
    // Name = Size
    public string Size { get; set; } // auto-property
    public short Weight { get; private set; } // Getter and Setter or implicitly set it to private set, by removing "private set;"
    public string Name { get; set; }

    // Constructor, constroctor method
    // the name of the constroctor method has to be: Dog
    public Dog(string name, string size, short weight)
    {
      Name = name;
      Weight = weight;
      Size = size;
    }


    // Behavior in a class
    // Method Signature has 4 parts: 
    // 1 Access Modifier = public accesor 
    // 2 Return Type
    // 3 Name
    // 4 List of Parameters 

    // Method signature
    // void means this method is returning nothing
    public void Bark()
    {
      Console.WriteLine($"{Name} barks noisily.");
    }

    // Parameters are camelCase 
    public void Eat(string typeOfFood)
    {
      if (String.Equals(typeOfFood, "healthy food", StringComparison.OrdinalIgnoreCase))
      {
        Console.WriteLine("this is healthy food");
      }

      switch (typeOfFood)
      {
        case "healthy food":
          Weight -= 1;
          break;

        case "bad food":
          Weight += 1;
          break;

        default:
          Console.WriteLine("didn't find the food");
          return;
          break;
      }

      Console.WriteLine($"{Name} I just ate: {typeOfFood} \n{Name}'s weight is: {Weight}\n");
    }



  }
}
