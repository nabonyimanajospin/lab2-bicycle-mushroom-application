namespace Lab2Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            usernameTxt = new TextBox();
            passwordTxt = new TextBox();
            loginBtn = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(182, 119);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(182, 177);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // usernameTxt
            // 
            usernameTxt.Location = new Point(319, 121);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(168, 23);
            usernameTxt.TabIndex = 2;
            usernameTxt.TextChanged += usernameTxt_TextChanged;
            // 
            // passwordTxt
            // 
            passwordTxt.Location = new Point(319, 179);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(168, 23);
            passwordTxt.TabIndex = 3;
            passwordTxt.UseSystemPasswordChar = true;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = SystemColors.HotTrack;
            loginBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = SystemColors.Control;
            loginBtn.Location = new Point(417, 268);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(204, 37);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(193, 40);
            label3.Name = "label3";
            label3.Size = new Size(623, 30);
            label3.TabIndex = 5;
            label3.Text = "WELCOME TO THE BICYCLE AND MUSHROOMS APPLICATION";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(898, 450);
            Controls.Add(label3);
            Controls.Add(loginBtn);
            Controls.Add(passwordTxt);
            Controls.Add(usernameTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox usernameTxt;
        private TextBox passwordTxt;
        private Button loginBtn;
        private Label label3;
    }
}