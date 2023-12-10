using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Prototyping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MS_Open_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void MS_Save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void MS_Print_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void foreColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void TS_Cut_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void TS_Left_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void TS_Center_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void TS_Right_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void TS_Copy_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void TS_Paste_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                TS_Font_DDown.Items.Add(font.Name.ToString());
            }
        }
    }
}
