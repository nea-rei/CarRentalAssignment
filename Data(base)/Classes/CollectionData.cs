using Common.Classes;
using Common.Enums;
using Common.Extensions;
using Common.Interfaces;
using Data.Interfaces;

namespace Data.Classes;

public class CollectionData : IData
{
    readonly List<IPerson> _persons = new();//variabel sparar objekt som implementerar samma I
    readonly List<IVehicle> _vehicles = new();
    readonly List<IBooking> _bookings = new();

    public CollectionData() => SeedData();
    //konstruktor som skapar listobjekten m data från Seed-metoden

    void SeedData()//metod som skapar objekt som addas till listan
    {
        var person1 = new Person(45123, "Elgh", "Moa");
        var person2 = new Person(45663, "Fager", "Nils");
        _persons.Add(person1);
        _persons.Add(person2);
        _persons.Add(new Person(88563, "Höve", "Anna"));

        var car1 = new Car("JUH458", "Volvo", 10000, 1, VehicleTypes.Combi, 200, VehicleStatus.Booked);
        var car2 = new Car("MAN985", "Saab", 20000, 1, VehicleTypes.Sedan, 100, VehicleStatus.Available);
        _vehicles.Add(car1);
        _vehicles.Add(car2);

        _vehicles.Add(new Motorcycle("NUJ741", "Yamaha", 20000, 0.5, VehicleTypes.Motorcycle, 50, VehicleStatus.Available));
        _vehicles.Add(new Car("WEK864", "Tesla", 1000, 3, VehicleTypes.Sedan, 100, VehicleStatus.Available));
        _vehicles.Add(new Car("KYT185", "Jeep", 5000, 1.5, VehicleTypes.Van, 300, VehicleStatus.Available));

        var rentaldate1 = new DateTime(2023, 09, 15);
        var rentaldate2 = new DateTime(2023, 09, 27);
       
        var returndate2 = DateTime.Today;

        var returnedKm2 = 20500;

        var booking1 = new Booking(person1, car1, rentaldate1)
        {
            
        };
        var booking2 = new Booking();


        double cost1 = (returndate2.Duration(rentaldate2) * car2.DailyCost) + (car2.CostKm * (returnedKm2-car2.Odometer));


        Booking be = new ();

        //be.ReturnVehicle(car2);


        _bookings.Add(booking1);
        _bookings.Add(new Booking(person2, car2, returnedKm2, rentaldate2, returndate2, cost1)
        {
            RegNo = car2.RegNo,
            Person = person2,
            Vehicle = car2,
            RentalDate = rentaldate2,
            ReturnDate = returndate2,
            ReturnedKm = returnedKm2,
            Cost = cost1

        }); ;

        //_bookings.Add(new Booking() {
        //    Person = person1,
        //    Vehicle = car1,
        //});
        //_bookings.Add(new Booking() { RentalDate = new DateTime()})

    }
    public IEnumerable<IPerson> GetPersons() => _persons;
    //metod som exponerar ut privata personlistan
    public IEnumerable<IVehicle> GetVehicles(VehicleStatus status = default) => _vehicles;
    public IEnumerable<IBooking> GetBookings() => _bookings;

    //public IEnumerable<IVehicle> GetVehicles(VehicleStatus status = default)
    //{
    //    return _vehicles.Where(v => v.Status == status);
    //}
}
