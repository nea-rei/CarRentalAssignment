using Common.Interfaces;

namespace Common.Classes;

public class Booking : IBooking
{
    public string RegNo { get; set; }
    public string Customer { get; set; }
    public int StartKm { get; set; }
    public int ReturnedKm { get; set; }
    public DateTime RentalDate { get; set; }
    public DateTime ReturnDate { get; set; }
    public int Cost { get; set; }
    public bool Status { get; set; }

    public void GetCustomer(IPerson person)
    {

    }

    public void GetVehicle(IVehicle vehicle)
    {

    }
    public Booking()
    {

    }


    //göra en extensionmetod? public void GetRentalDays(string rentaldate, string returndate) =>
    //(RentalDate, ReturnDate) = (rentaldate, returndate);

    //anropas när ett fordon återlämnas, ska beräkna kostnaden för uthyrningen
    public void ReturnVehicle(IVehicle vehicle)
    {
        //Cost = Duration() * vehicle.DailyCost + TotalKm() * vehicle.CostKm;

    }
}

