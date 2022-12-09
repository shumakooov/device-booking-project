﻿using booking.Entities;

namespace booking.DTO
{
    public class ShortDevicesListDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Os { get; set; }
        public double? Diagonal { get; set; }
        public Department? Department { get; set; }
        public string? Image { get; set; }
    }
}
