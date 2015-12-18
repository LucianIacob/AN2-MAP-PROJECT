using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using projectMAP_code;

namespace projectMAP
{
    static class Program
    {
        [STAThread]
        static void Main()
        {

            List<string> reservations = new List<string>();
            MemoryRepo<String> onlineUsers = new MemoryRepo<string>();
//            Repository<Book> repo = new MemoryRepository<Book>();
            Repository<Book> repo = new XMLRepository<Book>(@"C:\Users\Lucian\SkyDrive\Documents\Visual Studio 2013\ANUL II\MAP\projectMAP\data.xml");
//            Repository<Book> repo = new BinaryRepository<Book>(@"C:\Users\Lucian\SkyDrive\Documents\Visual Studio 2013\ANUL II\MAP\projectMAP\data.bin");

/*            
            IDGenerator generator = IDGenerator.getGenerator();
            repo.AddObject(new Book(generator.nextID(), "Klaus Iohannis", "Pas cu pas"));
            repo.AddObject(new Book(generator.nextID(), "Karl May", "Old Firehand"));
            repo.AddObject(new Book(generator.nextID(), "Gabriela Csibula", "Programare logica"));
            repo.AddObject(new Book(generator.nextID(), "John Evans", "Pi - the Number"));
            repo.AddObject(new Book(generator.nextID(), "Barack Obama", "White House"));
*/
            string fileNameUser = @"C:\Users\Lucian\SkyDrive\Documents\Visual Studio 2013\ANUL II\MAP\projectMAP\users.txt";
            string fileNameReservations = @"C:\Users\Lucian\SkyDrive\Documents\Visual Studio 2013\ANUL II\MAP\projectMAP\reservations.txt";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Biblioteca(repo, onlineUsers, fileNameUser, fileNameReservations, reservations));
            repo.Close();
        }
    }
}
