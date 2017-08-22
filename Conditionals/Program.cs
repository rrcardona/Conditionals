using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //    //    Console.WriteLine("Enter your age");
            //    //    int age = int.Parse(Console.ReadLine());

            //    //    if (age >= 17)
            //    //    {
            //    //        Console.WriteLine("You can see this movie");
            //    //    }

            //    //    else
            //    //    {
            //    //        Console.WriteLine("Sorry you are too young you need a parent present");
            //    //   



            //    //Console.WriteLine("Enter your percentage");
            //    //                 int grade = int.Parse(Console.ReadLine());
            //    //          if (grade >=90 && grade <=100)
            //    //     {
            //    //          Console.WriteLine("You got an A!!");
            //    //     }
            //    //          Else if (grade >=80 && grade <=89)
            //    //     {
            //    //          Console.Writeline("You got a B!! Not Bad);
            //    //     }

            //    Console.WriteLine("How many people attended dinner?");
            //    int peopleAttended = int.Parse(Console.ReadLine());
            //    Console.WriteLine("How much was the total bill?");
            //    double totalBill = double.Parse(Console.ReadLine());

            //    double discount = 0.0;
            //    if (totalBill >= 50.0d)
            //    {
            //        discount = 1.10;
            //        totalBill = totalBill / discount;
            //        //totalBill /=discount;

            //    }
            //    else
            //    {
            //        discount = 1.05;
            //        totalBill = totalBill / discount;
            //        //totalbill/=discount;

            //        double perPerson = totalBill / peopleAttended;
            //    }
            //    Console.WriteLine("Thank you for dining with us! Your new total is " + totalBill +
            //        "Each person will pay" + perPerson);
            //}



            //Console.WriteLine("What is your age?");
            //int userAge = int.Parse(Console.ReadLine());
            //if (userAge >= 0 && userAge <= 2)
            //{
            //    Console.WriteLine("Still in Mama's Arms");
            //}
            //else if (userAge == 3 || userAge == 4)
            //{
            //    Console.WriteLine("Preschool Maniac");
            //}
            //else if (userAge == 5 || userAge == 11)
            //{
            //    Console.WriteLine("Elementary School");
            //}
            //else if (userAge == 12 || userAge == 14)
            //{
            //    Console.WriteLine("Middle School");
            //}
            //else if (userAge == 15 || userAge == 18)
            //{
            //    Console.WriteLine("High School");
            //}
            //else if (userAge == 19 || userAge == 22)
            //{
            //    Console.WriteLine("College");
            //}
            //else if (userAge == 23 || userAge == 64)
            //{
            //    Console.WriteLine("Working for the man");
            //}
            //else if (userAge == 65 || userAge == 100)
            //{
            //    Console.WriteLine("Golden Years");
            //}
            //else if (userAge ==101 || userAge == 10000)
            //{
            //    Console.WriteLine("This program is for humans");
            //}



            Console.WriteLine("Please enter a number");
            Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine(number+ "is even");
            }
            else
            {
                Console.WriteLine(number+ "is odd");
            }











        }
    }
}
 

