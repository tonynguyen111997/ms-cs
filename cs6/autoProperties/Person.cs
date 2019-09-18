using System;

namespace autoProperties
{
  public class Person
  {
    /* 
     * `private set` makes it where you can only change the 
     * class variables inside of the class itself. If there was no
     * private, you will be able to change it outside of the class, such
     * as in Program.cs.
     */    
    public string FirstName { get; private set; }
    /*
     * Removing `set;` will make it read-only, meaning you can only grab
     * the value, but not change it. Makes it immutable.
     */
    public string LastName { get; }

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
      // FirstName = FirstName.ToUpper();
      // LastName = LastName.ToUpper();
      return ToString().ToUpper();
    }
  }
}