using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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



    public Booking()
    {

    }
    //public void GetRentalDays(string rentaldate, string returndate) =>
    //(RentalDate, ReturnDate) = (rentaldate, returndate);

    //ska innehålla en metod som anropas när ett fordon återlämnas
    //Den ska beräkna kostnaden för uthyrningen
    public void ReturnVehicle(IVehicle vehicle)
    {
        Cost = 0;


    }
}
