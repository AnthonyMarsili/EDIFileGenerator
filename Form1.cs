using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDIFileGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Button to move to the PO genereator
        private void PoBtnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form POGenerator = new Form2();
            POGenerator.Show();
        }

        //Button to move to the ASN-RC converter
        private void ConvertBtnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form ASNtoRCConverter = new Form3();
            ASNtoRCConverter.Show();
        }

        //Function to close all forms when application is closed
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
