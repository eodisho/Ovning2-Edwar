using System;

namespace Ovning2_Edwar
{
    class Program
    {
        static void Main(string[] args)
        {
            char yourChar = ' ';
            bool choice = true;

            Console.WriteLine("Please choose one of the following options");
            Console.WriteLine("0 - Quit the program");
            Console.WriteLine("1 - How many tickets would you like to buy?");
            Console.WriteLine("2 - Enter text 10 times");
            Console.WriteLine("3 - Enter a minium of a three words sentence)");
            do
            {
                Console.WriteLine();
                Console.WriteLine("Please choose a number");
                // Console.WriteLine("Enter a number");
                // ReadKey() reads which key is pressed on the keyboard. If you add true value in ReadKey() would not 
                // print the key you have chosen.Test it by adding the value true, see what shows on the screen.
                yourChar = char.ToLower(Console.ReadKey().KeyChar);
                switch (yourChar)
                {
                    case '0':
                        {
                            choice = false;
                            break;
                        }

                    case '1':
                        {
                            Console.WriteLine();
                            Console.WriteLine("Enter the number of people in your group");
                            int groupNumber = int.Parse(Console.ReadLine());
                            CalculateGroupCost(groupNumber);
                            break;
                        }
                    case '2':
                        {
                            UserText();
                            break;
                        }
                    case '3':
                        {
                            SplitSentence();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("That was an incorrect input, try again!");
                            Console.WriteLine();
                            break;
                        }
                }
            } while (choice);
        }

        public static void SplitSentence()
        {
            Console.ReadLine();
            Console.WriteLine("Enter your sentence");
            string line = Console.ReadLine();
            // splits the sentence and asigns the words to a string
            string[] word = line.Split(' ');
            if (word.Length < 3)
            {
                Console.WriteLine("You need to write more than three words");
                Console.ReadLine();
            }
            else
                Console.WriteLine("The last word in the sentence is:" + word[word.Length - 1]);
        }
        private static void UserText()
        {
            // array with 10 elments to hold user input
            string[] textEntered = new string[10];
            for (int i = 0; i < textEntered.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Enter a text");
                textEntered[i] = Console.ReadLine();
            }

            // Iterating through the array elements and printing them
            foreach (string value in textEntered)
            {
                Console.Write(value);
            }
            Console.WriteLine();
        }


        public static void CalculateGroupCost(int groupNumber)
        {
            int sum = 0;
            int grouptotalnumbers = 0;
            Console.WriteLine();
            for (int i = 0; i <= groupNumber; i++)
            {
                if (i >= groupNumber)
                {
                    break;
                }
                else
                    Console.WriteLine("Enter the age of each member of the group ");
                int groupMemberAge = int.Parse(Console.ReadLine());
                if (groupMemberAge < 20)
                {
                    sum += 80;
                    grouptotalnumbers += 1;
                }
                else if (groupMemberAge > 64)
                {
                    sum += 90;
                    grouptotalnumbers += 1;
                }
                else
                {
                    sum += 120;
                    grouptotalnumbers += 1;
                }
            }
            Console.WriteLine($"The total cost is: {sum }  kr, and number of people in the party is: { grouptotalnumbers}");
        }
    }
}
