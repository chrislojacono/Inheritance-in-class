using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigurinesInClass.Pieces.Heads
{
    class Skull
    {
        public Condition Condition { get; set; }
        public Color Color { get; set; }
        public Color EyeColor { get; set; }

        public void Wail()
        {
            if (Condition == Condition.OnFire)
            {
                Console.WriteLine($"The flaming skull with {EyeColor} eyes wails angrily.");
            }
            else
            {
                Console.WriteLine($"The {Color} skull wails mournfully because it is dead and {Condition} and not on fire.");
            }
        }
        public void Greet()
        {
            if(Condition == Condition.OnFire)
            {
                Console.WriteLine($"The flaming {Color} skull with {EyeColor} eyes smoulders in your direction.");
            }
            else
            {
                Console.WriteLine($"The {Color} skull is dead and can't greet you.");
            }
        }
    }

}
