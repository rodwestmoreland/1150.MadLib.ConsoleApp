﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace NewtLibs
{
    class NewtStory4
    {
        public static List<string> Story()
        {
            var setTitle = new Message("A Strange Story");
            setTitle.SetStoryTitle();

            List<string> words = new List<string>();
            
            Console.WriteLine("Enter a noun.");
            words.Add(Console.ReadLine()); //0
            Console.WriteLine("Enter an adjective.");
            words.Add(Console.ReadLine()); //1
            Console.WriteLine("Enter a noun.");
            words.Add(Console.ReadLine()); //2
            Console.WriteLine("Enter the name of a famous individual.");
            words.Add(Console.ReadLine()); //3
            Console.WriteLine("Enter the name of a location.");
            words.Add(Console.ReadLine()); //4
            Console.WriteLine("Enter a verb.");
            words.Add(Console.ReadLine()); //5
            Console.WriteLine("Enter an adjective.");
            words.Add(Console.ReadLine()); //6
            Console.WriteLine("Enter the name of a song.");
            words.Add(Console.ReadLine()); //7
            Console.WriteLine("Enter a verb ending in -ing.");
            words.Add(Console.ReadLine()); //8
            Console.WriteLine("Enter the name of another famous individual.");
            words.Add(Console.ReadLine()); //9
            Console.WriteLine("Enter the name of an adjective.");
            words.Add(Console.ReadLine()); //10
            return words;
        }
    }
}



