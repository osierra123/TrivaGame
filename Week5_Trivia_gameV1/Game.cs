using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Week5_Trivia_game
{
    class Game
    {
        public string PlayerAnswer; 
        public Game()
        {

            Player player = new Player();
            player.Name = "";
            Trivia trivia = new Trivia();

            player.Score = 0; 


            // Ask what is the players name
            //Accept input from the player.
            WriteLine("What is your name?");
            player.Name = ReadLine();
            WriteLine($"Nice to meet you {player.Name}");


            // What color is the sky question. again confirm
            //Accept input from the player.
            //Write out to the screen the player's answer and the correct answer.
            trivia.Question = new string[] { "What color is the sky? ", "What color is the cow?", 
                "What color is the dog?", " What color is the Lemon?", "What color is the cloud?", 
                "What color is the cat?", "What color is the notebook?", "What color is the pen?",
                "What color is the pencil?", "What color is the moon?", "What color is the sun?" };  
            trivia.Options = new string[] { "blue", "red", "black" };
            trivia.Answer = new string[] { "red", "red", "red", "red", "red", "red", "red", "red", "red", "red", "red", };

            for (int i = 0; i < trivia.Answer.Length; i++)
            {
                WriteLine(trivia.Question[i]);
                PlayerAnswer = ReadLine();

                if (PlayerAnswer.ToLower() == "red")
                {
                    WriteLine($"Your answer was {PlayerAnswer }, and the correct answer was {trivia.Answer[i]}");
                    player.Score++;
                }
                else
                {
                    WriteLine("Your answer did not match the correct answer");

                }
            }

            WriteLine($"You scored {player.Score}. ");
            ReadKey();  





           
           

           

            //Write a question to the screen. 
            //What color is the cow?
            //What color is the dog?
            //What color is the Lemon?
            //What color is the cloud?
            //What color is the cat?
            //What color is the notebook?
            //What color is the pen?
            //What color is the pencil?
            //What color is the moon?
            //What color is the sun?
             
            


            // Is the car on Question. Requires confirmation that answer is equal to answer
            //Accept input from the player.
            //Write out to the screen the player's answer and the correct answer.

        }


    }
}
