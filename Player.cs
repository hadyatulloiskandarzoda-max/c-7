using System;

namespace task;


class Player
{
    public string Name;
    public int Number;
    public string Position;
    public string Team;

    public string GetInfo()
    {
        return $"Name: {Name}\nNumber: {Number}\nPosition: {Position}\nTeam: {Team}";
    }

    public void ScoreGoal()
    {
        Console.WriteLine($"{Name} scores a goal!");
    }

    public void AssistGoal(string playerName)
    {
        Console.WriteLine($"{Name} assists a goal for {playerName}.");
    }
}


