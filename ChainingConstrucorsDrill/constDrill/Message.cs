using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Message
{
    public string Person;
    public int Number;

    public Message(string person) : this(person, 2)
    {
    }
    public Message(string person, int number)
    {
        this.Person = person;
        this.Number = number;
    }
}

