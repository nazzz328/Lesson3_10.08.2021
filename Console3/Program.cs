using System;

namespace Console3
{
    class Program
    {
        static void Main(string[] args)
        {


        // Task 1  //



             System.Console.WriteLine ("Task 1");
             System.Console.WriteLine ();

            System.Console.Write ("Enter the order price: SMN ");
            int price = int.Parse(Console.ReadLine());
            double discount;
            if (price >= 500 & price < 1000)
            {
            discount = price * 1.03;
            System.Console.WriteLine($"The price with discount - {discount} SMN");
            }

            else if (price >=1000)
            {
            discount = price * 1.05;
            System.Console.WriteLine($"The price with discount - {discount} SMN");
            }

            else 
            {
             System.Console.WriteLine($"The price is - {price} SMN");
            }

            System.Console.WriteLine ();
            System.Console.WriteLine ();



        // Task 2 //



            System.Console.WriteLine ("Task 2");
            System.Console.WriteLine ();

            System.Console.Write ("Enter number 1: ");
            int num1 = int.Parse(Console.ReadLine());
            System.Console.Write ("Enter number 2: ");
            int num2 = int.Parse(Console.ReadLine());
            System.Console.Write ("Enter number 3: ");
            int num3 = int.Parse(Console.ReadLine());
            System.Console.Write ("Enter number 4: ");
            int num4 = int.Parse(Console.ReadLine());



            if (num1 < num2 & num1 < num3 & num1 < num4 & num2 < num3 & num2 < num4 & num3 < num4)
            {
            System.Console.WriteLine ("Ascending order of numbers");    
            }

            else if (num1 == num2 & num1 == num3 & num1 == num4 & num2 == num3 & num2 == num4 & num3 == num4)

            {
            int mult = num1 * num2 * num3 * num4;
            System.Console.WriteLine ($"Multiplication of numbers: {mult}");
            }

            else

            {
                if (num1 < num2 & num1 < num3 & num1 < num4)
                {
                System.Console.WriteLine ($"Minimum value is: {num1}");
                }

                else if (num2 < num1 & num2 < num3 & num2 < num4)
                {
                System.Console.WriteLine ($"Minimum value is: {num2}");    
                }

                else if (num3 < num1 & num3 < num2 & num3 < num4)
                {
                System.Console.WriteLine ($"Minimum value is: {num3}");    
                }

                else if (num4 < num1 & num4 < num3 & num4 < num2)
                {
                System.Console.WriteLine ($"Minimum value is: {num4}");    
                }
            }

             System.Console.WriteLine ();
             System.Console.WriteLine ();



        // Task 3 //


             System.Console.WriteLine ("Task 2");
             System.Console.WriteLine ();

            System.Console.Write ("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            System.Console.Write ("Enter b: ");
            int b = int.Parse(Console.ReadLine());
            System.Console.Write ("Enter c: ");
            int c = int.Parse(Console.ReadLine());

            int max;
            int med;
            int min;

            if (a >= b & a >= c & b >= c)

            {
            System.Console.Write ($"a, b, c: {a}, {b}, {c}");
            }

            else if (a >= b & a >= c & c >= b)

            {
            max = a;
            med = c;
            min = b;
            System.Console.Write ($"a, b, c: {max}, {med}, {min}");
            }

             else if (b >= a & b >= c & a >= c)

            {
            max = b;
            med = a;
            min = c;
            System.Console.Write ($"a, b, c: {max}, {med}, {min}");
            }

             else if (b >= a & b >= c & c >= a)

            {
            max = b;
            med = c;
            min = a;
            System.Console.Write ($"a, b, c: {max}, {med}, {min}");
            }

             else if (c >= a & c >= b & a >= b)

            {
            max = c;
            med = a;
            min = b;
            System.Console.Write ($"a, b, c: {max}, {med}, {min}");
            }

             else if (c >= a & c >= b & b >= a)

            {
            max = c;
            med = b;
            min = a;
            System.Console.Write ($"a, b, c: {max}, {med}, {min}");
            }
        }
    }
}
