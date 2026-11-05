using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab2Project
{
    public partial class ChooseForm : Form
    {
        public ChooseForm()
        {
            InitializeComponent();
        }

        private void bicycleBtn_Click(object sender, EventArgs e)
        {
            BicycleForm bike = new BicycleForm();
            bike.Show();
            this.Hide();
        }

        private void mushroomBtn_Click(object sender, EventArgs e)
        {
            MushroomForm mushroom = new MushroomForm();
            mushroom.Show();
            this.Hide();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
