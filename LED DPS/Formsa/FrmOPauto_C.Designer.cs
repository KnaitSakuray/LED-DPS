namespace LED_DPS.Formsa
{
    partial class FrmOPauto_C
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
            chb_Nop = new RJControls.RJRadioButton();
            chb_data = new RJControls.RJRadioButton();
            dt_data = new RJControls.RJDatePicker();
            pnlClientArea.SuspendLayout();
            SuspendLayout();
            // 
            // pnlClientArea
            // 
            pnlClientArea.BackColor = Color.FromArgb(240, 245, 249);
            pnlClientArea.Controls.Add(chb_Nop);
            pnlClientArea.Controls.Add(chb_data);
            pnlClientArea.Controls.Add(dt_data);
            pnlClientArea.Location = new Point(1, 41);
            pnlClientArea.Size = new Size(958, 408);
            // 
            // chb_Nop
            // 
            chb_Nop.AutoSize = true;
            chb_Nop.CheckedColor = Color.FromArgb(245, 124, 37);
            chb_Nop.Customizable = false;
            chb_Nop.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chb_Nop.ForeColor = Color.FromArgb(132, 129, 132);
            chb_Nop.Location = new Point(671, 49);
            chb_Nop.MinimumSize = new Size(0, 21);
            chb_Nop.Name = "chb_Nop";
            chb_Nop.Padding = new Padding(10, 0, 0, 0);
            chb_Nop.Size = new Size(81, 25);
            chb_Nop.TabIndex = 5;
            chb_Nop.TabStop = true;
            chb_Nop.Text = "N° OP";
            chb_Nop.UnCheckedColor = Color.FromArgb(104, 110, 134);
            chb_Nop.UseVisualStyleBackColor = true;
            // 
            // chb_data
            // 
            chb_data.AutoSize = true;
            chb_data.CheckedColor = Color.FromArgb(245, 124, 37);
            chb_data.Customizable = false;
            chb_data.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chb_data.ForeColor = Color.FromArgb(132, 129, 132);
            chb_data.Location = new Point(671, 14);
            chb_data.MinimumSize = new Size(0, 21);
            chb_data.Name = "chb_data";
            chb_data.Padding = new Padding(10, 0, 0, 0);
            chb_data.Size = new Size(71, 25);
            chb_data.TabIndex = 4;
            chb_data.TabStop = true;
            chb_data.Text = "Data";
            chb_data.UnCheckedColor = Color.FromArgb(104, 110, 134);
            chb_data.UseVisualStyleBackColor = true;
            // 
            // dt_data
            // 
            dt_data.BackColor = Color.FromArgb(240, 245, 249);
            dt_data.BorderColor = Color.FromArgb(132, 129, 132);
            dt_data.BorderRadius = 15;
            dt_data.BorderSize = 1;
            dt_data.CustomFormat = "dddd,dd-MMMMM-yyyy ";
            dt_data.Customizable = true;
            dt_data.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dt_data.Format = DateTimePickerFormat.Time;
            dt_data.IconColor = Color.FromArgb(245, 124, 37);
            dt_data.Location = new Point(40, 32);
            dt_data.MinimumSize = new Size(120, 25);
            dt_data.Name = "dt_data";
            dt_data.Padding = new Padding(2);
            dt_data.Size = new Size(321, 37);
            dt_data.Style = LED_DPS.Controls.Design.ControlStyle.Glass;
            dt_data.TabIndex = 3;
            dt_data.Value = new DateTime(2023, 3, 21, 13, 35, 0, 0);
            // 
            // FrmOPauto_C
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderColor = Color.FromArgb(245, 124, 37);
            BorderSize = 1;
            Caption = "FrmOPauto_C";
            ClientSize = new Size(960, 450);
            Name = "FrmOPauto_C";
            Padding = new Padding(1);
            Text = "FrmOPauto_C";
            pnlClientArea.ResumeLayout(false);
            pnlClientArea.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RJControls.RJRadioButton chb_Nop;
        private RJControls.RJRadioButton chb_data;
        private RJControls.RJDatePicker dt_data;
    }
}