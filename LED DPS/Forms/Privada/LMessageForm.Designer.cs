namespace LED_DPS.Forms.Privada
{
    partial class LMessageForm
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
            pnlTittleBar = new Panel();
            btnExit = new Button();
            lblCaption = new Label();
            pnlIcon = new Panel();
            pbIcon = new FontAwesome.Sharp.IconPictureBox();
            pnlButtons = new Panel();
            pnlMessageText = new Panel();
            lblMessageText = new Label();
            pnlTittleBar.SuspendLayout();
            pnlIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcon).BeginInit();
            pnlMessageText.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTittleBar
            // 
            pnlTittleBar.BackColor = Color.SeaGreen;
            pnlTittleBar.Controls.Add(btnExit);
            pnlTittleBar.Controls.Add(lblCaption);
            pnlTittleBar.Dock = DockStyle.Top;
            pnlTittleBar.Location = new Point(1, 1);
            pnlTittleBar.Margin = new Padding(4, 3, 4, 3);
            pnlTittleBar.Name = "pnlTittleBar";
            pnlTittleBar.Size = new Size(470, 46);
            pnlTittleBar.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Right;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(423, 0);
            btnExit.Margin = new Padding(4, 3, 4, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(47, 46);
            btnExit.TabIndex = 4;
            btnExit.UseVisualStyleBackColor = true;
            // 
            // lblCaption
            // 
            lblCaption.AutoSize = true;
            lblCaption.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaption.ForeColor = Color.WhiteSmoke;
            lblCaption.Location = new Point(15, 13);
            lblCaption.Margin = new Padding(4, 0, 4, 0);
            lblCaption.Name = "lblCaption";
            lblCaption.Size = new Size(56, 17);
            lblCaption.TabIndex = 0;
            lblCaption.Text = "Caption";
            // 
            // pnlIcon
            // 
            pnlIcon.BackColor = Color.WhiteSmoke;
            pnlIcon.Controls.Add(pbIcon);
            pnlIcon.Dock = DockStyle.Left;
            pnlIcon.Location = new Point(1, 47);
            pnlIcon.Margin = new Padding(4, 3, 4, 3);
            pnlIcon.Name = "pnlIcon";
            pnlIcon.Size = new Size(58, 73);
            pnlIcon.TabIndex = 17;
            // 
            // pbIcon
            // 
            pbIcon.BackColor = Color.WhiteSmoke;
            pbIcon.ForeColor = Color.FromArgb(255, 169, 0);
            pbIcon.IconChar = FontAwesome.Sharp.IconChar.CommentDots;
            pbIcon.IconColor = Color.FromArgb(255, 169, 0);
            pbIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pbIcon.IconSize = 40;
            pbIcon.Location = new Point(8, 23);
            pbIcon.Margin = new Padding(4, 3, 4, 3);
            pbIcon.Name = "pbIcon";
            pbIcon.Size = new Size(40, 40);
            pbIcon.SizeMode = PictureBoxSizeMode.AutoSize;
            pbIcon.TabIndex = 5;
            pbIcon.TabStop = false;
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = SystemColors.ControlLight;
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Location = new Point(1, 120);
            pnlButtons.Margin = new Padding(4, 3, 4, 3);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(470, 69);
            pnlButtons.TabIndex = 4;
            // 
            // pnlMessageText
            // 
            pnlMessageText.AutoScroll = true;
            pnlMessageText.BackColor = SystemColors.Control;
            pnlMessageText.Controls.Add(lblMessageText);
            pnlMessageText.Dock = DockStyle.Fill;
            pnlMessageText.Location = new Point(59, 47);
            pnlMessageText.Margin = new Padding(0);
            pnlMessageText.Name = "pnlMessageText";
            pnlMessageText.Size = new Size(412, 73);
            pnlMessageText.TabIndex = 16;
            // 
            // lblMessageText
            // 
            lblMessageText.AutoSize = true;
            lblMessageText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblMessageText.ForeColor = SystemColors.GrayText;
            lblMessageText.Location = new Point(0, 0);
            lblMessageText.Margin = new Padding(4, 0, 4, 0);
            lblMessageText.MaximumSize = new Size(402, 0);
            lblMessageText.Name = "lblMessageText";
            lblMessageText.Padding = new Padding(6, 25, 0, 25);
            lblMessageText.Size = new Size(55, 67);
            lblMessageText.TabIndex = 1;
            lblMessageText.Text = "lblText";
            // 
            // LMessageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(472, 190);
            Controls.Add(pnlMessageText);
            Controls.Add(pnlIcon);
            Controls.Add(pnlButtons);
            Controls.Add(pnlTittleBar);
            Margin = new Padding(4, 3, 4, 3);
            MaximumSize = new Size(931, 744);
            MinimumSize = new Size(470, 184);
            Name = "LMessageForm";
            Padding = new Padding(1);
            StartPosition = FormStartPosition.CenterParent;
            Text = "RJMessageBox";
            Load += LMessageForm_Load;
            pnlTittleBar.ResumeLayout(false);
            pnlTittleBar.PerformLayout();
            pnlIcon.ResumeLayout(false);
            pnlIcon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcon).EndInit();
            pnlMessageText.ResumeLayout(false);
            pnlMessageText.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel pnlIcon;
        private System.Windows.Forms.Panel pnlTittleBar;
        private System.Windows.Forms.Panel pnlButtons;
        private FontAwesome.Sharp.IconPictureBox pbIcon;
        private System.Windows.Forms.Label lblCaption;
        public System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlMessageText;
        private System.Windows.Forms.Label lblMessageText;
        private LED_DPS.RJControls.RJDragControl rjDragControl1;
    }
}