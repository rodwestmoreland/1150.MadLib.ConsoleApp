﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramUI ui = new ProgramUI();
            Console.Title = "NewtLibs";
            string appLogo = @" 
███╗   ██╗███████╗██╗    ██╗████████╗██╗     ██╗██████╗ ███████╗
████╗  ██║██╔════╝██║    ██║╚══██╔══╝██║     ██║██╔══██╗██╔════╝
██╔██╗ ██║█████╗  ██║ █╗ ██║   ██║   ██║     ██║██████╔╝███████╗
██║╚██╗██║██╔══╝  ██║███╗██║   ██║   ██║     ██║██╔══██╗╚════██║
██║ ╚████║███████╗╚███╔███╔╝   ██║   ███████╗██║██████╔╝███████║
╚═╝  ╚═══╝╚══════╝ ╚══╝╚══╝    ╚═╝   ╚══════╝╚═╝╚═════╝ ╚══════╝
                                                                
";
            Console.WriteLine(appLogo);
            ui.RunMenu();
        }// Main


       
    }// class
}
