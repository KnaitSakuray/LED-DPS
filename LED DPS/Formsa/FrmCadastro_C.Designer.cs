namespace LED_DPS.Formsa
{
    partial class FrmCadastro_C
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            BtnAtualizar = new RJControls.RJButton();
            BtnCadastro = new RJControls.RJButton();
            rjLabel4 = new RJControls.RJLabel();
            txt_Nop = new RJControls.RJComboBox();
            rjLabel3 = new RJControls.RJLabel();
            txt_descricao = new RJControls.RJtxt();
            rjLabel2 = new RJControls.RJLabel();
            txt_qtd = new RJControls.RJtxt();
            rjLabel1 = new RJControls.RJLabel();
            txt_modelo = new RJControls.RJtxt();
            dgv_modelo = new Controls.DataGridViewMini();
            panel1 = new Panel();
            rjLabel5 = new RJControls.RJLabel();
            txt_liquido = new RJControls.RJtxt();
            rjLabel6 = new RJControls.RJLabel();
            txt_bruto = new RJControls.RJtxt();
            pnlClientArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_modelo).BeginInit();
            SuspendLayout();
            // 
            // pnlClientArea
            // 
            pnlClientArea.BackColor = Color.FromArgb(240, 245, 249);
            pnlClientArea.Controls.Add(rjLabel6);
            pnlClientArea.Controls.Add(txt_bruto);
            pnlClientArea.Controls.Add(rjLabel5);
            pnlClientArea.Controls.Add(txt_liquido);
            pnlClientArea.Controls.Add(panel1);
            pnlClientArea.Controls.Add(BtnAtualizar);
            pnlClientArea.Controls.Add(BtnCadastro);
            pnlClientArea.Controls.Add(rjLabel4);
            pnlClientArea.Controls.Add(txt_Nop);
            pnlClientArea.Controls.Add(rjLabel3);
            pnlClientArea.Controls.Add(txt_descricao);
            pnlClientArea.Controls.Add(rjLabel2);
            pnlClientArea.Controls.Add(txt_qtd);
            pnlClientArea.Controls.Add(rjLabel1);
            pnlClientArea.Controls.Add(txt_modelo);
            pnlClientArea.Controls.Add(dgv_modelo);
            pnlClientArea.Location = new Point(1, 41);
            pnlClientArea.Size = new Size(958, 463);
            // 
            // BtnAtualizar
            // 
            BtnAtualizar._1_Size = new Size(113, 109);
            BtnAtualizar.BackColor = Color.FromArgb(245, 124, 37);
            BtnAtualizar.BorderColor = Color.FromArgb(245, 124, 37);
            BtnAtualizar.BorderRadius = 15;
            BtnAtualizar.BorderSize = 0;
            BtnAtualizar.Design = LED_DPS.Controls.Design.ButtonDesign.Normal;
            BtnAtualizar.FlatAppearance.BorderSize = 0;
            BtnAtualizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, 116, 34);
            BtnAtualizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 109, 32);
            BtnAtualizar.FlatStyle = FlatStyle.Flat;
            BtnAtualizar.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAtualizar.ForeColor = Color.White;
            BtnAtualizar.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateBackward;
            BtnAtualizar.IconColor = Color.White;
            BtnAtualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnAtualizar.IconSize = 80;
            BtnAtualizar.Location = new Point(190, 296);
            BtnAtualizar.Name = "BtnAtualizar";
            BtnAtualizar.Size = new Size(113, 109);
            BtnAtualizar.Style = LED_DPS.Controls.Design.ControlStyle.Solid;
            BtnAtualizar.TabIndex = 26;
            BtnAtualizar.UseVisualStyleBackColor = false;
            BtnAtualizar.Click += BtnAtualizar_Click;
            // 
            // BtnCadastro
            // 
            BtnCadastro._1_Size = new Size(113, 109);
            BtnCadastro.BackColor = Color.FromArgb(245, 124, 37);
            BtnCadastro.BorderColor = Color.FromArgb(245, 124, 37);
            BtnCadastro.BorderRadius = 15;
            BtnCadastro.BorderSize = 0;
            BtnCadastro.Design = LED_DPS.Controls.Design.ButtonDesign.Normal;
            BtnCadastro.FlatAppearance.BorderSize = 0;
            BtnCadastro.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, 116, 34);
            BtnCadastro.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 109, 32);
            BtnCadastro.FlatStyle = FlatStyle.Flat;
            BtnCadastro.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCadastro.ForeColor = Color.White;
            BtnCadastro.IconChar = FontAwesome.Sharp.IconChar.Add;
            BtnCadastro.IconColor = Color.White;
            BtnCadastro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCadastro.IconSize = 80;
            BtnCadastro.Location = new Point(22, 296);
            BtnCadastro.Name = "BtnCadastro";
            BtnCadastro.Size = new Size(113, 109);
            BtnCadastro.Style = LED_DPS.Controls.Design.ControlStyle.Solid;
            BtnCadastro.TabIndex = 25;
            BtnCadastro.UseVisualStyleBackColor = false;
            BtnCadastro.Click += BtnCadastro_Click;
            // 
            // rjLabel4
            // 
            rjLabel4.AutoSize = true;
            rjLabel4.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel4.ForeColor = Color.FromArgb(132, 129, 132);
            rjLabel4.LinkLabel = false;
            rjLabel4.Location = new Point(357, 6);
            rjLabel4.Name = "rjLabel4";
            rjLabel4.Size = new Size(57, 17);
            rjLabel4.Style = LED_DPS.Controls.Design.LabelStyle.Normal;
            rjLabel4.TabIndex = 24;
            rjLabel4.Text = "Modelo:";
            // 
            // txt_Nop
            // 
            txt_Nop.AutoCompleteMode = AutoCompleteMode.None;
            txt_Nop.AutoCompleteSource = AutoCompleteSource.None;
            txt_Nop.BackColor = Color.FromArgb(240, 245, 249);
            txt_Nop.BorderColor = Color.FromArgb(132, 129, 132);
            txt_Nop.BorderRadius = 15;
            txt_Nop.BorderSize = 1;
            txt_Nop.Customizable = false;
            txt_Nop.DataSource = null;
            txt_Nop.DropDownBackColor = Color.FromArgb(250, 252, 253);
            txt_Nop.DropDownStyle = ComboBoxStyle.DropDown;
            txt_Nop.DropDownTextColor = Color.FromArgb(132, 129, 132);
            txt_Nop.IconColor = Color.FromArgb(245, 124, 37);
            txt_Nop.Location = new Point(357, 30);
            txt_Nop.Name = "txt_Nop";
            txt_Nop.Padding = new Padding(2);
            txt_Nop.SelectedIndex = -1;
            txt_Nop.Size = new Size(327, 32);
            txt_Nop.Style = LED_DPS.Controls.Design.ControlStyle.Glass;
            txt_Nop.TabIndex = 23;
            txt_Nop.Texts = "";
            txt_Nop.OnSelectedIndexChanged += cb_modelo_OnSelectedIndexChanged;
            // 
            // rjLabel3
            // 
            rjLabel3.AutoSize = true;
            rjLabel3.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel3.ForeColor = Color.FromArgb(132, 129, 132);
            rjLabel3.LinkLabel = false;
            rjLabel3.Location = new Point(22, 89);
            rjLabel3.Name = "rjLabel3";
            rjLabel3.Size = new Size(68, 17);
            rjLabel3.Style = LED_DPS.Controls.Design.LabelStyle.Normal;
            rjLabel3.TabIndex = 22;
            rjLabel3.Text = "Descrição:";
            // 
            // txt_descricao
            // 
            txt_descricao._Customizable = false;
            txt_descricao.BackColor = Color.FromArgb(240, 245, 249);
            txt_descricao.BorderColor = Color.FromArgb(246, 143, 69);
            txt_descricao.BorderFocusColor = Color.FromArgb(55, 159, 113);
            txt_descricao.BorderRadius = 15;
            txt_descricao.BorderSize = 2;
            txt_descricao.Font = new Font("Verdana", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txt_descricao.ForeColor = Color.FromArgb(132, 129, 132);
            txt_descricao.Location = new Point(22, 113);
            txt_descricao.MultiLine = false;
            txt_descricao.Name = "txt_descricao";
            txt_descricao.Padding = new Padding(10, 7, 10, 7);
            txt_descricao.PasswordChar = false;
            txt_descricao.PlaceHolderColor = Color.DarkGray;
            txt_descricao.PlaceHolderText = null;
            txt_descricao.ScrollBars = ScrollBars.None;
            txt_descricao.Size = new Size(276, 31);
            txt_descricao.Style = LED_DPS.Controls.Design.TextBoxStyle.MatteBorder;
            txt_descricao.TabIndex = 21;
            txt_descricao.Texts = "";
            txt_descricao.onTextChanged += txt_descricao_onTextChanged;
            // 
            // rjLabel2
            // 
            rjLabel2.AutoSize = true;
            rjLabel2.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel2.ForeColor = Color.FromArgb(132, 129, 132);
            rjLabel2.LinkLabel = false;
            rjLabel2.Location = new Point(22, 218);
            rjLabel2.Name = "rjLabel2";
            rjLabel2.Size = new Size(141, 17);
            rjLabel2.Style = LED_DPS.Controls.Design.LabelStyle.Normal;
            rjLabel2.TabIndex = 20;
            rjLabel2.Text = "Quantidade por caixa:";
            // 
            // txt_qtd
            // 
            txt_qtd._Customizable = false;
            txt_qtd.BackColor = Color.FromArgb(240, 245, 249);
            txt_qtd.BorderColor = Color.FromArgb(246, 143, 69);
            txt_qtd.BorderFocusColor = Color.FromArgb(55, 159, 113);
            txt_qtd.BorderRadius = 15;
            txt_qtd.BorderSize = 2;
            txt_qtd.Font = new Font("Verdana", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txt_qtd.ForeColor = Color.FromArgb(132, 129, 132);
            txt_qtd.Location = new Point(22, 242);
            txt_qtd.MultiLine = false;
            txt_qtd.Name = "txt_qtd";
            txt_qtd.Padding = new Padding(10, 7, 10, 7);
            txt_qtd.PasswordChar = false;
            txt_qtd.PlaceHolderColor = Color.DarkGray;
            txt_qtd.PlaceHolderText = null;
            txt_qtd.ScrollBars = ScrollBars.None;
            txt_qtd.Size = new Size(169, 31);
            txt_qtd.Style = LED_DPS.Controls.Design.TextBoxStyle.MatteBorder;
            txt_qtd.TabIndex = 19;
            txt_qtd.Texts = "";
            txt_qtd.onTextChanged += txt_qtd_onTextChanged;
            // 
            // rjLabel1
            // 
            rjLabel1.AutoSize = true;
            rjLabel1.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel1.ForeColor = Color.FromArgb(132, 129, 132);
            rjLabel1.LinkLabel = false;
            rjLabel1.Location = new Point(22, 26);
            rjLabel1.Name = "rjLabel1";
            rjLabel1.Size = new Size(57, 17);
            rjLabel1.Style = LED_DPS.Controls.Design.LabelStyle.Normal;
            rjLabel1.TabIndex = 18;
            rjLabel1.Text = "Modelo:";
            // 
            // txt_modelo
            // 
            txt_modelo._Customizable = false;
            txt_modelo.BackColor = Color.FromArgb(240, 245, 249);
            txt_modelo.BorderColor = Color.FromArgb(246, 143, 69);
            txt_modelo.BorderFocusColor = Color.FromArgb(55, 159, 113);
            txt_modelo.BorderRadius = 15;
            txt_modelo.BorderSize = 2;
            txt_modelo.Font = new Font("Verdana", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txt_modelo.ForeColor = Color.FromArgb(132, 129, 132);
            txt_modelo.Location = new Point(22, 50);
            txt_modelo.MultiLine = false;
            txt_modelo.Name = "txt_modelo";
            txt_modelo.Padding = new Padding(10, 7, 10, 7);
            txt_modelo.PasswordChar = false;
            txt_modelo.PlaceHolderColor = Color.DarkGray;
            txt_modelo.PlaceHolderText = null;
            txt_modelo.ScrollBars = ScrollBars.None;
            txt_modelo.Size = new Size(276, 31);
            txt_modelo.Style = LED_DPS.Controls.Design.TextBoxStyle.MatteBorder;
            txt_modelo.TabIndex = 17;
            txt_modelo.Texts = "";
            txt_modelo.onTextChanged += txt_modelo_onTextChanged;
            // 
            // dgv_modelo
            // 
            dgv_modelo.AllowUserToResizeRows = false;
            dgv_modelo.AlternatingRowsColor = Color.Empty;
            dgv_modelo.AlternatingRowsColorApply = false;
            dgv_modelo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_modelo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_modelo.BackgroundColor = Color.FromArgb(250, 252, 253);
            dgv_modelo.BorderRadius = 15;
            dgv_modelo.BorderStyle = BorderStyle.None;
            dgv_modelo.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_modelo.ColumnHeaderColor = Color.Orange;
            dgv_modelo.ColumnHeaderFont = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dgv_modelo.ColumnHeaderHeight = 40;
            dgv_modelo.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Orange;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.Padding = new Padding(15, 0, 0, 0);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_modelo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgv_modelo.ColumnHeadersHeight = 40;
            dgv_modelo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv_modelo.ColumnHeaderTextColor = Color.White;
            dgv_modelo.ColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_modelo.Customizable = false;
            dgv_modelo.DgvBackColor = Color.FromArgb(250, 252, 253);
            dgv_modelo.EnableHeadersVisualStyles = false;
            dgv_modelo.GridColor = Color.Gainsboro;
            dgv_modelo.Location = new Point(357, 80);
            dgv_modelo.Name = "dgv_modelo";
            dgv_modelo.RightToLeft = RightToLeft.No;
            dgv_modelo.RowHeaderColor = Color.WhiteSmoke;
            dgv_modelo.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(213, 199, 241);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgv_modelo.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgv_modelo.RowHeadersVisible = false;
            dgv_modelo.RowHeadersWidth = 30;
            dgv_modelo.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_modelo.RowHeight = 40;
            dgv_modelo.RowsColor = Color.FromArgb(250, 252, 253);
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(250, 252, 253);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Gray;
            dataGridViewCellStyle6.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(213, 199, 241);
            dataGridViewCellStyle6.SelectionForeColor = Color.Gray;
            dgv_modelo.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgv_modelo.RowsTextColor = Color.Gray;
            dgv_modelo.RowTemplate.Height = 40;
            dgv_modelo.SelectionBackColor = Color.FromArgb(213, 199, 241);
            dgv_modelo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_modelo.SelectionTextColor = Color.Gray;
            dgv_modelo.Size = new Size(478, 449);
            dgv_modelo.TabIndex = 16;
            dgv_modelo.CellContentClick += dgv_modelo_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Location = new Point(17, 478);
            panel1.Name = "panel1";
            panel1.Size = new Size(23, 16);
            panel1.TabIndex = 27;
            // 
            // rjLabel5
            // 
            rjLabel5.AutoSize = true;
            rjLabel5.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel5.ForeColor = Color.FromArgb(132, 129, 132);
            rjLabel5.LinkLabel = false;
            rjLabel5.Location = new Point(22, 147);
            rjLabel5.Name = "rjLabel5";
            rjLabel5.Size = new Size(88, 17);
            rjLabel5.Style = LED_DPS.Controls.Design.LabelStyle.Normal;
            rjLabel5.TabIndex = 29;
            rjLabel5.Text = "Peso Liquido:";
            // 
            // txt_liquido
            // 
            txt_liquido._Customizable = false;
            txt_liquido.BackColor = Color.FromArgb(240, 245, 249);
            txt_liquido.BorderColor = Color.FromArgb(246, 143, 69);
            txt_liquido.BorderFocusColor = Color.FromArgb(55, 159, 113);
            txt_liquido.BorderRadius = 15;
            txt_liquido.BorderSize = 2;
            txt_liquido.Font = new Font("Verdana", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txt_liquido.ForeColor = Color.FromArgb(132, 129, 132);
            txt_liquido.Location = new Point(22, 171);
            txt_liquido.MultiLine = false;
            txt_liquido.Name = "txt_liquido";
            txt_liquido.Padding = new Padding(10, 7, 10, 7);
            txt_liquido.PasswordChar = false;
            txt_liquido.PlaceHolderColor = Color.DarkGray;
            txt_liquido.PlaceHolderText = null;
            txt_liquido.ScrollBars = ScrollBars.None;
            txt_liquido.Size = new Size(93, 31);
            txt_liquido.Style = LED_DPS.Controls.Design.TextBoxStyle.MatteBorder;
            txt_liquido.TabIndex = 28;
            txt_liquido.Texts = "";
            // 
            // rjLabel6
            // 
            rjLabel6.AutoSize = true;
            rjLabel6.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel6.ForeColor = Color.FromArgb(132, 129, 132);
            rjLabel6.LinkLabel = false;
            rjLabel6.Location = new Point(172, 147);
            rjLabel6.Name = "rjLabel6";
            rjLabel6.Size = new Size(82, 17);
            rjLabel6.Style = LED_DPS.Controls.Design.LabelStyle.Normal;
            rjLabel6.TabIndex = 31;
            rjLabel6.Text = "Peso Bruto :";
            // 
            // txt_bruto
            // 
            txt_bruto._Customizable = false;
            txt_bruto.BackColor = Color.FromArgb(240, 245, 249);
            txt_bruto.BorderColor = Color.FromArgb(246, 143, 69);
            txt_bruto.BorderFocusColor = Color.FromArgb(55, 159, 113);
            txt_bruto.BorderRadius = 15;
            txt_bruto.BorderSize = 2;
            txt_bruto.Font = new Font("Verdana", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txt_bruto.ForeColor = Color.FromArgb(132, 129, 132);
            txt_bruto.Location = new Point(172, 171);
            txt_bruto.MultiLine = false;
            txt_bruto.Name = "txt_bruto";
            txt_bruto.Padding = new Padding(10, 7, 10, 7);
            txt_bruto.PasswordChar = false;
            txt_bruto.PlaceHolderColor = Color.DarkGray;
            txt_bruto.PlaceHolderText = null;
            txt_bruto.ScrollBars = ScrollBars.None;
            txt_bruto.Size = new Size(93, 31);
            txt_bruto.Style = LED_DPS.Controls.Design.TextBoxStyle.MatteBorder;
            txt_bruto.TabIndex = 30;
            txt_bruto.Texts = "";
            // 
            // FrmCadastro_C
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderColor = Color.FromArgb(245, 124, 37);
            BorderSize = 1;
            Caption = "FrmCadastro_C";
            ClientSize = new Size(960, 505);
            Name = "FrmCadastro_C";
            Padding = new Padding(1);
            Text = "FrmCadastro_C";
            Load += FrmCadastro_C_Load_1;
            pnlClientArea.ResumeLayout(false);
            pnlClientArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_modelo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RJControls.RJButton BtnAtualizar;
        private RJControls.RJButton BtnCadastro;
        private RJControls.RJLabel rjLabel4;
        private RJControls.RJComboBox txt_Nop;
        private RJControls.RJLabel rjLabel3;
        private RJControls.RJtxt txt_descricao;
        private RJControls.RJLabel rjLabel2;
        private RJControls.RJtxt txt_qtd;
        private RJControls.RJLabel rjLabel1;
        private RJControls.RJtxt txt_modelo;
        private Controls.DataGridViewMini dgv_modelo;
        private Panel panel1;
        private RJControls.RJLabel rjLabel6;
        private RJControls.RJtxt txt_bruto;
        private RJControls.RJLabel rjLabel5;
        private RJControls.RJtxt txt_liquido;
    }
}