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
        public int NrOfVehicles { get; set; }       //ToDo Testa om den blir 10 när skapar garage
        public Garage(int nrOfVehicles)
        {
            vehicles = new T[nrOfVehicles];        
        }
        internal T this[int index]
        {
            get => vehicles[index];
            set { vehicles[index] = value; }
        }


        public IEnumerator<T> GetEnumerator()       //ToDo Testa så att ej null PrintAll()
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

      }
}
