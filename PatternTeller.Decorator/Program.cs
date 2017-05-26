using System;
using System.Linq;

namespace PatternTeller.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Pattern Teller");
            Console.WriteLine("Have you ever heard about Decorator?");
            var repo = new UserRepository();
            var users = repo.GetUsers();

            Console.WriteLine($"Hey I got {users.Count()} users");
            Console.Read();
        }
    }
}