using System;
using System.Collections.Generic;

namespace PatternTeller.Decorator
{
    public class UserRepository
    {
        public IEnumerable<User> GetUsers()
        {
            Console.WriteLine("I will contact SQL Server to fetch data");
            return new List<User>();
        }
    }
}