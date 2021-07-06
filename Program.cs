using System;

namespace CalculatorOPP
{
    public class Program
    {
        public class Calculator
        {
            public Calculator()
            {

            }
            public double Add( double num1,double num2)
            {
                return num1 + num2;
            }
           // public double Add(Double[]  arr, int size)
                public double Add(Double[] arr)
            {
                int size = arr.Length;
                double sum = 0;
                for (int i = 0; i <= size-1 ; i++ )
                {
                    sum = sum + arr[i];
                }
                return sum;
            }
            public double Sub(double num1, double num2)
            {
                return num1 - num2;
            }
            public double Sub(double[] arr2)
            {
                int size = arr2.Length;
                double result = arr2[0];
                for (int i = 1; i <= size - 1; i++)
                {
                    result = result - arr2[i];
                }
                return result;
            }

            public double Mult(double num1, double num2)
            {
                return num1 * num2;
            }
            public double Div(double num1, double num2)
            {
                return num1 / num2;
            }
            public double Procent(double num1, double num2)
            {
                return num1 % num2;
            }
        }

       
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            double num3;
            double num4;
            string op;
            double result;
            ConsoleKeyInfo cki;
            do
            {

                Console.WriteLine("                        enter you first number");
                num3 = double.Parse(Console.ReadLine());
                Console.WriteLine("                        enter you secound number");
                num4 = double.Parse(Console.ReadLine());

                Console.WriteLine("                        enter an operator     ");
                op = Console.ReadLine();

               

                switch (op)
                {
                    case "+":
                        {
                            result = calc.Add(num3, num4);
                            Console.WriteLine(num3 + "  + " + num4 + " = " + result);
                            break;
                        }
                    case "-":
                        {
                            result = calc.Sub(num3, num4);
                            Console.WriteLine(num3 + "  - " + num4 + " = " + result);
                            break;
                        }
                    case "*":
                        {
                            result = calc.Mult(num3, num4);
                            Console.WriteLine(num3 + "  * " + num4 + " = " + result);
                            break;
                        }
                    case "/":
                        {
                            result = calc.Div(num3, num4);
                            Console.WriteLine(num3 + "  / " + num4 + " = " + result);
                            break;
                        }
                    case "%":
                        {
                            result = calc.Procent(num3, num4);
                            Console.WriteLine(num3 + "  % " + num4 + " = " + result);
                            break;
                        }
                    default:
                        {

                            Console.WriteLine("  Invalid operater   ");
                            break;
                        }

                }

                double[] test = new double[] {20.4, 40.6, 30,10 };
                double sum2 = calc.Add(test);
                Console.WriteLine();
                Console.WriteLine(" override Add: 20.4 + 40.6 + 30 +10 = " + sum2);

                double[] test2 = new double[] { 200.5, 40, 30.7, 10 };
                double sub2 = calc.Sub(test2);
                Console.WriteLine();
                Console.WriteLine(" override Sub: 200.5 - 40 - 30.7 - 10 =  " + sub2);



                Console.WriteLine(" \nclick any key to continue or Enter to leave");
                cki = Console.ReadKey();
            } while (cki.Key != ConsoleKey.Enter);

           // Console.ReadLine();
        }
    }
}
