using CustomerRouting;
using System;

namespace CustomerRoutingApp
{
    class Program
    {
        static void RunRouteTest(int startX, int startY)
        {
            var customers = TestCustomers.GetCustomers();
            var (route, totalDistance) = RouteCalculator.CalculateShortestRoute(startX, startY, customers);

            Console.WriteLine($"Starting Point: ({startX}, {startY})");
            Console.WriteLine($"Total Distance Travelled: {totalDistance} km");
            Console.WriteLine("Visit Order:");
            foreach (var customer in route)
            {
                Console.WriteLine($"- {customer.Name} at ({customer.X}, {customer.Y})");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            RunRouteTest(0, 0);
            RunRouteTest(100, 100);
            RunRouteTest(50, 50);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}