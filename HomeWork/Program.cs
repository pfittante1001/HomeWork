using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//Problem one checks equaltiy of two numbers
             * 
            Console.Write("Please enter your first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Please enter your second number: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine(" The numbers you entered are the same: " + num1 + " and " + num2);
            }
            else
            {
                Console.WriteLine(" The numbers you entered are not the same: " + num1 + " and " + num2);
            }
            

            // Problem two checks to see if a number is even or odd
            Console.Write("Please enter your number to check if the number is odd or even: ");
            int num1 = int.Parse(Console.ReadLine());

            if ((num1 % 2) == 0)
            {
                Console.WriteLine(" The number your entered " + num1 + " is even");
            }
            else
            {
                Console.WriteLine(" The number your entered " + num1 + " is odd");
            }
            

            //Problem three will tell if a number is a postive or negative number

            Console.Write(" Please enter a positive or negative number: ");
            int num1 = int.Parse(Console.ReadLine());

            if (num1 > 0)
            {
                Console.WriteLine("The number you entered " + num1 + " is a positive number");
            }
            else if (num1 == 0)
            {
                Console.WriteLine("If you lived in France, the number you entered " + num1 + " would be both a positive and negative number");
            }
            else
            {
                Console.WriteLine("The number you entered " + num1 + " is a negative number");

            }
            
            //Problem three checks to see if a charatcter is a vowel or a consonant
            Console.Write("Please enter a character from a - z or A - Z, to see if the letter is a consonant or vowel ");
            char char1 = char.Parse(Console.ReadLine());

            switch (char1)
            {
                case'a':
                    Console.WriteLine(" The character you entered " + char1 + " is a vowel");
                    break;
                case 'A':
                    Console.WriteLine(" The character you entered " + char1 + " is a vowel");
                    break;
                case 'e':
                    Console.WriteLine(" The character you entered " + char1 + " is a vowel");
                    break;
                case 'E':
                    Console.WriteLine(" The character you entered " + char1 + " is a vowel");
                    break;
                case 'i':
                    Console.WriteLine(" The character you entered " + char1 + " is a vowel");
                    break;
                case 'I':
                    Console.WriteLine(" The character you entered " + char1 + " is a vowel");
                    break;
                case 'o':
                    Console.WriteLine(" The character you entered " + char1 + " is a vowel");
                    break;
                case 'O':
                    Console.WriteLine(" The character you entered " + char1 + " is a vowel");
                    break;
                case 'u':
                    Console.WriteLine(" The character you entered " + char1 + " is a vowel");
                    break;
                case 'U':
                    Console.WriteLine(" The character you entered " + char1 + " is a vowel");
                    break;
                default:
                    Console.WriteLine(" The character you entered " + char1 + " is a consonant");
                    break;
            }
            
            //Problem four will find the largest of three numbers
            Console.Write("Please enter the first of three numbers ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Please enter the second of three numbers ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Please enter the last of three numbers ");
            int num3 = int.Parse(Console.ReadLine());
            int largestNum;
            if (num1 > num2 && num1 > num3)
            {
                largestNum = num1;
                Console.WriteLine("The first number you entered " + largestNum + " is the largest");
            }
            else if (num2 > num1 && num2 > num3)
            {
                largestNum = num2;
                Console.WriteLine("The second number you entered " + largestNum + " is the largest");


            }
            else
            {
                largestNum = num3;
                Console.WriteLine("The third number you entered " + largestNum + " is the largest");
            }

           // Problem four calculates the mean of four numbers
            Console.Write("Please enter the first of four numbers ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Please enter the second of four numbers ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Please enter the third of four numbers ");
            int num3 = int.Parse(Console.ReadLine());

            Console.Write("Please enter the last of four numbers ");
            int num4 = int.Parse(Console.ReadLine());

            double ttlNum = num1 + num2 + num3 + num4;
            double mean = ttlNum / 4;

            Console.WriteLine("The average number of the four you entered is " + mean);
           
            //Final Jepordy Problem
            Console.Write("Please enter your FIZZ number: ");
            int fizzNum = int.Parse(Console.ReadLine());

            Console.Write("Please enter your BUZZ number: ");
            int buzzNum = int.Parse(Console.ReadLine());

            Console.Write("Please enter the number you want to test: ");
            int testNum = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (((fizzNum % testNum) == 0) && ((buzzNum % testNum) == 0))
            {
                Console.WriteLine("FIZZBUZZI");

            }else if (((fizzNum % testNum) != 0) && ((buzzNum % testNum) == 0))
            {
                Console.WriteLine("BUZZI");
            }
            else if (((fizzNum % testNum) == 0) && ((buzzNum % testNum) != 0))
            {
                Console.WriteLine("FIZZ");

            }else
            {
                Console.WriteLine(testNum);
            }
            */

        }
    }
}
