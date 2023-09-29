using Common.Enums;

namespace Common.Interfaces
{
    public interface IVehicle
    {
        public string RegNo { get; set; }
        public string Brand { get; set; }
        public int Odometer { get; set; }
        public double CostKm { get; set; }
        public VehicleTypes VType { get; set; }
        public int DailyCost { get; set; }
        public VehicleStatus Status { get; set; }
    }
}
