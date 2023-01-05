using System;
using System.Reflection.Metadata;

class Program
{
     static void Main()

    {
        string UserChoice = string.Empty;
        do
        {
            Console.WriteLine("Enter your number ");
            int YourChoice = int.Parse(Console.ReadLine());
            int Start = 0;
            while (Start <= YourChoice)
            {
                Console.WriteLine(Start);
                Start = Start + 2;
            }
            
            do
            {
                Console.WriteLine("Do You want to contunue - Yes or No");
                UserChoice = Console.ReadLine().ToUpper();
                if (UserChoice != "YES" && UserChoice != "NO")
                {
                    Console.WriteLine("Your choice is incorrect.Select Yes or No");
                }
            }
            while (UserChoice != "YES" && UserChoice != "NO");

        } while(UserChoice== "YES");
        
    }
}