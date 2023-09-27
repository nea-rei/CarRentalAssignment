using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces;

public interface IBooking
{
    public string RegNo { get; set; }
    public string Customer { get; set; }
    public int StartKm { get; set; }
    public int ReturnedKm { get; set; }
    public DateTime RentalDate { get; set; }
    public DateTime ReturnDate { get; set; }
    public int Cost { get; set; }
    public bool Status { get; set; }
}
