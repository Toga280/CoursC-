using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Renard : Animal
    {
        public Renard(string name, int age) : base(name, age)
        {
        }
        public override void MakeSound()
        {
            Console.WriteLine("Le renard fait: Grrr!");
        }
    }
}