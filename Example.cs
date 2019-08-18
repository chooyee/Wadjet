using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EoH
{
    public partial class Example : Form
    {
        public Example()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if(fileDialog.ShowDialog().Equals(DialogResult.OK))
            {
                textBox1.Text = fileDialog.FileName;
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var isElf = Wadjet.ELF.ELFReader.isValidELF(textBox1.Text);
            var isEXE = Wadjet.WIN.ELFReader.IsValidEXE(textBox1.Text);
            if (isElf)
                MessageBox.Show("Is Linux Executable!");
            else if (isEXE)
                MessageBox.Show("Is Windows Executable!");
            else
                MessageBox.Show("Is neither Linux nor Windows Executable!");

        }
    }
}
