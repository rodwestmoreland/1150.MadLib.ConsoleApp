﻿using System;
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
                Console.WriteLine("Welcome to NewtLibs! The game where ___. Which NewtLib would you like? \n\n" +
                        "1. Story 1\n" +
                        "2. Story 2\n" +
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
                    //case 5:
                    //    words = NewtStory5.Story();
                    //    break;
                    //case 6:
                    //    words = NewtStory6.Story();
                    //    break;
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
                   $"for{words[5]} {words[6]} {words[7]} {words[8]} {words[9]}.\n" +
                   $"\nThe virus is mainly spread during close contact when people {words[10]} or {words[11]}. People can also \n" +
                   $"catch it by touching a contaminated surface and then touching their {words[12]}. Common symptoms \n" +
                   $"include {words[13]} and a {words[14]} throat. However, you may have the virus without showing any of these \n" +
                   $"symptoms, so it is important to heed the precautions even if you think you are well. {words[15]} \n" +
                   $"people are particularly vulnerable to the virus. \n" +
                   $"\nAs a society, out of love for others, we are working to flatten the curve. To do so, social \n" +
                   $"distancing is very important. We must all stay in our {words[16]} unless we have essential things to do \n" +
                   $"like {words[17]} groceries. If we are outside for essential activities or exercise, it is critical \n" +
                   $"to keep six {words[18]} away from people.\n" +
                   $"\nlt is also very important to wash your {words[19]} very often. I try to do so {words[20]} times per day\n" +
                   $"and each time it should last 20 {words[21]}.To help me wash for enough time, I sing {words[22]}.\n" +
                   $"lt’s also important to not touch your {words[23]} or {words[24]} and if you need to cough, please do not \n" +
                   $"cough into your hand, but instead into your {words[25]}. When greeting people, you can no longer \n" +
                   $"shake {words[26]}. Instead, we suggest {words[27]} from a distance and yelling {words[28]}.\n" +
                   $"\nWidespread panic has spurred panic buying. ln particular, people love to buy quarantine snacks and {words[29]}.\n" +
                   $"\nWe are so thankful for our healthcare and other essential workers. They are heroes like {words[30]}."
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
                },

            };

            Console.WriteLine(storyComplete[selector]);
            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();

        }// \createStory






    }// \class
}
