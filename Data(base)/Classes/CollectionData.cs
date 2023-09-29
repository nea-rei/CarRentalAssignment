using Common.Classes;
using Common.Enums;
using Common.Interfaces;
using Data.Interfaces;

namespace Data.Classes;

public class CollectionData : IData
{
    readonly List<IPerson> _persons = new();//variabel sparar objekt som implementerar samma I
    readonly List<IVehicle> _vehicles = new();

    public CollectionData() => SeedData();
    //konstruktor som skapar listobjekten m data från Seed-metoden

    void SeedData()//metod som skapar objekt som addas till listan
    {
        _persons.Add(new Customer(45123, "Elgh", "Moa"));
        _persons.Add(new Customer(45663, "Fager", "Nils"));
        _persons.Add(new Customer(88563, "Höve", "Anna"));
        _vehicles.Add(new Car("JUH458", "Volvo", 10000, 1, VehicleTypes.Combi, 200, VehicleStatus.Booked));
        _vehicles.Add(new Car("MAN985", "Saab", 20000, 1, VehicleTypes.Sedan, 100, VehicleStatus.Available));
        _vehicles.Add(new Car("NUJ741", "Yamaha", 20000, 0.5, VehicleTypes.Motorcycle, 50, VehicleStatus.Available));
        _vehicles.Add(new Car("WEK864", "Tesla", 1000, 3, VehicleTypes.Sedan, 100, VehicleStatus.Booked));

    }
    public IEnumerable<IPerson> GetPersons() => _persons;
    //metod som exponerar ut privata personlistan

    public IEnumerable<IVehicle> GetVehicles(VehicleStatus status = default) => _vehicles;

    //public IEnumerable<IVehicle> GetVehicles(VehicleStatus status = default)
    //{
    //    return _vehicles.Where(v => v.Status == status);
    //}
}
