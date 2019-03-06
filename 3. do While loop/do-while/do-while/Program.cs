using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------Task 1: (DO WHILE) -------------------------------//

            //do. . . while структурата во C е “превртена” верзија на структурата за повторување while.
            //наредбите од циклусот ќе бидат извршени сигурно еднаш, пред да се провери условот. Ако
            //условот е неточен, наредбите од циклусот do. . . while нема да бидат повторно извршени. 


            //Program that from n numbers (entered by the keyboard) will determine the number of numbers that
            //are divisible by 3, while dividing by 3 have a residue of 1 and 2 respectively:

            int i = 1, counterforzeros = 0, counterforones = 0, counterfortwos = 0;
            Console.WriteLine("Please enter how many numbers we will check??");
            int numbers = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Please enter a number to be checked..??");
                int no = int.Parse(Console.ReadLine());
                if (no % 3 == 0)
                {
                    counterforzeros++;
                }
                else if (no % 3 == 1)
                {
                    counterforones++;
                }
                else
                {
                    counterfortwos++;
                }
                i++;
            }

            while (i <= numbers);

            Console.WriteLine($"From your {numbers} numbers {counterforzeros} are devidible with three");
            Console.WriteLine($"From your {numbers} numbers {counterforones} have a residue of 1 while dividing with 3");
            Console.WriteLine($"From your {numbers} numbers {counterforones} have a residue of 2 while dividing with 3");
            
            //---------------Task 2: (DO WHILE) the same task from folder switch solved with do while -------------------------------//
            
                     int totalCost = 0;
            string decision = string.Empty;
          
            do {

                int order =-1;

                do
                {
                    Console.WriteLine(" Press 1,2 or 3 for coffee size");
                    Console.WriteLine(" (1) small coffee =1 usd || (2) Medium coffee = 2usd || (3) Large coffee = 3usd");
                    order = int.Parse(Console.ReadLine());
                    //string userChoice = Console.ReadLine().ToUpper();

                    switch (order)
                    {
                        case 1:
                            Console.WriteLine(" Order: {0} You ordered a small coffee", order);
                            totalCost += 1;
                            break;
                        case 2:
                            Console.WriteLine(" Order: {0} You ordered a medium coffee", order);
                            totalCost += 2;
                            break;
                        case 3:
                            Console.WriteLine(" Order: {0} You ordered a large coffee", order);
                            totalCost += 3;
                            break;
                        default:
                            Console.WriteLine(" Order: {0} You order is invalid", order);
                            break;
                    }
                }
                while (order != 1 && order != 2 && order != 3);


                do
                {
                    Console.WriteLine("Do you want to buy another coffee? Press YES/NO");
                    decision = Console.ReadLine().ToUpper();

                    if (decision != "YES" && decision != "NO")
                    {
                        Console.WriteLine("Your choice {0} is not apropriate pease try again", decision);
                    }

                }
                    while (decision != "YES" && decision != "NO") ;
            }
            while (decision.ToUpper() != "NO");
            

                Console.WriteLine("Thank you for shopping with us have a nice day!");
                Console.WriteLine($"Your total bill is {totalCost} usd");
            
            
            
            
            //---------------Task 3: (DO WHILE) -------------------------------//
                 // Program that counts all the even numbers to an entered number:
            string choice = string.Empty;
            do
            {
                Console.WriteLine("Please enter a number");
                int input = int.Parse(Console.ReadLine());

                int start = 0;

                while (start < input)
                {
                    Console.Write(start + " ");
                    start += 2;
                }
                do
                {
                    Console.WriteLine("Do you want to continue - Yes or No");
                    choice = Console.ReadLine().ToUpper();
                    if (choice != "YES" && choice != "NO")
                    {
                        Console.WriteLine("You did not entered yes or no please repeat Yes or No");
                    }
                }
                while (choice != "YES" && choice != "NO");
            }
            while (choice == "YES");
            
        }
    }
}
