namespace LED_DPS.Formsa
{
    partial class FrmGraficos
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
            Dth_data_INICIO = new RJControls.RJDatePicker();
            rjLabel3 = new RJControls.RJLabel();
            Btnconsultackd = new RJControls.RJButton();
            Dth_data_FIM = new RJControls.RJDatePicker();
            rjLabel1 = new RJControls.RJLabel();
            rjLabel2 = new RJControls.RJLabel();
            RB_DIA = new RJControls.RJRadioButton();
            RB_MES = new RJControls.RJRadioButton();
            RB_ANO = new RJControls.RJRadioButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            cartesianChart2 = new LiveCharts.WinForms.CartesianChart();
            cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            pnlClientArea.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlClientArea
            // 
            pnlClientArea.BackColor = Color.FromArgb(240, 245, 249);
            pnlClientArea.Controls.Add(tableLayoutPanel1);
            pnlClientArea.Controls.Add(RB_ANO);
            pnlClientArea.Controls.Add(RB_MES);
            pnlClientArea.Controls.Add(RB_DIA);
            pnlClientArea.Controls.Add(rjLabel2);
            pnlClientArea.Controls.Add(rjLabel1);
            pnlClientArea.Controls.Add(Dth_data_FIM);
            pnlClientArea.Controls.Add(Btnconsultackd);
            pnlClientArea.Controls.Add(rjLabel3);
            pnlClientArea.Controls.Add(Dth_data_INICIO);
            pnlClientArea.Location = new Point(1, 41);
            pnlClientArea.Size = new Size(958, 489);
            // 
            // Dth_data_INICIO
            // 
            Dth_data_INICIO.BackColor = Color.FromArgb(240, 245, 249);
            Dth_data_INICIO.BorderColor = Color.FromArgb(132, 129, 132);
            Dth_data_INICIO.BorderRadius = 15;
            Dth_data_INICIO.BorderSize = 1;
            Dth_data_INICIO.CustomFormat = "dddd,dd-MMMMM-yyyy ";
            Dth_data_INICIO.Customizable = true;
            Dth_data_INICIO.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Dth_data_INICIO.Format = DateTimePickerFormat.Time;
            Dth_data_INICIO.IconColor = Color.FromArgb(245, 124, 37);
            Dth_data_INICIO.Location = new Point(18, 34);
            Dth_data_INICIO.MinimumSize = new Size(120, 25);
            Dth_data_INICIO.Name = "Dth_data_INICIO";
            Dth_data_INICIO.Padding = new Padding(2);
            Dth_data_INICIO.Size = new Size(236, 37);
            Dth_data_INICIO.Style = LED_DPS.Controls.Design.ControlStyle.Glass;
            Dth_data_INICIO.TabIndex = 30;
            Dth_data_INICIO.Value = new DateTime(2023, 3, 21, 13, 35, 0, 0);
            // 
            // rjLabel3
            // 
            rjLabel3.AutoSize = true;
            rjLabel3.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel3.ForeColor = Color.FromArgb(132, 129, 132);
            rjLabel3.LinkLabel = false;
            rjLabel3.Location = new Point(18, 111);
            rjLabel3.Name = "rjLabel3";
            rjLabel3.Size = new Size(131, 17);
            rjLabel3.Style = LED_DPS.Controls.Design.LabelStyle.Normal;
            rjLabel3.TabIndex = 49;
            rjLabel3.Text = "Grafico de Produção";
            // 
            // Btnconsultackd
            // 
            Btnconsultackd._1_Size = new Size(75, 46);
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
            Btnconsultackd.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            Btnconsultackd.IconColor = Color.White;
            Btnconsultackd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Btnconsultackd.IconSize = 30;
            Btnconsultackd.Location = new Point(535, 25);
            Btnconsultackd.Name = "Btnconsultackd";
            Btnconsultackd.Size = new Size(75, 46);
            Btnconsultackd.Style = LED_DPS.Controls.Design.ControlStyle.Solid;
            Btnconsultackd.TabIndex = 61;
            Btnconsultackd.UseVisualStyleBackColor = false;
            Btnconsultackd.Click += Btnconsultackd_Click;
            // 
            // Dth_data_FIM
            // 
            Dth_data_FIM.BackColor = Color.FromArgb(240, 245, 249);
            Dth_data_FIM.BorderColor = Color.FromArgb(132, 129, 132);
            Dth_data_FIM.BorderRadius = 15;
            Dth_data_FIM.BorderSize = 1;
            Dth_data_FIM.CustomFormat = "dddd,dd-MMMMM-yyyy ";
            Dth_data_FIM.Customizable = true;
            Dth_data_FIM.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Dth_data_FIM.Format = DateTimePickerFormat.Time;
            Dth_data_FIM.IconColor = Color.FromArgb(245, 124, 37);
            Dth_data_FIM.Location = new Point(281, 34);
            Dth_data_FIM.MinimumSize = new Size(120, 25);
            Dth_data_FIM.Name = "Dth_data_FIM";
            Dth_data_FIM.Padding = new Padding(2);
            Dth_data_FIM.Size = new Size(236, 37);
            Dth_data_FIM.Style = LED_DPS.Controls.Design.ControlStyle.Glass;
            Dth_data_FIM.TabIndex = 62;
            Dth_data_FIM.Value = new DateTime(2023, 3, 21, 13, 35, 0, 0);
            // 
            // rjLabel1
            // 
            rjLabel1.AutoSize = true;
            rjLabel1.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel1.ForeColor = Color.FromArgb(132, 129, 132);
            rjLabel1.LinkLabel = false;
            rjLabel1.Location = new Point(18, 14);
            rjLabel1.Name = "rjLabel1";
            rjLabel1.Size = new Size(148, 17);
            rjLabel1.Style = LED_DPS.Controls.Design.LabelStyle.Normal;
            rjLabel1.TabIndex = 63;
            rjLabel1.Text = "Data Inicio (Hora Hora)";
            // 
            // rjLabel2
            // 
            rjLabel2.AutoSize = true;
            rjLabel2.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel2.ForeColor = Color.FromArgb(132, 129, 132);
            rjLabel2.LinkLabel = false;
            rjLabel2.Location = new Point(281, 14);
            rjLabel2.Name = "rjLabel2";
            rjLabel2.Size = new Size(68, 17);
            rjLabel2.Style = LED_DPS.Controls.Design.LabelStyle.Normal;
            rjLabel2.TabIndex = 64;
            rjLabel2.Text = "Data Final";
            // 
            // RB_DIA
            // 
            RB_DIA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RB_DIA.AutoSize = true;
            RB_DIA.CheckedColor = Color.FromArgb(245, 124, 37);
            RB_DIA.Customizable = false;
            RB_DIA.Font = new Font("Verdana", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            RB_DIA.ForeColor = Color.FromArgb(132, 129, 132);
            RB_DIA.Location = new Point(855, 10);
            RB_DIA.MinimumSize = new Size(40, 40);
            RB_DIA.Name = "RB_DIA";
            RB_DIA.Padding = new Padding(10, 0, 0, 0);
            RB_DIA.Size = new Size(71, 40);
            RB_DIA.TabIndex = 67;
            RB_DIA.TabStop = true;
            RB_DIA.Text = "Diaria";
            RB_DIA.UnCheckedColor = Color.FromArgb(104, 110, 134);
            RB_DIA.UseVisualStyleBackColor = true;
            // 
            // RB_MES
            // 
            RB_MES.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RB_MES.AutoSize = true;
            RB_MES.CheckedColor = Color.FromArgb(245, 124, 37);
            RB_MES.Customizable = false;
            RB_MES.Font = new Font("Verdana", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            RB_MES.ForeColor = Color.FromArgb(132, 129, 132);
            RB_MES.Location = new Point(855, 46);
            RB_MES.MinimumSize = new Size(40, 40);
            RB_MES.Name = "RB_MES";
            RB_MES.Padding = new Padding(10, 0, 0, 0);
            RB_MES.Size = new Size(80, 40);
            RB_MES.TabIndex = 68;
            RB_MES.TabStop = true;
            RB_MES.Text = "Mensal";
            RB_MES.UnCheckedColor = Color.FromArgb(104, 110, 134);
            RB_MES.UseVisualStyleBackColor = true;
            // 
            // RB_ANO
            // 
            RB_ANO.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RB_ANO.AutoSize = true;
            RB_ANO.CheckedColor = Color.FromArgb(245, 124, 37);
            RB_ANO.Customizable = false;
            RB_ANO.Font = new Font("Verdana", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            RB_ANO.ForeColor = Color.FromArgb(132, 129, 132);
            RB_ANO.Location = new Point(855, 85);
            RB_ANO.MinimumSize = new Size(40, 40);
            RB_ANO.Name = "RB_ANO";
            RB_ANO.Padding = new Padding(10, 0, 0, 0);
            RB_ANO.Size = new Size(60, 40);
            RB_ANO.TabIndex = 70;
            RB_ANO.TabStop = true;
            RB_ANO.Text = "Ano";
            RB_ANO.UnCheckedColor = Color.FromArgb(104, 110, 134);
            RB_ANO.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(cartesianChart2, 0, 1);
            tableLayoutPanel1.Controls.Add(cartesianChart1, 0, 0);
            tableLayoutPanel1.Location = new Point(18, 141);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Size = new Size(930, 336);
            tableLayoutPanel1.TabIndex = 71;
            // 
            // cartesianChart2
            // 
            cartesianChart2.Dock = DockStyle.Fill;
            cartesianChart2.Location = new Point(3, 137);
            cartesianChart2.Name = "cartesianChart2";
            cartesianChart2.Size = new Size(924, 196);
            cartesianChart2.TabIndex = 1;
            cartesianChart2.Text = "cartesianChart2";
            // 
            // cartesianChart1
            // 
            cartesianChart1.Dock = DockStyle.Fill;
            cartesianChart1.Location = new Point(3, 3);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(924, 128);
            cartesianChart1.TabIndex = 0;
            cartesianChart1.Text = "cartesianChart1";
            // 
            // FrmGraficos
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderColor = Color.FromArgb(245, 124, 37);
            BorderSize = 1;
            Caption = "FrmGraficos";
            ClientSize = new Size(960, 531);
            Name = "FrmGraficos";
            Padding = new Padding(1);
            Text = "FrmGraficos";
            Load += FrmGraficos_Load;
            pnlClientArea.ResumeLayout(false);
            pnlClientArea.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private RJControls.RJDatePicker Dth_data_INICIO;
        private RJControls.RJLabel rjLabel3;
        private RJControls.RJButton Btnconsultackd;
        private RJControls.RJLabel rjLabel2;
        private RJControls.RJLabel rjLabel1;
        private RJControls.RJDatePicker Dth_data_FIM;
        private RJControls.RJRadioButton RB_ANO;
        private RJControls.RJRadioButton RB_MES;
        private RJControls.RJRadioButton RB_DIA;
        private TableLayoutPanel tableLayoutPanel1;
        private LiveCharts.WinForms.CartesianChart cartesianChart2;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
    }
}