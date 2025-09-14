using System.Collections.Generic;
using System.Diagnostics;
using Xunit;

namespace CustomerRouting.Tests
{
    public class RouteCalculatorTests
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(100, 100)]
        [InlineData(50, 50)]
        public void TestShortestRoute(int startX, int startY)
        {
            var customers = TestCustomers.GetCustomers();
            var (route, totalDistance) = RouteCalculator.CalculateShortestRoute(startX, startY, customers);

            Debug.WriteLine($"Starting Point: ({startX}, {startY})");
            Debug.WriteLine($"Total Distance Travelled: {totalDistance} km");
            Debug.WriteLine("Visit Order:");
            foreach (var customer in route)
            {
                Debug.WriteLine(customer.Name);
            }

            Assert.Equal(10, route.Count);
        }
        //checks that the route calculator handles an empty input
        [Fact]
        public void CalculateShortestRoute_WithNoCustomers_ShouldReturnZeroDistance()
        {
            var emptyList = new List<Customer>();
            var (route, totalDistance) = RouteCalculator.CalculateShortestRoute(0, 0, emptyList);

            Assert.Empty(route);
            Assert.Equal(0, totalDistance);
        }

        //ensures the route calculator works correctly with just one customer
        [Fact]
        public void CalculateShortestRoute_WithOneCustomer_ShouldReturnCorrectDistance()
        {
            var customers = new List<Customer> { new Customer("Solo", 10, 10) };
            var (route, totalDistance) = RouteCalculator.CalculateShortestRoute(0, 0, customers);

            Assert.Single(route);
            Assert.Equal(20, totalDistance); // Manhattan distance: |10-0| + |10-0|
            Assert.Equal("Solo", route[0].Name);
        }

        //checks that customers with the same coordinates are handled correctly
        [Fact]
        public void CalculateShortestRoute_WithDuplicateCoordinates_ShouldVisitAll()
        {
            var customers = new List<Customer>
    {
        new Customer("A", 10, 10),
        new Customer("B", 10, 10),
        new Customer("C", 10, 10)
    };

            var (route, totalDistance) = RouteCalculator.CalculateShortestRoute(0, 0, customers);

            Assert.Equal(3, route.Count);
            Assert.Equal(20, totalDistance); // Only first move costs distance; others are at same spot
        }
    }
}