using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigurinesInClass.Pieces.Heads
{
    class CoolHead
    {
        public string Hair { get; set; }
        public string Eyewear { get; set; }
        public Gender Gender { get; set; }
        public Color EyeColor { get; set; }

        public void Chew()
        {
            Console.WriteLine($"The {Gender} head with {Hair} hair is wearing {Eyewear} and chilling.");
        }

        public void Greet()
        {
            Console.WriteLine($"The {Gender} head with {Hair} hair is wearing {Eyewear} and says 'sup brah'");
        }

    }
}
