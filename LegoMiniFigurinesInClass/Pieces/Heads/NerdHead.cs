using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigurinesInClass.Pieces.Heads
{
    class NerdHead
    {
        public string EyeWear { get; set; }
        public bool Braces { get; set; }
        public string Hat { get; set; }
        public bool Acne { get; set; }

        public void Pontificate()
        {
            Console.WriteLine($"The nerd wearing a {Hat} says 'Actually... I am a very smart'");
        }

        public void Greet()
        {
            Console.WriteLine($"The nerd wearing a {Hat} says 'I've calculated the chances of us ever seeing each other again. It is zero.'");
        }
    }
}
