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
for loop:
*Count all the even numbers from 1 to 100*
Ex 1:
  for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
 Ex 2:         
  for (int i=2; i<=100; i = i + 2)
            {
                Console.Write(i + " ");
            }
do while:
Ex 1:
*Count all the even numbers from 1 to 100*
 var i = 2;
            do
            {
                Console.Write(i + " ");
                i=i+2;
            }
            while (i <= 100);
Ex2:
*Enter a message until the user enters the correct input*
 do
            {
                Console.WriteLine("Please enter your username?");
            }
            while (Console.ReadLine().ToLower() != "kristina");
 while:
 *Count all the even numbers from 1 to 100*
 Ex 1:
 int i = 2;
           while( i<=100){
                if(i%2 == 0)
                {
                    Console.Write(i + " ");
                }
                i++;
            }
Ex2:
*Enter a message until the user enters the correct input*
            
            Console.WriteLine("Please enter your username?");
            while (Console.ReadLine().ToLower() != "kristina")
            {
                Console.WriteLine("Please enter your username?");
            }

