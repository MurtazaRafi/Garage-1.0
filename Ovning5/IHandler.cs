using System.Collections.Generic;

namespace Ovning5
{
    public interface IHandler
    {
        string FindVehiclesByPropertyValues(List<(string, string)> propValuePairs, string vehicleType);
        string GetVehicleTypes();
        string PrintAll();
    }
}