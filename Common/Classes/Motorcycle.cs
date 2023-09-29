using Common.Enums;
using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Classes;

public class Motorcycle : IVehicle
{
    public string RegNo { get; set; } = string.Empty;
    public string Brand { get; set; } = string.Empty;
    public int Odometer { get; set; }
    public double CostKm { get; set; }
    public VehicleTypes VType { get; set; }
    public int DailyCost { get; set; }
    public VehicleStatus Status { get; set; } = default;

    public Motorcycle(string regNo, string brand, int odometer, double costKm, VehicleTypes vType,
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
