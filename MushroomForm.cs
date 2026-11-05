using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab2Project
{
    public partial class MushroomForm : Form
    {
        public MushroomForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // You can leave this empty, it was just auto-generated when you double-clicked the label
        }

        private void identifyBtn_Click(object sender, EventArgs e)
        {
            // 1. Check if they forgot to answer the main questions
            if ((!forestYes.Checked && !forestNo.Checked) ||
                (!cupYes.Checked && !cupNo.Checked))
            {
                MessageBox.Show("Please answer at least the Forest and Cup questions.");
                return;
            }

            // 2. Start the logic tree
            if (forestYes.Checked)
            {
                if (cupYes.Checked)
                {
                    if (!ringYes.Checked && !ringNo.Checked)
                    {
                        MessageBox.Show("Please answer the Ring question.");
                        return;
                    }

                    if (ringYes.Checked)
                        MessageBox.Show("Your mushroom is: Amanite tue-mouche");
                    else
                        MessageBox.Show("Your mushroom is: Pied bleu");
                }
                else if (cupNo.Checked)
                {
                    if (!gillsYes.Checked && !gillsNo.Checked)
                    {
                        MessageBox.Show("Please answer the Gills question.");
                        return;
                    }

                    if (gillsNo.Checked)
                        MessageBox.Show("Your mushroom is: Cepe de bordeaux");
                    else
                        MessageBox.Show("Your mushroom is: Girolle");
                }
            }
            else if (forestNo.Checked)
            {
                if (cupYes.Checked)
                    MessageBox.Show("Your mushroom is: Agaric Jaunissant");
                else
                    MessageBox.Show("Your mushroom is: Coprin chevelu");
            }

            // ==========================================
            // NEW CODE: Clear all buttons for the next try
            // ==========================================
            forestYes.Checked = false;
            forestNo.Checked = false;
            cupYes.Checked = false;
            cupNo.Checked = false;
            ringYes.Checked = false;
            ringNo.Checked = false;
            gillsYes.Checked = false;
            gillsNo.Checked = false;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            ChooseForm choose = new ChooseForm();
            choose.Show();
            this.Hide();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }
    }
}