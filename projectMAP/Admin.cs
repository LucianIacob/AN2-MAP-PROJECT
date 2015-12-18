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
    public partial class Admin : Form, IObserver<Book>, IObserver<String>
    {
        private MemoryRepo<String> useri;
        private Repository<Book> repo;
        
        public Admin(Repository<Book> repo, MemoryRepo<String> users)
        {
            InitializeComponent();
            this.repo = repo;
            this.repo.Subscribe(this);
            this.useri = users; 
            this.useri.Subscribe(this);
            reloadData();
        }

        private void reloadData()
        {
            lstPublicatiiAdmin.Items.Clear();
            foreach (Book b in repo.GetAll())
            {
                lstPublicatiiAdmin.Items.Add(b);
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
        public void OnNext(string s)
        {
            this.refreshUseri();
        }

        private void refreshUseri()
        {
            lstUseriActivi.Items.Clear();
            foreach (String s in useri.GetAll())
            {
                lstUseriActivi.Items.Add(s);
            }
        }
   
        IDGenerator generator = IDGenerator.getGenerator();
        private void btnAddPublicatie_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtAutor.Text) && !String.IsNullOrWhiteSpace(txtNumePublicatie.Text))
            {
                Book b = new Book(generator.nextID(), txtAutor.Text, txtNumePublicatie.Text);
                repo.AddObject(b);
                txtAutor.Clear();
                txtNumePublicatie.Clear();
            }
            else
            {
                MessageBox.Show("Numele autorului sau titlul incosistent!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            refreshUseri(); 
        }
    }
}
