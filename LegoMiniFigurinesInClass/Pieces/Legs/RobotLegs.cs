using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigurinesInClass.Pieces.Legs
{
    class RobotLegs : LegsBase  
    {
        public RobotLegs()
        {
            Covering = "Metal";
            NumberOfLegs = 3;
            Speed = 4;
            _musicGenre = "Robo Boogie";
            Shoes = "No Shoes";
        }

        public override void Dance()
        {
            Console.WriteLine("The Robot legs dance the robot for the rest of the time.");
        }
    }
}
