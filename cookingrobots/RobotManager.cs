using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CookingRobots
{
    public class RobotManager
    {
        Robot myRobot;
        public RobotManager()
        {
            // Display the number of command line arguments.
            StaffPage();
        }

        public void StaffPage()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Staff Menu");
                Console.WriteLine("");
                Console.WriteLine("1. Build a predefined robot");
                Console.WriteLine("2. Build a custom Robot");
                Console.WriteLine("3. Switch to Client");
                Console.WriteLine("4. Quit");
                Console.Write("What would you like to do?(1/2/3/4): ");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.Clear();
                    Console.WriteLine("1. BakerHelper");
                    Console.WriteLine("2. StewHelper");
                    Console.Write("What would you like to do?(1/2): ");
                    string robot = Console.ReadLine();
                    if (robot == "1")
                    {
                        this.myRobot = new BakerHelper();
                        Console.WriteLine("Robot set to BakerHelper");
                        Console.WriteLine("Press Any Key to continue...");
                        Console.ReadLine();
                    }
                    else if (robot == "2")
                    {
                        this.myRobot = new StewHelper();
                        Console.WriteLine("Robot set to StewHelper");
                        Console.WriteLine("Press Any Key to continue...");
                        Console.ReadLine();
                    }
                }
                else if (choice == "2")
                {
                    Console.Clear();
                    Console.Write("How many containers? (1 <= x <= 10): ");
                    int count = Convert.ToInt32(Console.ReadLine());
                    this.myRobot = new Robot(count);
                    this.myRobot.SetLabels();
                    this.myRobot.recipe = new Recipe("EMPTY");
                }
                else if (choice == "3")
                {
                    if(this.myRobot != null)
                    {
                        this.ClientPage();
                        return;
                    }
                    Console.WriteLine("ERROR: No robot Created");
                    Console.WriteLine("Press Any Key to continue...");
                    Console.ReadLine();

                }
                else if (choice == "4")
                {
                    return;
                }
            }
        }

        public  void ClientPage()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Client Menu");
                Console.WriteLine("");
                Console.WriteLine("1. Add custom recipe");
                Console.WriteLine("2. Edit labels");
                Console.WriteLine("3. Execute Robot Recipe");
                Console.WriteLine("4. Quit");
                Console.Write("What would you like to do?(1/2/3/4): ");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    this.RecipeMaker();
                }
                else if (choice == "2")
                {
                    Console.Clear();
                    if(this.myRobot != null)
                    {
                        this.myRobot.SetLabels();
                    }
                    else
                    {
                        Console.WriteLine("ERROR: no robot created");
                    }
                }
                else if (choice == "3")
                {
                    Console.Clear();
                    if (this.myRobot != null)
                    {
                        this.myRobot.Make();
                        Console.WriteLine("Press Any Key to continue...");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("ERROR: no robot created");
                    }
                }
                else if (choice == "4")
                {
                    return;
                }
            }

        }

        public void RecipeMaker()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Recipe maker");
            Console.Write("What's the name of your recipe?: ");
            string name = Console.ReadLine();
            Recipe newrecipe = new Recipe(name);
            while (true)
            {
                Console.Clear();
                Console.WriteLine("making Recipe: " + newrecipe.name);
                Console.WriteLine("Other options aren't implemneted, just proof of concept");
                Console.Write("What's next? (direction, save): ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "direction":
                        Console.Clear();
                        Console.Write("Direction: ");
                        string direction = Console.ReadLine();
                        newrecipe.AddStep(new Misc(direction));
                        break;

                    case "save":
                        Console.Clear();
                        Console.WriteLine("Saving Recipe to robot...");
                        this.myRobot.AddRecipie(newrecipe);
                        Console.WriteLine("Press Any Key to continue...");
                        Console.ReadLine();
                        return;
                }
            }
        }
    }
}
