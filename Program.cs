
//1
//Student student1 = new Student();
//student1.firstName = "Abbos";
//student1.lastName = "Jumaev";
//student1.Age = 20;
//
//System.Console.WriteLine($"Enter your FirstName : {student1.firstName}");
//System.Console.WriteLine($"Enter your LastName : {student1.lastName}");
//System.Console.WriteLine($"Enter your Age : {student1.Age}");
//
//
//
//
//class Student
//{
//    public string firstName;
//    public string lastName;
//    public int Age; 
//   
//    public int GetBirthYear()
//    {
//        return DateTime.Now.Year - Age; 
//    }
//
//}


//3
// Player player = new Player();
//
//
//        player.Name = "Cristiano Ronaldo";
//        player.Number = 7;
//        player.Position = "Forward";
//        player.Team = "Real Madrid";
//
//        
//     Console.Write("Enter player's name: ");
//        string name = Console.ReadLine();
//
//        Console.Write("Enter player's number: ");
//        int number = int.Parse(Console.ReadLine());
//
//        Console.Write("Enter player's position: ");
//        string position = Console.ReadLine();
//
//        Console.Write("Enter player's team: ");
//        string team = Console.ReadLine();
//        
//        Console.WriteLine(player.GetInfo());
//        player.ScoreGoal();
//        player.AssistGoal("Benzema");
//
//
//
//class Player
//{
//    public string Name;
//    public int Number;
//    public string Position;
//    public string Team;
//
//    public string GetInfo()
//    {
//        return $"Name: {Name}\nNumber: {Number}\nPosition: {Position}\nTeam: {Team}";
//    }
//
//    public void ScoreGoal()
//    {
//        Console.WriteLine($"{Name} scores a goal!");
//    }
//
//    public void AssistGoal(string playerName)
//    {
//        Console.WriteLine($"{Name} assists a goal for {playerName}.");
//    }
//}


       
   //4
 Employee employee1 = new Employee();

        
     Console.Write("Enter employee's Firstname: ");
        employee1.Firstname = Console.ReadLine();

        Console.Write("Enter employee's Lastname: ");
        employee1.Lastname= Console.ReadLine();

        Console.Write("Enter employee's  Age: ");
        employee1.Age = int.Parse(Console.ReadLine());

        Console.Write("Enter employee's Position: ");
         employee1.Position = Console.ReadLine();

         Console.Write("Enter employee's Salary:");
         employee1.SetSalary (float.Parse(Console.ReadLine()));
        
     
        Console.WriteLine();
        Console.WriteLine(employee1.GetInfo());

      



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



       
     




