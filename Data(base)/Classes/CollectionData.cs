using Common.Classes;
using Common.Enums;
using Common.Interfaces;
using Data.Interfaces;

namespace Data.Classes;

public class CollectionData : IData
{
    readonly List<IPerson> _persons = new();//sparar objekt som implementerar samma I
    readonly List<IVehicle> _vehicles = new();

    public CollectionData() => SeedData();//konstruktor som hämtar data från Seed-metoden

    void SeedData()
    {
        _persons.Add(new Customer(45123, "Elgh", "Moa"));
        _persons.Add(new Customer(45663, "Fager", "Nils"));
        _persons.Add(new Customer(88563, "Höve", "Anna"));
        _vehicles.Add(new Car("JUH458", "Volvo", 10000, 1, VehicleTypes.Combi, 200, default));
        _vehicles.Add(new Car("MAN985", "Saab", 20000, 1, VehicleTypes.Sedan, 100, default));

    }
    public IEnumerable<IPerson> GetPersons() => _persons;
    public IEnumerable<IVehicle> GetVehicles(VehicleStatus status = default) => _vehicles;
}
