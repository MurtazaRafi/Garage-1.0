using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ovning5
{
    public class Garage<T> :  IEnumerable<T> where T : IVehicle //IGarage<T>,
    {
        private T[] vehicles;

        public Garage(int nrOfVehicles)
        {
            vehicles = new T[nrOfVehicles];
        }
        public T this[int index]
        {
            get => vehicles[index];
            set { vehicles[index] = value; } //ToDo kolla så att ej skickar index out of bounds
        }


        // Kommer köra över hela arrayen, även null. Bör fixas, hur?
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in vehicles)
            {
                if(item!=null)
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
            //Boolskt returvärde?
            //Titta om garaget är fullt?
            //Är vehicle null?
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

        public bool Remove(T vehicle)
        {
            bool succcess = false;
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i].RegNr == "abc123")      //ToDo ändra så att det reg nr som inputar ska tas bort
                {
                    vehicles[i] = null;     // ?? Hur fixa så att kan sätta lika med null ??
                    succcess = true;
                    break;
                }
            }
            return succcess;
        }


    }
}
