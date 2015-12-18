using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace projectMAP_code
{
    
    public interface Repository<T> : IObservable<T> where T : IDObject
    {
        void AddObject(T o);
        bool Remove(int id);
        T Find(int id);
        T[] GetAll();
        //String ToString(StringEncoder<T> sr);
        void Close();
    }
    
    public class MemoryRepository<T> : Repository<T> where T : IDObject
    {
        protected List<T> data;
        private List<IObserver<T>> observers = new List<IObserver<T>>();
        private class Unsubscriber : IDisposable
        {
            private List<IObserver<T>> _observers;
            private IObserver<T> _observer;

            public Unsubscriber(List<IObserver<T>> observers, IObserver<T> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }

        public MemoryRepository()
        {
            data = new List<T>();
        }

        public IDisposable Subscribe(IObserver<T> observer)
        {
            if(!observers.Contains(observer))
                observers.Add(observer);
            return new Unsubscriber(observers, observer);
        }

        public void Notify(T next)
        {
            foreach (IObserver<T> obs in this.observers)
            {
                obs.OnNext(next);
            }
        }

        public void AddObject(T o)
        {
            data.Add(o);
            this.Notify(o);
        }

        public bool Remove(int id)
        {
            foreach (T o in data)
            {
                if (o.ID == id)
                {
                    data.Remove(o);
                    this.Notify(o);
                    return true;
                }
            }
            return false;
        }

        public T Find(int id)
        {
            foreach (T o in data)
            {
                if (o.ID == id)
                {
                    return o;
                }
            }
            return null;
        }

        public T[] GetAll()
        {
            return data.ToArray();
        }

        public virtual void Close() { }

    }

    public class BinaryRepository<T> : MemoryRepository<T> where T : IDObject
    {
        private String fileName;
        public BinaryRepository(String fileName)
        {
            this.fileName = fileName;
            deserialize();
        }
        public override void Close()
        {
            serialize();
        }

        private void serialize()
        {
            Stream stream = File.Open(fileName, FileMode.Create);
            BinaryFormatter formater = new BinaryFormatter();

            formater.Serialize(stream, data);
            stream.Close();
        }
        private void deserialize()
        {
            Stream stream = File.Open(fileName, FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();

            try
            {
                this.data = (List<T>)formatter.Deserialize(stream);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            stream.Close();
        }
    }

    public class XMLRepository<T> : MemoryRepository<T> where T : IDObject
    {
        private String fileName;

        public XMLRepository(String fileName)
        {
            this.fileName = fileName;
            unmarshall();
        }
        public override void Close()
        {
            marshall();
        }

        private void marshall()
        {
            XmlSerializer ser = new XmlSerializer(this.data.GetType());
            TextWriter writer = new StreamWriter(fileName);
            ser.Serialize(writer, this.data);
            writer.Close();
        }

        private void unmarshall()
        {
            XmlSerializer ser = new XmlSerializer(this.data.GetType());
            TextReader reader = new StreamReader(fileName);
            this.data = (List<T>)ser.Deserialize(reader);
            reader.Close();
        }
    }

    class Repository
    {
    }
}
