﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();

            dog.Eat();
            dog.bark();

            Console.ReadLine();
        }
    }
}
