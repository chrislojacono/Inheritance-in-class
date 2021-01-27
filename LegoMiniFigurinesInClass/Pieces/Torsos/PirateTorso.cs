using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigurinesInClass.Pieces.Torsos
{
    class PirateTorso : Torso
    {
        public bool HookForHand { get; private set; }
        
        public PirateTorso(bool hookForHand)
        {
            Accesory = "Parrot";
            HookForHand = hookForHand;
        }

        public override void Wave()
        {
            if (HookForHand)
            {
                Console.WriteLine($"The pirate torso beckons menacingly with his hook...");
            }
            else
            {
                base.Wave();
               // Console.WriteLine($"The pirate torso gives you the finger!");
            }
            
        }
    }
}
