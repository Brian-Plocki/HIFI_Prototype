using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiFiPrototype
{
    public partial class UploadForm : Form
    {
        public UploadForm()
        {
            InitializeComponent();
        }

        public string MyValue
        {
            get { return textBox1.Text; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UploadCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Upload1_Click(object sender, EventArgs e)
        {
            UploadForm2 ulf2 = new UploadForm2();
            ulf2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
