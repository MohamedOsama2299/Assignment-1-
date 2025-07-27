using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__1__
{
    internal struct person
    {
        private string[] name;
        private int[] age;
        public person(string name1, int age1, string name2, int age2, string name3, int age3)
        {
            name = new string[3];
            age = new int[3];
            name[0] = name1;
            age[0] = age1;
            name[1] = name2;
            age[1] = age2;
            name[2] = name3;
            age[2] = age3;
        }
        public void result()
        {
            int x = age.Max();
            Console.WriteLine($"The name is {name} \n age is {x}");

        }
    }
}
