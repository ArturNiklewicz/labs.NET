public class Program
{
    public static readonly List<EnumExample.Task> tasks = new();

    static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("1. Add task\n2. View tasks\n3. Delete Task\n4. Exit");
            Console.Write("Choose an option: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddTask();
                    break;
                case 2:
                    ViewTasks();
                    break;
                case 3:

                    DeleteTask();
                    break;
                case 4:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }

    static void AddTask()
    {
        Console.WriteLine("You are adding a task:");
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string description = Console.ReadLine();
        Console.Write("Day: ");
        EnumExample.DayOfWeek day = (EnumExample.DayOfWeek)Convert.ToInt32(Console.ReadLine());
        tasks.Add(new EnumExample.Task(name, description, day));
    }
    private static void DeleteTask()
    {
        throw new NotImplementedException();
    }

    private static void ViewTasks()
    {
        foreach (var task in tasks)
        {
            Console.WriteLine(task);
        }
    }
}