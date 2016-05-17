using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Inderjeet Singh
 * Date: May 17, 2016
 * Description: Adcanced demo lessons for lesson 2
 * version: 0.0.2 -Added a refrences to driver class
 *                 from unit test
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

        }
        static int addXandY(int firstNumber, int secondNumber)
        {
            int result = 0;
            result = firstNumber + secondNumber;
            return result;
        }
    }
}
