﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.ServiceModel;

namespace NumberGuessingConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //(1) Create a proxy to the WCF service.
            NumberGuessServiceClient client = new NumberGuessServiceClient();

            Console.WriteLine("**********************************************************************");
            Console.WriteLine(" _   _                 _               ");
            Console.WriteLine("| \\ | |_   _ _ __ ___ | |__   ___ _ __ ");
            Console.WriteLine("|  \\| | | | | '_ ` _ \\| '_ \\ / _ \\ '__|");
            Console.WriteLine("| |\\  | |_| | | | | | | |_) |  __/ |   ");
            Console.WriteLine("|_| \\_|\\__,_|_| |_| |_|_.__/ \\___|_|   ");
            Console.WriteLine("                                       ");
            Console.WriteLine("  ____                     _                ____                      ");
            Console.WriteLine(" / ___|_   _  ___  ___ ___(_)_ __   __ _   / ___| __ _ _ __ ___   ___ ");
            Console.WriteLine("| |  _| | | |/ _ \\/ __/ __| | '_ \\ / _` | | |  _ / _` | '_ ` _ \\ / _ \\");
            Console.WriteLine("| |_| | |_| |  __/\\__ \\__ \\ | | | | (_| | | |_| | (_| | | | | | |  __/");
            Console.WriteLine(" \\____|\\__,_|\\___||___/___/_|_| |_|\\__, |  \\____|\\__,_|_| |_| |_|\\___|");
            Console.WriteLine("                                   |___/                              ");
            Console.WriteLine("**********************************************************************");
            int lowerLimit = takeNumberInput("Enter a Lower Limit:");
            int upperLimit = takeNumberInput("Enter an Upper Limit:");

            int secretNumber = client.SecretNumber(lowerLimit, upperLimit);
            Console.WriteLine("A Secret Number has been generated between " + lowerLimit.ToString() + " and " + upperLimit.ToString());

            int guessCount = 0;
            string output = "";
            bool cont = true;
            while (cont)
            {
                int guess = takeNumberInput("What number would you like to guess?");
                output = client.checkNumber(guess, secretNumber);
                cont = !output.ToLower().Contains("correct");
                guessCount++;
                buildAttemptOutput(output, guessCount,cont);
            }

            Console.WriteLine("\n\nPress <return> to exit.");
            Console.ReadLine();
            
        }

        private static int takeNumberInput(String msg) {
            try {
                Console.WriteLine(msg);
                string userInput = Console.ReadLine();
                if(userInput.Equals("")){
                    throw new System.FormatException();
                }else{
                    return int.Parse(userInput);
                }
            }catch(System.FormatException){
                return takeNumberInput("Invalid Input, try again...");
            }
        }

        private static void buildAttemptOutput(string msg,int count, bool tryAgain){
            string output = "";
            if (tryAgain) {
                output += msg+" - Try Again! - "+" Attempts - "+count.ToString();
            } else {
                output += msg + " Attempts - " + count.ToString();
            }

            Console.WriteLine(output);
        }

    }
}