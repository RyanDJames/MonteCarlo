using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarlo
{
    public struct Points
    {
        double x;
        double y;

        public Points(double x, double y)
        {
            this.x = x;
            this.y = y;

        }

        public Points(Random number)
        {
            this.x = number.NextDouble();
            this.y = number.NextDouble();
        }

        public double sideThree()
        {
            return Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2));
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            while(loop)
            {
                try
                {
                    Console.WriteLine("Please enter a number greater than 0");

                    string userInput = Console.ReadLine();

                    if (userInput == "done")
                        loop = false;

                    Random number = new Random();

                    Points[] coords = new Points[Convert.ToInt32(userInput)];

                    int count = 0;

                    for (int x = 0; x < Convert.ToInt32(userInput); x++)
                    {
                        coords[x] = new Points(number);

                        if (coords[x].sideThree() <= 1)
                        {
                            count++;
                        }
                    }
                    double z = Convert.ToDouble(count);
                    double y = Convert.ToDouble(userInput);

                    double pie = (z / y) * 4.0;

                    Console.WriteLine($"Approx:{ pie}");
                }


                catch (Exception)
                {
                    Console.WriteLine("something went wrong");







                }
            }
        }
    }
}
