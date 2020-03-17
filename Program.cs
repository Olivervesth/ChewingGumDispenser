using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChewingGumDispenser
{

    class Program
    {


        static void Main(string[] args)
        {
            Refill refill = new Refill();
            ChewingGums[] gumDispenser = new ChewingGums[55];
            Menu menu = new Menu();

            
            
            menu.welcomeScreen();
            Console.ReadKey();
        }


        
      
        




    }
}
