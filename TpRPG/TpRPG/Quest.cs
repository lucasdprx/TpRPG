namespace TpRPG;

public class Quest(string name, string description)
{
    public string name = name;
    public string description = description;
    public bool isCompleted;

    public void Complete()
    {
        isCompleted = true;
        Console.WriteLine($"{name} has been completed.");
    }
}