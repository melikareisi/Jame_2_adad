﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jam_e_do_adad
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Adad Aval Ra Vared Konid :");
            string Input_1 = Console.ReadLine();
            Console.WriteLine("Adad Dovom Ra Vared Konid :");
            string Input_2 = Console.ReadLine();

            int num1 = Convert.ToInt32(Input_1);
            int num2 = Convert.ToInt32(Input_2);
            int sum = num1 + num2;

            Console.WriteLine("Jam'e do adad =");
            Console.WriteLine(sum);
        }
    }
}
