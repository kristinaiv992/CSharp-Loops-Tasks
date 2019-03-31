# CSharp-Loops-Tasks
<p><b>Small Csharp school tasks using loops</b></p>
There are four types of loops in C# (Csharp) : </br> 
<i>While loop, for loop, do while loop and foreach loop! </i>
<hr>
<p>:one: While Loops </p>
<p>:two: For Loops </p>
<p>:three: Do While Loops </p>
<p>:four: Foreach Loops </p>

Bonus:
<p>:five: Switch </p>

<hr>
for loop:</br>
*Count all the even numbers from 1 to 100*</br>
Ex 1:</br>

    for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
 Ex 2:</br>
  
    for (int i=2; i<=100; i = i + 2)
            {
                Console.Write(i + " ");
            }
do while:</br>
Ex 1:</br>
*Count all the even numbers from 1 to 100*</br>

     var i = 2;
            do
            {
                Console.Write(i + " ");
                i=i+2;
            }
            while (i <= 100);
Ex2:</br>
*Enter a message until the user enters the correct input*</br>
            
            do
            {
                Console.WriteLine("Please enter your username?");
            }
            while (Console.ReadLine().ToLower() != "kristina");
 while:</br>
 *Count all the even numbers from 1 to 100*</br>
 Ex 1:
 
    int i = 2;
           while( i<=100){
                if(i%2 == 0)
                {
                    Console.Write(i + " ");
                }
                i++;
            }
Ex2:</br>
*Enter a message until the user enters the correct input*</br>
            
            Console.WriteLine("Please enter your username?");
            while (Console.ReadLine().ToLower() != "kristina")
            {
                Console.WriteLine("Please enter your username?");
            }

