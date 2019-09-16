using System;

namespace autoProperties
{
  public class Person
  {
    public string FirstName { get; private set; }
    public string LastName { get; private set; }

    public Person(string first, string last){
      FirstName = first;
      LastName = last;
    }

    public override string ToString()
    {
      return FirstName + " " + LastName;
    }

    public string AllCaps()
    {
      FirstName = FirstName.ToUpper();
      LastName = LastName.ToUpper();
      return ToString();
    }
  }
}