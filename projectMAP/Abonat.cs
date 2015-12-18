using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projectMAP_code;

namespace projectMAP
{
    public partial class Abonat : Form, IObserver<Book>
    {
        private MemoryRepo<String> useri;
        private Repository<Book> repo;
        private List<string> reservations = new List<string>();

        public Abonat(Repository<Book> repo, MemoryRepo<String> users, List<string> rez)
        {
            InitializeComponent();
            this.repo = repo;
            this.repo.Subscribe(this);
            this.useri = users;
            this.reservations = rez;
            reloadData();
        }

        private void reloadData()
        {
            lstPublicatiiAbonati.Items.Clear();
            foreach (Book b in repo.GetAll())
            {
                lstPublicatiiAbonati.Items.Add(b);
            }
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }
        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(Book value)
        {
            this.reloadData();
        }

        private void btnRezerva_Click(object sender, EventArgs e)
        {
            if (lstPublicatiiAbonati.SelectedIndex < 0)
            {
                MessageBox.Show("Select one!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                String toParse = lstPublicatiiAbonati.SelectedItem.ToString();
                String[] parsed = toParse.Split(new String[] { " - " }, 3, StringSplitOptions.RemoveEmptyEntries);
                reservations.Add("Datele cartii: " + parsed[0] + " " + parsed[1] + " - " + parsed[2] + ".   Nume Abonat: " + this.Text);
                repo.Remove(Int32.Parse(parsed[0]));
            }
        }

        private void Abonat_FormClosing(object sender, FormClosingEventArgs e)
        {
            useri.Remove(this.Text);
        }
    }
}
