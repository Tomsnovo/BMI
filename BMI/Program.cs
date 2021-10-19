using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            double height;
            double heightm;
            double weight;
            double BMI;
            while (true)
            {
                Console.Clear();

                Console.WriteLine(" BMI calculator");
                Console.Write(" Enter weight:");
                weight = double.Parse(Console.ReadLine());
                Console.Write(" Enter height:");
                height = double.Parse(Console.ReadLine());
                heightm = height / (100);

                if (height <= 0 || weight <= 0)
                {
                    Console.WriteLine(" nejses antihmota!");
                    break;
                }


                BMI = weight / (heightm * heightm);
                BMI = Math.Round(BMI, 1);
              
                Console.WriteLine();
                Console.WriteLine($" Your BMI is {BMI}. ");
                Console.WriteLine();
                
                if (BMI < (18.5))
                {
                    Console.WriteLine(" You have underweight!");

                }
                else if (BMI > (18.5) && BMI < (24.9))
                {
                    Console.WriteLine(" You are in normal!");
                }
                else if (BMI > (25) && BMI < (29.9))
                {
                    Console.WriteLine(" You have overweight!");
                }
                else if (BMI > (30) && BMI < (34.9))
                {
                    Console.WriteLine(" You have 1st degree obesity!");
                }
                else if (BMI > (35) && BMI < (39.9))
                {
                    Console.WriteLine(" You have 2nd degree obesity!");
                }
                else if (BMI > (40))
                {
                    Console.WriteLine(" You have 3rd degree obesity!");
                }
                

                Console.ReadLine();
            }



        }   
    }
}
