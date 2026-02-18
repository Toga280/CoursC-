using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Loup : Animal
    {
        public Loup(string nom, int age) : base(nom, age)
        {
        }
        public override void MakeSound()
        {
            Console.WriteLine("le loup hurle à la lune.");
        }
    }
}