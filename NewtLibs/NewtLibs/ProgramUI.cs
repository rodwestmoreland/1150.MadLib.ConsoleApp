using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtLibs
{
    public class ProgramUI
    {
        
        public void RunMenu()
        {

            bool continueToRun = true;
            while (continueToRun)
            {
                Console.WriteLine("Welcome to NewtLibs! The game where you fill in the ___!! Which NewtLib would you like? \n\n" +
                        "1. A Very Odd Day\n" +
                        "2. Important Considerations\n" +
                        "3. Story 3\n" +
                        "4. Story 4\n" +
                        "5. Story 5\n" +
                        "6. Story 6\n" +
                        "7. Random Story\n" +
                        "8. Exit");

                int userStory = Convert.ToInt32(Console.ReadLine());

                if (userStory == 8)
                { Environment.Exit(0); }
                else if(userStory > 0 && userStory < 8)
                {
                    CreateStory(userStory);
                } else
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a number 1 - 8");
                    Console.WriteLine();
                }
                

            }// \while
        }// \Run Menu

        public void CreateStory(int select)
        {

            List<string> words = new List<string>();
            Console.WriteLine(words.Count);
            Console.ReadLine();

            int selector = select;

            switch (selector) //Our questions
            {
                case 1:
                    words = NewtStory1.Story();
                    break;
                case 2:
                    words = NewtStory2.Story();
                    break;
                case 3:
                    words = NewtStory3.Story();
                    break;
                case 4:
                    words = NewtStory4.Story();
                    break;
                case 5:
                    words = NewtStory5.Story();
                    break;
                case 6:
                    words = NewtStory6.Story();
                    break;
            }
            

            var storyComplete = new Dictionary<int, string>()
            {
                {
                   1, $"This morning {words[0]} woke up feeling {words[7]}. 'It is going to be a {words[2]} day!'\n" +
                $"Outside, a bunch of {words[5]} were protesting to keep {words[6]} in stores. They began to sway \n" +
                $"to the rhythm of the {words[3]}, which made all the {words[5]} very {words[4]}. Concerned, {words[0]} \n" +
                $"texted {words[1]}, who flew to {words[8]} and dropped {words[6]} in a puddle of frozen {words[9]}. \n" +
                $"{words[1]} woke up in the year {words[10]}, in a world where {words[5]} ruled the world."
                },
                {
                   2, $"The {words[0]} virus is affecting {words[1]} of people around the {words[2]}.\n" +
                   $"The outbreak was first identified in {words[3]} and was recognized as a pandemic by the World \n" +
                   $"{words[4]} Organization on March ll. lt is also called COVID-19, which is an abbreviation \n" +
                   $"for {words[5]} {words[6]} {words[7]} {words[8]} {words[9]}.\n" +
                   $"\nThe virus is mainly spread during close contact when people {words[10]} or {words[11]}. People can also \n" +
                   $"catch it by touching a contaminated surface and then touching their {words[12]}. Common symptoms \n" 
                },

                {
                    3, $"It was during the battle of {words[0]} when I was running through a {words[1]} when a {words[2]} went off right next to my platoon. \n" +
                    $"{words[3]}, our commanding officer, yelled for us to {words[4]} to the nearest {words[5]} we could find. When we got to the \n" +
                    $" {words[5]} we had to start a {words[6]}. As we were starting the fire the enemy saw the {words[7]} from the fire and started {words[8]} at us. \n" +
                    $"We all quickly ducked behind the {words[9]} and returned fire. we quickly eliminated the enemy and were {words[10]} that we \n" +
                    $" had won the battle."
                },
                {
                    4, $" Once upon a time there was a {words[0]}. It had {words[1]} {words[2]}! One day it met {words[3]}on the side of the {words[4]},they were {words[5]}.\n" +
                    $" It was very {words[6]}; they both looked like hobos! All of the sudden they started singing {words[7]}really loudly.\n" +
                    $" Then we started {words[8]}with {words[9]}. They looked really {words[10]}!"
<<<<<<< HEAD
                }

=======
                },
                {
                  5, $" I am currently enrolled in a Software Development class. It's much more {words[0]} than I thought it would be. The instructor is very {words[1]} when it comes to teaching. My favorite LA is {words[2]}, he helps the most. {words[3]} is the smartest student, {words[4]} puts the most time into studying, {words[5]} is always sharing the best resources. {words[6]} seems to be what we always get off topic about, but after a little bit of {words[7]}, we always get back on track. I can't wait to graduate, I'm going to go to {words[8]} to celebrate!!"
                },
                {
                  6, $"A vacation is when you take a trip to some {words[0]} place with your {words[1]} family. A good vacation place is one where you can ride {words[2]}, and play {words[3]} game. I like to spend my time {words[4]} or {words[5]}. Parents need vacations more than kids because parents are always very {words[6]} and because they have to work {words[7]} hours every day all year long making enough {words[8]} to pay for the vacation."
                }
>>>>>>> b2f40dcb14f5eb5fd02e8cd1d14dca99889c9803
            };

            Console.WriteLine("Here is your story...\n" + storyComplete[selector]);
            Console.WriteLine();
            Console.WriteLine(words.Count);
            Console.ReadLine();
            Console.Clear();

        }// \createStory



    }// \class
}
