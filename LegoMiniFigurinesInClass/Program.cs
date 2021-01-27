using System;
using LegoMiniFigurinesInClass.Pieces.Heads;
using LegoMiniFigurinesInClass.Pieces;
using LegoMiniFigurinesInClass.Pieces.Torsos;

namespace LegoMiniFigurinesInClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new CoolHead();
            head.Eyewear = "Sunglasses";
            head.Hair = "Long";
            head.Gender = Gender.Male;
            head.Talk("stuff");

            var pirateWithHook = new PirateTorso(true) { Clothing = Clothing.SmokingJacket };
            var pirateWithoutHook = new PirateTorso(false) { Clothing = Clothing.Tanktop };
            pirateWithHook.Wave();
            pirateWithoutHook.Wave();


            var skeletonTorso = new SkeletonTorso(false, Condition.OnFire);
            var policeTorso = new PoliceOfficerTorso();

            var torsos = new Torso[] { pirateWithoutHook, pirateWithHook, skeletonTorso, policeTorso };

            foreach (var torso in torsos)
            {
                torso.Wave();
            }
        }
    }
}
