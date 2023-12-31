﻿namespace RestoFlow.Core.Models.User
{
    public class AuthResponseDTO
    {
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Token { get; set; } = null!;
    }
}
