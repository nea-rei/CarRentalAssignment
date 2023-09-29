using Common.Interfaces;

namespace Common.Extensions;

public static class BookingExtensions
{
    //public static int Duration(this DateTime rentaldate, DateTime returndate){ return int; }

    public static int TotalKm(this IVehicle vehicle, IBooking booking)
    {  return vehicle.Odometer * booking.ReturnedKm;}
}

