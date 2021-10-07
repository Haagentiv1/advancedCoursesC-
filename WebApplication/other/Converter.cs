using System;

namespace WebApplication.other
{
    public static class Converter
    {
        public static void Execute()
        {
            double dollar = 5;
            Console.WriteLine(dollar + "$ = " + dollar.ConvertToEur() + "€");
        }

        public static double ConvertToEur(this double usd)
        {
            if (usd > 0)
            {
                return usd * 0.85;
            }

            return usd;

            {
            }
        }
    }
}