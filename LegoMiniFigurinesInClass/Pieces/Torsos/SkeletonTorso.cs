using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigurinesInClass.Pieces.Torsos
{
    class SkeletonTorso : Torso
    {
        public Condition Condition { get; set; }
        public SkeletonTorso(bool hasArmsAttached, Condition condition)
        {
            NumberOfArms = hasArmsAttached ? 2 : 0;
            Clothing = Clothing.None;
            Color = Color.Yellow;
            Condition = condition;
        }

        public override void Wave()
        {
            if(Condition == Condition.Broken)
            {
                Console.WriteLine($"The skeleton torso is broken and can'y wave.");
            }
            else
            {
                base.Wave();
            }
            
        }
    }
}
