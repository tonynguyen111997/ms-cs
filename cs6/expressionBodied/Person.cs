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

    /*
     * Similar to JS arrow functions with slight differences.
     * JS: const ToString = () => `${FirstName} ${LastName}`;
     * C#: public override string ToString() => $"{FirstName} {LastName}";
     */
    public override string ToString() => $"{FirstName} {LastName}";

    /*
     * Expression-bodied members are not like JS arrow function in the 
     * sense that you write chunks of code in it. Expression-bodied members
     * are meant for short concise one-liner code. The example below shows
     * that it doesn't allow for multi-line code.
     */
    public string AllCaps() => {
      return ToString().ToUpper();
    }
    // public string AllCaps() => ToString().ToUpper();
  }
}