using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int num = 100;
            Book oneMoreBook = new Book("Harry Poter", "J.K Roling", 1951, "Little, Brown and Company", 10.00);
            Book myBook = new Book("The Catcher in the Rye", "J.D. Salinger", 1951, "Little, Brown and Company", 10.00);
            string name = myBook.GetTitle();*//*
            Console.WriteLine(myBook.GetCost());
            double newCost = myBook.GetCost() * 1.2;
            myBook.SetCost(newCost);
            Console.WriteLine(myBook.GetCost());
            if(oneMoreBook.GetCost()>myBook.GetCost())
            {
                Console.WriteLine("The book " + oneMoreBook.GetTitle() + " is more expensive than " + myBook.GetTitle());
            }
            else
            {
                Console.WriteLine("The book " + myBook.GetTitle() + " is more expensive than " + oneMoreBook.GetTitle());
            }  */
            /*Console.WriteLine(myBook);*/
            /*Employee emp1 = new Employee("Ethan", 50000, true);
            Employee emp2 = new Employee("Sara", 120000, false);
            Employee emp3 = new Employee("Dr.Strange", 30000, true);
            Console.WriteLine(emp1);
            Console.WriteLine(emp2);
            Console.WriteLine(emp3);
            Console.WriteLine(emp1.IsHighSalary());
            emp1.SetSalary(10000);
            Console.WriteLine(emp1.IsHighSalary());
            emp1.SetName("Ethan Luckfish");
            Console.WriteLine(emp1.GetName());
            if (emp1.GetSalary()> emp2.GetSalary())
            {
                Console.WriteLine(emp1.GetName());
            }
            else
            {
                Console.WriteLine(emp2.GetName());  
            }
            int sum = emp1.GetSalary() + emp2.GetSalary() + emp3.GetSalary();
            Console.WriteLine($"sum is {sum}");
            Random rnd = new Random();
            int value = rnd.Next(1,14);
            Card one = new Card(value,'H') ;

            Console.WriteLine("old"+one);
            Card two = new Card(one);


            two.SetSuit('D');
            Console.WriteLine("new"+one);/*

            





        }
    }
}
