using System;

namespace task;

public class Class
{
    
class Student
{
    public string firstName;
    public string lastName;
    public int Age; 
   
    public int GetBirthYear()
    {
        return DateTime.Now.Year - Age; 
    }

}

}
