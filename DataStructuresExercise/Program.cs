using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresExercise
{
    class Program
    {
        

        static void Main( string[] args )
        {
            //initializing a stack
            Stack<string> inputNumbers = new Stack<string>();

            Console.WriteLine("Welcome to our digital memory of numbers");
            Console.WriteLine("How many numbers do you want me to remember?");
            string amountNum = Console.ReadLine();
            //making the wanted number into an integer
            int amountNumInt = Convert.ToInt32(amountNum);

            Console.WriteLine("Please insert {0} amount of numbers. One at a time" , amountNum);

            //for loop to add every number in the stack
            for ( int i = 0 ; i < amountNumInt ; i++ )
            {
                //does not check for whether there are numbers in the lines, or just 'enter'
                inputNumbers.Push(Console.ReadLine());
            }

            Console.WriteLine("This is your numbers:");

            foreach ( var elem in inputNumbers )
            {
                Console.WriteLine(elem);
            }
            Console.ReadLine();

            
        }
        
    }
}
