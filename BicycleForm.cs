using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab2Project
{
    public partial class BicycleForm : Form
    {
        public BicycleForm()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            string startText = startTimeTxt.Text;
            string endText = endTimeTxt.Text;

            // 1. Check if empty
            if (string.IsNullOrWhiteSpace(startText) || string.IsNullOrWhiteSpace(endText))
            {
                MessageBox.Show("Please enter both times.");
                return;
            }

            // 2. Check if they typed actual numbers (This prevents the crash!)
            int start;
            int end;

            if (!int.TryParse(startText, out start) || !int.TryParse(endText, out end))
            {
                MessageBox.Show("Please enter valid numbers only.");
                return;
            }

            // 3. Validate the rules here so that none can enter my system things which are invalid
            if (start < 0 || start > 23 || end < 1 || end > 24 || end <= start)
            {
                MessageBox.Show("Invalid times! Start must be 0-23, End 1-24, and End > Start.");
                return;
            }

            // 4. Calculate
            int total = 0;
            int current = start;

            while (current < end)
            {
                if ((current >= 0 && current < 7) || (current >= 21 && current < 24))
                    total = total + 500;
                else if ((current >= 7 && current < 14) || (current >= 19 && current < 21))
                    total = total + 1000;
                else
                    total = total + 1500;

                current = current + 1;
            }

            MessageBox.Show("Total cost is: " + total + " RWF");

            startTimeTxt.Clear();
            endTimeTxt.Clear();
            startTimeTxt.Focus(); // Puts the cursor back in the first box for me to remember the role of Focus()
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