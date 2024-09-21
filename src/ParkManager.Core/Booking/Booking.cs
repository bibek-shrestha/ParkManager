namespace ParkManager.Core.Booking;

public class Booking
{
    public BookingId Id { get; set; }
    public BookingStatus Status { get; set; }
    public DateTime From { get; set; }
    public DateTime To { get; set; }
}

public enum BookingStatus {
    REQUESTED, DECLINED, CANCELLED, APPROVED
}