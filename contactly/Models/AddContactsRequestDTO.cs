﻿namespace contactly.Models
{
    public class AddContactsRequestDTO
    {
        public required string Name { get; set; }
        public string? Email { get; set; }
        public required string Phone { get; set; }
        public bool Favorite { get; set; }
    }
}