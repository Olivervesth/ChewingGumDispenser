using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChewingGumDispenser
{
    class Menu
    {
        Program program = new Program();
        public Refill refill { get; set; }
        public void welcomeScreen()
        {
           
            // Start menu for the dispenser 
            Console.WriteLine("Welcome to the electric Chewing Gum Dispenser\nWould you like a gumball?\n(Yes,No,Refill,Trash)");
            
            string request = Console.ReadLine();

            // checks if there is any gum in the machine
            if (refill == null)
            {
                refill = new Refill();
                refill.fillDispenser();
            }
            //Options for the user
            switch (request)
            {
                case "Yes":
                    Console.Clear();
                    refill.giveGum();
                    refill.countGum();
                    Console.ReadKey();
                    Console.Clear();
                    welcomeScreen();
                    break;

                case "No":
                    Console.Clear();
                    randomFact();
                    Console.ReadKey();
                    Console.Clear();
                    welcomeScreen();
                    break;

                case "Refill":
                    refill.countGum();
                    Console.WriteLine("Press enter to buy a new batch gum");
                    Console.ReadKey();
                    refill = new Refill();
                    refill.fillDispenser();
                    Console.WriteLine("Refill complete");
                    refill.countGum();
                    Console.ReadKey();
                    Console.Clear();
                    welcomeScreen();
                    break;

                case "Trash":
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }

        }
        

        // Gives random fact about gum
        public void randomFact()
        {
            Random rFact = new Random();



            switch (rFact.Next(1, 7))
            {
                case 1:
                    Console.WriteLine("Did you know the world’s oldest piece of chewing gum is 9000 years old!");
                    break;


                case 2:
                    Console.WriteLine("Did you know the average person chews over 300 sticks of gum each year!");
                    break;

                case 3:
                    Console.WriteLine("Did you know most chewing gum is purchased between Halloween and Christmas.");
                    break;

                case 4:
                    Console.WriteLine("Did you know chewing gum while peeling onions will keep you from crying.");
                    break;

                case 5:
                    Console.WriteLine("Did you know humans are the only animals on earth that chew gum.");
                    break;

                case 6:
                    Console.WriteLine("Did you know many dentists now widely recommend chewing sugar free gum to their patients.");
                    break;

                case 7:
                    Console.WriteLine("Did you know in the beginning, chewing gums were made only by hand! Today almost all gums are made by machine.");
                    break;
                default:
                    break;
            }

        }

    }
}
