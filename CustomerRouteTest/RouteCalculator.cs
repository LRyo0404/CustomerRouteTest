using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomerRouting
{
    public static class RouteCalculator
    {
        public static (List<Customer> route, int totalDistance) CalculateShortestRoute(int startX, int startY, List<Customer> customers)
        {
            var remaining = new List<Customer>(customers);
            var route = new List<Customer>();
            int totalDistance = 0;
            int currentX = startX;
            int currentY = startY;

            while (remaining.Any())
            {
                var next = remaining
                    .OrderBy(c => Math.Abs(c.X - currentX) + Math.Abs(c.Y - currentY))
                    .First();

                totalDistance += Math.Abs(next.X - currentX) + Math.Abs(next.Y - currentY);
                route.Add(next);
                currentX = next.X;
                currentY = next.Y;
                remaining.Remove(next);
            }

            return (route, totalDistance);
        }
    }
}