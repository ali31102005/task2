using System;




namespace ConsoleApp1
{
    class test
    {
        public int a = 1;
        public int b = 2;
    }
    class Class1
    {
        

        public static void Main(string[] args)
        {
            #region p1_comment
            //declare and initialize integer variable
            int x = 10;
            /*declare and initialize integer variable*/
            int y = 20;
            /*Add two integer variable and initialize the third with th result */
            int sum = x + y;
            // print the result
            Console.WriteLine(sum);
            #endregion
            #region Q1
            /* What is the shortcut to comment and uncomment a selected block of code in Visual 
            Studio? comment: ctrl+k+c   uncomment: ctrl+k+u*/
            #endregion
            #region p2_error
            int x2 = 10;
            int y2 = 20;
            Console.WriteLine(x2 + y2);
            #endregion
            #region Q2
            //Explain the difference between a runtime error and a logical error with examples.
            //runtime error like divide by zero
            // logical error is a correct syntax but does not solve the problem
            #endregion
            #region p3
            string FullName = "Ali Ahmed Ali";
            int Age = 19;
            int Salary = 20;
            #endregion
            #region


            test t1 = new test();
            Console.WriteLine(t1.a);
            test t2 = t1;
            t2.a = 5;
            Console.WriteLine(t1.a);
            #endregion
            #region Q3
            //Explain the difference between value types and reference types in terms of memory
            //allocation.
            //value types: stored in stack
            // reference types: stored in heap
            #endregion


            #region p4
            int x3 = 15;
            int y3 = 4;
            //oSum
            Console.WriteLine(x3 + y3);
            //o Difference
            Console.WriteLine(x3 - y3);
            //o Product
            Console.WriteLine(x3 * y3);
            //o Division result
            Console.WriteLine(x3 / y3);
            //o Remainder
            Console.WriteLine(x3 % y3);
            #endregion
            #region p5
            int a = 2, b = 7;
            // 2 < 7
            // output is 2
            Console.WriteLine(a % b);
            #endregion
            #region p6
            int n = int.Parse(Console.ReadLine());
            if(n > 10 && n % 2 == 0)
            {
                Console.WriteLine("number is both greater than 10 and even");
            }
            else
            Console.WriteLine("number is not both greater than 10 and even");
            #endregion
            #region
            double d = double.Parse(Console.ReadLine());
            int c = (int)(d);// explicit
            // int c = d // implicit causes error
            Console.WriteLine(c);
            #endregion
            #region
            //Why is explicit casting required when converting a double to an int?
            //double is larger than int and has fractions so that will lead to data loss
            #endregion
            #region
            string age = Console.ReadLine();
            int age2 = int.Parse(age);
            if (age2 > 0)
            {
                Console.WriteLine("age is valid");
            }
            else
            {
                Console.WriteLine("age is not valid");
            }
            #endregion
            #region
            int i = 5;
            int j = i++; // assign then increment
            Console.WriteLine("j: "+j);
            Console.WriteLine("i: " + i);
            j = ++i; //increment then assign
            Console.WriteLine("j: " + j);
            Console.WriteLine("i: " + i);
            #endregion
            #region
            //Given the code below, what is the value of x after execution? Explain why
            //int x = 5;
            //int y = ++x + x++;
            // x = 7
            // x is incremented twice
            #endregion

        }
    }
}
