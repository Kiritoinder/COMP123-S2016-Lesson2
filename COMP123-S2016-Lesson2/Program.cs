using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Inderjeet Singh
 * Date: May 17, 2016
 * Description: Adcanced demo lessons for lesson 2
 * version: 0.0.6 - Compleated readUntilEnd
 */

namespace COMP123_S2016_Lesson2
{

    /**
     * Main Driver class For lesson 2
     * 
     * @class program
     */
   public class Program
    {
        /**
       *  Main method for our drive class
       *  
       * @constructor Main
       * @param{string[]} args
       */
        static void Main(string[] args)
        {
            int x = 50;
            int y = 40;
            int result = 0;
            int numberOfEntries;
            result = addXandY(x, y);
            Console.WriteLine(result);
            Console.WriteLine();

            addYtoX(ref y,ref x);
            Console.WriteLine(x);


                Console.Write("How many entries do you want to make: ");
                int.TryParse(Console.ReadLine(), out numberOfEntries);
                if (numberOfEntries>0)
                {
                    readUntilEnd(numberOfEntries);
                }

        }
        /**
         * Simple method to add two values
         * @method addXandY
         * @param {int} firstNumber
         * @param {int} secondNumber
         */
        public static int addXandY(int firstNumber, int secondNumber)
        {
            int result = 0;
            result = firstNumber + secondNumber;
            return result;
        }
        /**
         * @method addYtoX
         * @param {ref int} x
         * @param {ref int} y
         */
        public static int addYtoX(ref int x, ref int y)
        {
            x += y;
            return x;
        }


        public static int readUntilEnd(int numberOfEntries)
        { 
            //variable declaration
            string[] inputs = new string[numberOfEntries];
            int inputCounter = 0;
            //execution of code
            do
            {
                Console.WriteLine("Enter a value - ('end' to stop)");
                inputs[inputCounter] = "";
                inputs[inputCounter]= Console.ReadLine();
                inputCounter++;
            }
            while ((inputs[inputCounter -1])!="end"&& (inputCounter<numberOfEntries));

            return inputCounter;
        }
    }
}
