namespace LED_DPS.Formsa
{
    partial class FrmEmbalagem_C
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
            rjPanel2 = new RJControls.RJPanel();
            lblQtdCaixa = new RJControls.RJLabel();
            rjLabel9 = new RJControls.RJLabel();
            btn_frente = new RJControls.RJButton();
            btn_atras = new RJControls.RJButton();
            rjPanel1 = new RJControls.RJPanel();
            lblPorCaixa = new RJControls.RJLabel();
            rjLabel6 = new RJControls.RJLabel();
            rjLabel5 = new RJControls.RJLabel();
            lblAvisos = new RJControls.RJLabel();
            dgv_caixa = new RJControls.RJDataGridView();
            sn = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            txt_sn = new RJControls.RJTextBox();
            rjLabel3 = new RJControls.RJLabel();
            rjLabel2 = new RJControls.RJLabel();
            rjLabel1 = new RJControls.RJLabel();
            cb_op = new RJControls.RJComboBox();
            txtNcaixa = new RJControls.RJTextBox();
            rjLabel10 = new RJControls.RJLabel();
            BtnStatus = new RJControls.RJButton();
            panelTopSide = new Panel();
            lblStatusOP = new RJControls.RJLabel();
            rjLabel7 = new RJControls.RJLabel();
            lblQtdOP = new RJControls.RJLabel();
            lblmodelo = new RJControls.RJLabel();
            cb_linha = new RJControls.RJComboBox();
            rjLabel11 = new RJControls.RJLabel();
            panelBotSide = new Panel();
            rjLabel4 = new RJControls.RJLabel();
            btnDeletarSn = new RJControls.RJButton();
            rjPanel3 = new RJControls.RJPanel();
            lblPendente = new RJControls.RJLabel();
            rjLabel8 = new RJControls.RJLabel();
            btn_imprimir = new RJControls.RJButton();
            pnlClientArea.SuspendLayout();
            rjPanel2.SuspendLayout();
            rjPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_caixa).BeginInit();
            panelTopSide.SuspendLayout();
            panelBotSide.SuspendLayout();
            rjPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // pnlClientArea
            // 
            pnlClientArea.BackColor = Color.FromArgb(240, 245, 249);
            pnlClientArea.Controls.Add(panelBotSide);
            pnlClientArea.Controls.Add(panelTopSide);
            pnlClientArea.Location = new Point(1, 41);
            pnlClientArea.Size = new Size(958, 589);
            // 
            // rjPanel2
            // 
            rjPanel2.BackColor = Color.FromArgb(250, 252, 253);
            rjPanel2.BorderRadius = 10;
            rjPanel2.Controls.Add(lblQtdCaixa);
            rjPanel2.Controls.Add(rjLabel9);
            rjPanel2.Customizable = false;
            rjPanel2.Location = new Point(743, 156);
            rjPanel2.Name = "rjPanel2";
            rjPanel2.Size = new Size(197, 102);
            rjPanel2.TabIndex = 25;
            // 
            // lblQtdCaixa
            // 
            lblQtdCaixa.Anchor = AnchorStyles.None;
            lblQtdCaixa.AutoSize = true;
            lblQtdCaixa.FlatStyle = FlatStyle.Flat;
            lblQtdCaixa.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblQtdCaixa.ForeColor = Color.FromArgb(99, 96, 99);
            lblQtdCaixa.LinkLabel = false;
            lblQtdCaixa.Location = new Point(-8, 54);
            lblQtdCaixa.MinimumSize = new Size(220, 25);
            lblQtdCaixa.Name = "lblQtdCaixa";
            lblQtdCaixa.RightToLeft = RightToLeft.No;
            lblQtdCaixa.Size = new Size(220, 25);
            lblQtdCaixa.Style = LED_DPS.Controls.Design.LabelStyle.Title2;
            lblQtdCaixa.TabIndex = 6;
            lblQtdCaixa.Text = "0";
            lblQtdCaixa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rjLabel9
            // 
            rjLabel9.Anchor = AnchorStyles.None;
            rjLabel9.AutoSize = true;
            rjLabel9.FlatStyle = FlatStyle.Flat;
            rjLabel9.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel9.ForeColor = Color.FromArgb(99, 96, 99);
            rjLabel9.LinkLabel = false;
            rjLabel9.Location = new Point(0, 4);
            rjLabel9.Name = "rjLabel9";
            rjLabel9.RightToLeft = RightToLeft.No;
            rjLabel9.Size = new Size(201, 50);
            rjLabel9.Style = LED_DPS.Controls.Design.LabelStyle.Title2;
            rjLabel9.TabIndex = 5;
            rjLabel9.Text = "Quantidade embalada\r\n           na Caixa";
            // 
            // btn_frente
            // 
            btn_frente._1_Size = new Size(70, 62);
            btn_frente.BackColor = Color.FromArgb(245, 124, 37);
            btn_frente.BorderColor = Color.FromArgb(245, 124, 37);
            btn_frente.BorderRadius = 15;
            btn_frente.BorderSize = 0;
            btn_frente.Design = LED_DPS.Controls.Design.ButtonDesign.Normal;
            btn_frente.FlatAppearance.BorderSize = 0;
            btn_frente.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, 116, 34);
            btn_frente.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 109, 32);
            btn_frente.FlatStyle = FlatStyle.Flat;
            btn_frente.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btn_frente.ForeColor = Color.White;
            btn_frente.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            btn_frente.IconColor = Color.White;
            btn_frente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_frente.IconSize = 60;
            btn_frente.ImageAlign = ContentAlignment.TopCenter;
            btn_frente.Location = new Point(652, 275);
            btn_frente.Name = "btn_frente";
            btn_frente.Size = new Size(70, 62);
            btn_frente.Style = LED_DPS.Controls.Design.ControlStyle.Solid;
            btn_frente.TabIndex = 24;
            btn_frente.UseMnemonic = false;
            btn_frente.UseVisualStyleBackColor = false;
            btn_frente.Click += btn_frente_Click;
            // 
            // btn_atras
            // 
            btn_atras._1_Size = new Size(68, 62);
            btn_atras.BackColor = Color.FromArgb(245, 124, 37);
            btn_atras.BorderColor = Color.FromArgb(245, 124, 37);
            btn_atras.BorderRadius = 15;
            btn_atras.BorderSize = 0;
            btn_atras.Design = LED_DPS.Controls.Design.ButtonDesign.Normal;
            btn_atras.FlatAppearance.BorderSize = 0;
            btn_atras.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, 116, 34);
            btn_atras.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 109, 32);
            btn_atras.FlatStyle = FlatStyle.Flat;
            btn_atras.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btn_atras.ForeColor = Color.White;
            btn_atras.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            btn_atras.IconColor = Color.White;
            btn_atras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_atras.IconSize = 60;
            btn_atras.ImageAlign = ContentAlignment.TopCenter;
            btn_atras.Location = new Point(564, 275);
            btn_atras.Name = "btn_atras";
            btn_atras.Size = new Size(68, 62);
            btn_atras.Style = LED_DPS.Controls.Design.ControlStyle.Solid;
            btn_atras.TabIndex = 23;
            btn_atras.UseMnemonic = false;
            btn_atras.UseVisualStyleBackColor = false;
            btn_atras.Click += btn_atras_Click;
            // 
            // rjPanel1
            // 
            rjPanel1.BackColor = Color.FromArgb(250, 252, 253);
            rjPanel1.BorderRadius = 10;
            rjPanel1.Controls.Add(lblPorCaixa);
            rjPanel1.Controls.Add(rjLabel6);
            rjPanel1.Customizable = false;
            rjPanel1.Location = new Point(661, 85);
            rjPanel1.Name = "rjPanel1";
            rjPanel1.Size = new Size(151, 65);
            rjPanel1.TabIndex = 22;
            // 
            // lblPorCaixa
            // 
            lblPorCaixa.Anchor = AnchorStyles.None;
            lblPorCaixa.AutoSize = true;
            lblPorCaixa.FlatStyle = FlatStyle.Flat;
            lblPorCaixa.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblPorCaixa.ForeColor = Color.FromArgb(99, 96, 99);
            lblPorCaixa.LinkLabel = false;
            lblPorCaixa.Location = new Point(-33, 27);
            lblPorCaixa.MinimumSize = new Size(220, 25);
            lblPorCaixa.Name = "lblPorCaixa";
            lblPorCaixa.RightToLeft = RightToLeft.No;
            lblPorCaixa.Size = new Size(220, 25);
            lblPorCaixa.Style = LED_DPS.Controls.Design.LabelStyle.Title2;
            lblPorCaixa.TabIndex = 6;
            lblPorCaixa.Text = "0";
            lblPorCaixa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rjLabel6
            // 
            rjLabel6.Anchor = AnchorStyles.None;
            rjLabel6.AutoSize = true;
            rjLabel6.FlatStyle = FlatStyle.Flat;
            rjLabel6.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel6.ForeColor = Color.FromArgb(99, 96, 99);
            rjLabel6.LinkLabel = false;
            rjLabel6.Location = new Point(4, 2);
            rjLabel6.Name = "rjLabel6";
            rjLabel6.RightToLeft = RightToLeft.No;
            rjLabel6.Size = new Size(150, 25);
            rjLabel6.Style = LED_DPS.Controls.Design.LabelStyle.Title2;
            rjLabel6.TabIndex = 5;
            rjLabel6.Text = "DPS POR CAIXA";
            // 
            // rjLabel5
            // 
            rjLabel5.AutoSize = true;
            rjLabel5.FlatStyle = FlatStyle.Flat;
            rjLabel5.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel5.ForeColor = Color.FromArgb(99, 96, 99);
            rjLabel5.LinkLabel = false;
            rjLabel5.Location = new Point(8, 3);
            rjLabel5.Name = "rjLabel5";
            rjLabel5.RightToLeft = RightToLeft.No;
            rjLabel5.Size = new Size(42, 25);
            rjLabel5.Style = LED_DPS.Controls.Design.LabelStyle.Title2;
            rjLabel5.TabIndex = 21;
            rjLabel5.Text = "SN:";
            // 
            // lblAvisos
            // 
            lblAvisos.AutoSize = true;
            lblAvisos.FlatStyle = FlatStyle.Flat;
            lblAvisos.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblAvisos.ForeColor = Color.FromArgb(99, 96, 99);
            lblAvisos.LinkLabel = false;
            lblAvisos.Location = new Point(8, 72);
            lblAvisos.Name = "lblAvisos";
            lblAvisos.RightToLeft = RightToLeft.No;
            lblAvisos.Size = new Size(55, 25);
            lblAvisos.Style = LED_DPS.Controls.Design.LabelStyle.Title2;
            lblAvisos.TabIndex = 20;
            lblAvisos.Text = "PASS";
            // 
            // dgv_caixa
            // 
            dgv_caixa.AllowUserToResizeRows = false;
            dgv_caixa.AlternatingRowsColor = Color.Empty;
            dgv_caixa.AlternatingRowsColorApply = false;
            dgv_caixa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv_caixa.BackgroundColor = Color.FromArgb(250, 252, 253);
            dgv_caixa.BorderRadius = 13;
            dgv_caixa.BorderStyle = BorderStyle.None;
            dgv_caixa.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_caixa.ColumnHeaderColor = Color.MediumPurple;
            dgv_caixa.ColumnHeaderFont = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dgv_caixa.ColumnHeaderHeight = 40;
            dgv_caixa.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.MediumPurple;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(15, 0, 0, 0);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_caixa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_caixa.ColumnHeadersHeight = 40;
            dgv_caixa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv_caixa.ColumnHeaderTextColor = Color.White;
            dgv_caixa.Columns.AddRange(new DataGridViewColumn[] { sn, Column1, Column2 });
            dgv_caixa.ColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv_caixa.Customizable = false;
            dgv_caixa.DgvBackColor = Color.FromArgb(250, 252, 253);
            dgv_caixa.EnableHeadersVisualStyles = false;
            dgv_caixa.GridColor = Color.Gainsboro;
            dgv_caixa.Location = new Point(8, 156);
            dgv_caixa.Name = "dgv_caixa";
            dgv_caixa.ReadOnly = true;
            dgv_caixa.RightToLeft = RightToLeft.No;
            dgv_caixa.RowHeaderColor = Color.WhiteSmoke;
            dgv_caixa.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(213, 199, 241);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_caixa.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_caixa.RowHeadersVisible = false;
            dgv_caixa.RowHeadersWidth = 30;
            dgv_caixa.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_caixa.RowHeight = 40;
            dgv_caixa.RowsColor = Color.FromArgb(250, 252, 253);
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(250, 252, 253);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Gray;
            dataGridViewCellStyle3.Padding = new Padding(15, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(213, 199, 241);
            dataGridViewCellStyle3.SelectionForeColor = Color.Gray;
            dgv_caixa.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgv_caixa.RowsTextColor = Color.Gray;
            dgv_caixa.RowTemplate.Height = 40;
            dgv_caixa.SelectionBackColor = Color.FromArgb(213, 199, 241);
            dgv_caixa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_caixa.SelectionTextColor = Color.Gray;
            dgv_caixa.Size = new Size(517, 332);
            dgv_caixa.TabIndex = 19;
            // 
            // sn
            // 
            sn.HeaderText = "SN";
            sn.Name = "sn";
            sn.ReadOnly = true;
            sn.Width = 64;
            // 
            // Column1
            // 
            Column1.HeaderText = "MODELO";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 102;
            // 
            // Column2
            // 
            Column2.HeaderText = "DATA";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 82;
            // 
            // txt_sn
            // 
            txt_sn._Customizable = false;
            txt_sn.BackColor = Color.FromArgb(240, 245, 249);
            txt_sn.BorderColor = Color.FromArgb(132, 129, 132);
            txt_sn.BorderFocusColor = Color.FromArgb(246, 143, 69);
            txt_sn.BorderRadius = 15;
            txt_sn.BorderSize = 2;
            txt_sn.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_sn.ForeColor = Color.FromArgb(132, 129, 132);
            txt_sn.Location = new Point(8, 31);
            txt_sn.MultiLine = false;
            txt_sn.Name = "txt_sn";
            txt_sn.Padding = new Padding(10, 7, 10, 7);
            txt_sn.PasswordChar = false;
            txt_sn.PlaceHolderColor = Color.DarkGray;
            txt_sn.PlaceHolderText = "";
            txt_sn.RightToLeft = RightToLeft.No;
            txt_sn.ScrollBars = ScrollBars.None;
            txt_sn.Size = new Size(367, 38);
            txt_sn.Style = LED_DPS.Controls.Design.TextBoxStyle.MatteBorder;
            txt_sn.TabIndex = 18;
            txt_sn.onTextChanged += txt_sn_onTextChanged;
            txt_sn.KeyPress += txt_sn_KeyPress;
            // 
            // rjLabel3
            // 
            rjLabel3.AutoSize = true;
            rjLabel3.FlatStyle = FlatStyle.Flat;
            rjLabel3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel3.ForeColor = Color.FromArgb(99, 96, 99);
            rjLabel3.LinkLabel = false;
            rjLabel3.Location = new Point(680, 11);
            rjLabel3.Name = "rjLabel3";
            rjLabel3.RightToLeft = RightToLeft.No;
            rjLabel3.Size = new Size(147, 25);
            rjLabel3.Style = LED_DPS.Controls.Design.LabelStyle.Title2;
            rjLabel3.TabIndex = 17;
            rjLabel3.Text = "Quantidade OP:";
            // 
            // rjLabel2
            // 
            rjLabel2.AutoSize = true;
            rjLabel2.FlatStyle = FlatStyle.Flat;
            rjLabel2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel2.ForeColor = Color.FromArgb(99, 96, 99);
            rjLabel2.LinkLabel = false;
            rjLabel2.Location = new Point(442, 11);
            rjLabel2.Name = "rjLabel2";
            rjLabel2.RightToLeft = RightToLeft.No;
            rjLabel2.Size = new Size(83, 25);
            rjLabel2.Style = LED_DPS.Controls.Design.LabelStyle.Title2;
            rjLabel2.TabIndex = 16;
            rjLabel2.Text = "Modelo:";
            // 
            // rjLabel1
            // 
            rjLabel1.AutoSize = true;
            rjLabel1.FlatStyle = FlatStyle.Flat;
            rjLabel1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel1.ForeColor = Color.FromArgb(99, 96, 99);
            rjLabel1.LinkLabel = false;
            rjLabel1.Location = new Point(63, 11);
            rjLabel1.Name = "rjLabel1";
            rjLabel1.RightToLeft = RightToLeft.No;
            rjLabel1.Size = new Size(42, 25);
            rjLabel1.Style = LED_DPS.Controls.Design.LabelStyle.Title2;
            rjLabel1.TabIndex = 15;
            rjLabel1.Text = "OP:";
            // 
            // cb_op
            // 
            cb_op.AutoCompleteMode = AutoCompleteMode.None;
            cb_op.AutoCompleteSource = AutoCompleteSource.None;
            cb_op.BackColor = Color.FromArgb(240, 245, 249);
            cb_op.BorderColor = Color.FromArgb(132, 129, 132);
            cb_op.BorderRadius = 15;
            cb_op.BorderSize = 1;
            cb_op.Customizable = false;
            cb_op.DataSource = null;
            cb_op.DropDownBackColor = Color.FromArgb(250, 252, 253);
            cb_op.DropDownStyle = ComboBoxStyle.DropDown;
            cb_op.DropDownTextColor = Color.FromArgb(132, 129, 132);
            cb_op.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cb_op.IconColor = Color.FromArgb(245, 124, 37);
            cb_op.Location = new Point(111, 0);
            cb_op.Name = "cb_op";
            cb_op.Padding = new Padding(2);
            cb_op.RightToLeft = RightToLeft.No;
            cb_op.SelectedIndex = -1;
            cb_op.Size = new Size(264, 49);
            cb_op.Style = LED_DPS.Controls.Design.ControlStyle.Glass;
            cb_op.TabIndex = 14;
            cb_op.Texts = "";
            cb_op.OnSelectedIndexChanged += cb_op_OnSelectedIndexChanged;
            cb_op.Load += cb_op_Load;
            // 
            // txtNcaixa
            // 
            txtNcaixa._Customizable = false;
            txtNcaixa.BackColor = Color.FromArgb(240, 245, 249);
            txtNcaixa.BorderColor = Color.FromArgb(132, 129, 132);
            txtNcaixa.BorderFocusColor = Color.FromArgb(246, 143, 69);
            txtNcaixa.BorderRadius = 15;
            txtNcaixa.BorderSize = 2;
            txtNcaixa.Enabled = false;
            txtNcaixa.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNcaixa.ForeColor = Color.FromArgb(132, 129, 132);
            txtNcaixa.Location = new Point(531, 368);
            txtNcaixa.MaxLength = 10;
            txtNcaixa.MultiLine = false;
            txtNcaixa.Name = "txtNcaixa";
            txtNcaixa.Padding = new Padding(10, 7, 10, 7);
            txtNcaixa.PasswordChar = false;
            txtNcaixa.PlaceHolderColor = Color.DarkGray;
            txtNcaixa.PlaceHolderText = "";
            txtNcaixa.RightToLeft = RightToLeft.No;
            txtNcaixa.ScrollBars = ScrollBars.None;
            txtNcaixa.Size = new Size(224, 38);
            txtNcaixa.Style = LED_DPS.Controls.Design.TextBoxStyle.MatteBorder;
            txtNcaixa.TabIndex = 27;
            // 
            // rjLabel10
            // 
            rjLabel10.AutoSize = true;
            rjLabel10.FlatStyle = FlatStyle.Flat;
            rjLabel10.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel10.ForeColor = Color.FromArgb(99, 96, 99);
            rjLabel10.LinkLabel = false;
            rjLabel10.Location = new Point(564, 340);
            rjLabel10.Name = "rjLabel10";
            rjLabel10.RightToLeft = RightToLeft.No;
            rjLabel10.Size = new Size(158, 25);
            rjLabel10.Style = LED_DPS.Controls.Design.LabelStyle.Title2;
            rjLabel10.TabIndex = 28;
            rjLabel10.Text = "Numero da caixa";
            // 
            // BtnStatus
            // 
            BtnStatus._1_Size = new Size(233, 66);
            BtnStatus.BackColor = Color.FromArgb(245, 124, 37);
            BtnStatus.BorderColor = Color.FromArgb(245, 124, 37);
            BtnStatus.BorderRadius = 15;
            BtnStatus.BorderSize = 0;
            BtnStatus.Design = LED_DPS.Controls.Design.ButtonDesign.Normal;
            BtnStatus.FlatAppearance.BorderSize = 0;
            BtnStatus.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, 116, 34);
            BtnStatus.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 109, 32);
            BtnStatus.FlatStyle = FlatStyle.Flat;
            BtnStatus.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnStatus.ForeColor = Color.White;
            BtnStatus.IconChar = FontAwesome.Sharp.IconChar.None;
            BtnStatus.IconColor = Color.White;
            BtnStatus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnStatus.IconSize = 80;
            BtnStatus.Location = new Point(692, 422);
            BtnStatus.Name = "BtnStatus";
            BtnStatus.Size = new Size(233, 66);
            BtnStatus.Style = LED_DPS.Controls.Design.ControlStyle.Solid;
            BtnStatus.TabIndex = 29;
            BtnStatus.Text = "POSTO DE EMBALAGEM ATIVO";
            BtnStatus.UseVisualStyleBackColor = false;
            BtnStatus.Click += rjButton1_Click;
            // 
            // panelTopSide
            // 
            panelTopSide.Controls.Add(lblStatusOP);
            panelTopSide.Controls.Add(rjLabel7);
            panelTopSide.Controls.Add(lblQtdOP);
            panelTopSide.Controls.Add(lblmodelo);
            panelTopSide.Controls.Add(cb_linha);
            panelTopSide.Controls.Add(rjLabel11);
            panelTopSide.Controls.Add(cb_op);
            panelTopSide.Controls.Add(rjLabel1);
            panelTopSide.Controls.Add(rjLabel2);
            panelTopSide.Controls.Add(rjLabel3);
            panelTopSide.Dock = DockStyle.Top;
            panelTopSide.Location = new Point(0, 0);
            panelTopSide.Name = "panelTopSide";
            panelTopSide.Size = new Size(958, 93);
            panelTopSide.TabIndex = 30;
            // 
            // lblStatusOP
            // 
            lblStatusOP.AutoSize = true;
            lblStatusOP.FlatStyle = FlatStyle.Flat;
            lblStatusOP.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatusOP.ForeColor = Color.FromArgb(99, 96, 99);
            lblStatusOP.LinkLabel = false;
            lblStatusOP.Location = new Point(833, 47);
            lblStatusOP.Name = "lblStatusOP";
            lblStatusOP.RightToLeft = RightToLeft.No;
            lblStatusOP.Size = new Size(32, 25);
            lblStatusOP.Style = LED_DPS.Controls.Design.LabelStyle.Title2;
            lblStatusOP.TabIndex = 23;
            lblStatusOP.Text = "....";
            // 
            // rjLabel7
            // 
            rjLabel7.AutoSize = true;
            rjLabel7.FlatStyle = FlatStyle.Flat;
            rjLabel7.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel7.ForeColor = Color.FromArgb(99, 96, 99);
            rjLabel7.LinkLabel = false;
            rjLabel7.Location = new Point(728, 47);
            rjLabel7.Name = "rjLabel7";
            rjLabel7.RightToLeft = RightToLeft.No;
            rjLabel7.Size = new Size(99, 25);
            rjLabel7.Style = LED_DPS.Controls.Design.LabelStyle.Title2;
            rjLabel7.TabIndex = 22;
            rjLabel7.Text = "Status OP:";
            // 
            // lblQtdOP
            // 
            lblQtdOP.AutoSize = true;
            lblQtdOP.FlatStyle = FlatStyle.Flat;
            lblQtdOP.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblQtdOP.ForeColor = Color.FromArgb(99, 96, 99);
            lblQtdOP.LinkLabel = false;
            lblQtdOP.Location = new Point(833, 11);
            lblQtdOP.Name = "lblQtdOP";
            lblQtdOP.RightToLeft = RightToLeft.No;
            lblQtdOP.Size = new Size(32, 25);
            lblQtdOP.Style = LED_DPS.Controls.Design.LabelStyle.Title2;
            lblQtdOP.TabIndex = 21;
            lblQtdOP.Text = "....";
            // 
            // lblmodelo
            // 
            lblmodelo.AutoSize = true;
            lblmodelo.FlatStyle = FlatStyle.Flat;
            lblmodelo.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblmodelo.ForeColor = Color.FromArgb(99, 96, 99);
            lblmodelo.LinkLabel = false;
            lblmodelo.Location = new Point(531, 11);
            lblmodelo.Name = "lblmodelo";
            lblmodelo.RightToLeft = RightToLeft.No;
            lblmodelo.Size = new Size(32, 25);
            lblmodelo.Style = LED_DPS.Controls.Design.LabelStyle.Title2;
            lblmodelo.TabIndex = 20;
            lblmodelo.Text = "....";
            // 
            // cb_linha
            // 
            cb_linha.AutoCompleteMode = AutoCompleteMode.None;
            cb_linha.AutoCompleteSource = AutoCompleteSource.None;
            cb_linha.BackColor = Color.FromArgb(240, 245, 249);
            cb_linha.BorderColor = Color.FromArgb(132, 129, 132);
            cb_linha.BorderRadius = 15;
            cb_linha.BorderSize = 1;
            cb_linha.Customizable = false;
            cb_linha.DataSource = null;
            cb_linha.DropDownBackColor = Color.FromArgb(250, 252, 253);
            cb_linha.DropDownStyle = ComboBoxStyle.DropDown;
            cb_linha.DropDownTextColor = Color.FromArgb(132, 129, 132);
            cb_linha.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb_linha.IconColor = Color.FromArgb(245, 124, 37);
            cb_linha.Items.AddRange(new object[] { "LINHA1", "LINHA2" });
            cb_linha.Location = new Point(111, 55);
            cb_linha.Name = "cb_linha";
            cb_linha.Padding = new Padding(2);
            cb_linha.RightToLeft = RightToLeft.No;
            cb_linha.SelectedIndex = -1;
            cb_linha.Size = new Size(168, 32);
            cb_linha.Style = LED_DPS.Controls.Design.ControlStyle.Glass;
            cb_linha.TabIndex = 18;
            cb_linha.Texts = "";
            cb_linha.Visible = false;
            cb_linha.OnSelectedIndexChanged += cb_linha_OnSelectedIndexChanged;
            // 
            // rjLabel11
            // 
            rjLabel11.AutoSize = true;
            rjLabel11.FlatStyle = FlatStyle.Flat;
            rjLabel11.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel11.ForeColor = Color.FromArgb(99, 96, 99);
            rjLabel11.LinkLabel = false;
            rjLabel11.Location = new Point(42, 57);
            rjLabel11.Name = "rjLabel11";
            rjLabel11.RightToLeft = RightToLeft.No;
            rjLabel11.Size = new Size(63, 25);
            rjLabel11.Style = LED_DPS.Controls.Design.LabelStyle.Title2;
            rjLabel11.TabIndex = 19;
            rjLabel11.Text = "Linha:";
            // 
            // panelBotSide
            // 
            panelBotSide.AutoScroll = true;
            panelBotSide.Controls.Add(rjLabel4);
            panelBotSide.Controls.Add(btnDeletarSn);
            panelBotSide.Controls.Add(rjPanel3);
            panelBotSide.Controls.Add(BtnStatus);
            panelBotSide.Controls.Add(rjLabel10);
            panelBotSide.Controls.Add(txtNcaixa);
            panelBotSide.Controls.Add(btn_imprimir);
            panelBotSide.Controls.Add(dgv_caixa);
            panelBotSide.Controls.Add(rjPanel2);
            panelBotSide.Controls.Add(btn_frente);
            panelBotSide.Controls.Add(btn_atras);
            panelBotSide.Controls.Add(rjPanel1);
            panelBotSide.Controls.Add(rjLabel5);
            panelBotSide.Controls.Add(txt_sn);
            panelBotSide.Controls.Add(lblAvisos);
            panelBotSide.Dock = DockStyle.Fill;
            panelBotSide.Enabled = false;
            panelBotSide.Location = new Point(0, 93);
            panelBotSide.Name = "panelBotSide";
            panelBotSide.Size = new Size(958, 496);
            panelBotSide.TabIndex = 31;
            // 
            // rjLabel4
            // 
            rjLabel4.AutoSize = true;
            rjLabel4.FlatStyle = FlatStyle.Flat;
            rjLabel4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel4.ForeColor = Color.FromArgb(99, 96, 99);
            rjLabel4.LinkLabel = false;
            rjLabel4.Location = new Point(531, 422);
            rjLabel4.Name = "rjLabel4";
            rjLabel4.RightToLeft = RightToLeft.No;
            rjLabel4.Size = new Size(94, 25);
            rjLabel4.Style = LED_DPS.Controls.Design.LabelStyle.Title2;
            rjLabel4.TabIndex = 32;
            rjLabel4.Text = "Delete Sn";
            // 
            // btnDeletarSn
            // 
            btnDeletarSn._1_Size = new Size(47, 44);
            btnDeletarSn.BackColor = Color.FromArgb(245, 124, 37);
            btnDeletarSn.BorderColor = Color.FromArgb(245, 124, 37);
            btnDeletarSn.BorderRadius = 15;
            btnDeletarSn.BorderSize = 0;
            btnDeletarSn.Design = LED_DPS.Controls.Design.ButtonDesign.Normal;
            btnDeletarSn.FlatAppearance.BorderSize = 0;
            btnDeletarSn.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, 116, 34);
            btnDeletarSn.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 109, 32);
            btnDeletarSn.FlatStyle = FlatStyle.Flat;
            btnDeletarSn.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeletarSn.ForeColor = Color.White;
            btnDeletarSn.IconChar = FontAwesome.Sharp.IconChar.X;
            btnDeletarSn.IconColor = Color.White;
            btnDeletarSn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDeletarSn.IconSize = 40;
            btnDeletarSn.ImageAlign = ContentAlignment.TopCenter;
            btnDeletarSn.Location = new Point(553, 450);
            btnDeletarSn.Name = "btnDeletarSn";
            btnDeletarSn.Size = new Size(47, 44);
            btnDeletarSn.Style = LED_DPS.Controls.Design.ControlStyle.Solid;
            btnDeletarSn.TabIndex = 31;
            btnDeletarSn.UseMnemonic = false;
            btnDeletarSn.UseVisualStyleBackColor = false;
            btnDeletarSn.Click += btnDeletarSn_Click;
            // 
            // rjPanel3
            // 
            rjPanel3.BackColor = Color.FromArgb(250, 252, 253);
            rjPanel3.BorderRadius = 10;
            rjPanel3.Controls.Add(lblPendente);
            rjPanel3.Controls.Add(rjLabel8);
            rjPanel3.Customizable = false;
            rjPanel3.Location = new Point(535, 156);
            rjPanel3.Name = "rjPanel3";
            rjPanel3.Size = new Size(194, 102);
            rjPanel3.TabIndex = 30;
            // 
            // lblPendente
            // 
            lblPendente.Anchor = AnchorStyles.None;
            lblPendente.AutoSize = true;
            lblPendente.FlatStyle = FlatStyle.Flat;
            lblPendente.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblPendente.ForeColor = Color.FromArgb(99, 96, 99);
            lblPendente.LinkLabel = false;
            lblPendente.Location = new Point(-18, 54);
            lblPendente.MinimumSize = new Size(220, 25);
            lblPendente.Name = "lblPendente";
            lblPendente.RightToLeft = RightToLeft.No;
            lblPendente.Size = new Size(220, 25);
            lblPendente.Style = LED_DPS.Controls.Design.LabelStyle.Title2;
            lblPendente.TabIndex = 6;
            lblPendente.Text = ".......";
            lblPendente.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rjLabel8
            // 
            rjLabel8.Anchor = AnchorStyles.None;
            rjLabel8.AutoSize = true;
            rjLabel8.FlatStyle = FlatStyle.Flat;
            rjLabel8.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel8.ForeColor = Color.FromArgb(99, 96, 99);
            rjLabel8.LinkLabel = false;
            rjLabel8.Location = new Point(0, 4);
            rjLabel8.Name = "rjLabel8";
            rjLabel8.RightToLeft = RightToLeft.No;
            rjLabel8.Size = new Size(198, 50);
            rjLabel8.Style = LED_DPS.Controls.Design.LabelStyle.Title2;
            rjLabel8.TabIndex = 5;
            rjLabel8.Text = "Quantidade pendente\r\n            na caixa";
            // 
            // btn_imprimir
            // 
            btn_imprimir._1_Size = new Size(122, 131);
            btn_imprimir.BackColor = Color.FromArgb(245, 124, 37);
            btn_imprimir.BorderColor = Color.FromArgb(245, 124, 37);
            btn_imprimir.BorderRadius = 15;
            btn_imprimir.BorderSize = 0;
            btn_imprimir.Design = LED_DPS.Controls.Design.ButtonDesign.Normal;
            btn_imprimir.FlatAppearance.BorderSize = 0;
            btn_imprimir.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, 116, 34);
            btn_imprimir.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 109, 32);
            btn_imprimir.FlatStyle = FlatStyle.Flat;
            btn_imprimir.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btn_imprimir.ForeColor = Color.White;
            btn_imprimir.IconChar = FontAwesome.Sharp.IconChar.Print;
            btn_imprimir.IconColor = Color.White;
            btn_imprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_imprimir.IconSize = 80;
            btn_imprimir.Location = new Point(818, 275);
            btn_imprimir.Name = "btn_imprimir";
            btn_imprimir.Size = new Size(122, 131);
            btn_imprimir.Style = LED_DPS.Controls.Design.ControlStyle.Solid;
            btn_imprimir.TabIndex = 26;
            btn_imprimir.UseVisualStyleBackColor = false;
            btn_imprimir.Click += btn_imprimir_Click;
            // 
            // FrmEmbalagem_C
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderColor = Color.FromArgb(245, 124, 37);
            BorderSize = 1;
            Caption = "FrmEmbalagem_C";
            ClientSize = new Size(960, 631);
            Name = "FrmEmbalagem_C";
            Padding = new Padding(1);
            Text = "FrmEmbalagem_C";
            Load += FrmEmbalagem_C_Load;
            pnlClientArea.ResumeLayout(false);
            rjPanel2.ResumeLayout(false);
            rjPanel2.PerformLayout();
            rjPanel1.ResumeLayout(false);
            rjPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_caixa).EndInit();
            panelTopSide.ResumeLayout(false);
            panelTopSide.PerformLayout();
            panelBotSide.ResumeLayout(false);
            panelBotSide.PerformLayout();
            rjPanel3.ResumeLayout(false);
            rjPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private RJControls.RJDataGridView dgv_caixa;
        private RJControls.RJPanel rjPanel2;
        private RJControls.RJLabel lblQtdCaixa;
        private RJControls.RJLabel rjLabel9;
        private RJControls.RJComboBox cb_op;
        private RJControls.RJButton btn_frente;
        private RJControls.RJLabel rjLabel1;
        private RJControls.RJButton btn_atras;
        private RJControls.RJLabel rjLabel2;
        private RJControls.RJPanel rjPanel1;
        private RJControls.RJLabel lblPorCaixa;
        private RJControls.RJLabel rjLabel6;
        private RJControls.RJLabel rjLabel3;
        private RJControls.RJLabel rjLabel5;
        private RJControls.RJTextBox txt_sn;
        private RJControls.RJLabel lblAvisos;
        private RJControls.RJLabel rjLabel10;
        private RJControls.RJTextBox txtNcaixa;
        private RJControls.RJButton BtnStatus;
        private Panel panelBotSide;
        private Panel panelTopSide;
        private RJControls.RJLabel lblQtdOP;
        private RJControls.RJLabel lblmodelo;
        private RJControls.RJComboBox cb_linha;
        private RJControls.RJLabel rjLabel11;
        private DataGridViewTextBoxColumn sn;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private RJControls.RJPanel rjPanel3;
        private RJControls.RJLabel lblPendente;
        private RJControls.RJLabel rjLabel8;
        private RJControls.RJButton btn_imprimir;
        private RJControls.RJLabel lblStatusOP;
        private RJControls.RJLabel rjLabel7;
        private RJControls.RJButton btnDeletarSn;
        private RJControls.RJLabel rjLabel4;
    }
}