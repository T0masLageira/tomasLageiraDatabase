﻿namespace tomasLageiraDatabase.Models
{
    public class Owners
    {

        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? DriverLicense { get; set; }

        public List<Vehicles>? Vehicles { get; set; }
    }
}
