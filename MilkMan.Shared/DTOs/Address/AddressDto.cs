﻿namespace MilkMan.Shared.DTOs.Address
{
    public class AddressDto
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string AddressDetails { get; set; }
        public int FloorNumber { get; set; }
        public int FlatNumber { get; set; }
        public string? DeliveryInstructions { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

    }
}