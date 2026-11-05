namespace Lab2Project
{
    partial class MushroomForm
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
            label3 = new Label();
            label4 = new Label();
            forestYes = new RadioButton();
            forestNo = new RadioButton();
            cupYes = new RadioButton();
            cupNo = new RadioButton();
            ringYes = new RadioButton();
            ringNo = new RadioButton();
            gillsYes = new RadioButton();
            gillsNo = new RadioButton();
            identifyBtn = new Button();
            backBtn = new Button();
            logoutBtn = new Button();
            label5 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(102, 103);
            label1.Name = "label1";
            label1.Size = new Size(192, 21);
            label1.TabIndex = 0;
            label1.Text = "Does it grow in a forest?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(102, 161);
            label2.Name = "label2";
            label2.Size = new Size(215, 21);
            label2.TabIndex = 1;
            label2.Text = "Does it have a convex cup?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(102, 220);
            label3.Name = "label3";
            label3.Size = new Size(159, 21);
            label3.TabIndex = 2;
            label3.Text = "Does it have a ring?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(102, 275);
            label4.Name = "label4";
            label4.Size = new Size(147, 21);
            label4.TabIndex = 3;
            label4.Text = "Does it have gills?";
            // 
            // forestYes
            // 
            forestYes.AutoSize = true;
            forestYes.Location = new Point(10, 14);
            forestYes.Name = "forestYes";
            forestYes.Size = new Size(44, 19);
            forestYes.TabIndex = 4;
            forestYes.TabStop = true;
            forestYes.Text = "YES";
            forestYes.UseVisualStyleBackColor = true;
            // 
            // forestNo
            // 
            forestNo.AutoSize = true;
            forestNo.Location = new Point(111, 16);
            forestNo.Name = "forestNo";
            forestNo.Size = new Size(43, 19);
            forestNo.TabIndex = 5;
            forestNo.TabStop = true;
            forestNo.Text = "NO";
            forestNo.UseVisualStyleBackColor = true;
            // 
            // cupYes
            // 
            cupYes.AutoSize = true;
            cupYes.Location = new Point(10, 15);
            cupYes.Name = "cupYes";
            cupYes.Size = new Size(44, 19);
            cupYes.TabIndex = 6;
            cupYes.TabStop = true;
            cupYes.Text = "YES";
            cupYes.UseVisualStyleBackColor = true;
            // 
            // cupNo
            // 
            cupNo.AutoSize = true;
            cupNo.Location = new Point(111, 15);
            cupNo.Name = "cupNo";
            cupNo.Size = new Size(43, 19);
            cupNo.TabIndex = 7;
            cupNo.TabStop = true;
            cupNo.Text = "NO";
            cupNo.UseVisualStyleBackColor = true;
            // 
            // ringYes
            // 
            ringYes.AutoSize = true;
            ringYes.Location = new Point(10, 12);
            ringYes.Name = "ringYes";
            ringYes.Size = new Size(44, 19);
            ringYes.TabIndex = 8;
            ringYes.TabStop = true;
            ringYes.Text = "YES";
            ringYes.UseVisualStyleBackColor = true;
            // 
            // ringNo
            // 
            ringNo.AutoSize = true;
            ringNo.Location = new Point(111, 12);
            ringNo.Name = "ringNo";
            ringNo.Size = new Size(43, 19);
            ringNo.TabIndex = 9;
            ringNo.TabStop = true;
            ringNo.Text = "NO";
            ringNo.UseVisualStyleBackColor = true;
            // 
            // gillsYes
            // 
            gillsYes.AutoSize = true;
            gillsYes.Location = new Point(10, 12);
            gillsYes.Name = "gillsYes";
            gillsYes.Size = new Size(44, 19);
            gillsYes.TabIndex = 10;
            gillsYes.TabStop = true;
            gillsYes.Text = "YES";
            gillsYes.UseVisualStyleBackColor = true;
            // 
            // gillsNo
            // 
            gillsNo.AutoSize = true;
            gillsNo.Location = new Point(111, 12);
            gillsNo.Name = "gillsNo";
            gillsNo.Size = new Size(43, 19);
            gillsNo.TabIndex = 11;
            gillsNo.TabStop = true;
            gillsNo.Text = "NO";
            gillsNo.UseVisualStyleBackColor = true;
            // 
            // identifyBtn
            // 
            identifyBtn.BackColor = SystemColors.Highlight;
            identifyBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            identifyBtn.ForeColor = SystemColors.Control;
            identifyBtn.Location = new Point(102, 335);
            identifyBtn.Name = "identifyBtn";
            identifyBtn.Size = new Size(181, 42);
            identifyBtn.TabIndex = 12;
            identifyBtn.Text = "Identify Mushroom";
            identifyBtn.UseVisualStyleBackColor = false;
            identifyBtn.Click += identifyBtn_Click;
            // 
            // backBtn
            // 
            backBtn.BackColor = SystemColors.Highlight;
            backBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            backBtn.ForeColor = SystemColors.Control;
            backBtn.Location = new Point(349, 335);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(180, 42);
            backBtn.TabIndex = 13;
            backBtn.Text = "Back To Menu";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // logoutBtn
            // 
            logoutBtn.BackColor = SystemColors.Highlight;
            logoutBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            logoutBtn.ForeColor = SystemColors.Control;
            logoutBtn.Location = new Point(593, 335);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(175, 42);
            logoutBtn.TabIndex = 14;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.GradientActiveCaption;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Desktop;
            label5.Location = new Point(102, 39);
            label5.Name = "label5";
            label5.Size = new Size(532, 30);
            label5.TabIndex = 15;
            label5.Text = "WELCOME TO THE MUSHROOM IDENTIFIER SYSTEM";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(forestYes);
            groupBox1.Controls.Add(forestNo);
            groupBox1.Location = new Point(349, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(165, 41);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cupYes);
            groupBox2.Controls.Add(cupNo);
            groupBox2.Location = new Point(349, 136);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(165, 40);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ringYes);
            groupBox3.Controls.Add(ringNo);
            groupBox3.Location = new Point(349, 198);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(165, 37);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(gillsYes);
            groupBox4.Controls.Add(gillsNo);
            groupBox4.Location = new Point(349, 253);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(165, 37);
            groupBox4.TabIndex = 19;
            groupBox4.TabStop = false;
            // 
            // MushroomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(logoutBtn);
            Controls.Add(backBtn);
            Controls.Add(identifyBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MushroomForm";
            Text = "MushroomForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private RadioButton forestYes;
        private RadioButton forestNo;
        private RadioButton cupYes;
        private RadioButton cupNo;
        private RadioButton ringYes;
        private RadioButton ringNo;
        private RadioButton gillsYes;
        private RadioButton gillsNo;
        private Button identifyBtn;
        private Button backBtn;
        private Button logoutBtn;
        private Label label5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
    }
}