using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ovning5
{
    public class Garage<T> : IEnumerable<T> where T : IVehicle //IGarage<T>,
    {
        private T[] vehicles;
        public Garage(int nrOfVehicles)
        {
            vehicles = new T[nrOfVehicles];
        }
        internal T this[int index]
        {
            get => vehicles[index];
            set { vehicles[index] = value; }
        }


        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in vehicles)
            {
                if (item != null)
                    yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        // ??
        public bool Add(T vehicle)
        {

            bool success = false;

            if (vehicles.Last() != null)
                return false;

            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] == null)
                {
                    vehicles[i] = vehicle;
                    success = true;
                    break;
                }
            }
            return success;
        }

        internal bool UniqueRegNr(string regNr)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i]?.RegNr.ToLower() == regNr.ToLower())
                    return false;
            }
            return true;
        }

        //public bool Remove(T vehicle)
        public bool Remove(string regNr)
        {
            bool succcess = false;
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i]?.RegNr.ToLower() == regNr.ToLower())
                {
                    vehicles[i] = default(T);
                    succcess = true;
                    break;
                }
            }
            return succcess;
        }

        internal string FindVehicles(string color, int nrOfWheels)
        {
            var veh = vehicles.Where(v => v.Color == color).Select(v => v.GetType().Name); //ToDo Fixa så att kan välja
            return veh.ToString();
        }

        internal T GetVehicleByRegNr(string regNr)
        {

            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i]?.RegNr.ToLower() == regNr.ToLower())
                {
                    return vehicles[i];
                }
            }

            return default(T);
        }
    }
}
