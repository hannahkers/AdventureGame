using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    //Code created in class 
    public static class Utility
    {
        //have user press a key to move on
        public static void DelayUser()
        {
            Console.WriteLine("Please enter any key to continue...");
            Console.ReadLine();
        }

        //convert item list to array
        public static int ShowUserOptionsAndGetAValidResponse(string title, List<string> items)
        {
            //items.Add("Go back");
            return ShowUserOptionsAndGetAValidResponse(title, items.ToArray());
        }

        //show user a list of options and have them choose a valid response
        public static int ShowUserOptionsAndGetAValidResponse(string title, string[] items)
        {
            Console.WriteLine(title);
            for (int i = 0; i < items.Length; i++)
            {
                int roomNumber = i + 1;
                string details = $"{roomNumber}) {items[i]}";
                Console.WriteLine(details);
            }
            return GetAValidNumberFromTheUser(items.Length);
        }


        public static int GetAValidNumberFromTheUser(int numberOfItems)
        {
            Console.WriteLine($"Please pick a number between 1 and {numberOfItems}");
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (number > 0 && number <= numberOfItems)
                {
                    number--;
                    //Console.WriteLine($"Thank you for choosing a valid number {number}");
                    return number;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("You didn't enter a valid number");
                //Console.WriteLine("0 cannot be divided by 0");
            }
            //Recursive function
            return GetAValidNumberFromTheUser(numberOfItems);
        }
    }
}
