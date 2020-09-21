using System.Collections.Generic;

namespace Ovning5
{
    public interface IGarage<T> where T : IVehicle
    {
        int NrOfVehicles { get; set; }

        bool Add(T vehicle);
        IEnumerator<T> GetEnumerator();
        bool Remove(string regNr);
    }
}