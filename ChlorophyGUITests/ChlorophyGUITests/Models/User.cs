﻿namespace ChlorophyGUITests.Models
{
    public class User
    {
        //private static readonly User _currentUser = new();

        public Guid Id { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public List<Models.PlantDetails>? Plants { get; set; }



    }
}
