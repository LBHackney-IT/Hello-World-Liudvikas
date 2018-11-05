using System;
using HelloWorld;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args) //this is like a stage in theater
        {
            string shoutToTheWorld = "Hello World!"; //decide on message

            HelperClass.OrderAMessage(shoutToTheWorld); //order your team to get the message printed by any means

            Console.ReadKey(); //We keep staring at our hard work we paid all those peanuts for.
        }
    }
}

