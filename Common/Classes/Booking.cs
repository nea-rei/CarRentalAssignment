using Common.Enums;
using Common.Extensions;
using Common.Interfaces;
using Microsoft.VisualBasic;

namespace Common.Classes;

public class Booking : IBooking
{
    public string RegNo { get; set; } = string.Empty;
    public IPerson Person { get; set; }
    public IVehicle Vehicle { get; set; }
    public int StartKm { get; set; }
    public int? ReturnedKm { get; set; }
    public DateTime RentalDate { get; set; }
    public DateTime? ReturnDate { get; set; }
    public VehicleStatus Status { get; set; }
    public double? Cost { get; set; }

    public Booking(IPerson person, IVehicle vehicle, DateTime rentaldate)
    {
        RegNo = vehicle.RegNo;
        Person = person;
        Vehicle = vehicle;
        StartKm = vehicle.Odometer;
        RentalDate = rentaldate;
        Status = vehicle.Status;
    }
    public Booking(IPerson person, IVehicle vehicle, int returnedkm, DateTime rentaldate, DateTime returndate, double cost)
    {
        RegNo = vehicle.RegNo;
        Person = person;
        Vehicle = vehicle;
        RentalDate = rentaldate;
        ReturnDate = returndate;
        StartKm = vehicle.Odometer;
        ReturnedKm = returnedkm;
        Cost = cost;
        Status = vehicle.Status;
    }

    public Booking()
    {

    }




    //göra en extensionmetod för datum?

    public void ReturnVehicle(IVehicle vehicle)
    {

        Cost = (ReturnDate?.Duration(RentalDate)* vehicle.DailyCost) + ((ReturnedKm - vehicle.Odometer) * vehicle.CostKm);
    }
}

