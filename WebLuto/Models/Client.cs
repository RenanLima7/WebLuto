﻿namespace WebLuto.Models
{
    public class Client : User
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string CPF { get; set; }

        public Address Address { get; set; }

        public string? Phone { get; set; }

        public DateTime? BirthDate { get; set; }

        public string? Avatar { get; set; }
    }
}