using System;

public static class Kata
{
  public static int CountSheeps(bool[] sheeps)
  {
    int counter = 0;
    
    foreach(var sheep in sheeps){
      if(sheep) counter++;
    }
    
    return counter;
  }
}
