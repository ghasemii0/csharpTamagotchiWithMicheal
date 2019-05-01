using System;
using System.Collections.Generic;
namespace Tamagotchi
{
    public class Pet
    {
      private int _food;
      private int _sleep;
      private int _play;
      private static List<Pet> _instances = new List<Pet> { };

      public Pet(int food, int sleep, int play)
      {
        _food += food;
        _sleep += sleep;
        _play += play;
        _instances.Add(this);
      }
      public int getFood()
      {
        return _food;
      }
      public int getSleep()
      {
        return _sleep;
      }
      public int getPlay()
      {
        return _play;
      }
      public static List<Pet> GetAll()
      {
          return _instances;
      }


    }
}
