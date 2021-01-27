using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigurinesInClass.Pieces.Legs
{
    class SpiderLegs : LegsBase
    {
        public SpiderLegs()
        {
            NumberOfLegs = 8;
            Shoes = "Rollerskates";
            Speed = 100;
            _musicGenre = "Rock Opera";
            Size = Size.Spider;
            Covering = "Hair";
        }

        public override void Dance()
        {
            Console.WriteLine($"Spiders can't dance to {_musicGenre}");
        }
    }
}
