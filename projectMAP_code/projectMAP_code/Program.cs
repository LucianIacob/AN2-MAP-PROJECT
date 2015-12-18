using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectMAP_code
{
    [Serializable()]
    public class Book : IDObject
    {
        public Book()
            : base(IDGenerator.getGenerator().nextID())
        {
        }

        public Book(int id, String autor, String name)
            : base(id)
        {
            Name = name;
            Autor = autor;
        }
    
        public String Name { get; set; }
        public String Autor { get; set; }

        public override string ToString()
        {
            return ID + " - " + Autor + " - " + Name;
        }
    }

    class Program
    {
        static String BookToString1(Book b)
        {
            return b.ID + " - " + b.Autor + " - " + b.Name;
        }

        static String BookToString2(Book b)
        {
            return "ID= " + b.ID + " Autor= " + b.Autor + "Titlu= " + b.Name;
        }

        static Book StringToBook(String s)
        { //aaaaaa
            String[] tokens = s.Split(new String[] { " - " }, 3, StringSplitOptions.RemoveEmptyEntries);
            return new Book(Int32.Parse(tokens[0]), tokens[1], tokens[2]);
        }

        static void Main(string[] args)
        {
        }
    }
}
