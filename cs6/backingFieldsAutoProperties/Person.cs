using System;

namespace backingFieldsAutoProperties
{
  class Person
  {

    public string FirstName { get; }
    public string LastName { get; }
    public string MiddleName { get; } = "";

    public Person(string first, string middle, string last)
    {
      FirstName = first;
      MiddleName = middle;
      LastName = last;
    }

    public override string ToString()
    {
      return $"{FirstName} {MiddleName} {LastName}";
    }
  }
}