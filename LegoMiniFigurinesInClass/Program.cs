﻿using System;
using LegoMiniFigurinesInClass.Pieces.Heads;
using LegoMiniFigurinesInClass.Pieces;

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
        }
    }
}
