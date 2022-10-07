using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace my_first_calculator
{
    internal class Program
    {
        static void Main(string[] args)
         {
                bool backTop = true;


             while (backTop)
            {
                Console.WriteLine("what of calulation you want to use? (+, -, *, or /");
                string UsInput = Console.ReadLine();

                Console.WriteLine("first number");
                string Us1Input = Console.ReadLine();


                Console.WriteLine("secound number");
                string Us2Input = Console.ReadLine();

               

                Console.WriteLine("Do you want continue? Y/Nnn");
                string Us3Input = Console.ReadLine();

                string sign = UsInput;
                string x = Us1Input;
                string y = Us2Input;
                string ans2 = Us3Input;
                int answer;
                

            


                string sum = x + y;


                int number1 = Int32.Parse(x);
                int number2 = Int32.Parse(y);
                string signe = (sign);

                sum = x + sign + y;




                if (UsInput == "x")
                {
                    answer = number1 * number1;
                    Console.WriteLine(number1 + " x " + number2 + " = " + answer);
                    Console.ReadLine();

                }
                else if (UsInput == "-")
                {
                    answer = number1 - number2;
                    Console.WriteLine(number1 + " + " + number2 + " = " + answer);
                    //Console.ReadLine();
                }
                else if (UsInput == "+")
                {
                    answer = number1 + number2;
                    Console.WriteLine("total is:  " + answer);
                    Console.WriteLine("do you want continiue continue? y/n? ");
                    Console.ReadLine();
                    Console.WriteLine(ans2);
                }
                    if (Us3Input == "Y")
                    {
                            Console.Write("   you pressed YES we will contiunes \n\n\n ");
                    backTop = true;
                    }
                    else if (Us3Input == "N")
                    {
                            Console.Write("  u pressed no. bye!  ");
                        break;
                    }




                else if (UsInput == "/")
                {
                    answer = number1 / number2;
                    Console.WriteLine("total is : " + answer);
                }
                //*
                // else if (UsInput == " ")
                //  {
                //      Console.WriteLine();
                //     Console.WriteLine("Error number fail, do you want ot start over?");
                //  }
                //


                else

                {
                    Console.WriteLine("you pressed No");
                    System.Environment.Exit(1);
                }


              


            }

        }
    }
}
