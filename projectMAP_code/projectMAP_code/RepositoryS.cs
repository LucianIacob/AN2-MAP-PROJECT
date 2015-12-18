using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectMAP_code
{
    public interface RepositoryS<T> : IObservable<T> where T : IComparable<T>
    {
        void Add(T obj);
        T Find(T obj);
        bool Remove(T obj);
        void RemoveAll();
        List<T> GetAll();
        String ToString();
    }
}
