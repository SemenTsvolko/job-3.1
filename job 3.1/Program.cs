using System;

namespace job_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                Console.WriteLine("Введите число k");
                

                int k = int.Parse(Console.ReadLine()); // проверка на число 
                
                
                
                {

                    k = 0; // обнуляем
                    Console.Clear(); // стираем неправильное число 
                
                
                }

                Random random = new Random();
                Console.WriteLine("1 случайное число=");
                int e = random.Next(0, 10);
                Console.WriteLine(e);
                Console.WriteLine("2 случайное число=");
                int n = random.Next(0, 10);
                Console.WriteLine(n);
                double f = 0;
                
                double c = 1;
                

                for (int i = -2; i < k; i++)

                {

                    f += (Math.Pow(-1, e)) / (Math.Pow(i - 5, 2));
                    
                }
                for (int j = -3; j < 2*k; j++)
                {
                    c *= ((n * n * n) - 8) / (n + 4);
                    
                }

                Console.WriteLine("W=");
                double W = c * f;
                Console.WriteLine("{0:0.00}", W); // выведет два знака после запятой

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
            Console.ReadKey();
        
    
        }


            
    }
}
