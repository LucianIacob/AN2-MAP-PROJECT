using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectMAP_code
{
    public class MemoryRepo<T> : RepositoryS<T> where T : IComparable<T>
    {
        protected List<T> data; 
        private List<IObserver<T>> observers;

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<T>> _observers; 
            private IObserver<T> _observer;
            public Unsubscriber(List<IObserver<T>> observers, IObserver<T> observer) 
            { 
                _observers = observers; 
                _observer = observer; 
            }
            public void Dispose() 
            { 
                if (_observer != null && _observers.Contains(_observer)) 
                    _observers.Remove(_observer); 
            }
        }

        public IDisposable Subscribe(IObserver<T> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);
            return new Unsubscriber(observers, observer);
        }

        public void Notify(T obj)
        {
            foreach (IObserver<T> obs in observers)
            {
                obs.OnNext(obj);
            }
        }

        public MemoryRepo()
        {
            data = new List<T>();
            observers = new List<IObserver<T>>();
        }

        public virtual void Add(T obj)
        {
            data.Add(obj);
            Notify(obj);
        }

        public T Find(T obj)
        {
            foreach (T o in data)
            {
                if (o.CompareTo(obj) == 0)
                {
                    return o;
                }
            }
            return default(T);
        }

        public virtual bool Remove(T obj)
        {
            foreach (T o in data)
            {
                if (o.CompareTo(obj) == 0)
                {
                    T aux = Find(obj);
                    data.Remove(aux);
                    Notify(obj);
                    return true;
                }
            }
            return false;
        }

        public void RemoveAll()
        {
            data.Clear();
        }

        public List<T> GetAll()
        {
            return data;
        }

        public override String ToString()
        {
            StringBuilder sb = new StringBuilder("MemoryRepo: \n");
            foreach (T obj in data)
            {
                sb.Append(obj.ToString() + "\n");
            }
            return sb.ToString();
        }
    }
}

