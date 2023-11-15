using System;
using System.Text.RegularExpressions;

public class Kata
{
  public static bool ValidatePin(string pin)
  {
    Regex rgx = new Regex(@"^\d{4}(?:\d{2})?$");
    return rgx.IsMatch(pin);
  }
}
