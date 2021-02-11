using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtLibs
{
    class NewtStory3
    {
        public static List<string> Story()
        {
            var setTitle = new Message("War, War Never Changes");
            setTitle.SetStoryTitle();

            List<string> words = new List<string>();
            
            Console.WriteLine("Enter a noun.");
            words.Add(Console.ReadLine()); //0
            Console.WriteLine("Enter a noun.");
            words.Add(Console.ReadLine()); //1
            Console.WriteLine("Enter a noun.");
            words.Add(Console.ReadLine()); //2
            Console.WriteLine("Name of a famous individual.");
            words.Add(Console.ReadLine()); //3
            Console.WriteLine("Enter a verb.");
            words.Add(Console.ReadLine()); //4
            Console.WriteLine("Name of a location.");
            words.Add(Console.ReadLine()); //5
            Console.WriteLine("Enter a noun.");
            words.Add(Console.ReadLine()); //6
            Console.WriteLine("Enter an adjective relating to the previous question.");
            words.Add(Console.ReadLine()); //7
            Console.WriteLine("Enter a verb ending with (ing).");
            words.Add(Console.ReadLine()); //8
            Console.WriteLine("Enter a plural noun.");
            words.Add(Console.ReadLine()); //9
            Console.WriteLine("Enter an emotion.");
            words.Add(Console.ReadLine()); //10
            return words;
        }

    }
}
