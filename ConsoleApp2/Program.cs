﻿using System;

namespace ConsoleApp2
{
    class Program
    {
      public  static int  Main(string[] args)
        {
            {
                for (int i=0;i<10;i++)
                {
                    Console.WriteLine("i");
                }//i goes out of scope here
                 //we can declare a variable with that name in scope 
                 for (int i=9;i>-0;i--)
                {
                    Console.WriteLine(i);
                }//i goes out of scope here.
                return 0;
            }
           
        }
    }
}
