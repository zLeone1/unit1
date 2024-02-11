using System.Threading;


bool exit = true;
List<string> tasks = new List<string>();
while (exit!)
{

    Console.WriteLine("Welcome, What do you want to do?  \n 1. Add New Assingment \n 2. Check your current assignments \n 3. Leave");
    int input = Convert.ToInt32(Console.ReadLine());
    switch (input)
    {
       
        case 1:
            Console.Write("" +
                "Add a new task ");
            string newtask = Console.ReadLine();
            tasks.Add(newtask);
            Console.WriteLine("Task succesfully added");
            Console.WriteLine();
            break;
        case 2:
            if (tasks.Count == 0)
            {
                Console.WriteLine("You Have no current tasks:");
                continue;
            }
            Console.WriteLine("Your current tasks are:");
           
            for (int i = 0; i < tasks.Count; i++)
            { if (tasks[i].Contains(" COMPLETED"))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{i + 1}. {tasks[i]}");
                    Console.ResetColor();
                    continue;
                }
                Console.WriteLine($"{i + 1}. {tasks[i]}");
               
               
            }

            Console.WriteLine("Select a task ");         
            int option = Convert.ToInt32(Console.ReadLine());
             if (option >= 1 && option <= tasks.Count)
                {
                    string selectedTask = tasks[option - 1];
                    Console.WriteLine($"Task {option}:  {selectedTask}");
                Console.WriteLine("What do you want to do with this task? \n 1. Mark as Completed \n 2. Delete ");
                int option2 = Convert.ToInt32(Console.ReadLine());
                switch (option2)
                {
                    case 1:
                        if (tasks[option - 1].Contains(" COMPLETED"))
                        {
                            Console.WriteLine("Task is already completed");
                            continue;
                        }
                        selectedTask = selectedTask + " COMPLETED";
                        tasks[option - 1] = selectedTask;
                    
                        break;


                        case 2:
                        tasks.RemoveAt(option - 1);
                        Console.WriteLine("Task succesfully deleted");
                        break;

                }

                }
             else
            {
                Console.WriteLine("Task number doesn't exist.");
            }
           
                

                   
                    
                

                break;

        case 3:
            exit = false;
            break;
 
    }
}

 