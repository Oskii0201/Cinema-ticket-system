namespace Cinema_ticket_system
{
    partial class MainForm
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.userName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.RepertuarButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.NameLabel = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Blue;
            this.panelTop.Controls.Add(this.NameLabel);
            this.panelTop.Controls.Add(this.userName);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.MenuPanel);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1071, 108);
            this.panelTop.TabIndex = 0;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Palatino Linotype", 17.25F);
            this.userName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.userName.Location = new System.Drawing.Point(940, 9);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(0, 31);
            this.userName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 17.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(876, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Witaj";
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.RepertuarButton);
            this.MenuPanel.Location = new System.Drawing.Point(315, 18);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(477, 69);
            this.MenuPanel.TabIndex = 4;
            // 
            // RepertuarButton
            // 
            this.RepertuarButton.Location = new System.Drawing.Point(20, 23);
            this.RepertuarButton.Name = "RepertuarButton";
            this.RepertuarButton.Size = new System.Drawing.Size(75, 23);
            this.RepertuarButton.TabIndex = 0;
            this.RepertuarButton.Text = "Repertuar";
            this.RepertuarButton.UseVisualStyleBackColor = true;
            this.RepertuarButton.Click += new System.EventHandler(this.RepertuarButton_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Magneto", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightPink;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(0, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "WSB";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 17.25F);
            this.label3.ForeColor = System.Drawing.Color.LightPink;
            this.label3.Location = new System.Drawing.Point(3, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cinema ticket system";
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.Blue;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 587);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1071, 32);
            this.panelBottom.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 108);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1071, 479);
            this.panelMain.TabIndex = 2;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Palatino Linotype", 17.25F);
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NameLabel.Location = new System.Drawing.Point(940, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(58, 31);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "user";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 619);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RepertuarButton;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NameLabel;
    }
}