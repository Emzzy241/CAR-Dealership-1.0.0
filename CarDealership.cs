// THIS APPLICATION HAS THE FOLLOWING AIMS..... Although you can come up with your own aims too


/*
    Try adding additional static methods to give the Car class interesting(and possibly quirky) functionalities
    1. Adding a functionality to lower cost of the cars by a percentage amount for a sales event
    2. Calculating how well each Car would perform or do in the Dakar Rally(a racing event). YOU CAN CALCULATE THIS HOWEVER YOU WANT
    Though you may want to add more fields to your Car
    3. Calculating each Car's resale value by Year..... Same as above, you can calculate this however you want
*/

using System;
using System.Collections.Generic;

class CarDealership
{
    static void Main()
    {
        // after our Main entry point, le us now write our full-fledged Application
        Console.WriteLine("Welcome to the Ema's Car Dealership, What would you like to purchase TOday");


        // the Discount section
        Console.WriteLine("Please note that our Company is giving out Discounts to all Customers");
        Console.WriteLine("Get 0.2% on Cars you Purchase Today, Get 0.7% for any Planes you Purchase Today");
        Console.WriteLine("On other Automotives, Get 1.0% on Bikes you Purchase TOoday, Get 0.99%on Tricycles you Purchase TOday");

        Console.WriteLine("Enter T for Tricycles, B for Bikes, C fo Cars, P for Planes");

        string userAutomotive = Console.ReadLine();
        // working on capitalizations i.e Upper or Lower cases
        string realUserAuto = userAutomotive.ToUpper();

        if (realUserAuto == "T")
        {
            Console.WriteLine("You Picked Tricycles, here are the ones we have:");
            Console.WriteLine("Free-way Tricycle, Costs: $1,400");
            Console.WriteLine("Ledger Tricycle, Costs: $1,100");
            Console.WriteLine("Napep Tricycle, Costs: $1,200");

            Console.WriteLine("To know about other Features of the Automotive, Enter D to know how Tricycle would perform in the Dakar Rally for Tricycles");
            Console.WriteLine("Enter i to know how much you can sell your Tricycle in several years to come");

            // other Application functionalities
            string userSecondInput = Console.ReadLine();

            if (userSecondInput == "i")
            {

                Console.WriteLine("Enter the Year you want to know how much you'll sell your Tricycle");

                string yearUserEntered = Console.ReadLine();

                int yearInInteger = int.Parse(yearUserEntered);

                Console.WriteLine("In the Year " + yearInInteger + " This is how much you will sell the: ");

                int triCalcYear = yearInInteger / 2000 * 100;
                Console.WriteLine("Free-way Tricycle, Cost: $ " + triCalcYear);
                Console.WriteLine("Ledger Tricycle, Cost: $ " + triCalcYear);
                Console.WriteLine("Napep Tricycle, Cost: $ " + triCalcYear);

            }

            else if (userSecondInput == "D")
            {
                Console.WriteLine("In the Dakar Rally, The Free-way Tricycle will go from 0-60km in 54s");
                Console.WriteLine("In the Dakar Rally, The Ledger Tricycle will go from 0-60km in 1minute 20seconds");
                Console.WriteLine("In the Dakar Rally, The Napep Tricycle will go from 0-60km in 2minutes");

            }


        }
        else if (realUserAuto == "B")
        {
            Console.WriteLine("You Picked Tricycles, here are the ones we have:");
            Console.WriteLine("Zana Bike, Costs: $300");
            Console.WriteLine("Suzuki Bike, Costs: $300");
            Console.WriteLine("Bajaj Bike, Costs: $400");

            Console.WriteLine("To know about other Features of the Automotive, Enter D to know how Automotive would perform in the Dakar Rally for Bikes");
            Console.WriteLine("Enter i to know how much you can sell your Automotive in several years to come");

            // other Application functionalities
            string userSecondInput = Console.ReadLine();

            if (userSecondInput == "i")
            {
                Console.WriteLine("Enter the Year you want to know how much you'll sell your Tricycle");

                string yearUserEntered = Console.ReadLine();

                int yearInInteger = int.Parse(yearUserEntered);

                Console.WriteLine("In the Year " + yearInInteger + " This is how much you will sell the: ");

                int triCalcYear = yearInInteger / 2000 * 100;
                Console.WriteLine("Free-way Tricycle, Cost: $ " + triCalcYear);
                Console.WriteLine("Ledger Tricycle, Cost: $ " + triCalcYear);
                Console.WriteLine("Napep Tricycle, Cost: $ " + triCalcYear);


            }

            else if (userSecondInput == "D")
            {
                Console.WriteLine("In the Dakar Rally, The Zana Bike will go from 0-60km in 3minutes 30seconds");
                Console.WriteLine("In the Dakar Rally, The Suzuki Bike will go from 0-60km in 3minutes 15seconds");
                Console.WriteLine("In the Dakar Rally, The Bajaj Bike will go from 0-60km in 3minutes");

            }


        }
        else if (realUserAuto == "C")
        {
            Console.WriteLine("You Picked Cars, here are the ones we have:");
            Console.WriteLine("Honda Crosstour, Costs: ₦7,400");
            Console.WriteLine("Lexus-350, Costs: $10,100");
            Console.WriteLine("Toyota Camry, Costs: $3,200");

            Console.WriteLine("To know about other Features of the Automotive, Enter D to know how Automotive would perform in the Dakar Rally FOr Cars");
            Console.WriteLine("Enter i to know how much you can sell your Automotive in several years to come");

            // other Application functionalities
            string userSecondInput = Console.ReadLine();

            if (userSecondInput == "i")
            {
                Console.WriteLine("Enter the Year you want to know how much you'll sell your Tricycle");

                string yearUserEntered = Console.ReadLine();

                int yearInInteger = int.Parse(yearUserEntered);

                Console.WriteLine("In the Year " + yearInInteger + " This is how much you will sell the: ");

                int carCalcYear = yearInInteger / 2000 * 100;
                Console.WriteLine("Honda Crosstour, Cost: $ " + carCalcYear);
                Console.WriteLine("Lexus-350, Cost: $ " + carCalcYear);
                Console.WriteLine("Toyota Camry, Cost: $ " + carCalcYear);

            }

            else if (userSecondInput == "D")
            {
                Console.WriteLine("In the Dakar Rally, The Honda Crosstour will go from 0-60km in 7s");
                Console.WriteLine("In the Dakar Rally, The Lexus-350 will go from 0-60km in 9s");
                Console.WriteLine("In the Dakar Rally, The Toyota Camry will go from 0-60km in 8s");

            }


        }
        else if (realUserAuto == "P")
        {
            Console.WriteLine("You Picked Planes, here are the ones we have:");
            Console.WriteLine("Air144, Costs: $290,400");
            Console.WriteLine("Gulf-stream Jet, Costs: $900,100");
            Console.WriteLine("G-5 Aerodynamo, Costs: $800,200");

            Console.WriteLine("To know about other Features of the Automotive, Enter D to know how Automotive would perform in the Dakar Rally For Planes");
            Console.WriteLine("Enter i to know how much you can sell your Automotive in several years to come");

            // other Application functionalities
            string userSecondInput = Console.ReadLine();

            if (userSecondInput == "i")
            {
                Console.WriteLine("Enter the Year you want to know how much you'll sell your Tricycle");

                string yearUserEntered = Console.ReadLine();

                int yearInInteger = int.Parse(yearUserEntered);

                    Console.WriteLine("In the Year " + yearInInteger + " This is how much you will sell the: ");

                    int planeCalcYear = yearInInteger / 2000 * 100;
                    Console.WriteLine("Air144, Costs, Cost: $ " + planeCalcYear);
                    Console.WriteLine("Gulf-stream Jet, Cost: $ " + planeCalcYear);
                    Console.WriteLine("G-5 Aerodynamo, Cost: $ " + planeCalcYear);

            }



            else if (userSecondInput == "D")
            {
                Console.WriteLine("In the Dakar Rally, The Air144 will go from 0-60km in 4s");
                Console.WriteLine("In the Dakar Rally, The Gulf-stream Jet will go from 0-60km in 4s");
                Console.WriteLine("In the Dakar Rally, The G-5 Aerodynamo will go from 0-60km in 4s");

            }


        }
    }
}