using System;

namespace task;


class Employee
{
    public string Firstname;
    public string Lastname;
    public int Age;
    public string Position;
    public decimal Salary;

    public string GetInfo()
    {
        return $"Name: {Firstname}\nLastname: {Lastname}\nAge: {Age}\nPosition: {Position}\nSalary: {GetSalary()}";
    }

public void SetSalary(float salary)
{
     if(salary > 0 )
        {
            this.Salary =  decimal.Parse($"{salary}");
        }
}
public float GetSalary()
{
   return float.Parse($"{this.Salary}");
}
}


}
