namespace Task2
{

    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            decimal gross = decimal.Parse(Console.ReadLine());
            decimal net = 0;
           

            if (gross > 1000)
            {
                net = (gross) - (gross - 1000) * 0.1m;

                if (gross > 3000)
                {
                    net = net - 2000 * 0.15m;
                }
                else
                {
                    net = net - (gross-1000)*0.15m;
                }
            }

            Console.WriteLine(net);

        }
    }
}
