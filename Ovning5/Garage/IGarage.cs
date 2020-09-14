using System.Collections.Generic;

namespace Ovning5
{
    public interface IGarage<T> where T : Vehicle
    {
        T this[int index] { get; set; }

        IEnumerator<T> GetEnumerator();
    }
}