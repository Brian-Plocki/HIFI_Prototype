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
    public partial class UploadForm2 : Form
    {
        public UploadForm2()
        {
            InitializeComponent();

            UploadForm ul = new UploadForm();

            //ul.ShowDialog(this); // make sure this instance of Form1 is visible
            textBox1.Text = ul.MyValue;
        }

        private void btnCancelUploadForm2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
