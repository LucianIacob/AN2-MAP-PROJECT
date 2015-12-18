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
using System.IO;

namespace projectMAP
{
    public partial class Biblioteca : Form
    {
        private Repository<Book> repo;
        private MemoryRepo<String> onlineUsers;
        public List<String> toFile = new List<string>();
        public List<String> reservations = new List<string>();
        public string fileNameUsers, fileNameReservations;

        public Biblioteca(Repository<Book> repo, MemoryRepo<string> online, string filename, string fileNameR, List<string> rez)
		{
            InitializeComponent();
            this.repo = repo;
            this.onlineUsers = online;
            this.fileNameUsers = filename;
            this.reservations = rez;
            this.fileNameReservations = fileNameR;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Admin adm = new Admin(repo, onlineUsers); 
            adm.Show();
        }
        private void btnAbonat_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNume.Text))
            {
                MessageBox.Show("Alegeti un nume", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                Abonat ab = new Abonat(repo, onlineUsers, reservations);
                ab.Text = txtNume.Text;
                ab.Show();
                onlineUsers.Add(txtNume.Text);
                // list of users for to file
                toFile.Add(txtNume.Text);
                txtNume.Clear();
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
        public void OnNext(String user)
        {
        }

        private void Selectie_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (string s in toFile)
            {
                string[] lines = toFile.ToArray();
                File.WriteAllLines(this.fileNameUsers, lines);    
            }
            foreach (string s in reservations)
            {
                string[] lines = reservations.ToArray();
                File.WriteAllLines(this.fileNameReservations, lines);
            }
        }
    }
}
