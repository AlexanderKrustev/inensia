using System;

namespace Task2
{
    public class Program
    {

        static void Main(string[] args)
        {
            decimal gross = decimal.Parse(Console.ReadLine());
            decimal net = gross;

            var taxes = new[]
                    {
                        new { Lower = 0m, Upper = 1000m, Rate = 0.0m },
                        new { Lower = 1000m, Upper = decimal.MaxValue, Rate = 0.1m },
                        new { Lower = 1000m, Upper = 3000m, Rate = 0.15m },
                       
                    }; //In order to add new taxes please add a new row to the taxes array and provide lower and upper limits with rate as well 
            foreach(var tax in taxes)
            {
                var taxableAmount = Math.Min(tax.Upper - tax.Lower, gross - tax.Lower);
                if (taxableAmount <= 0)
                {
                    break;
                }
                net -= taxableAmount * tax.Rate;
                
            }   
        Console.WriteLine(net);

        }

    }
}
