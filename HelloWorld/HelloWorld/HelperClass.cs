using System;
using System.Collections.Generic;
using System.Text;
using OtherPersonsCode;


namespace HelloWorld
{
    static class HelperClass
    {

        static void printMessage(string atext, bool aisEnoughPeanuts) //Squirrels control the print press.
        {
            if (aisEnoughPeanuts) //Need to pay them enough peanuts to get access to the print press.
            {
                Console.WriteLine(atext);
            }
        }

        static bool getAllPeanuts() //Need someone to get all the peanuts squirrels are asking for.
        {

            CounterClass earnee = new CounterClass(); //We create a peanut searcher.
            return earnee.work(); // He earns peanuts until he get enough. Once that happens we get true as output.

        }

        public static void OrderAMessage(string tempText) //has to be public to be accessed. If not specified, it will be provate by default.
        {
            bool temp1 = getAllPeanuts();
            printMessage(tempText, temp1);
        }
    }
}
