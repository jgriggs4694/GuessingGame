using System;

namespace GUESSTHENUMBER
{
    class Program
    {
        static int GetIntegerFromUser(string question)
        {
            int integerFromUser;
            bool success;
            do
            {
                Console.WriteLine(question);
                string userResponse = Console.ReadLine();
                success = int.TryParse(userResponse, out integerFromUser);

            } while (success == false);
            return integerFromUser;
        }    

        static void Main(string[] args)
        {
            Console.WriteLine("Let's play a guessing game! The highed your score, the worse you did!");
            int max = GetIntegerFromUser("What max range would you like?");

            //counter needs to be in scope
            //let them know if guess is right or wrong
            //blah

            Random rnd = new Random();
            int secretNumber = rnd.Next(1, max + 1);

            
            int input = 0;
            int guessNum = 0;

            do
            {
                guessNum = GetIntegerFromUser("Guess a number bro");
                if (guessNum > secretNumber)
                {
                    Console.WriteLine("Your answer is higher than the secret number!");
                    input++;
                }
                else if (guessNum < secretNumber)
                {
                    Console.WriteLine("Your answer is lower than the secret number");
                    input++;
                }
                else 
                {
                    Console.WriteLine("You have guessed correctly!");
                    Console.WriteLine($"It took you {input} tries");
                }
            }while (guessNum != secretNumber); 
           

            
        }
    }
}