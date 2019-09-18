using System;

namespace expressionBodied
{
  class Person
  {
    private string FirstName { get; }
    private string LastName { get; }
    public Person(string first, string last)
    {
      FirstName = first;
      LastName = last;
    }

    public override string ToString() => $"{FirstName} {LastName}";

    public string AllCaps() => ToString().ToUpper();
  }
}