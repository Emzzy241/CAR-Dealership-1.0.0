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

class CarDealership{
    static void Main(){
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

        if(realUserAuto == "T"){
            Console.WriteLine("You Picked Tricycles, here are the ones we have:");
            Console.WriteLine("Free-way Tricycle, Costs: ₦1,400,000");
            Console.WriteLine("Ledger Tricycle, Costs: ₦1,100,000");
            Console.WriteLine("Napep Tricycle, Costs: ₦1,200,000");
        }
        else if (realUserAuto == "B")
        {
            Console.WriteLine("You Picked Tricycles, here are the ones we have:");
            Console.WriteLine("Zana Bike, Costs: ₦300,000");
            Console.WriteLine("Suzuki Bike, Costs: ₦300,000");
            Console.WriteLine("Baja Bike, Costs: ₦400,000");   
        }
        else if (realUserAuto == "C")
        {
            Console.WriteLine("You Picked Cars, here are the ones we have:");
            Console.WriteLine("Honda Crosstour, Costs: ₦7,400,000");
            Console.WriteLine("Lexus-350, Costs: ₦10,100,000");
            Console.WriteLine("Toyota Camry , Costs: ₦3,200,000");
        }
        else if (realUserAuto == "P")
        {
            Console.WriteLine("You Picked Planes, here are the ones we have:");
            Console.WriteLine("Air144, Costs: ₦290,400,000");
            Console.WriteLine("Gulf-stream Jet, Costs: ₦900,100,000");
            Console.WriteLine("G-5 Aerodynamo, Costs: ₦800,200,000");
        }
    }
}