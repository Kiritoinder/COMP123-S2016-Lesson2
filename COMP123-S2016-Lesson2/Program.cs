using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Inderjeet Singh
 * Date: May 17, 2016
 * Description: Adcanced demo lessons for lesson 2
 * version: 0.0.5 - Added readUntilEnd - Not Completed 
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

            result = addXandY(x, y);
            Console.WriteLine(result);
            Console.WriteLine();

            addYtoX(ref y,ref x);
            Console.WriteLine(x);

            Console.WriteLine(readUntilEnd());
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
        public static string[] readUntilEnd()
        {
            string[] inputs = new string[100];

            int inputCounter = 0;
            do
            {
                Console.WriteLine("Enter a value - ('end' to stop)");
                inputs[inputCounter]= Console.ReadLine();
                if(inputs[inputCounter]=="end")
                {
                    inputCounter = -1;
                }else
                {
                    inputCounter++;
                }

            } while (inputCounter !=-1);

            return inputs;
        }
    }
}
