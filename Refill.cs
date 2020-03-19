using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChewingGumDispenser
{
    class Refill
    {
        public ChewingGums[] GumDispendser { get; set; }

        public void fillDispenser()
        {
            GumDispendser = new ChewingGums[55];
            //Fills the array with gum 
            for (int i = 0; i < 55; i++)
            {

                if (i <= 13)
                {
                    //25%
                    GumDispendser[i] = new ChewingGums("BlueBerry", "Blue");
                }
                else if (i > 13 && i <= 20)
                {

                    //14%
                    GumDispendser[i] = new ChewingGums("StrawBerry", "Red");
                }
                else if (i > 20 && i <= 25)
                {
                    //10%
                    GumDispendser[i] = new ChewingGums("Appel", "Green");
                }
                else if (i > 25 && i <= 35)
                {
                    //19%
                    GumDispendser[i] = new ChewingGums("Orange", "Orange");

                }
                else if (i > 35 && i <= 46)
                {
                    //20%
                    GumDispendser[i] = new ChewingGums("TuttiFrutti", "Yellow");

                }
                else if (i > 46 && i <= 52)
                {
                    //12%
                    GumDispendser[i] = new ChewingGums("BlackBerry", "Purpel");

                }
                else if (i > 52)
                {
                    //Fills the 2 last empty spots in the array
                    GumDispendser[i] = new ChewingGums("TuttiFrutti", "Yellow");
                }

            }


           


        }

        //Gives the user a gum and describe the taste and the color
        //Stakkels barn, han eller hun får jo aldrig sit tyggegummi ..... metoden er void
        //Den burde jo returerne et Gum
        public void giveGum()
        {
            //Picking random index in the array so you get a random gum
            Random rand = new Random();
            int index = rand.Next(0, 55);
            
            //Ingen Console i dit logik lag
            Console.Clear();
            if(GumDispendser[index] == null)
            {
                giveGum();
            }
           //Ingen Console i dit logik lag
            Console.WriteLine($"Gum taste:{GumDispendser[index].taste}\nGum color:{GumDispendser[index].color}\nEnjoy your gum");
           //Ingen Console i dit logik lag
            Console.ReadKey();
            GumDispendser[index] = null;

        }
        //Counts how many empty spots there are in the array and minus it with the max count so you get how many gums are left in the machine 
        public void countGum()
        {
            int i = 0;
            foreach (ChewingGums item in GumDispendser)
            {
                if (item == null)
                i++;
            }
            Console.WriteLine("There is {0} gum left",55 - i );
        }
    }
}
