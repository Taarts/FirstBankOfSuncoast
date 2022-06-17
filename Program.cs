using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace FirstBankOfSuncoast
{
    enum AccountType
    {
        Checking, Savings
    }

    class Program
    {
        // static void DisplayGreeting()
        // {
        //     Console.WriteLine("----------------------------------------");
        //     Console.WriteLine("    Welcome to First Bank of Suncoast   ");
        //     Console.WriteLine("----------------------------------------");
        //     Console.WriteLine();
        //     Console.WriteLine();
        // }

        static string PromptForString(string prompt)
        {
            Console.Write(prompt);
            var userInput = Console.ReadLine();

            return userInput;
        }

        static int PromptForInteger(string prompt)
        {
            Console.Write(prompt);
            int userInput;
            var isThisGoodInput = Int32.TryParse(Console.ReadLine(), out userInput);

            if (isThisGoodInput)
            {
                return userInput;
            }
            else
            {
                Console.WriteLine("Sorry, that isn't a valid input, I'm using 0 as your answer.");
                return 0;
            }
        }

        static void Main(string[] args)
        {
            var keepGoing = true;

            // DisplayGreeting();

            // While the user hasn't said QUIT yet
            while (keepGoing)
            {
                // Insert a blank line then prompt them and get their answer (force uppercase)
                Console.WriteLine();
                Console.Write("Which account do you want?\n (C)hecking or (S)avings? \n or (Q)uit: ");
                var choice = Console.ReadLine().ToUpper();


                switch (choice)
                {
                    case "Q":
                        keepGoing = false;
                        break;
                    case "C":
                        checkingMenu();
                        // Checking(database);
                        break;

                    case "S":
                        SavingsMenu();
                        break;

                    default:
                        Console.WriteLine("☠️ ☠️ ☠️ ☠️ ☠️ NOPE! ☠️ ☠️ ☠️ ☠️ ☠️");
                        break;
                }
            }
        }

        public static void checkingMenu()
        {
            Console.WriteLine($"Print Checking");
            var checkingAnswer = PromptForString("Would you like to...?\n (V)iew Balance\n or (D)eposit money\n (W)ithdraw money\n or (Q)uit: ");
            switch (checkingAnswer)
            {
                case "V":
                    ShowBalance(AccountType.Checking);
                    break;

                case "D":
                    DepositFunds(AccountType.Checking);
                    break;

                case "W":
                    WithDrawFunds(AccountType.Checking);
                    break;

                default:
                    Console.WriteLine("wrong answer, you muppet. 💥 🥾");
                    break;

            }
        }

        public static void SavingsMenu()
        {
            Console.WriteLine($"Print Saving");
            var savingsAnswer = PromptForString("Would you like to...?\n (V)iew Balance\n or (D)eposit money\n (W)ithdraw money\n or (Q)uit: ");

            switch (savingsAnswer)
            {
                case "V":
                    ShowBalance(AccountType.Savings);
                    break;

                case "D":
                    DepositFunds(AccountType.Savings);
                    break;

                case "W":
                    WithDrawFunds(AccountType.Savings);
                    break;

                default:
                    Console.WriteLine("wrong answer, you muppet. 💥 🥾");
                    break;

            }

        }

        public static void WithDrawFunds(AccountType accountType)
        {
            switch (accountType)
            {
                case AccountType.Checking:
                    break;
                case AccountType.Savings:
                    break;
            }
        }

        public static void DepositFunds(AccountType accountType)
        {
            switch (accountType)
            {
                case AccountType.Checking:
                    break;
                case AccountType.Savings:
                    break;

            }
        }

        public static void ShowBalance(AccountType accountType)
        {
            switch (accountType)
            {
                case AccountType.Checking:

                    break;
                case AccountType.Savings:
                    break;
            }
        }


    }
}