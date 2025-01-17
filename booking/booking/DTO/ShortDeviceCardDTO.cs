﻿//using booking.Entities;

using booking.Entities;

namespace booking.DTO
{
    public class ShortDeviceCardDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Os { get; set; }
        public double? Diagonal { get; set; }
        public DepartmentDTO? Department { get; set; }
        public string? Image { get; set; }
    }
}
