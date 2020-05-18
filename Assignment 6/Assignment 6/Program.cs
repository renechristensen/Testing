using System;

namespace Assignment_6
{
    class Program{

        static void Main(string[] args){
            String input;
            int result = 0;
            bool printResult = false; 
            bool isRunning = true;
            int firstNumber;
            int secondNumber; 
            while (isRunning){
                Console.WriteLine("welcome to the PROGRAM. There are many exciting options available, including: \n1) \"exit\" shuts the PROGRAM down.");
                Console.WriteLine("2) \"1\" opens the adder functionality \n3) \"2\" opens the subtraktion funktionality \n4) \"3\" opens the multiplikation funktionality"); 
                Console.WriteLine("5) \"4\" opens the division funktionality\nfurther functionality may be available in the future :D");

                
                input = Console.ReadLine();
                if (input == "exit")
                {
                    Console.WriteLine("exiting now");
                    isRunning = false;
                }
                else if (input == "1")
                {
                    printResult = true;
                    Console.WriteLine("\nWelcome to the adder which returns the sum of two numbers :) \nWhat is your first number?");
                    firstNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nWhat is your second number :)");
                    secondNumber = Convert.ToInt32(Console.ReadLine());
                    result = adder(firstNumber, secondNumber);
                }
                else if (input == "2")
                {
                    printResult = true;
                    Console.WriteLine("\nWelcome to the subtraktor which returns the difference between two numbers :) \nWhat is your first number?");
                    firstNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nWhat is your second number :)");
                    secondNumber = Convert.ToInt32(Console.ReadLine());
                    result = subtrakter(firstNumber, secondNumber);
                }
                else if (input == "3") {
                    printResult = true;
                    Console.WriteLine("\nWelcome to the multiplikator which returns the product two numbers :) \nWhat is your first number?");
                    firstNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nWhat is your second number :)");
                     secondNumber = Convert.ToInt32(Console.ReadLine());
                    result = multiplikator(firstNumber, secondNumber);
                }
                else if (input == "4") {
                    printResult = true;
                    Console.WriteLine("\nWelcome to the divider  which divides two numbers :) \nWhat is your first number?");
                    firstNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nWhat is your second number :)");
                    secondNumber = Convert.ToInt32(Console.ReadLine());
                    result = divider(firstNumber, secondNumber);
                }
                else
                {

                    Console.WriteLine(input + " is an unknown command \n Try another function \n\n");
                }

                if (printResult) {
                    Console.WriteLine("\nThe result of the calculation is " + result + "\n\n");
                    printResult = false;
                }
            }

            // local method that asks the user for two integers and returns the sum. This function is not safe for 
            // use as it crashes when fed anything other than integers. Error handling required, but outside scope for this assignment
            int adder(int FirstNumber, int SecondNumber)
            {
                return firstNumber + secondNumber;
            }

            // same as adder, except it returns the difference
            int subtrakter(int firstNumber, int secondNumber)
            {
                return firstNumber - secondNumber;
            }
            //returns the product of two factors
            int multiplikator(int firstNumber, int secondNumber)
            {
                return firstNumber * secondNumber; 
            }
            // returns the result of dividing two numbers
            int divider(int firstNumber, int secondNumber)
            {
                return firstNumber / secondNumber;
            }

        }

    }
}
