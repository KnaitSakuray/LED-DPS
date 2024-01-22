namespace LED_DPS.Formsa
{
    partial class FrmConsultaML
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
            rjLabel6 = new RJControls.RJLabel();
            txt_modelo = new RJControls.RJTextBox();
            txt_dataH = new RJControls.RJTextBox();
            txt_linha = new RJControls.RJTextBox();
            txt_op = new RJControls.RJTextBox();
            rjLabel5 = new RJControls.RJLabel();
            rjLabel4 = new RJControls.RJLabel();
            rjLabel3 = new RJControls.RJLabel();
            rjLabel2 = new RJControls.RJLabel();
            rjLabel1 = new RJControls.RJLabel();
            txt_qtd = new RJControls.RJTextBox();
            rjPanel1 = new RJControls.RJPanel();
            dgv_sn = new Controls.DataGridViewMini();
            txt_consulta = new RJControls.RJTextBox();
            Btn_consultaML = new RJControls.RJButton();
            pnlClientArea.SuspendLayout();
            rjPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_sn).BeginInit();
            SuspendLayout();
            // 
            // pnlClientArea
            // 
            pnlClientArea.BackColor = Color.FromArgb(240, 245, 249);
            pnlClientArea.Controls.Add(Btn_consultaML);
            pnlClientArea.Controls.Add(txt_consulta);
            pnlClientArea.Controls.Add(dgv_sn);
            pnlClientArea.Controls.Add(rjPanel1);
            pnlClientArea.Controls.Add(rjLabel6);
            pnlClientArea.Location = new Point(1, 41);
            pnlClientArea.Size = new Size(958, 408);
            // 
            // rjLabel6
            // 
            rjLabel6.Anchor = AnchorStyles.None;
            rjLabel6.AutoSize = true;
            rjLabel6.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel6.ForeColor = Color.FromArgb(132, 129, 132);
            rjLabel6.LinkLabel = false;
            rjLabel6.Location = new Point(231, 15);
            rjLabel6.Name = "rjLabel6";
            rjLabel6.Size = new Size(85, 17);
            rjLabel6.Style = LED_DPS.Controls.Design.LabelStyle.Normal;
            rjLabel6.TabIndex = 42;
            rjLabel6.Text = "Master Label";
            // 
            // txt_modelo
            // 
            txt_modelo._Customizable = false;
            txt_modelo.BackColor = Color.FromArgb(240, 245, 249);
            txt_modelo.BorderColor = Color.FromArgb(132, 129, 132);
            txt_modelo.BorderFocusColor = Color.FromArgb(246, 143, 69);
            txt_modelo.BorderRadius = 15;
            txt_modelo.BorderSize = 2;
            txt_modelo.Enabled = false;
            txt_modelo.Font = new Font("Verdana", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txt_modelo.ForeColor = Color.FromArgb(132, 129, 132);
            txt_modelo.Location = new Point(10, 123);
            txt_modelo.MultiLine = false;
            txt_modelo.Name = "txt_modelo";
            txt_modelo.Padding = new Padding(10, 7, 10, 7);
            txt_modelo.PasswordChar = false;
            txt_modelo.PlaceHolderColor = Color.DarkGray;
            txt_modelo.PlaceHolderText = null;
            txt_modelo.ScrollBars = ScrollBars.None;
            txt_modelo.Size = new Size(167, 31);
            txt_modelo.Style = LED_DPS.Controls.Design.TextBoxStyle.MatteBorder;
            txt_modelo.TabIndex = 56;
            // 
            // txt_dataH
            // 
            txt_dataH._Customizable = false;
            txt_dataH.BackColor = Color.FromArgb(240, 245, 249);
            txt_dataH.BorderColor = Color.FromArgb(132, 129, 132);
            txt_dataH.BorderFocusColor = Color.FromArgb(246, 143, 69);
            txt_dataH.BorderRadius = 15;
            txt_dataH.BorderSize = 2;
            txt_dataH.Enabled = false;
            txt_dataH.Font = new Font("Verdana", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txt_dataH.ForeColor = Color.FromArgb(132, 129, 132);
            txt_dataH.Location = new Point(298, 31);
            txt_dataH.MultiLine = false;
            txt_dataH.Name = "txt_dataH";
            txt_dataH.Padding = new Padding(10, 7, 10, 7);
            txt_dataH.PasswordChar = false;
            txt_dataH.PlaceHolderColor = Color.DarkGray;
            txt_dataH.PlaceHolderText = null;
            txt_dataH.ScrollBars = ScrollBars.None;
            txt_dataH.Size = new Size(210, 31);
            txt_dataH.Style = LED_DPS.Controls.Design.TextBoxStyle.MatteBorder;
            txt_dataH.TabIndex = 55;
            // 
            // txt_linha
            // 
            txt_linha._Customizable = false;
            txt_linha.BackColor = Color.FromArgb(240, 245, 249);
            txt_linha.BorderColor = Color.FromArgb(132, 129, 132);
            txt_linha.BorderFocusColor = Color.FromArgb(246, 143, 69);
            txt_linha.BorderRadius = 15;
            txt_linha.BorderSize = 2;
            txt_linha.Enabled = false;
            txt_linha.Font = new Font("Verdana", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txt_linha.ForeColor = Color.FromArgb(132, 129, 132);
            txt_linha.Location = new Point(178, 31);
            txt_linha.MultiLine = false;
            txt_linha.Name = "txt_linha";
            txt_linha.Padding = new Padding(10, 7, 10, 7);
            txt_linha.PasswordChar = false;
            txt_linha.PlaceHolderColor = Color.DarkGray;
            txt_linha.PlaceHolderText = null;
            txt_linha.ScrollBars = ScrollBars.None;
            txt_linha.Size = new Size(83, 31);
            txt_linha.Style = LED_DPS.Controls.Design.TextBoxStyle.MatteBorder;
            txt_linha.TabIndex = 54;
            // 
            // txt_op
            // 
            txt_op._Customizable = false;
            txt_op.BackColor = Color.FromArgb(240, 245, 249);
            txt_op.BorderColor = Color.FromArgb(132, 129, 132);
            txt_op.BorderFocusColor = Color.FromArgb(246, 143, 69);
            txt_op.BorderRadius = 15;
            txt_op.BorderSize = 2;
            txt_op.Enabled = false;
            txt_op.Font = new Font("Verdana", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txt_op.ForeColor = Color.FromArgb(132, 129, 132);
            txt_op.Location = new Point(10, 31);
            txt_op.MultiLine = false;
            txt_op.Name = "txt_op";
            txt_op.Padding = new Padding(10, 7, 10, 7);
            txt_op.PasswordChar = false;
            txt_op.PlaceHolderColor = Color.DarkGray;
            txt_op.PlaceHolderText = null;
            txt_op.ScrollBars = ScrollBars.None;
            txt_op.Size = new Size(113, 31);
            txt_op.Style = LED_DPS.Controls.Design.TextBoxStyle.MatteBorder;
            txt_op.TabIndex = 53;
            // 
            // rjLabel5
            // 
            rjLabel5.AutoSize = true;
            rjLabel5.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel5.ForeColor = Color.FromArgb(132, 129, 132);
            rjLabel5.LinkLabel = false;
            rjLabel5.Location = new Point(270, 103);
            rjLabel5.Name = "rjLabel5";
            rjLabel5.Size = new Size(79, 17);
            rjLabel5.Style = LED_DPS.Controls.Design.LabelStyle.Normal;
            rjLabel5.TabIndex = 52;
            rjLabel5.Text = "Quantidade";
            // 
            // rjLabel4
            // 
            rjLabel4.AutoSize = true;
            rjLabel4.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel4.ForeColor = Color.FromArgb(132, 129, 132);
            rjLabel4.LinkLabel = false;
            rjLabel4.Location = new Point(298, 11);
            rjLabel4.Name = "rjLabel4";
            rjLabel4.Size = new Size(71, 17);
            rjLabel4.Style = LED_DPS.Controls.Design.LabelStyle.Normal;
            rjLabel4.TabIndex = 50;
            rjLabel4.Text = "Data/Hora";
            // 
            // rjLabel3
            // 
            rjLabel3.AutoSize = true;
            rjLabel3.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel3.ForeColor = Color.FromArgb(132, 129, 132);
            rjLabel3.LinkLabel = false;
            rjLabel3.Location = new Point(186, 11);
            rjLabel3.Name = "rjLabel3";
            rjLabel3.Size = new Size(40, 17);
            rjLabel3.Style = LED_DPS.Controls.Design.LabelStyle.Normal;
            rjLabel3.TabIndex = 48;
            rjLabel3.Text = "Linha";
            // 
            // rjLabel2
            // 
            rjLabel2.AutoSize = true;
            rjLabel2.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel2.ForeColor = Color.FromArgb(132, 129, 132);
            rjLabel2.LinkLabel = false;
            rjLabel2.Location = new Point(10, 103);
            rjLabel2.Name = "rjLabel2";
            rjLabel2.Size = new Size(54, 17);
            rjLabel2.Style = LED_DPS.Controls.Design.LabelStyle.Normal;
            rjLabel2.TabIndex = 46;
            rjLabel2.Text = "Modelo";
            // 
            // rjLabel1
            // 
            rjLabel1.AutoSize = true;
            rjLabel1.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel1.ForeColor = Color.FromArgb(132, 129, 132);
            rjLabel1.LinkLabel = false;
            rjLabel1.Location = new Point(10, 11);
            rjLabel1.Name = "rjLabel1";
            rjLabel1.Size = new Size(26, 17);
            rjLabel1.Style = LED_DPS.Controls.Design.LabelStyle.Normal;
            rjLabel1.TabIndex = 44;
            rjLabel1.Text = "OP";
            // 
            // txt_qtd
            // 
            txt_qtd._Customizable = false;
            txt_qtd.AllowDrop = true;
            txt_qtd.BackColor = Color.FromArgb(240, 245, 249);
            txt_qtd.BorderColor = Color.FromArgb(132, 129, 132);
            txt_qtd.BorderFocusColor = Color.FromArgb(246, 143, 69);
            txt_qtd.BorderRadius = 15;
            txt_qtd.BorderSize = 2;
            txt_qtd.Enabled = false;
            txt_qtd.Font = new Font("Verdana", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txt_qtd.ForeColor = Color.FromArgb(132, 129, 132);
            txt_qtd.Location = new Point(270, 123);
            txt_qtd.MultiLine = false;
            txt_qtd.Name = "txt_qtd";
            txt_qtd.Padding = new Padding(10, 7, 10, 7);
            txt_qtd.PasswordChar = false;
            txt_qtd.PlaceHolderColor = Color.DarkGray;
            txt_qtd.PlaceHolderText = null;
            txt_qtd.ScrollBars = ScrollBars.None;
            txt_qtd.Size = new Size(94, 31);
            txt_qtd.Style = LED_DPS.Controls.Design.TextBoxStyle.MatteBorder;
            txt_qtd.TabIndex = 56;
            // 
            // rjPanel1
            // 
            rjPanel1.Anchor = AnchorStyles.None;
            rjPanel1.BackColor = Color.FromArgb(250, 252, 253);
            rjPanel1.BorderRadius = 0;
            rjPanel1.Controls.Add(rjLabel1);
            rjPanel1.Controls.Add(txt_modelo);
            rjPanel1.Controls.Add(txt_op);
            rjPanel1.Controls.Add(rjLabel3);
            rjPanel1.Controls.Add(txt_qtd);
            rjPanel1.Controls.Add(txt_dataH);
            rjPanel1.Controls.Add(txt_linha);
            rjPanel1.Controls.Add(rjLabel5);
            rjPanel1.Controls.Add(rjLabel4);
            rjPanel1.Controls.Add(rjLabel2);
            rjPanel1.Customizable = false;
            rjPanel1.Location = new Point(40, 86);
            rjPanel1.Name = "rjPanel1";
            rjPanel1.Size = new Size(521, 194);
            rjPanel1.TabIndex = 58;
            // 
            // dgv_sn
            // 
            dgv_sn.AllowUserToResizeRows = false;
            dgv_sn.AlternatingRowsColor = Color.Empty;
            dgv_sn.AlternatingRowsColorApply = false;
            dgv_sn.Anchor = AnchorStyles.None;
            dgv_sn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_sn.BackgroundColor = Color.FromArgb(250, 252, 253);
            dgv_sn.BorderRadius = 15;
            dgv_sn.BorderStyle = BorderStyle.None;
            dgv_sn.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_sn.ColumnHeaderColor = Color.Orange;
            dgv_sn.ColumnHeaderFont = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dgv_sn.ColumnHeaderHeight = 40;
            dgv_sn.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Orange;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(15, 0, 0, 0);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_sn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_sn.ColumnHeadersHeight = 40;
            dgv_sn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv_sn.ColumnHeaderTextColor = Color.White;
            dgv_sn.ColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_sn.Customizable = false;
            dgv_sn.DgvBackColor = Color.FromArgb(250, 252, 253);
            dgv_sn.EnableHeadersVisualStyles = false;
            dgv_sn.GridColor = Color.Gainsboro;
            dgv_sn.Location = new Point(567, 18);
            dgv_sn.Name = "dgv_sn";
            dgv_sn.ReadOnly = true;
            dgv_sn.RightToLeft = RightToLeft.No;
            dgv_sn.RowHeaderColor = Color.WhiteSmoke;
            dgv_sn.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(213, 199, 241);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_sn.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_sn.RowHeadersVisible = false;
            dgv_sn.RowHeadersWidth = 30;
            dgv_sn.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_sn.RowHeight = 40;
            dgv_sn.RowsColor = Color.FromArgb(250, 252, 253);
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(250, 252, 253);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Gray;
            dataGridViewCellStyle3.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(213, 199, 241);
            dataGridViewCellStyle3.SelectionForeColor = Color.Gray;
            dgv_sn.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgv_sn.RowsTextColor = Color.Gray;
            dgv_sn.RowTemplate.Height = 40;
            dgv_sn.SelectionBackColor = Color.FromArgb(213, 199, 241);
            dgv_sn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_sn.SelectionTextColor = Color.Gray;
            dgv_sn.Size = new Size(369, 368);
            dgv_sn.TabIndex = 60;
            // 
            // txt_consulta
            // 
            txt_consulta._Customizable = false;
            txt_consulta.AllowDrop = true;
            txt_consulta.Anchor = AnchorStyles.None;
            txt_consulta.BackColor = Color.FromArgb(240, 245, 249);
            txt_consulta.BorderColor = Color.FromArgb(132, 129, 132);
            txt_consulta.BorderFocusColor = Color.FromArgb(246, 143, 69);
            txt_consulta.BorderRadius = 15;
            txt_consulta.BorderSize = 2;
            txt_consulta.Font = new Font("Verdana", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txt_consulta.ForeColor = Color.FromArgb(132, 129, 132);
            txt_consulta.Location = new Point(218, 35);
            txt_consulta.MultiLine = false;
            txt_consulta.Name = "txt_consulta";
            txt_consulta.Padding = new Padding(10, 7, 10, 7);
            txt_consulta.PasswordChar = false;
            txt_consulta.PlaceHolderColor = Color.DarkGray;
            txt_consulta.PlaceHolderText = null;
            txt_consulta.ScrollBars = ScrollBars.None;
            txt_consulta.Size = new Size(105, 31);
            txt_consulta.Style = LED_DPS.Controls.Design.TextBoxStyle.MatteBorder;
            txt_consulta.TabIndex = 61;
            txt_consulta.KeyPress += txt_consulta_KeyPress;
            // 
            // Btn_consultaML
            // 
            Btn_consultaML._1_Size = new Size(47, 48);
            Btn_consultaML.Anchor = AnchorStyles.None;
            Btn_consultaML.BackColor = Color.FromArgb(245, 124, 37);
            Btn_consultaML.BorderColor = Color.FromArgb(245, 124, 37);
            Btn_consultaML.BorderRadius = 15;
            Btn_consultaML.BorderSize = 0;
            Btn_consultaML.Design = LED_DPS.Controls.Design.ButtonDesign.Normal;
            Btn_consultaML.FlatAppearance.BorderSize = 0;
            Btn_consultaML.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, 116, 34);
            Btn_consultaML.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 109, 32);
            Btn_consultaML.FlatStyle = FlatStyle.Flat;
            Btn_consultaML.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_consultaML.ForeColor = Color.White;
            Btn_consultaML.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            Btn_consultaML.IconColor = Color.White;
            Btn_consultaML.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Btn_consultaML.IconSize = 30;
            Btn_consultaML.Location = new Point(424, 18);
            Btn_consultaML.Name = "Btn_consultaML";
            Btn_consultaML.Size = new Size(47, 48);
            Btn_consultaML.Style = LED_DPS.Controls.Design.ControlStyle.Solid;
            Btn_consultaML.TabIndex = 62;
            Btn_consultaML.UseVisualStyleBackColor = false;
            Btn_consultaML.Click += Btn_consultaML_Click;
            // 
            // FrmConsultaML
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderColor = Color.FromArgb(245, 124, 37);
            BorderSize = 1;
            Caption = "FrmConsultaML";
            ClientSize = new Size(960, 450);
            Name = "FrmConsultaML";
            Padding = new Padding(1);
            Text = "FrmConsultaML";
            pnlClientArea.ResumeLayout(false);
            pnlClientArea.PerformLayout();
            rjPanel1.ResumeLayout(false);
            rjPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_sn).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private RJControls.RJLabel rjLabel6;
        private RJControls.RJLabel rjLabel5;
        private RJControls.RJLabel rjLabel4;
        private RJControls.RJLabel rjLabel3;
        private RJControls.RJLabel rjLabel2;
        private RJControls.RJLabel rjLabel1;
        private RJControls.RJTextBox txt_qtd;
        private RJControls.RJTextBox txt_modelo;
        private RJControls.RJTextBox txt_dataH;
        private RJControls.RJTextBox txt_linha;
        private RJControls.RJTextBox txt_op;
        private RJControls.RJPanel rjPanel1;
        private Controls.DataGridViewMini dgv_sn;
        private RJControls.RJTextBox txt_consulta;
        private RJControls.RJButton Btn_consultaML;
    }
}