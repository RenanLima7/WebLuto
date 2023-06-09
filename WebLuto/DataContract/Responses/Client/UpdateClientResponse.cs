﻿namespace WebLuto.DataContract.Responses
{
    public class UpdateClientResponse
    {
        public long Id { get; set; }

        public string Email { get; set; }
        
        public bool IsConfirmed { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string CPF { get; set; }

        public UpdateAddressResponse Address { get; set; }

        public string? Phone { get; set; }

        public DateTime? BirthDate { get; set; }

        public string? Avatar { get; set; }

        public DateTime UpdateDate { get; set; }
    }
}
