using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Ovning5
{
    public class Garage<T> :  IEnumerable<T> where T : Vehicle //IGarage<T>,
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

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in vehicles)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
    }
}
