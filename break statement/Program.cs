﻿using System;

namespace Tutlane
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                if (i == 3)
                    break;
                Console.WriteLine("i value: {0}", i);
            }
            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();
        }
    }
};
