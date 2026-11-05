namespace Lab2Project
{
    partial class ChooseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseForm));
            bicycleBtn = new Button();
            mushroomBtn = new Button();
            logoutBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // bicycleBtn
            // 
            bicycleBtn.BackColor = SystemColors.HotTrack;
            bicycleBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            bicycleBtn.ForeColor = SystemColors.Control;
            bicycleBtn.Location = new Point(161, 191);
            bicycleBtn.Name = "bicycleBtn";
            bicycleBtn.Size = new Size(160, 40);
            bicycleBtn.TabIndex = 0;
            bicycleBtn.Text = "Bicycle";
            bicycleBtn.UseVisualStyleBackColor = false;
            bicycleBtn.Click += bicycleBtn_Click;
            // 
            // mushroomBtn
            // 
            mushroomBtn.BackColor = SystemColors.HotTrack;
            mushroomBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            mushroomBtn.ForeColor = SystemColors.Control;
            mushroomBtn.Location = new Point(379, 191);
            mushroomBtn.Name = "mushroomBtn";
            mushroomBtn.Size = new Size(165, 40);
            mushroomBtn.TabIndex = 1;
            mushroomBtn.Text = "Mushroom";
            mushroomBtn.UseVisualStyleBackColor = false;
            mushroomBtn.Click += mushroomBtn_Click;
            // 
            // logoutBtn
            // 
            logoutBtn.BackColor = SystemColors.HotTrack;
            logoutBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            logoutBtn.ForeColor = SystemColors.Control;
            logoutBtn.Location = new Point(597, 191);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(168, 40);
            logoutBtn.TabIndex = 2;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(149, 40);
            label1.Name = "label1";
            label1.Size = new Size(562, 30);
            label1.TabIndex = 3;
            label1.Text = "CHOOSE THE SYSTEM YOU WANT TO CONTINUE WITH:";
            label1.Click += label1_Click;
            // 
            // ChooseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(logoutBtn);
            Controls.Add(mushroomBtn);
            Controls.Add(bicycleBtn);
            Name = "ChooseForm";
            Text = "ChooseForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bicycleBtn;
        private Button mushroomBtn;
        private Button logoutBtn;
        private Label label1;
    }
}