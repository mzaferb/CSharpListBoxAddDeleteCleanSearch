using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxAddDltClnSrc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int i = listBox1.Items.IndexOf(textBox1.Text);
            if (i > -1)
            {
                MessageBox.Show("Already on the list!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox1.Focus();
                return;
            }

            if (textBox1.Text != "")
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("The line is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }
        }

        private void btnDlt_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Choose an item from the list!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }
        }

        private void btnCln_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                listBox1.Items.Clear();
            }
        }

        private void btnSrc_Click(object sender, EventArgs e)
        {
            int i = listBox1.Items.IndexOf(textBox2.Text);
            if (i > -1)
            {
                listBox1.SelectedIndex = i;
            }
            else
            {
                MessageBox.Show("Not on the list!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}