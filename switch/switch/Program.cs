using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vezbi_od_tutorijal
{
    class Program
    {
        static void Main(string[] args)
        {


            //-----------------------------------------switch CASE---------------------------------------------------//



            //---------------Task 1: -------------------------------//
            //Console.WriteLine("Please enter a number?");
            //int number = int.Parse(Console.ReadLine());

            //switch (number)
            //{
            //    case 10:
            //        Console.WriteLine("You entered number 10");
            //    break;
            //    case 20:
            //        Console.WriteLine("You entered number 20");
            //    break;
            //    case 30:
            //        Console.WriteLine("You entered number 30");
            //    break;
            //    default:
            //        Console.WriteLine("You entered a number that is not 10, 20 or 30");
            //    break;
            //}


            //---------------Task 2: -------------------------------//
            //VERZIJA 2
            //Console.WriteLine("Please enter a number?");
            //int number = int.Parse(Console.ReadLine());

            //switch (number)
            //{
            //    case 10:
            //    case 20:
            //    case 30:
            //        Console.WriteLine("You entered number {0}", number);
            //        break;
            //    default:
            //        Console.WriteLine("You entered a number that is not 10, 20 or 30");
            //        break;
            //}




            //--------------------------------------------------//
            //Switch Case easy Task
            //---------------Task 3: -------------------------------//
            //**A user wants to buy a coffee as much times as he wants Yuhiyuhiyei let's make a small program :))**...//
            ////Run a small Program using Switch Case:
            ///------------------------------------------------------------------


            //Start: //Label is a kind of marker in a peogram where your goto can jump!
            //Console.WriteLine(" Press 1,2 or 3 for coffee size");
            //Console.WriteLine(" (1) small coffee =1 usd || (2) Medium coffee = 2usd || (3) Large coffee = 3usd");
            //int order = int.Parse(Console.ReadLine());
            //int totalCost = 0;

            //switch (order)
            //{
            //    case 1:
            //        Console.WriteLine(" Order: {0} You ordered a small coffee", order);
            //        totalCost += order;
            //        break;
            //    case 2:
            //        Console.WriteLine(" Order: {0} You ordered a medium coffee", order);
            //        totalCost += order;
            //        break;
            //    case 3:
            //        Console.WriteLine(" Order: {0} You ordered a large coffee", order);
            //        totalCost += order;
            //        break;
            //    default:
            //        Console.WriteLine(" Order: {0} You order is invalid", order);
            //        goto Start;
            //}
            //Console.WriteLine($"Your total bill is {totalCost} usd");



            //AnotherQuestion:
            //Console.WriteLine("Do you want to buy another coffee? Press Y/N");
            //string userChoice = Console.ReadLine();
            //switch (userChoice.ToUpper()) //whatever the user enters it will be in uppercase!
            //{
            //    case "Y":
            //        goto Start;
            //    case "N":
            //        Console.WriteLine("Thank you for shopping with us have a nice day!");
            //        break;
            //    default:
            //        Console.WriteLine("Your choice {0} is not apropriate pease try again", userChoice);
            //        goto AnotherQuestion;
            //}  

        }

    }
}
