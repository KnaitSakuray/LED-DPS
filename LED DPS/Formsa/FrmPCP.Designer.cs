namespace LED_DPS.Formsa
{
    partial class FrmPCP
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dt_dataI = new RJControls.RJDatePicker();
            rjLabel1 = new RJControls.RJLabel();
            rjLabel2 = new RJControls.RJLabel();
            rjLabel3 = new RJControls.RJLabel();
            Dgvpcp = new Controls.DataGridViewMini();
            txt_ml = new RJControls.RJtxt();
            Btnconsultackd = new RJControls.RJButton();
            rjLabel4 = new RJControls.RJLabel();
            dt_dataF = new RJControls.RJDatePicker();
            panelData = new Panel();
            panelOp = new Panel();
            panel3 = new Panel();
            rjToggleButton1 = new RJControls.RJToggleButton();
            pnlClientArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgvpcp).BeginInit();
            panelData.SuspendLayout();
            panelOp.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pnlClientArea
            // 
            pnlClientArea.BackColor = Color.FromArgb(240, 245, 249);
            pnlClientArea.Controls.Add(rjToggleButton1);
            pnlClientArea.Controls.Add(panel3);
            pnlClientArea.Controls.Add(Btnconsultackd);
            pnlClientArea.Controls.Add(Dgvpcp);
            pnlClientArea.Controls.Add(rjLabel3);
            pnlClientArea.Location = new Point(1, 41);
            pnlClientArea.Size = new Size(958, 408);
            pnlClientArea.Paint += pnlClientArea_Paint;
            // 
            // dt_dataI
            // 
            dt_dataI.BackColor = Color.FromArgb(240, 245, 249);
            dt_dataI.BorderColor = Color.FromArgb(132, 129, 132);
            dt_dataI.BorderRadius = 15;
            dt_dataI.BorderSize = 1;
            dt_dataI.CustomFormat = "dddd,dd-MMMMM-yyyy ";
            dt_dataI.Customizable = true;
            dt_dataI.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dt_dataI.Format = DateTimePickerFormat.Time;
            dt_dataI.IconColor = Color.FromArgb(245, 124, 37);
            dt_dataI.Location = new Point(12, 27);
            dt_dataI.MinimumSize = new Size(120, 25);
            dt_dataI.Name = "dt_dataI";
            dt_dataI.Padding = new Padding(2);
            dt_dataI.Size = new Size(237, 37);
            dt_dataI.Style = LED_DPS.Controls.Design.ControlStyle.Glass;
            dt_dataI.TabIndex = 28;
            dt_dataI.Value = new DateTime(2023, 6, 27, 0, 0, 0, 0);
            // 
            // rjLabel1
            // 
            rjLabel1.AutoSize = true;
            rjLabel1.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel1.ForeColor = Color.FromArgb(132, 129, 132);
            rjLabel1.LinkLabel = false;
            rjLabel1.Location = new Point(12, 7);
            rjLabel1.Name = "rjLabel1";
            rjLabel1.Size = new Size(72, 17);
            rjLabel1.Style = LED_DPS.Controls.Design.LabelStyle.Normal;
            rjLabel1.TabIndex = 30;
            rjLabel1.Text = "Data Inicio";
            // 
            // rjLabel2
            // 
            rjLabel2.AutoSize = true;
            rjLabel2.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel2.ForeColor = Color.FromArgb(132, 129, 132);
            rjLabel2.LinkLabel = false;
            rjLabel2.Location = new Point(17, 7);
            rjLabel2.Name = "rjLabel2";
            rjLabel2.Size = new Size(102, 17);
            rjLabel2.Style = LED_DPS.Controls.Design.LabelStyle.Normal;
            rjLabel2.TabIndex = 31;
            rjLabel2.Text = "Procura por OP";
            // 
            // rjLabel3
            // 
            rjLabel3.AutoSize = true;
            rjLabel3.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel3.ForeColor = Color.FromArgb(132, 129, 132);
            rjLabel3.LinkLabel = false;
            rjLabel3.Location = new Point(17, 126);
            rjLabel3.Name = "rjLabel3";
            rjLabel3.Size = new Size(133, 17);
            rjLabel3.Style = LED_DPS.Controls.Design.LabelStyle.Normal;
            rjLabel3.TabIndex = 43;
            rjLabel3.Text = "Ordens de Produção";
            // 
            // Dgvpcp
            // 
            Dgvpcp.AllowUserToResizeRows = false;
            Dgvpcp.AlternatingRowsColor = Color.Empty;
            Dgvpcp.AlternatingRowsColorApply = false;
            Dgvpcp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Dgvpcp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Dgvpcp.BackgroundColor = Color.FromArgb(250, 252, 253);
            Dgvpcp.BorderRadius = 15;
            Dgvpcp.BorderStyle = BorderStyle.None;
            Dgvpcp.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Dgvpcp.ColumnHeaderColor = Color.Orange;
            Dgvpcp.ColumnHeaderFont = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            Dgvpcp.ColumnHeaderHeight = 40;
            Dgvpcp.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Orange;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(15, 0, 0, 0);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            Dgvpcp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            Dgvpcp.ColumnHeadersHeight = 40;
            Dgvpcp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            Dgvpcp.ColumnHeaderTextColor = Color.White;
            Dgvpcp.ColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Dgvpcp.Customizable = false;
            Dgvpcp.DgvBackColor = Color.FromArgb(250, 252, 253);
            Dgvpcp.Enabled = false;
            Dgvpcp.EnableHeadersVisualStyles = false;
            Dgvpcp.GridColor = Color.Gainsboro;
            Dgvpcp.Location = new Point(17, 146);
            Dgvpcp.Name = "Dgvpcp";
            Dgvpcp.RightToLeft = RightToLeft.No;
            Dgvpcp.RowHeaderColor = Color.WhiteSmoke;
            Dgvpcp.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(213, 199, 241);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            Dgvpcp.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            Dgvpcp.RowHeadersVisible = false;
            Dgvpcp.RowHeadersWidth = 30;
            Dgvpcp.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            Dgvpcp.RowHeight = 40;
            Dgvpcp.RowsColor = Color.FromArgb(250, 252, 253);
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(250, 252, 253);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Gray;
            dataGridViewCellStyle3.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(213, 199, 241);
            dataGridViewCellStyle3.SelectionForeColor = Color.Gray;
            Dgvpcp.RowsDefaultCellStyle = dataGridViewCellStyle3;
            Dgvpcp.RowsTextColor = Color.Gray;
            Dgvpcp.RowTemplate.Height = 40;
            Dgvpcp.SelectionBackColor = Color.FromArgb(213, 199, 241);
            Dgvpcp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgvpcp.SelectionTextColor = Color.Gray;
            Dgvpcp.Size = new Size(904, 244);
            Dgvpcp.TabIndex = 44;
            // 
            // txt_ml
            // 
            txt_ml._Customizable = false;
            txt_ml.BackColor = Color.FromArgb(240, 245, 249);
            txt_ml.BorderColor = Color.FromArgb(246, 143, 69);
            txt_ml.BorderFocusColor = Color.FromArgb(55, 159, 113);
            txt_ml.BorderRadius = 15;
            txt_ml.BorderSize = 2;
            txt_ml.Font = new Font("Verdana", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txt_ml.ForeColor = Color.FromArgb(132, 129, 132);
            txt_ml.Location = new Point(17, 26);
            txt_ml.MultiLine = false;
            txt_ml.Name = "txt_ml";
            txt_ml.Padding = new Padding(10, 7, 10, 7);
            txt_ml.PasswordChar = false;
            txt_ml.PlaceHolderColor = Color.DarkGray;
            txt_ml.PlaceHolderText = null;
            txt_ml.RightToLeft = RightToLeft.No;
            txt_ml.ScrollBars = ScrollBars.None;
            txt_ml.Size = new Size(150, 31);
            txt_ml.Style = LED_DPS.Controls.Design.TextBoxStyle.MatteBorder;
            txt_ml.TabIndex = 45;
            txt_ml.Texts = "";
            // 
            // Btnconsultackd
            // 
            Btnconsultackd._1_Size = new Size(47, 48);
            Btnconsultackd.BackColor = Color.FromArgb(245, 124, 37);
            Btnconsultackd.BorderColor = Color.FromArgb(245, 124, 37);
            Btnconsultackd.BorderRadius = 15;
            Btnconsultackd.BorderSize = 0;
            Btnconsultackd.Design = LED_DPS.Controls.Design.ButtonDesign.Normal;
            Btnconsultackd.FlatAppearance.BorderSize = 0;
            Btnconsultackd.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, 116, 34);
            Btnconsultackd.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 109, 32);
            Btnconsultackd.FlatStyle = FlatStyle.Flat;
            Btnconsultackd.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            Btnconsultackd.ForeColor = Color.White;
            Btnconsultackd.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            Btnconsultackd.IconColor = Color.White;
            Btnconsultackd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Btnconsultackd.IconSize = 30;
            Btnconsultackd.Location = new Point(874, 92);
            Btnconsultackd.Name = "Btnconsultackd";
            Btnconsultackd.Size = new Size(47, 48);
            Btnconsultackd.Style = LED_DPS.Controls.Design.ControlStyle.Solid;
            Btnconsultackd.TabIndex = 60;
            Btnconsultackd.UseVisualStyleBackColor = false;
            Btnconsultackd.Click += Btnconsultackd_Click;
            // 
            // rjLabel4
            // 
            rjLabel4.AutoSize = true;
            rjLabel4.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel4.ForeColor = Color.FromArgb(132, 129, 132);
            rjLabel4.LinkLabel = false;
            rjLabel4.Location = new Point(268, 7);
            rjLabel4.Name = "rjLabel4";
            rjLabel4.Size = new Size(68, 17);
            rjLabel4.Style = LED_DPS.Controls.Design.LabelStyle.Normal;
            rjLabel4.TabIndex = 62;
            rjLabel4.Text = "Data Final";
            // 
            // dt_dataF
            // 
            dt_dataF.BackColor = Color.FromArgb(240, 245, 249);
            dt_dataF.BorderColor = Color.FromArgb(132, 129, 132);
            dt_dataF.BorderRadius = 15;
            dt_dataF.BorderSize = 1;
            dt_dataF.CustomFormat = "dddd,dd-MMMMM-yyyy ";
            dt_dataF.Customizable = true;
            dt_dataF.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dt_dataF.Format = DateTimePickerFormat.Time;
            dt_dataF.IconColor = Color.FromArgb(245, 124, 37);
            dt_dataF.Location = new Point(268, 27);
            dt_dataF.MinimumSize = new Size(120, 25);
            dt_dataF.Name = "dt_dataF";
            dt_dataF.Padding = new Padding(2);
            dt_dataF.Size = new Size(237, 37);
            dt_dataF.Style = LED_DPS.Controls.Design.ControlStyle.Glass;
            dt_dataF.TabIndex = 61;
            dt_dataF.Value = new DateTime(2023, 6, 27, 0, 0, 0, 0);
            dt_dataF.OnValueChanged += Btnconsultackd_Click;
            // 
            // panelData
            // 
            panelData.Controls.Add(rjLabel4);
            panelData.Controls.Add(dt_dataF);
            panelData.Controls.Add(rjLabel1);
            panelData.Controls.Add(dt_dataI);
            panelData.Dock = DockStyle.Left;
            panelData.Location = new Point(0, 0);
            panelData.Name = "panelData";
            panelData.Size = new Size(562, 79);
            panelData.TabIndex = 63;
            // 
            // panelOp
            // 
            panelOp.Controls.Add(txt_ml);
            panelOp.Controls.Add(rjLabel2);
            panelOp.Dock = DockStyle.Left;
            panelOp.Location = new Point(562, 0);
            panelOp.Name = "panelOp";
            panelOp.Size = new Size(193, 79);
            panelOp.TabIndex = 64;
            panelOp.Visible = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(panelOp);
            panel3.Controls.Add(panelData);
            panel3.Location = new Point(17, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(799, 79);
            panel3.TabIndex = 65;
            // 
            // rjToggleButton1
            // 
            rjToggleButton1.Activated = true;
            rjToggleButton1.AutoSize = true;
            rjToggleButton1.Checked = true;
            rjToggleButton1.CheckState = CheckState.Checked;
            rjToggleButton1.Customizable = false;
            rjToggleButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rjToggleButton1.Location = new Point(17, 92);
            rjToggleButton1.MinimumSize = new Size(250, 30);
            rjToggleButton1.Name = "rjToggleButton1";
            rjToggleButton1.OFF_BackBorderColor = Color.FromArgb(171, 171, 171);
            rjToggleButton1.OFF_Text = "Busca por OP";
            rjToggleButton1.OFF_TextColor = Color.Gray;
            rjToggleButton1.OFF_ToggleColor = Color.FromArgb(171, 171, 171);
            rjToggleButton1.ON_BackBorderColor = Color.FromArgb(245, 124, 37);
            rjToggleButton1.ON_Text = "Busca por Data";
            rjToggleButton1.ON_TextColor = Color.FromArgb(132, 129, 132);
            rjToggleButton1.ON_ToggleColor = Color.FromArgb(245, 124, 37);
            rjToggleButton1.Size = new Size(250, 30);
            rjToggleButton1.Style = LED_DPS.Controls.Design.ControlStyle.Glass;
            rjToggleButton1.TabIndex = 66;
            rjToggleButton1.Text = "#";
            rjToggleButton1.UseVisualStyleBackColor = true;
            rjToggleButton1.CheckedChanged += rjToggleButton1_CheckedChanged;
            // 
            // FrmPCP
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderColor = Color.FromArgb(245, 124, 37);
            BorderSize = 1;
            Caption = "FrmPCP";
            ClientSize = new Size(960, 450);
            Name = "FrmPCP";
            Padding = new Padding(1);
            Text = "FrmPCP";
            Load += FrmPCP_Load;
            pnlClientArea.ResumeLayout(false);
            pnlClientArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Dgvpcp).EndInit();
            panelData.ResumeLayout(false);
            panelData.PerformLayout();
            panelOp.ResumeLayout(false);
            panelOp.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private RJControls.RJDatePicker dt_dataI;
        private RJControls.RJLabel rjLabel2;
        private RJControls.RJLabel rjLabel1;
        private RJControls.RJLabel rjLabel3;
        private Controls.DataGridViewMini Dgvpcp;
        private RJControls.RJtxt txt_ml;
        private RJControls.RJButton Btnconsultackd;
        private RJControls.RJLabel rjLabel4;
        private RJControls.RJDatePicker dt_dataF;
        private Panel panel3;
        private Panel panelOp;
        private Panel panelData;
        private RJControls.RJToggleButton rjToggleButton1;
    }
}