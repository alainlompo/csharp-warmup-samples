﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoFunctional.linq.datasources;
using GoFunctional.linq.extension.methods;
using GoFunctional.linq.filtering;
using GoFunctional.linq.grouping;
using GoFunctional.linq.ordering;
using GoFunctional.linq.querie.multisource;
using GoFunctional.linq.zippping;
using GoFunctional.linq.taking.and.skipping;
using GoFunctional.linq.aggregations;

namespace GoFunctional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple demo of Func<T, TResult>....");
            TemperatureConverter tConv = new TemperatureConverter();
            tConv.DoConversionDemo();
            Console.WriteLine();
            Console.WriteLine("Method extension demo....");
            Console.Write("Input a string.....:");
            String src = Console.ReadLine();
            bool isPalyndrome = src.IsPalyndrome();
            if (isPalyndrome)
            {
                Console.WriteLine(src + " is a palyndrome...");
            }
            else
            {
                Console.WriteLine(src + " is not a palyndrome....");
            }

            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine(" Illustrate customized data source for linq....");
            TextDataSource dataSource = new TextDataSource();
            dataSource.fromMemory("Un break de batterie \n Coule sur la FM \n Et se mele a mon sang pour faire de moi...");
            var result = from f in dataSource
                         where f.getReservoir().Count == 3
                         select f.getReservoir()[1];
            Console.WriteLine(result);
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("OfType demo .......");
            OfTypeDemo.DoOfTypeDemo();
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("Now an order by descending demo....");
            OrderByDemo.DoOrderByDemo();
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("Now a group by demo ....");
            GroupByDemo.DoGroupByDemo();
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("A multi source query demo ....");
            MultiSourceLinqQueries.DoMultiSourceQueryDemo();
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("... using selectMany... ");
            MultiSourceLinqQueries.DoSelectManyDemo();
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("Now a linq zipping demo....");
            LinqZippingDemo.DoZippingDemo();
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("Take and skip demo...");
            TakingAndSkippingDemo.DoSkipAndTakeDemo(3, 10);
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("Aggregation demo on sum...");
            AggregationDemo.DoAggregationDemo();
            Console.ReadKey();
        }
    }
}
