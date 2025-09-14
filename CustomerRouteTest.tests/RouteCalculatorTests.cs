using NUnit.Framework.Internal;
using System.Collections.Generic;
using Xunit;
using Xunit.Sdk;

namespace CustomerRouteTest
{
    [TestClass]
    public class RouteCalculatorTests
    {
        [TestMethod]
        public void TestCalculateShortestRoute_StartingAt00()
        {
            // Initialize the test data
            List<Customer> customers = CustomerData.GetTestCustomers();

            // Starting coordinates (0, 0)
            int startX = 0;
            int startY = 0;

            // Calculate the shortest route
            List<Customer> route = RouteCalculator.CalculateShortestRoute(startX, startY, customers);

            // Output the route details
            RouteCalculator.PrintRoute(route);

            // You can add assertions based on expected route or distance here if needed.
            Assert.IsNotNull(route);
            Assert.AreEqual(11, route.Count);  // 10 customers + the starting point
        }

        [TestMethod]
        public void TestCalculateShortestRoute_StartingAt100100()
        {
            // Initialize the test data
            List<Customer> customers = CustomerData.GetTestCustomers();

            // Starting coordinates (100, 100)
            int startX = 100;
            int startY = 100;

            // Calculate the shortest route
            List<Customer> route = RouteCalculator.CalculateShortestRoute(startX, startY, customers);

            // Output the route details
            RouteCalculator.PrintRoute(route);

            // You can add assertions based on expected route or distance here if needed.
            Assert.IsNotNull(route);
            Assert.AreEqual(11, route.Count);  // 10 customers + the starting point
        }

        [TestMethod]
        public void TestCalculateShortestRoute_StartingAt5050()
        {
            // Initialize the test data
            List<Customer> customers = CustomerData.GetTestCustomers();

            // Starting coordinates (50, 50)
            int startX = 50;
            int startY = 50;

            // Calculate the shortest route
            List<Customer> route = RouteCalculator.CalculateShortestRoute(startX, startY, customers);

            // Output the route details
            RouteCalculator.PrintRoute(route);

            // You can add assertions based on expected route or distance here if needed.
            Assert.IsNotNull(route);
            Assert.AreEqual(11, route.Count);  // 10 customers + the starting point
        }
    }
}
