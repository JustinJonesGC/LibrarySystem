﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            App.ShowMenu();
            App.GetMenuSelection();
            App.PrintTable();
            Console.ReadLine();
        }
    }
}
