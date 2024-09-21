using System;

namespace ParkManager.Core.Amenity;

public class Amenity
{
    public AmenityId Id { get; set; }
    public string Label { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public string? Notes { get; set; }
    public AmenityStatus Status { get; set; }

}

public enum AmenityStatus {
    WORKING, UNDER_MAINTENANCE, NOT_WORKING
}
