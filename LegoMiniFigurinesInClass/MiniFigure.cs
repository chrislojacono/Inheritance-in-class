using System;
using System.Collections.Generic;
using System.Text;
using LegoMiniFigurinesInClass.Pieces.Heads;
using LegoMiniFigurinesInClass.Pieces.Legs;
using LegoMiniFigurinesInClass.Pieces.Torsos;

namespace LegoMiniFigurinesInClass
{
    class MiniFigure
    {
        public Head Head { get; }
        public Torso Torso { get; }
        public LegsBase Legs { get; }

        public MiniFigure(Head head, Torso torso, LegsBase legs)
        {
            Head = head;
            Legs = legs;
            Torso = torso;
        }

        public void MeetSomeone()
        {
            Legs.Walk();
            Torso.Wave();
            Head.Greet();
        }
    }
}
