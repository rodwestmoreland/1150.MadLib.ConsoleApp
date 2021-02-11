using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtLibs
{
    class NewtStory5
    {
        public static List<string> Story()
        {
            var setTitle = new Message("Software Developer 76");
            setTitle.SetStoryTitle();

            List<string> words = new List<string>();

            Console.WriteLine("Enter an adjective.");
            words.Add(Console.ReadLine()); //0
            Console.WriteLine("Enter an adjective.");
            words.Add(Console.ReadLine()); //1
            Console.WriteLine("Enter the name of a LA.");
            words.Add(Console.ReadLine()); //2
            Console.WriteLine("Enter a student name.");
            words.Add(Console.ReadLine()); //3
            Console.WriteLine("Enter a student name.");
            words.Add(Console.ReadLine()); //4
            Console.WriteLine("Enter a student name.");
            words.Add(Console.ReadLine()); //5
            Console.WriteLine("Enter a noun.");
            words.Add(Console.ReadLine()); //6
            Console.WriteLine("Enter a verb ending in ing.");
            words.Add(Console.ReadLine()); //7
            Console.WriteLine("Enter a place");
            words.Add(Console.ReadLine()); //8
          

            return words;
        }

    }
}
