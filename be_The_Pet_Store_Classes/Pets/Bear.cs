using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace be_The_Pet_Store_Classes.Pets
{
  class Bear
  {
    public string Name { get; set; }
    public string Type { get; set; }
    public int NumberOffFishEaten { get; private set; }
    public string EducatioLevel { get; set; } = "GED";
    public bool LovesHoney { get; }
    public Tiger BestTigerFriend { get; set; }

    // writing constructor ctor and 2xtab
    public Bear(string name, string type)
    {
      Name = name;
      Type = type;
      EducatioLevel = "GED";

      if (name == "Winnie the Pooh")
      {
        LovesHoney = true;
      }
      else if (name == "Yogi")
      {
        EducatioLevel = "Above Average";
      }
      else
      {
        EducatioLevel = "High School";
      }

    }

    public Bear(string name, string type, string educationLevel) : this(name, type)
    {

    }

    public void EatFish(int howMany)
    {
      if (howMany <= 0) return;
      NumberOffFishEaten += howMany;
    }

    public void HangOutWithBestFriend()
    {
      Console.WriteLine($"{Name}'s best friend is {BestTigerFriend}\n");
    }


  }
}
