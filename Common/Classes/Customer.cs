using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Classes;

public class Customer : IPerson
{
    public int SSN { get; set; }
    public string LastName { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;

    public Customer(int ssn, string lastname, string firstname) =>
        (SSN, LastName, FirstName) = (ssn, lastname, firstname);

}
