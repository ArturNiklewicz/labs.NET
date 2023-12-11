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
        Console.WriteLine("\nYou are adding a task:");
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string description = Console.ReadLine();
        Console.Write("Day: ");
        EnumExample.DayOfWeek day = (EnumExample.DayOfWeek)Convert.ToInt32(Console.ReadLine()) - 1;
        tasks.Add(new EnumExample.Task(name, description, day));
    }
    private static void DeleteTask()
    {
        Console.Write("\nEnter the name of the task to delete: ");
        string name = Console.ReadLine(); //TODO: sprawdzić czy task o takiej nazwie istnieje
        if (tasks.Exists(task => task.Name == name))
        {
            tasks.RemoveAll(task => task.Name == name);
            Console.WriteLine($"You have deleted {name}, now you have got {tasks.Count()} tasks\n");
        }
        else
        {
            Console.WriteLine("There is no task with this name\n");
        }
    }

    private static void ViewTasks()
    {
        foreach (var task in tasks)
        {
            Console.WriteLine(task);
        }
    }
}