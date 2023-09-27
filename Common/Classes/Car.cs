using Common.Enums;
using Common.Interfaces;

namespace Common.Classes
{
    public class Car : IVehicle
    {
        public string RegNo { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public int Odometer { get; set; }
        public int CostKm { get; set; }
        public VehicleTypes VType { get; set; }
        public int DailyCost { get; set; }
        public VehicleStatus Status { get; set; } = default;

        public Car(string regNo, string brand, int odometer, int costKm, VehicleTypes vType,
            int dailyCost, VehicleStatus status)
        {
            RegNo = regNo;
            Brand = brand;
            Odometer = odometer;
            CostKm = costKm;
            VType = vType;
            DailyCost = dailyCost;
            Status = status;
        }
    }
}
