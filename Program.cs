﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLesson
{
    internal class Program
    {
        //פעולה המקבלת שתי נקודות 
        //ומחזירה את המרחק בינהן
        public static double DistanceBetweenPoints(Point p1,Point p2 ) 
        {
            double distance = p1.Distance(p2);
            return distance;

        }
        //לכתוב פעולה המקבלת שלוש נקודות ומחזירה את המרחק המצטבר ביניהם
        public static double DistanceBetween3Points(Point p1,Point p2,Point p3) 
        {
            double distance1 = p1.Distance(p2);
            double distance2 = p2.Distance(p3);
            return distance1 + distance2;
        }
        //יש לכתוב פעולה המקבלת שלוש נקודות ומחזירה אמת אם הם יוצרות משולש שווה שוקיים
        public static bool IsTriangleShave(Point p1,Point p2, Point p3) 
        {
            bool isTriangle = p1.Distance(p2) == p3.Distance(p2) &&
                p2.Distance(p1) == p3.Distance(p1);
            return isTriangle;

        }
        //פעולה המקבלת מערך של נקודות שתי קורדינאטות
        //הפעולה תחזיר אמת אם הנקודה קיימת במערך אחרת יוחזר שקר
        //בסוף הפעולה לא יהיה שינוי במערך 
        public static bool IsInArr(Point[] arrPoint, double x, double y) 
        {
            Point pointToCheck = new Point(x, y);
            for(int i = 0; i < arrPoint.Length; i++) 
            {
                if (arrPoint[i].IsEqual(pointToCheck)) 
                {
                    return true;
                }
            }
            return false;
        }

        //פעולה המקבלת מערך של נקודות ונקודה נוספת 
        //הפעולה תחזיר אמת אם הנקודה קיימת במערך
        //בסוף הפעולה המערך ללא שינוי
        public static bool IsPointInArray(Point[] arr, Point p1)
        {
            for(int i = 0; i < arr.Length; i++) 
            {
                if (arr[i].GetX() == p1.GetX() && arr[i].GetY() == p1.GetY()) 
                {
                    return true;
                }
            }
            return false;
        }
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
            Console.WriteLine("new"+one);
            */

            /*Car c1 = new Car("Volvo", "S80", 2024);
            Console.WriteLine(c1);

            c1.Drive(100);
            c1.SetDirection(1);

            c1.TurnOn();
            c1.SetDirection(1);
            c1.Drive(1000);
            Console.WriteLine(c1);
            c1.TurnOff();

            Car c2 = c1;
            c2.TurnOn();
            c2.SetDirection(1);
            c2.Drive(10);
            Console.WriteLine(c1);

            Car c3 = new Car(c1);
            c3.SetDirection(1);
            c3.Drive(20);

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);*/
            /*
                        Point p1 = new Point(0, 0);
                        Point p2 = new Point(3, 4);
                        Console.WriteLine(p1);




                        double distance = p1.Distance(p2 );
                        Console.WriteLine(distance);

                        Point p3 = p1.MidPoint(p2);
                        Console.WriteLine(p3);

                        Point p4 = p1;
                        Console.WriteLine(p4);

                        double newX = p1.GetX() + 1;
                        double newY = p1.GetY() + 10;
                        p1.SetX(newX);
                        p1.SetY(newY);
                        Console.WriteLine(p1);*/
            int[] arr = new int[10];
            arr[8] = 100;
            Point[] arrPoint = new Point[10];
            arrPoint[0] = new Point(0, 0);
            double num = arrPoint[0].GetX();
            arrPoint[1] = new Point(3, 4);
            double distance = arrPoint[0].Distance(arrPoint[1]);
            Console.WriteLine( distance);

        }
    }
}
