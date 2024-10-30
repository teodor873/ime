using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forma
{
    public partial class SecondForm : Form
    {
        public SecondForm()
        {
            InitializeComponent();
        }

        private void SecondForm_Load(object sender, EventArgs e)
        {

        }

        public SecondForm(string labelText) : this()

        {

            lblGreetingText.Text = labelText;

        }

        private void btnDialogResultYes_Click(object sender, EventArgs e)
        {

        }
    }
}
