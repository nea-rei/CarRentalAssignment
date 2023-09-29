using Common.Enums;
using Common.Interfaces;
using Data.Interfaces;

namespace Business.Classes;

public class BookingProcessor
{

    private readonly IData _data; //interfaceinjektion (istället för klassinj)
                                  //för att uppnå en "mjuk" koppling med datalagret
    public BookingProcessor(IData data) => _data = data;//(mini-affärslager) konstruktor som injeceras med IData-objekt

    public IEnumerable<IPerson> Customers => _data.GetPersons();
    //property som returnerar metoden GetPersons-metoden från
    public IEnumerable<IVehicle> Vehicles => _data.GetVehicles();


    public VehicleStatus VehicleStatus = VehicleStatus.Available;

}
