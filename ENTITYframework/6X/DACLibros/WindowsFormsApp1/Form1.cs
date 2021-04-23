using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DACLibros;
using DACLibros.Admin;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtAuthorId_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertarPublisher_Click(object sender, EventArgs e)
        {
            Publisher publisher = new Publisher()
            { pub_id = "1234", pub_name = "Maria", city = "Mar del Plata", state = "BA", country = "Argentina" };

            int filasAfectadas = AdminPublisher.Create(publisher);

            MostrarPublishers();
        }

        private void MostrarPublishers()
        {
            gridPublisher.DataSource = AdminPublisher.GetList();
        }

        private void btnModificarPublisher_Click(object sender, EventArgs e)
        {
            Publisher publisherMod = new Publisher()
            { pub_id = "123-45-6789", pub_name = "Sofia Milagros", city = "Mar Chiquita", state = "Buenos Aires", country = "Argentina" };

            int filasAfectadas = AdminPublisher.Create(publisherMod);

            MostrarPublishers();
        }

        private void btnEliminarPublisher_Click(object sender, EventArgs e)
        {
            Publisher publisherDel = new Publisher()
            { pub_id = "123-45-6789", pub_name = "Sofia Milagros", city = "Mar Chiquita", state = "Buenos Aires", country = "Argentina" };

            int filasAfectadas = AdminPublisher.Create(publisherDel);

            MostrarPublishers();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarPublishers();
        }
    }

}
