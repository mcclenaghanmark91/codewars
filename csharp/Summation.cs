using System;

public static class Kata 
{
    public static int summation(int num)
    {
      int summation = 0;
      
      for(int i = 0; i <= num; i++ ){
        summation += i;
      }
      
      return summation;
    }
}
