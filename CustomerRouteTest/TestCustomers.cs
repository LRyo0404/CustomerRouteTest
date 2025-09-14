using CustomerRouting;
using System.Collections.Generic;


namespace CustomerRouting
{
  
        public static class TestCustomers
        {
            public static List<Customer> GetCustomers() => new List<Customer>
        {
            new Customer("Customer 1", 10, 20),
            new Customer("Customer 2", 90, 24),
            new Customer("Customer 3", 34, 63),
            new Customer("Customer 4", 67, 1),
            new Customer("Customer 5", 24, 84),
            new Customer("Customer 6", 51, 44),
            new Customer("Customer 7", 97, 92),
            new Customer("Customer 8", 77, 13),
            new Customer("Customer 9", 35, 39),
            new Customer("Customer 10", 85, 29)
        };
        }
}

