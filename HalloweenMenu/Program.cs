using System;

namespace HolidayRestaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Holiday Restaurant*****");

            while (true)
            {


                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Breakfast Menu");
                Console.WriteLine("2. Lunch Menu");
                Console.WriteLine("3. Dinner Menu");
                Console.WriteLine("4. Drink Menu");
                Console.WriteLine("5. Checkout");

                var option = Console.ReadLine();
                switch (option)
                {
                    case "0":
                        Console.WriteLine("Thank you, have a great day!");
                        return;
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    default:
                        Console.WriteLine("Invalid choice. PLease try again.");
                        break;


                }
            }



        }
    }
}
