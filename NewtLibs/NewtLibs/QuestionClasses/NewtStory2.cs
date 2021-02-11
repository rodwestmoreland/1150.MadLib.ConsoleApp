using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtLibs
{
    class NewtStory2
    {
        public static List<string> Story()
        {
            var setTitle = new Message("Important Considerations");
            setTitle.SetStoryTitle();

            List<string> words = new List<string>();

            Console.WriteLine("Enter a name/type of beverage");
            words.Add(Console.ReadLine()); //0
            Console.WriteLine("Enter a number");
            words.Add(Console.ReadLine()); //1
            Console.WriteLine("Enter something round");
            words.Add(Console.ReadLine()); //2
            Console.WriteLine("Enter a place");
            words.Add(Console.ReadLine()); //3
            Console.WriteLine("Enter a Hors d'oeuvre or side dish");
            words.Add(Console.ReadLine()); //4
            Console.WriteLine("Enter a word beginning with the letter C");
            words.Add(Console.ReadLine()); //5
            Console.WriteLine("Enter a word beginning with the letter O");
            words.Add(Console.ReadLine()); //6
            Console.WriteLine("Enter a word beginning with the letter V");
            words.Add(Console.ReadLine()); //7
            Console.WriteLine("Enter a word beginning with the letter I");
            words.Add(Console.ReadLine()); //8
            Console.WriteLine("Enter a word beginning with the letter D");
            words.Add(Console.ReadLine()); //9
            Console.WriteLine("Enter a verb");
            words.Add(Console.ReadLine()); //10
            Console.WriteLine("Enter a verb");
            words.Add(Console.ReadLine()); //11.
            Console.WriteLine("Enter a body part");
            words.Add(Console.ReadLine()); //12.
            Console.WriteLine("Enter a bodily function");
            words.Add(Console.ReadLine()); //13.
            Console.WriteLine("Enter a adjective");
            words.Add(Console.ReadLine()); //14.
            Console.WriteLine("Enter another adjective"); //Capital letter
            words.Add(Console.ReadLine()); //15.
            Console.WriteLine("Enter a type of building/structure or outside area");
            words.Add(Console.ReadLine()); //16
            Console.WriteLine("Enter a verb ending in -ing");
            words.Add(Console.ReadLine()); //17.
            Console.WriteLine("Enter a unit of measure (plural)");
            words.Add(Console.ReadLine()); //18.
            Console.WriteLine("Enter a body part");
            words.Add(Console.ReadLine()); //19
            Console.WriteLine("Enter a number");
            words.Add(Console.ReadLine()); //20.
            Console.WriteLine("Enter a unit of time (seconds, minutes, days, years, etc)");
            words.Add(Console.ReadLine()); //21
            Console.WriteLine("Enter a nursery rhyme or children's song");
            words.Add(Console.ReadLine()); //22.
            Console.WriteLine("Enter a body part");
            words.Add(Console.ReadLine()); //23.
            Console.WriteLine("Enter a another body part");
            words.Add(Console.ReadLine()); //24.
            Console.WriteLine("Enter an item of clothing");
            words.Add(Console.ReadLine()); //25.
            Console.WriteLine("Enter a body part (plural)"); 
            words.Add(Console.ReadLine()); //26.
            Console.WriteLine("Enter a verb ending in -ing");
            words.Add(Console.ReadLine()); //27.
            Console.WriteLine("Enter a phrase or salutation");
            words.Add(Console.ReadLine()); //28.
            Console.WriteLine("Enter something you would find in a bathroom (plural)");
            words.Add(Console.ReadLine()); //29.
            Console.WriteLine("Enter a cartoon character");
            words.Add(Console.ReadLine()); //30
            
            Console.Clear();
            return words;
        }

    }
}
