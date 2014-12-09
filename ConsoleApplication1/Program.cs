using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Thread.Sleep(2000);
            //we make a list of random fruits
            string[] fruits = new string[7] {"appel","peer","banan","appel","kers","tomaat","appel"} ;
            
            //and we want to filter out all the apples
            foreach(string appel in getAppels(fruits))
            {
                //when an apple is found by getApples, write that down!
                Console.WriteLine(appel);
            }
            Console.ReadKey(); //just so the application doesn't end

        }


        /// <summary>
        /// function to return only apples from a string-array. This is obviously heavy computation, so each iteration takes 2 seconds.
        /// </summary>
        /// <param name="fruits">a list of strings, preferably consisting of fruits</param>
        /// <returns>apples. only apples.</returns>
        public static IEnumerable<string> getAppels(string[] fruits){
            foreach (var fruit in fruits)
            {
                if (fruit == "appel")
                {
                    //when we found an apple, immediately return tci
                    yield return fruit;

                    //to simulate a heavy computation
                    Thread.Sleep(2000);
                }
            }
            //stop searching
            yield break;
        }
    }
}
