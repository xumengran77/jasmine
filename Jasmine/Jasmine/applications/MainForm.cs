using Jasmine.applications.infomation.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jasmine.applications
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            InformationForm form = new InformationForm();
            form.ShowDialog();
        }
    }
}
