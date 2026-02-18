using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    internal class Minotaure : Animal
    {
        public Minotaure(string name, int age) : base(name, age)
        {
        }
        public override void MakeSound()
        {
            Console.WriteLine("Le minotaure fait: c'est pas une déviance !");
        }
    }
}
