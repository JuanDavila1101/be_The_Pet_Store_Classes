using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace be_The_Pet_Store_Classes.Pets
{
  class Tiger
  {
    // { get; set; } 
    public string Name { get; set; }
    public string Size { get; set; }
    public int NumberOfKills { get; set; }
    public short Speed { get; set; }

    // Fields 
    // Fields are things that I want to keep track of in the class 
    // but I don't want to expose external to the class
    // Fields start with _ and then camelCase
    // explicit private for: private int _numberOfBites;
    int _numberOfBites;

    public void Bite(string handlerName)
    {
      _numberOfBites++;
      Console.WriteLine($"\n{Name} the tiger just bit {handlerName}. \nThat's the {_numberOfBites} time.\n");
    }


  }

}
