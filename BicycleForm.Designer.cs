namespace Lab2Project
{
    partial class BicycleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            startTimeTxt = new TextBox();
            endTimeTxt = new TextBox();
            calculateBtn = new Button();
            backBtn = new Button();
            logoutBtn = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(120, 150);
            label1.Name = "label1";
            label1.Size = new Size(92, 21);
            label1.TabIndex = 0;
            label1.Text = "Start Time:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(120, 234);
            label2.Name = "label2";
            label2.Size = new Size(85, 21);
            label2.TabIndex = 1;
            label2.Text = "End Time:";
            // 
            // startTimeTxt
            // 
            startTimeTxt.Location = new Point(258, 148);
            startTimeTxt.Name = "startTimeTxt";
            startTimeTxt.Size = new Size(195, 23);
            startTimeTxt.TabIndex = 2;
            // 
            // endTimeTxt
            // 
            endTimeTxt.Location = new Point(258, 232);
            endTimeTxt.Name = "endTimeTxt";
            endTimeTxt.Size = new Size(195, 23);
            endTimeTxt.TabIndex = 3;
            // 
            // calculateBtn
            // 
            calculateBtn.BackColor = SystemColors.Highlight;
            calculateBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            calculateBtn.ForeColor = SystemColors.Control;
            calculateBtn.Location = new Point(120, 310);
            calculateBtn.Name = "calculateBtn";
            calculateBtn.Size = new Size(128, 42);
            calculateBtn.TabIndex = 4;
            calculateBtn.Text = "Calculate Rent";
            calculateBtn.UseVisualStyleBackColor = false;
            calculateBtn.Click += calculateBtn_Click;
            // 
            // backBtn
            // 
            backBtn.BackColor = SystemColors.Highlight;
            backBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backBtn.ForeColor = SystemColors.Control;
            backBtn.Location = new Point(294, 310);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(159, 42);
            backBtn.TabIndex = 5;
            backBtn.Text = "Back To Menu";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // logoutBtn
            // 
            logoutBtn.BackColor = SystemColors.Highlight;
            logoutBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoutBtn.ForeColor = SystemColors.Control;
            logoutBtn.Location = new Point(503, 310);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(164, 42);
            logoutBtn.TabIndex = 6;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(128, 30);
            label3.Name = "label3";
            label3.Size = new Size(450, 30);
            label3.TabIndex = 7;
            label3.Text = "WELCOME TO THE BICYCLE RENTAL SYSTEM";
            // 
            // BicycleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(logoutBtn);
            Controls.Add(backBtn);
            Controls.Add(calculateBtn);
            Controls.Add(endTimeTxt);
            Controls.Add(startTimeTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BicycleForm";
            Text = "BicycleForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox startTimeTxt;
        private TextBox endTimeTxt;
        private Button calculateBtn;
        private Button backBtn;
        private Button logoutBtn;
        private Label label3;
    }
}