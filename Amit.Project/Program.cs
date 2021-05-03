using Amit.Project.ListOperations;
using Amit.Project.Mathematics;
using System;
using System.Collections.Generic;

namespace Amit.Project
{
    class Program
    {

        int num1 = 0;
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            //Mathematics mathematics = new Mathematics();
            //MathematicsOut mathematicsOut = new MathematicsOut();

            MathematicsInAnotherProj mathematicsInAnotherProj = new MathematicsInAnotherProj();
            Console.WriteLine("Enter the  value of a and b for mathematics operation");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int result = mathematicsInAnotherProj.Sum(a, b);

            Console.WriteLine("Addition result is {0}", result);
            Console.WriteLine("Addition result is {0}", mathematicsInAnotherProj.Sum(a, b));

            Console.WriteLine("Substraction result is {0}", mathematicsInAnotherProj.Substract(a, b));

            Console.WriteLine("Multiplication result is {0}", mathematicsInAnotherProj.Multiply(a, b));

            Console.WriteLine("Division result is {0}", mathematicsInAnotherProj.DivisionRemainder(a, b));

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("*************************************List Operation **********************************");
            ListOp listOp = new ListOp();
             
            List<int> obj = listOp.AddInteger();
            
            foreach(int item in obj)
            {
                Console.WriteLine(item);

                if(item == 78)
                {
                    Console.WriteLine(item);
                }
            }

            var removedData = listOp.RemoveIntegerFromList(obj, 78);

            Console.WriteLine("*************************************After Removal List Items**********************************");
            foreach (int item in removedData)
            {
                Console.WriteLine(item);

                if (item == 78)
                {
                    Console.WriteLine(item);
                }
            }

            var removedAllData = listOp.RemovemAllitemFromList(obj, 78);

            Console.WriteLine("*************************************After Removal All Items**********************************");
            foreach (int item in removedAllData)
            {
                Console.WriteLine(item);

                if (item == 78)
                {
                    Console.WriteLine(item);
                }
            }

            Console.ReadKey();
        }
    }

    //class Mathematics
    //{

    //    public int Sum(int a, int b)
    //    {
    //        return a + b;
    //    }
    //    public int Substract(int a, int b)
    //    {
    //        return a - b;
    //    }
    //    public int Multiply(int a, int b)
    //    {
    //        return a * b;
    //    }
    //    public int DivisionQuotient(int a, int b)
    //    {
    //        return a / b;
    //    }

    //    public int DivisionRemainder(int a, int b)
    //    {
    //        return a % b;
    //    }
    //}
}
