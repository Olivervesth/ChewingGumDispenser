using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChewingGumDispenser
{
    //Husk klasser skal navngives i ental
    class ChewingGums
    {
       
        // Gum props so we know the taste and color
        public string taste { get; set; }
        public string color { get; set; }

        public ChewingGums(string taste,string color)
        {
            this.taste = taste;
            this.color = color;
        }

    }
}
