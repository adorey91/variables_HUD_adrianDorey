﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace virablesHUD_v1._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarations & initializing
            string game = "Variables_HUD_v1.0"; // game name
            string playerName;
            float score = 0f; // score is 0
            int health = 100; // health is 100
            int lives = 3;
            float multiplier = 0f;
            string playerInput;



            // pretend gameplay
            Console.WriteLine("Enter Name: ");
            playerName = Console.ReadLine();

            Console.Clear();
            
            Console.WriteLine("Game Name: "+game);
            Console.WriteLine("Player Name: " + playerName);
            Console.WriteLine("Score: " + score + "| " + "Health: " + health + "| " + "Lives: " + lives + "| " + "Multiplier: " + multiplier);
            Console.WriteLine(""); 
            Console.WriteLine(playerName+" walks through forest and falls in a hole and takes 25 damage");
            Console.WriteLine("");
            health = health - 25;
            multiplier = 2;
            score = score - (2 * multiplier);

            Console.WriteLine("Press any key to continue the story");
            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine("Game Name: " + game);
            Console.WriteLine("Player Name: " + playerName);
            Console.WriteLine("Score: " + score + "| " + "Health: " + health + "| " + "Lives: " + lives + "| " + "Multiplier: " + multiplier); 
            Console.WriteLine("");
            Console.WriteLine("Half way through the tunnel, " + playerName + " sees a dark figure that looks like it could be an enemy. They find a rock and throw it at the enemy.");
            Console.WriteLine("");

            Console.WriteLine("Press any key to continue the story");
            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine("Game Name: " + game);
            Console.WriteLine("Player Name: " + playerName);
            Console.WriteLine("Score: " + score + "| " + "Health: " + health + "| " + "Lives: " + lives + "| " + "Multiplier: " + multiplier); 
            Console.WriteLine("");
            Console.WriteLine("The dark figure quickly approaches and swallows "+playerName+" whole");
            Console.WriteLine("");
            health = 0;
            lives = lives - 1;
            multiplier = multiplier / 2;
            score = score - (100* multiplier);

            Console.WriteLine("Press any key to continue the story");
            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine("Game Name: " + game);
            Console.WriteLine("Player Name: " + playerName);
            Console.WriteLine("Score: " + score + "| " + "Health: " + health + "| " + "Lives: " + lives + "| " + "Multiplier: " + multiplier); 
            Console.WriteLine("");
            Console.WriteLine(playerName+" spawns back at the bottom of the tunnel");
            Console.WriteLine();
            health = health + 100;
            
            Console.WriteLine("Press any key to continue the story");
            Console.ReadKey(true);
            Console.Clear();


            Console.WriteLine("Game Name: " + game);
            Console.WriteLine("Player Name: " + playerName);
            Console.WriteLine("Score: " + score + "| " + "Health: " + health + "| " + "Lives: " + lives + "| " + "Multiplier: " + multiplier); 
            Console.WriteLine("");
            Console.WriteLine("They follow the same tunnel as before but this time makes it to the end without seeing the dark figure. The tunnel leads to a beautfiul apple orchard. Hero decides to eat an apple. The apple gives them 50 health");
            Console.WriteLine("");
            health = health + 50;
            multiplier = 1.2f;
            score = score + (25 * multiplier);

            Console.WriteLine("Press any key to continue the story");
            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine("Game Name: " + game);
            Console.WriteLine("Player Name: " + playerName);
            Console.WriteLine("Score: " + score + "| " + "Health: " + health + "| " + "Lives: " + lives + "| " + "Multiplier: " + multiplier); 
            Console.WriteLine("");
            Console.WriteLine("After healing " + playerName+ " goes for a walk through the orchard where they find a chest and decide to open it.");
            Console.WriteLine("");

            Console.WriteLine("Press any key to continue the story");
            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine("Game Name: " + game);
            Console.WriteLine("Player Name: " + playerName);
            Console.WriteLine("Score: " + score + "| " + "Health: " + health + "| " + "Lives: " + lives + "| " + "Multiplier: " + multiplier); 
            Console.WriteLine("");
            Console.WriteLine(playerName+" finds a map to the exit and money but the inside of the lid to the chest has a sign that says only pick one.");
            Console.WriteLine("");

            Console.WriteLine("Press any key to continue the story");
            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine("Game Name: " + game);
            Console.WriteLine("Player Name: " + playerName);
            Console.WriteLine("Score: " + score + "| " + "Health: " + health + "| " + "Lives: " + lives + "| " + "Multiplier: " + multiplier); 
            Console.WriteLine("");
            Console.WriteLine("Type "+playerName+"'s direction... map, money or both");
            Console.WriteLine("");

            playerInput = Console.ReadLine();
            playerInput = playerInput.ToLower();

            Console.Clear();

            if (playerInput == "map")
            {
                Console.WriteLine("Game Name: " + game);
                Console.WriteLine("Player Name: " + playerName);
                Console.WriteLine("Score: " + score + "| " + "Health: " + health + "| " + "Lives: " + lives + "| " + "Multiplier: " + multiplier); 
                Console.WriteLine("");
                Console.WriteLine("Using the map, "+playerName+" finds their way out of the orchard and back home where there's 1000$ and a pie waiting");
                Console.WriteLine("");
                score = score + (3000 * multiplier);
                health = health + 50;

                Console.WriteLine("Press any key to finish the story");
                Console.ReadKey(true);
                Console.Clear();

                Console.WriteLine("Game Name: " + game);
                Console.WriteLine("Player Name: " + playerName);
                Console.WriteLine("Score: " + score + "| " + "Health: " + health + "| " + "Lives: " + lives + "| " + "Multiplier: " + multiplier); 
                Console.WriteLine("");
                Console.WriteLine(playerName+" lives happily ever after.");
                Console.WriteLine("");
            }
            else if (playerInput == "money")
            {
                Console.WriteLine("Game Name: " + game);
                Console.WriteLine("Player Name: " + playerName);
                Console.WriteLine("Score: " + score + "| " + "Health: " + health + "| " + "Lives: " + lives + "| " + "Multiplier: " + multiplier); 
                Console.WriteLine("");
                Console.WriteLine(playerName+" has taken the money and receives 2500 but will not find their way back home but instead builds a new home in the orchard.");
                Console.WriteLine("");
                score = score + (2500 * multiplier);

                Console.WriteLine("Press any key to finish the story");
                Console.ReadKey(true);
                Console.Clear();

                Console.WriteLine("Game Name: " + game);
                Console.WriteLine("Player Name: " + playerName);
                Console.WriteLine("Score: " + score + "| " + "Health: " + health + "| " + "Lives: " + lives + "| " + "Multiplier: " + multiplier); 
                Console.WriteLine("");
                Console.WriteLine(playerName+" lives a pretty good life.");
                Console.WriteLine("");
            }
            else if (playerInput == "both")
            {
                Console.WriteLine("Game Name: " + game);
                Console.WriteLine("Player Name: " + playerName);
                Console.WriteLine("Score: " + score + "| " + "Health: " + health + "| " + "Lives: " + lives + "| " + "Multiplier: " + multiplier); 
                Console.WriteLine("");
                Console.WriteLine(playerName+" being gready decides to take both. The dark figure appears from no where, screams and swallows them whole once more, but this time takes all remaining lives and health.");
                Console.WriteLine("");

                Console.WriteLine("Press any key to finish the story");
                Console.ReadKey(true);
                Console.Clear();

                health = health - health;
                score = score - 100;
                lives = lives - lives;

                Console.WriteLine("Game Name: " + game);
                Console.WriteLine("Player Name: " + playerName);
                Console.WriteLine("Score: " + score + "| " + "Health: " + health + "| " + "Lives: " + lives + "| " + "Multiplier: " + multiplier); 
                Console.WriteLine("");

            }
            else
            {
                Console.WriteLine("Game Name: " + game);
                Console.WriteLine("Player Name: " + playerName);
                Console.WriteLine("Score: " + score + "| " + "Health: " + health + "| " + "Lives: " + lives + "| " + "Multiplier: " + multiplier); 
                Console.WriteLine("");
                Console.WriteLine(playerName+" Dies.");
                Console.WriteLine("You didn't listen.");
                Console.WriteLine("");
                health = health - health;
                score = score - 1000;
                lives = lives - lives;

                Console.WriteLine("Press any key to finish the story");
                Console.ReadKey(true);
                Console.Clear();


                Console.WriteLine("Game Name: " + game);
                Console.WriteLine("Player Name: " + playerName);
                Console.WriteLine("Score: " + score + "| " + "Health: " + health + "| " + "Lives: " + lives + "| " + "Multiplier: " + multiplier); 
                Console.WriteLine("");
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey(true);
        }
    }
}
