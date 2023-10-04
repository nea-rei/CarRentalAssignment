using Common.Interfaces;

namespace Common.Classes;

public class Person : IPerson
{
    public int SSN { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string FullName => $"{LastName} {FirstName} ({SSN})";

    public Person(int ssn, string lastname, string firstname) =>
        (SSN, LastName, FirstName) = (ssn, lastname, firstname);

}
