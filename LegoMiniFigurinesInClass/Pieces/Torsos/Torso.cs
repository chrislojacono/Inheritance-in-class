using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigurinesInClass.Pieces.Torsos
{
    class Torso
    {
        public Clothing Clothing { get; set; }
        public Color Color { get; set; }
        public int NumberOfArms { get; set; }
        public string Accesory { get; set; }

        public Torso()
        {
            NumberOfArms = 2;
        }

        //With virtual you get to say by default this is how this method works 

        public virtual void Wave()
        {
            if(NumberOfArms > 0)
            {
                Console.WriteLine($"The {GetType().Name} wearing a {Clothing} and {Accesory} gives a friendly wave.");
            }
            else
            {
                Console.WriteLine("You can't wave with no arms ya big dummy!");
            }
        }

    }
}
