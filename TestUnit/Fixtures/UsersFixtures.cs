using DockerProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUnit.Fixtures
{
    public static class UsersFixtures
    {
        public static List<User> GetTestUsers() =>
            new()
            {
                new User()
                {
                    Name = "Test User 1",
                    Email = "t@gmail.com",
                    Address = new Address()
                    {
                        Street = "123 Nairobi",
                        City =  "Nairobi",
                        ZipCode = "00100"
                    }
                },
                new User()
                {
                    Name = "Test User 2",
                    Email = "t2@gmail.com",
                    Address = new Address()
                    {
                        Street = "101 Nairobi",
                        City = "Nairobi",
                        ZipCode = "00400"
                    }
                },
                new User()
                {
                    Name = "Test User 3",
                    Email = "t3@gmail.com",
                    Address = new Address()
                    {
                        Street = "101 Nairobi",
                        City = "Nairobi",
                        ZipCode = "00400"
                    }
                },
        };
    }
}
