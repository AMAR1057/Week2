using System;

abstract class Salesperson
{
    protected string firstName;
    protected string lastName;
    public string FirstName 
    {
        get{return firstName;}
        set{firstName = value;}

    }
    public string LastName{
        get{return lastName;}
        set{lastName = value;}

    }

    public string GetFullName()
    {
        return firstName + ""+lastName;
    }

    protected Salesperson(string firstName,string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }
}