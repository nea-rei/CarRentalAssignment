using Common.Classes;
using Common.Enums;
using Common.Extensions;

namespace Common.Interfaces;

public interface IBooking
{
    public string RegNo { get; set; }
    public IPerson Person { get; set; }
    public IVehicle Vehicle { get; set; }
    public int? ReturnedKm { get; set; }
    public int StartKm { get; set; }
    public DateTime RentalDate { get; set; }
    public DateTime? ReturnDate { get; set; }
    public double? Cost { get; set; }
    public VehicleStatus Status { get; set; }

}
