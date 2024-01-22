namespace LED_DPS.Formsa
{
    partial class FrmOPmanual_C
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
            dgv_op = new Controls.DataGridViewMini();
            chb_finalizado = new RJControls.RJRadioButton();
            chb_pendente = new RJControls.RJRadioButton();
            rjLabel5 = new RJControls.RJLabel();
            txt_descricao = new RJControls.RJTextBox();
            btn_atualizar = new RJControls.RJButton();
            btn_cadastro = new RJControls.RJButton();
            rjLabel4 = new RJControls.RJLabel();
            txt_qtd = new RJControls.RJTextBox();
            rjLabel3 = new RJControls.RJLabel();
            dt_data = new RJControls.RJDatePicker();
            rjLabel2 = new RJControls.RJLabel();
            cb_modelo = new RJControls.RJComboBox();
            rjLabel1 = new RJControls.RJLabel();
            txt_Nop = new RJControls.RJTextBox();
            pnlClientArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_op).BeginInit();
            SuspendLayout();
            // 
            // pnlClientArea
            // 
            pnlClientArea.BackColor = Color.FromArgb(240, 245, 249);
            pnlClientArea.Controls.Add(dgv_op);
            pnlClientArea.Controls.Add(chb_finalizado);
            pnlClientArea.Controls.Add(chb_pendente);
            pnlClientArea.Controls.Add(rjLabel5);
            pnlClientArea.Controls.Add(txt_descricao);
            pnlClientArea.Controls.Add(btn_atualizar);
            pnlClientArea.Controls.Add(btn_cadastro);
            pnlClientArea.Controls.Add(rjLabel4);
            pnlClientArea.Controls.Add(txt_qtd);
            pnlClientArea.Controls.Add(rjLabel3);
            pnlClientArea.Controls.Add(dt_data);
            pnlClientArea.Controls.Add(rjLabel2);
            pnlClientArea.Controls.Add(cb_modelo);
            pnlClientArea.Controls.Add(rjLabel1);
            pnlClientArea.Controls.Add(txt_Nop);
            pnlClientArea.Location = new Point(1, 41);
            pnlClientArea.Size = new Size(958, 408);
            pnlClientArea.Paint += pnlClientArea_Paint;
            // 
            // dgv_op
            // 
            dgv_op.AllowUserToResizeRows = false;
            dgv_op.AlternatingRowsColor = Color.Empty;
            dgv_op.AlternatingRowsColorApply = false;
            dgv_op.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_op.BackgroundColor = Color.FromArgb(250, 252, 253);
            dgv_op.BorderRadius = 15;
            dgv_op.BorderStyle = BorderStyle.None;
            dgv_op.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_op.ColumnHeaderColor = Color.Orange;
            dgv_op.ColumnHeaderFont = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dgv_op.ColumnHeaderHeight = 40;
            dgv_op.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Orange;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(15, 0, 0, 0);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_op.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_op.ColumnHeadersHeight = 40;
            dgv_op.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv_op.ColumnHeaderTextColor = Color.White;
            dgv_op.ColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_op.Customizable = false;
            dgv_op.DgvBackColor = Color.FromArgb(250, 252, 253);
            dgv_op.EnableHeadersVisualStyles = false;
            dgv_op.GridColor = Color.Gainsboro;
            dgv_op.Location = new Point(26, 243);
            dgv_op.Name = "dgv_op";
            dgv_op.RightToLeft = RightToLeft.No;
            dgv_op.RowHeaderColor = Color.WhiteSmoke;
            dgv_op.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(213, 199, 241);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_op.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_op.RowHeadersVisible = false;
            dgv_op.RowHeadersWidth = 30;
            dgv_op.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_op.RowHeight = 40;
            dgv_op.RowsColor = Color.FromArgb(250, 252, 253);
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(250, 252, 253);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Gray;
            dataGridViewCellStyle3.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(213, 199, 241);
            dataGridViewCellStyle3.SelectionForeColor = Color.Gray;
            dgv_op.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgv_op.RowsTextColor = Color.Gray;
            dgv_op.RowTemplate.Height = 40;
            dgv_op.SelectionBackColor = Color.FromArgb(213, 199, 241);
            dgv_op.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_op.SelectionTextColor = Color.Gray;
            dgv_op.Size = new Size(873, 327);
            dgv_op.TabIndex = 37;
            // 
            // chb_finalizado
            // 
            chb_finalizado.AutoSize = true;
            chb_finalizado.CheckedColor = Color.FromArgb(245, 124, 37);
            chb_finalizado.Customizable = false;
            chb_finalizado.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chb_finalizado.ForeColor = Color.FromArgb(132, 129, 132);
            chb_finalizado.Location = new Point(749, 66);
            chb_finalizado.MinimumSize = new Size(0, 21);
            chb_finalizado.Name = "chb_finalizado";
            chb_finalizado.Padding = new Padding(10, 0, 0, 0);
            chb_finalizado.Size = new Size(110, 25);
            chb_finalizado.TabIndex = 36;
            chb_finalizado.Text = "Finalizado";
            chb_finalizado.UnCheckedColor = Color.FromArgb(104, 110, 134);
            chb_finalizado.UseVisualStyleBackColor = true;
            chb_finalizado.CheckedChanged += chb_finalizado_CheckedChanged;
            // 
            // chb_pendente
            // 
            chb_pendente.AutoSize = true;
            chb_pendente.Checked = true;
            chb_pendente.CheckedColor = Color.FromArgb(245, 124, 37);
            chb_pendente.Customizable = false;
            chb_pendente.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chb_pendente.ForeColor = Color.FromArgb(132, 129, 132);
            chb_pendente.Location = new Point(749, 31);
            chb_pendente.MinimumSize = new Size(0, 21);
            chb_pendente.Name = "chb_pendente";
            chb_pendente.Padding = new Padding(10, 0, 0, 0);
            chb_pendente.Size = new Size(107, 25);
            chb_pendente.TabIndex = 35;
            chb_pendente.TabStop = true;
            chb_pendente.Text = "Pendente";
            chb_pendente.UnCheckedColor = Color.FromArgb(104, 110, 134);
            chb_pendente.UseVisualStyleBackColor = true;
            chb_pendente.CheckedChanged += chb_pendente_CheckedChanged;
            // 
            // rjLabel5
            // 
            rjLabel5.AutoSize = true;
            rjLabel5.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel5.ForeColor = Color.FromArgb(132, 129, 132);
            rjLabel5.LinkLabel = false;
            rjLabel5.Location = new Point(31, 146);
            rjLabel5.Name = "rjLabel5";
            rjLabel5.Size = new Size(65, 17);
            rjLabel5.Style = LED_DPS.Controls.Design.LabelStyle.Normal;
            rjLabel5.TabIndex = 34;
            rjLabel5.Text = "Descrição";
            // 
            // txt_descricao
            // 
            txt_descricao._Customizable = false;
            txt_descricao.BackColor = Color.FromArgb(240, 245, 249);
            txt_descricao.BorderColor = Color.FromArgb(132, 129, 132);
            txt_descricao.BorderFocusColor = Color.FromArgb(246, 143, 69);
            txt_descricao.BorderRadius = 15;
            txt_descricao.BorderSize = 2;
            txt_descricao.Font = new Font("Verdana", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txt_descricao.ForeColor = Color.FromArgb(132, 129, 132);
            txt_descricao.Location = new Point(31, 170);
            txt_descricao.MultiLine = false;
            txt_descricao.Name = "txt_descricao";
            txt_descricao.Padding = new Padding(10, 7, 10, 7);
            txt_descricao.PasswordChar = false;
            txt_descricao.PlaceHolderColor = Color.DarkGray;
            txt_descricao.PlaceHolderText = null;
            txt_descricao.ScrollBars = ScrollBars.None;
            txt_descricao.Size = new Size(611, 31);
            txt_descricao.Style = LED_DPS.Controls.Design.TextBoxStyle.MatteBorder;
            txt_descricao.TabIndex = 33;
            // 
            // btn_atualizar
            // 
            btn_atualizar._1_Size = new Size(78, 70);
            btn_atualizar.BackColor = Color.FromArgb(245, 124, 37);
            btn_atualizar.BorderColor = Color.FromArgb(245, 124, 37);
            btn_atualizar.BorderRadius = 15;
            btn_atualizar.BorderSize = 0;
            btn_atualizar.Design = LED_DPS.Controls.Design.ButtonDesign.Normal;
            btn_atualizar.FlatAppearance.BorderSize = 0;
            btn_atualizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, 116, 34);
            btn_atualizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 109, 32);
            btn_atualizar.FlatStyle = FlatStyle.Flat;
            btn_atualizar.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btn_atualizar.ForeColor = Color.White;
            btn_atualizar.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateBackward;
            btn_atualizar.IconColor = Color.White;
            btn_atualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_atualizar.IconSize = 80;
            btn_atualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_atualizar.Location = new Point(707, 167);
            btn_atualizar.Name = "btn_atualizar";
            btn_atualizar.Size = new Size(78, 70);
            btn_atualizar.Style = LED_DPS.Controls.Design.ControlStyle.Solid;
            btn_atualizar.TabIndex = 32;
            btn_atualizar.UseVisualStyleBackColor = false;
            btn_atualizar.Click += btn_atualizar_Click;
            // 
            // btn_cadastro
            // 
            btn_cadastro._1_Size = new Size(78, 68);
            btn_cadastro.BackColor = Color.FromArgb(245, 124, 37);
            btn_cadastro.BorderColor = Color.FromArgb(245, 124, 37);
            btn_cadastro.BorderRadius = 15;
            btn_cadastro.BorderSize = 0;
            btn_cadastro.Design = LED_DPS.Controls.Design.ButtonDesign.Normal;
            btn_cadastro.FlatAppearance.BorderSize = 0;
            btn_cadastro.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, 116, 34);
            btn_cadastro.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 109, 32);
            btn_cadastro.FlatStyle = FlatStyle.Flat;
            btn_cadastro.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cadastro.ForeColor = Color.White;
            btn_cadastro.IconChar = FontAwesome.Sharp.IconChar.Add;
            btn_cadastro.IconColor = Color.White;
            btn_cadastro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_cadastro.IconSize = 80;
            btn_cadastro.ImageAlign = ContentAlignment.MiddleLeft;
            btn_cadastro.Location = new Point(821, 167);
            btn_cadastro.Name = "btn_cadastro";
            btn_cadastro.Size = new Size(78, 68);
            btn_cadastro.Style = LED_DPS.Controls.Design.ControlStyle.Solid;
            btn_cadastro.TabIndex = 31;
            btn_cadastro.UseVisualStyleBackColor = false;
            btn_cadastro.Click += btn_cadastro_Click;
            // 
            // rjLabel4
            // 
            rjLabel4.AutoSize = true;
            rjLabel4.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel4.ForeColor = Color.FromArgb(132, 129, 132);
            rjLabel4.LinkLabel = false;
            rjLabel4.Location = new Point(390, 9);
            rjLabel4.Name = "rjLabel4";
            rjLabel4.Size = new Size(79, 17);
            rjLabel4.Style = LED_DPS.Controls.Design.LabelStyle.Normal;
            rjLabel4.TabIndex = 30;
            rjLabel4.Text = "Quantidade";
            // 
            // txt_qtd
            // 
            txt_qtd._Customizable = false;
            txt_qtd.BackColor = Color.FromArgb(240, 245, 249);
            txt_qtd.BorderColor = Color.FromArgb(132, 129, 132);
            txt_qtd.BorderFocusColor = Color.FromArgb(246, 143, 69);
            txt_qtd.BorderRadius = 15;
            txt_qtd.BorderSize = 2;
            txt_qtd.Font = new Font("Verdana", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txt_qtd.ForeColor = Color.FromArgb(132, 129, 132);
            txt_qtd.Location = new Point(390, 33);
            txt_qtd.MultiLine = false;
            txt_qtd.Name = "txt_qtd";
            txt_qtd.Padding = new Padding(10, 7, 10, 7);
            txt_qtd.PasswordChar = false;
            txt_qtd.PlaceHolderColor = Color.DarkGray;
            txt_qtd.PlaceHolderText = null;
            txt_qtd.ScrollBars = ScrollBars.None;
            txt_qtd.Size = new Size(106, 31);
            txt_qtd.Style = LED_DPS.Controls.Design.TextBoxStyle.MatteBorder;
            txt_qtd.TabIndex = 29;
            // 
            // rjLabel3
            // 
            rjLabel3.AutoSize = true;
            rjLabel3.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel3.ForeColor = Color.FromArgb(132, 129, 132);
            rjLabel3.LinkLabel = false;
            rjLabel3.Location = new Point(390, 67);
            rjLabel3.Name = "rjLabel3";
            rjLabel3.Size = new Size(109, 17);
            rjLabel3.Style = LED_DPS.Controls.Design.LabelStyle.Normal;
            rjLabel3.TabIndex = 28;
            rjLabel3.Text = "Data de Inclusão";
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
            dt_data.Location = new Point(390, 91);
            dt_data.MinimumSize = new Size(120, 25);
            dt_data.Name = "dt_data";
            dt_data.Padding = new Padding(2);
            dt_data.Size = new Size(252, 37);
            dt_data.Style = LED_DPS.Controls.Design.ControlStyle.Glass;
            dt_data.TabIndex = 27;
            dt_data.Value = new DateTime(2023, 3, 21, 13, 35, 0, 0);
            // 
            // rjLabel2
            // 
            rjLabel2.AutoSize = true;
            rjLabel2.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel2.ForeColor = Color.FromArgb(132, 129, 132);
            rjLabel2.LinkLabel = false;
            rjLabel2.Location = new Point(31, 72);
            rjLabel2.Name = "rjLabel2";
            rjLabel2.Size = new Size(54, 17);
            rjLabel2.Style = LED_DPS.Controls.Design.LabelStyle.Normal;
            rjLabel2.TabIndex = 26;
            rjLabel2.Text = "Modelo";
            // 
            // cb_modelo
            // 
            cb_modelo.AutoCompleteMode = AutoCompleteMode.None;
            cb_modelo.AutoCompleteSource = AutoCompleteSource.None;
            cb_modelo.BackColor = Color.FromArgb(240, 245, 249);
            cb_modelo.BorderColor = Color.FromArgb(132, 129, 132);
            cb_modelo.BorderRadius = 15;
            cb_modelo.BorderSize = 1;
            cb_modelo.Customizable = false;
            cb_modelo.DataSource = null;
            cb_modelo.DropDownBackColor = Color.FromArgb(250, 252, 253);
            cb_modelo.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_modelo.DropDownTextColor = Color.FromArgb(132, 129, 132);
            cb_modelo.IconColor = Color.FromArgb(245, 124, 37);
            cb_modelo.Location = new Point(31, 95);
            cb_modelo.Name = "cb_modelo";
            cb_modelo.Padding = new Padding(2);
            cb_modelo.SelectedIndex = -1;
            cb_modelo.Size = new Size(200, 32);
            cb_modelo.Style = LED_DPS.Controls.Design.ControlStyle.Glass;
            cb_modelo.TabIndex = 25;
            cb_modelo.Texts = "";
            cb_modelo.OnSelectedIndexChanged += cb_modelo_OnSelectedIndexChanged;
            // 
            // rjLabel1
            // 
            rjLabel1.AutoSize = true;
            rjLabel1.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel1.ForeColor = Color.FromArgb(132, 129, 132);
            rjLabel1.LinkLabel = false;
            rjLabel1.Location = new Point(31, 9);
            rjLabel1.Name = "rjLabel1";
            rjLabel1.Size = new Size(80, 17);
            rjLabel1.Style = LED_DPS.Controls.Design.LabelStyle.Normal;
            rjLabel1.TabIndex = 24;
            rjLabel1.Text = "Numero OP";
            // 
            // txt_Nop
            // 
            txt_Nop._Customizable = false;
            txt_Nop.BackColor = Color.FromArgb(240, 245, 249);
            txt_Nop.BorderColor = Color.FromArgb(132, 129, 132);
            txt_Nop.BorderFocusColor = Color.FromArgb(246, 143, 69);
            txt_Nop.BorderRadius = 15;
            txt_Nop.BorderSize = 2;
            txt_Nop.Font = new Font("Verdana", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Nop.ForeColor = Color.FromArgb(132, 129, 132);
            txt_Nop.Location = new Point(31, 33);
            txt_Nop.MultiLine = false;
            txt_Nop.Name = "txt_Nop";
            txt_Nop.Padding = new Padding(10, 7, 10, 7);
            txt_Nop.PasswordChar = false;
            txt_Nop.PlaceHolderColor = Color.DarkGray;
            txt_Nop.PlaceHolderText = null;
            txt_Nop.ScrollBars = ScrollBars.None;
            txt_Nop.Size = new Size(151, 31);
            txt_Nop.Style = LED_DPS.Controls.Design.TextBoxStyle.MatteBorder;
            txt_Nop.TabIndex = 23;
            // 
            // FrmOPmanual_C
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderColor = Color.FromArgb(245, 124, 37);
            BorderSize = 1;
            Caption = "FrmOPmanual_C";
            ClientSize = new Size(960, 450);
            Name = "FrmOPmanual_C";
            Padding = new Padding(1);
            Text = "FrmOPmanual_C";
            Load += FrmOPmanual_C_load_1;
            pnlClientArea.ResumeLayout(false);
            pnlClientArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_op).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Controls.DataGridViewMini dgv_op;
        private RJControls.RJRadioButton chb_finalizado;
        private RJControls.RJRadioButton chb_pendente;
        private RJControls.RJLabel rjLabel5;
        private RJControls.RJTextBox txt_descricao;
        private RJControls.RJButton btn_atualizar;
        private RJControls.RJButton btn_cadastro;
        private RJControls.RJLabel rjLabel4;
        private RJControls.RJTextBox txt_qtd;
        private RJControls.RJLabel rjLabel3;
        private RJControls.RJDatePicker dt_data;
        private RJControls.RJLabel rjLabel2;
        private RJControls.RJComboBox cb_modelo;
        private RJControls.RJLabel rjLabel1;
        private RJControls.RJTextBox txt_Nop;
    }
}