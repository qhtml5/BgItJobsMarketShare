﻿namespace ItJobsMarketShare.CLI
{
    using System;
    using System.Linq;
    using System.Text;

    public static class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            var technologiesList =
                new JobsBgTechnologiesCountProvider().GetCount(new TechnologiesProvider().GetTechnologies());

            Console.WriteLine();
            Console.WriteLine("Technology,Count");
            foreach (var item in technologiesList.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{item.Key},{item.Value}");
            }
        }
    }
}
