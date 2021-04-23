using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEF.Repository;
using WindowsEF.Data;

namespace WindowsEF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarAuthors();
        }

        private void MostrarAuthors()
        {
            gridAuthor.DataSource = AuthorRepository.GetList();
        }


        private void btnBuscarPorCity_Click(object sender, EventArgs e)
        {
            string city = txtCity.Text;

            gridAuthor.DataSource = AuthorRepository.GetList(city);
        }

        private void btnBuscarAuthor_Click(object sender, EventArgs e)
        {
            Author author = AuthorRepository.GetAuthor(txtAuthorId.Text);
            MessageBox.Show(author.au_fname + " " + author.au_lname);
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Author author = new Author()
            { au_id = "486-29-1222", au_fname = "Juan", au_lname = "Perez", phone = "415 585-3330", contract = true };

            int filasAfectadas = AuthorRepository.Create(author);

            MostrarAuthors();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Author authorMod = new Author()
            { au_id = "486-29-1222", au_fname = "Juan Manuel", au_lname = "Perez Gonzalez", phone = "415 585-3330", contract = true };

            int filasAfectadas = AuthorRepository.Edit(authorMod);

            MostrarAuthors();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Author authorDel = new Author()
            { au_id = "486-29-1222", au_fname = "Juan Manuel", au_lname = "Perez Gonzalez", phone = "415 585-3330", contract = true };

            int filasAfectadas = AuthorRepository.Delete(authorDel);

            MostrarAuthors();
        }
    }
}
