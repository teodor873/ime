using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace forma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            if (openPictureDialog.ShowDialog() == DialogResult.OK)

            {

                pbAvatar.ImageLocation = openPictureDialog.FileName;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.DefaultExt = "*.rtf";

            saveFileDialog.Filter = "RTF Files|*.rtf";

            if ((saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && (saveFileDialog.FileName.Length > 0)))


{

                try

                {

                    // Save the contents of the RichTextBox into the file.

                    richTxtComment.SaveFile(saveFileDialog.FileName);

                }

                catch (Exception)
                {
                    Console.WriteLine("");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Здрасти {txtName.Text}\n това е голямотот ти постижение");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //SecondForm secondForm = new SecondForm();

            string str = "ime: "+txtName.Text.Trim()+" komentar: "+richTxtComment.Text;

            SecondForm secondForm = new SecondForm(str);

            secondForm.Show();
        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            string str = "Hello " + txtName.Text.Trim();

            SecondForm secondForm = new SecondForm(str);

            if (DialogResult.Yes == secondForm.ShowDialog())

            {

                MessageBox.Show("Вие натиснахте бутона Yes");

            }

            else MessageBox.Show("Вие затворихте прозореца без да натиснете бутона Yes");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            richTxtComment.Clear();
        }

       

    }
}
