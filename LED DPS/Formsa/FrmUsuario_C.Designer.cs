namespace LED_DPS.Formsa
{
    partial class FrmUsuario_C
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
            BtnAtualizar = new RJControls.RJButton();
            BtnCadastro = new RJControls.RJButton();
            txt_senha = new RJControls.RJtxt();
            txt_Usuario = new RJControls.RJtxt();
            txt_nome = new RJControls.RJtxt();
            chb_Adm = new RJControls.RJCheckBox();
            chb_OP = new RJControls.RJCheckBox();
            chb_Consulta = new RJControls.RJCheckBox();
            chb_Embalagem = new RJControls.RJCheckBox();
            chb_cadastro = new RJControls.RJCheckBox();
            rjLabel5 = new RJControls.RJLabel();
            DgvUsuario = new Controls.DataGridViewMini();
            rjLabel4 = new RJControls.RJLabel();
            cb_setor = new RJControls.RJComboBox();
            rjLabel3 = new RJControls.RJLabel();
            rjLabel2 = new RJControls.RJLabel();
            rjLabel1 = new RJControls.RJLabel();
            chb_Import = new RJControls.RJCheckBox();
            txt_Id_matricula = new RJControls.RJtxt();
            rjLabel6 = new RJControls.RJLabel();
            rjMenuIcon1 = new RJControls.RJMenuIcon();
            pnlClientArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rjMenuIcon1).BeginInit();
            SuspendLayout();
            // 
            // pnlClientArea
            // 
            pnlClientArea.BackColor = Color.FromArgb(240, 245, 249);
            pnlClientArea.Controls.Add(rjMenuIcon1);
            pnlClientArea.Controls.Add(txt_Id_matricula);
            pnlClientArea.Controls.Add(rjLabel6);
            pnlClientArea.Controls.Add(chb_Import);
            pnlClientArea.Controls.Add(BtnAtualizar);
            pnlClientArea.Controls.Add(BtnCadastro);
            pnlClientArea.Controls.Add(txt_senha);
            pnlClientArea.Controls.Add(txt_Usuario);
            pnlClientArea.Controls.Add(txt_nome);
            pnlClientArea.Controls.Add(chb_Adm);
            pnlClientArea.Controls.Add(chb_OP);
            pnlClientArea.Controls.Add(chb_Consulta);
            pnlClientArea.Controls.Add(chb_Embalagem);
            pnlClientArea.Controls.Add(chb_cadastro);
            pnlClientArea.Controls.Add(rjLabel5);
            pnlClientArea.Controls.Add(DgvUsuario);
            pnlClientArea.Controls.Add(rjLabel4);
            pnlClientArea.Controls.Add(cb_setor);
            pnlClientArea.Controls.Add(rjLabel3);
            pnlClientArea.Controls.Add(rjLabel2);
            pnlClientArea.Controls.Add(rjLabel1);
            pnlClientArea.Location = new Point(1, 41);
            pnlClientArea.Size = new Size(958, 501);
            pnlClientArea.Paint += pnlClientArea_Paint;
            // 
            // BtnAtualizar
            // 
            BtnAtualizar._1_Size = new Size(113, 86);
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
            BtnAtualizar.Location = new Point(193, 470);
            BtnAtualizar.Name = "BtnAtualizar";
            BtnAtualizar.Size = new Size(113, 86);
            BtnAtualizar.Style = LED_DPS.Controls.Design.ControlStyle.Solid;
            BtnAtualizar.TabIndex = 37;
            BtnAtualizar.UseVisualStyleBackColor = false;
            BtnAtualizar.Click += BtnAtualizar_Click;
            // 
            // BtnCadastro
            // 
            BtnCadastro._1_Size = new Size(113, 86);
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
            BtnCadastro.Location = new Point(25, 470);
            BtnCadastro.Name = "BtnCadastro";
            BtnCadastro.Size = new Size(113, 86);
            BtnCadastro.Style = LED_DPS.Controls.Design.ControlStyle.Solid;
            BtnCadastro.TabIndex = 36;
            BtnCadastro.UseVisualStyleBackColor = false;
            BtnCadastro.Click += BtnCadastro_Click;
            // 
            // txt_senha
            // 
            txt_senha._Customizable = false;
            txt_senha.BackColor = Color.FromArgb(240, 245, 249);
            txt_senha.BorderColor = Color.FromArgb(246, 143, 69);
            txt_senha.BorderFocusColor = Color.FromArgb(55, 159, 113);
            txt_senha.BorderRadius = 15;
            txt_senha.BorderSize = 2;
            txt_senha.Font = new Font("Verdana", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txt_senha.ForeColor = Color.FromArgb(132, 129, 132);
            txt_senha.Location = new Point(32, 195);
            txt_senha.MultiLine = false;
            txt_senha.Name = "txt_senha";
            txt_senha.Padding = new Padding(10, 7, 10, 7);
            txt_senha.PasswordChar = false;
            txt_senha.PlaceHolderColor = Color.DarkGray;
            txt_senha.PlaceHolderText = "";
            txt_senha.RightToLeft = RightToLeft.No;
            txt_senha.ScrollBars = ScrollBars.None;
            txt_senha.Size = new Size(250, 31);
            txt_senha.Style = LED_DPS.Controls.Design.TextBoxStyle.MatteBorder;
            txt_senha.TabIndex = 35;
            txt_senha.Texts = "";
            // 
            // txt_Usuario
            // 
            txt_Usuario._Customizable = false;
            txt_Usuario.BackColor = Color.FromArgb(240, 245, 249);
            txt_Usuario.BorderColor = Color.FromArgb(246, 143, 69);
            txt_Usuario.BorderFocusColor = Color.FromArgb(55, 159, 113);
            txt_Usuario.BorderRadius = 15;
            txt_Usuario.BorderSize = 2;
            txt_Usuario.Font = new Font("Verdana", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Usuario.ForeColor = Color.FromArgb(132, 129, 132);
            txt_Usuario.Location = new Point(32, 139);
            txt_Usuario.MultiLine = false;
            txt_Usuario.Name = "txt_Usuario";
            txt_Usuario.Padding = new Padding(10, 7, 10, 7);
            txt_Usuario.PasswordChar = false;
            txt_Usuario.PlaceHolderColor = Color.DarkGray;
            txt_Usuario.PlaceHolderText = null;
            txt_Usuario.RightToLeft = RightToLeft.No;
            txt_Usuario.ScrollBars = ScrollBars.None;
            txt_Usuario.Size = new Size(250, 31);
            txt_Usuario.Style = LED_DPS.Controls.Design.TextBoxStyle.MatteBorder;
            txt_Usuario.TabIndex = 34;
            txt_Usuario.Texts = "";
            // 
            // txt_nome
            // 
            txt_nome._Customizable = false;
            txt_nome.BackColor = Color.FromArgb(240, 245, 249);
            txt_nome.BorderColor = Color.FromArgb(246, 143, 69);
            txt_nome.BorderFocusColor = Color.FromArgb(55, 159, 113);
            txt_nome.BorderRadius = 15;
            txt_nome.BorderSize = 2;
            txt_nome.Font = new Font("Verdana", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nome.ForeColor = Color.FromArgb(132, 129, 132);
            txt_nome.Location = new Point(32, 80);
            txt_nome.MultiLine = false;
            txt_nome.Name = "txt_nome";
            txt_nome.Padding = new Padding(10, 7, 10, 7);
            txt_nome.PasswordChar = false;
            txt_nome.PlaceHolderColor = Color.DarkGray;
            txt_nome.PlaceHolderText = null;
            txt_nome.RightToLeft = RightToLeft.No;
            txt_nome.ScrollBars = ScrollBars.None;
            txt_nome.Size = new Size(250, 31);
            txt_nome.Style = LED_DPS.Controls.Design.TextBoxStyle.MatteBorder;
            txt_nome.TabIndex = 33;
            txt_nome.Texts = "";
            // 
            // chb_Adm
            // 
            chb_Adm.AutoSize = true;
            chb_Adm.BorderColor = Color.FromArgb(245, 124, 37);
            chb_Adm.BorderSize = 1;
            chb_Adm.Check = false;
            chb_Adm.Customizable = false;
            chb_Adm.Font = new Font("Verdana", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            chb_Adm.ForeColor = Color.FromArgb(132, 129, 132);
            chb_Adm.IconColor = Color.FromArgb(245, 124, 37);
            chb_Adm.Location = new Point(195, 373);
            chb_Adm.MinimumSize = new Size(0, 40);
            chb_Adm.Name = "chb_Adm";
            chb_Adm.Padding = new Padding(10, 0, 0, 0);
            chb_Adm.Size = new Size(70, 40);
            chb_Adm.Style = LED_DPS.Controls.Design.ControlStyle.Glass;
            chb_Adm.TabIndex = 32;
            chb_Adm.Text = "ADM ";
            chb_Adm.UseVisualStyleBackColor = true;
            chb_Adm.CheckedChanged += chb_Adm_CheckedChanged;
            // 
            // chb_OP
            // 
            chb_OP.AutoSize = true;
            chb_OP.BorderColor = Color.FromArgb(245, 124, 37);
            chb_OP.BorderSize = 1;
            chb_OP.Check = false;
            chb_OP.Customizable = false;
            chb_OP.Font = new Font("Verdana", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            chb_OP.ForeColor = Color.FromArgb(132, 129, 132);
            chb_OP.IconColor = Color.FromArgb(245, 124, 37);
            chb_OP.Location = new Point(195, 331);
            chb_OP.MinimumSize = new Size(0, 40);
            chb_OP.Name = "chb_OP";
            chb_OP.Padding = new Padding(10, 0, 0, 0);
            chb_OP.Size = new Size(59, 40);
            chb_OP.Style = LED_DPS.Controls.Design.ControlStyle.Glass;
            chb_OP.TabIndex = 31;
            chb_OP.Text = "OP ";
            chb_OP.UseVisualStyleBackColor = true;
            chb_OP.CheckedChanged += chb_OP_CheckedChanged;
            // 
            // chb_Consulta
            // 
            chb_Consulta.AutoSize = true;
            chb_Consulta.BorderColor = Color.FromArgb(245, 124, 37);
            chb_Consulta.BorderSize = 1;
            chb_Consulta.Check = false;
            chb_Consulta.Customizable = false;
            chb_Consulta.Font = new Font("Verdana", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            chb_Consulta.ForeColor = Color.FromArgb(132, 129, 132);
            chb_Consulta.IconColor = Color.FromArgb(245, 124, 37);
            chb_Consulta.Location = new Point(32, 415);
            chb_Consulta.MinimumSize = new Size(0, 40);
            chb_Consulta.Name = "chb_Consulta";
            chb_Consulta.Padding = new Padding(10, 0, 0, 0);
            chb_Consulta.Size = new Size(98, 40);
            chb_Consulta.Style = LED_DPS.Controls.Design.ControlStyle.Glass;
            chb_Consulta.TabIndex = 30;
            chb_Consulta.Text = "Consulta ";
            chb_Consulta.UseVisualStyleBackColor = true;
            chb_Consulta.CheckedChanged += chb_Consulta_CheckedChanged;
            chb_Consulta.ChangeUICues += chb_Consulta_ChangeUICues;
            // 
            // chb_Embalagem
            // 
            chb_Embalagem.AutoSize = true;
            chb_Embalagem.BorderColor = Color.FromArgb(245, 124, 37);
            chb_Embalagem.BorderSize = 1;
            chb_Embalagem.Check = false;
            chb_Embalagem.Customizable = false;
            chb_Embalagem.Font = new Font("Verdana", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            chb_Embalagem.ForeColor = Color.FromArgb(132, 129, 132);
            chb_Embalagem.IconColor = Color.FromArgb(245, 124, 37);
            chb_Embalagem.Location = new Point(32, 373);
            chb_Embalagem.MinimumSize = new Size(0, 40);
            chb_Embalagem.Name = "chb_Embalagem";
            chb_Embalagem.Padding = new Padding(10, 0, 0, 0);
            chb_Embalagem.Size = new Size(119, 40);
            chb_Embalagem.Style = LED_DPS.Controls.Design.ControlStyle.Glass;
            chb_Embalagem.TabIndex = 29;
            chb_Embalagem.Text = "Embalagem  ";
            chb_Embalagem.UseVisualStyleBackColor = true;
            chb_Embalagem.CheckedChanged += chb_Embalagem_CheckedChanged;
            // 
            // chb_cadastro
            // 
            chb_cadastro.AutoSize = true;
            chb_cadastro.BorderColor = Color.FromArgb(245, 124, 37);
            chb_cadastro.BorderSize = 1;
            chb_cadastro.Check = false;
            chb_cadastro.Customizable = false;
            chb_cadastro.Font = new Font("Verdana", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            chb_cadastro.ForeColor = Color.FromArgb(132, 129, 132);
            chb_cadastro.IconColor = Color.FromArgb(245, 124, 37);
            chb_cadastro.Location = new Point(32, 331);
            chb_cadastro.MinimumSize = new Size(0, 40);
            chb_cadastro.Name = "chb_cadastro";
            chb_cadastro.Padding = new Padding(10, 0, 0, 0);
            chb_cadastro.Size = new Size(100, 40);
            chb_cadastro.Style = LED_DPS.Controls.Design.ControlStyle.Glass;
            chb_cadastro.TabIndex = 28;
            chb_cadastro.Text = "Cadastro ";
            chb_cadastro.UseVisualStyleBackColor = true;
            chb_cadastro.CheckedChanged += chb_cadastro_CheckedChanged;
            // 
            // rjLabel5
            // 
            rjLabel5.AutoSize = true;
            rjLabel5.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel5.ForeColor = Color.FromArgb(132, 129, 132);
            rjLabel5.LinkLabel = false;
            rjLabel5.Location = new Point(132, 298);
            rjLabel5.Name = "rjLabel5";
            rjLabel5.Size = new Size(56, 17);
            rjLabel5.Style = LED_DPS.Controls.Design.LabelStyle.Normal;
            rjLabel5.TabIndex = 27;
            rjLabel5.Text = "Acessos";
            // 
            // DgvUsuario
            // 
            DgvUsuario.AllowUserToResizeRows = false;
            DgvUsuario.AlternatingRowsColor = Color.Empty;
            DgvUsuario.AlternatingRowsColorApply = false;
            DgvUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgvUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvUsuario.BackgroundColor = Color.FromArgb(250, 252, 253);
            DgvUsuario.BorderRadius = 15;
            DgvUsuario.BorderStyle = BorderStyle.None;
            DgvUsuario.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DgvUsuario.ColumnHeaderColor = Color.Orange;
            DgvUsuario.ColumnHeaderFont = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            DgvUsuario.ColumnHeaderHeight = 40;
            DgvUsuario.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Orange;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(15, 0, 0, 0);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgvUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgvUsuario.ColumnHeadersHeight = 40;
            DgvUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DgvUsuario.ColumnHeaderTextColor = Color.White;
            DgvUsuario.ColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvUsuario.Customizable = false;
            DgvUsuario.DgvBackColor = Color.FromArgb(250, 252, 253);
            DgvUsuario.EnableHeadersVisualStyles = false;
            DgvUsuario.GridColor = Color.Gainsboro;
            DgvUsuario.Location = new Point(390, 28);
            DgvUsuario.Name = "DgvUsuario";
            DgvUsuario.RightToLeft = RightToLeft.No;
            DgvUsuario.RowHeaderColor = Color.WhiteSmoke;
            DgvUsuario.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(213, 199, 241);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DgvUsuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DgvUsuario.RowHeadersVisible = false;
            DgvUsuario.RowHeadersWidth = 30;
            DgvUsuario.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DgvUsuario.RowHeight = 40;
            DgvUsuario.RowsColor = Color.FromArgb(250, 252, 253);
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(250, 252, 253);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Gray;
            dataGridViewCellStyle3.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(213, 199, 241);
            dataGridViewCellStyle3.SelectionForeColor = Color.Gray;
            DgvUsuario.RowsDefaultCellStyle = dataGridViewCellStyle3;
            DgvUsuario.RowsTextColor = Color.Gray;
            DgvUsuario.RowTemplate.Height = 40;
            DgvUsuario.SelectionBackColor = Color.FromArgb(213, 199, 241);
            DgvUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvUsuario.SelectionTextColor = Color.Gray;
            DgvUsuario.Size = new Size(418, 556);
            DgvUsuario.TabIndex = 26;
            DgvUsuario.CellContentClick += DgvUsuario_CellContentClick;
            DgvUsuario.CellContentDoubleClick += DgvUsuario_CellContentDoubleClick;
            // 
            // rjLabel4
            // 
            rjLabel4.AutoSize = true;
            rjLabel4.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel4.ForeColor = Color.FromArgb(132, 129, 132);
            rjLabel4.LinkLabel = false;
            rjLabel4.Location = new Point(32, 239);
            rjLabel4.Name = "rjLabel4";
            rjLabel4.Size = new Size(40, 17);
            rjLabel4.Style = LED_DPS.Controls.Design.LabelStyle.Normal;
            rjLabel4.TabIndex = 25;
            rjLabel4.Text = "Setor";
            // 
            // cb_setor
            // 
            cb_setor.AutoCompleteMode = AutoCompleteMode.None;
            cb_setor.AutoCompleteSource = AutoCompleteSource.None;
            cb_setor.BackColor = Color.FromArgb(240, 245, 249);
            cb_setor.BorderColor = Color.FromArgb(132, 129, 132);
            cb_setor.BorderRadius = 15;
            cb_setor.BorderSize = 1;
            cb_setor.Customizable = false;
            cb_setor.DataSource = null;
            cb_setor.DropDownBackColor = Color.FromArgb(250, 252, 253);
            cb_setor.DropDownStyle = ComboBoxStyle.DropDown;
            cb_setor.DropDownTextColor = Color.FromArgb(132, 129, 132);
            cb_setor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cb_setor.IconColor = Color.FromArgb(245, 124, 37);
            cb_setor.Items.AddRange(new object[] { "PRODUÇÃO", "TI", "QUALIDADE", "ENGENHARIA", "RH", "LOGISTICA" });
            cb_setor.Location = new Point(32, 263);
            cb_setor.Name = "cb_setor";
            cb_setor.Padding = new Padding(2);
            cb_setor.RightToLeft = RightToLeft.No;
            cb_setor.SelectedIndex = -1;
            cb_setor.Size = new Size(250, 31);
            cb_setor.Style = LED_DPS.Controls.Design.ControlStyle.Glass;
            cb_setor.TabIndex = 24;
            cb_setor.Texts = "";
            // 
            // rjLabel3
            // 
            rjLabel3.AutoSize = true;
            rjLabel3.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel3.ForeColor = Color.FromArgb(132, 129, 132);
            rjLabel3.LinkLabel = false;
            rjLabel3.Location = new Point(32, 178);
            rjLabel3.Name = "rjLabel3";
            rjLabel3.Size = new Size(45, 17);
            rjLabel3.Style = LED_DPS.Controls.Design.LabelStyle.Normal;
            rjLabel3.TabIndex = 23;
            rjLabel3.Text = "Senha";
            // 
            // rjLabel2
            // 
            rjLabel2.AutoSize = true;
            rjLabel2.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel2.ForeColor = Color.FromArgb(132, 129, 132);
            rjLabel2.LinkLabel = false;
            rjLabel2.Location = new Point(32, 119);
            rjLabel2.Name = "rjLabel2";
            rjLabel2.Size = new Size(54, 17);
            rjLabel2.Style = LED_DPS.Controls.Design.LabelStyle.Normal;
            rjLabel2.TabIndex = 22;
            rjLabel2.Text = "Usuário";
            // 
            // rjLabel1
            // 
            rjLabel1.AutoSize = true;
            rjLabel1.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel1.ForeColor = Color.FromArgb(132, 129, 132);
            rjLabel1.LinkLabel = false;
            rjLabel1.Location = new Point(32, 62);
            rjLabel1.Name = "rjLabel1";
            rjLabel1.Size = new Size(45, 17);
            rjLabel1.Style = LED_DPS.Controls.Design.LabelStyle.Normal;
            rjLabel1.TabIndex = 21;
            rjLabel1.Text = "Nome";
            // 
            // chb_Import
            // 
            chb_Import.AutoSize = true;
            chb_Import.BorderColor = Color.FromArgb(245, 124, 37);
            chb_Import.BorderSize = 1;
            chb_Import.Check = false;
            chb_Import.Customizable = false;
            chb_Import.Font = new Font("Verdana", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            chb_Import.ForeColor = Color.FromArgb(132, 129, 132);
            chb_Import.IconColor = Color.FromArgb(245, 124, 37);
            chb_Import.Location = new Point(195, 415);
            chb_Import.MinimumSize = new Size(0, 40);
            chb_Import.Name = "chb_Import";
            chb_Import.Padding = new Padding(10, 0, 0, 0);
            chb_Import.Size = new Size(149, 40);
            chb_Import.Style = LED_DPS.Controls.Design.ControlStyle.Glass;
            chb_Import.TabIndex = 38;
            chb_Import.Text = "Importação SN   ";
            chb_Import.UseVisualStyleBackColor = true;
            chb_Import.CheckedChanged += chb_Import_CheckedChanged;
            // 
            // txt_Id_matricula
            // 
            txt_Id_matricula._Customizable = false;
            txt_Id_matricula.BackColor = Color.FromArgb(240, 245, 249);
            txt_Id_matricula.BorderColor = Color.FromArgb(246, 143, 69);
            txt_Id_matricula.BorderFocusColor = Color.FromArgb(55, 159, 113);
            txt_Id_matricula.BorderRadius = 15;
            txt_Id_matricula.BorderSize = 2;
            txt_Id_matricula.Font = new Font("Verdana", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Id_matricula.ForeColor = Color.FromArgb(132, 129, 132);
            txt_Id_matricula.Location = new Point(32, 28);
            txt_Id_matricula.MultiLine = false;
            txt_Id_matricula.Name = "txt_Id_matricula";
            txt_Id_matricula.Padding = new Padding(10, 7, 10, 7);
            txt_Id_matricula.PasswordChar = false;
            txt_Id_matricula.PlaceHolderColor = Color.DarkGray;
            txt_Id_matricula.PlaceHolderText = null;
            txt_Id_matricula.RightToLeft = RightToLeft.No;
            txt_Id_matricula.ScrollBars = ScrollBars.None;
            txt_Id_matricula.Size = new Size(250, 31);
            txt_Id_matricula.Style = LED_DPS.Controls.Design.TextBoxStyle.MatteBorder;
            txt_Id_matricula.TabIndex = 40;
            txt_Id_matricula.Texts = "";
            txt_Id_matricula.onTextChanged += txt_Id_matricula_onTextChanged;
            // 
            // rjLabel6
            // 
            rjLabel6.AutoSize = true;
            rjLabel6.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel6.ForeColor = Color.FromArgb(132, 129, 132);
            rjLabel6.LinkLabel = false;
            rjLabel6.Location = new Point(32, 10);
            rjLabel6.Name = "rjLabel6";
            rjLabel6.Size = new Size(64, 17);
            rjLabel6.Style = LED_DPS.Controls.Design.LabelStyle.Normal;
            rjLabel6.TabIndex = 39;
            rjLabel6.Text = "Matricula";
            // 
            // rjMenuIcon1
            // 
            rjMenuIcon1.BackColor = Color.Transparent;
            rjMenuIcon1.BackIcon = false;
            rjMenuIcon1.Customizable = false;
            rjMenuIcon1.DropdownMenu = null;
            rjMenuIcon1.ForeColor = Color.WhiteSmoke;
            rjMenuIcon1.IconChar = FontAwesome.Sharp.IconChar.SearchLocation;
            rjMenuIcon1.IconColor = Color.WhiteSmoke;
            rjMenuIcon1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            rjMenuIcon1.IconSize = 45;
            rjMenuIcon1.Location = new Point(288, 28);
            rjMenuIcon1.Name = "rjMenuIcon1";
            rjMenuIcon1.Size = new Size(45, 45);
            rjMenuIcon1.SizeMode = PictureBoxSizeMode.AutoSize;
            rjMenuIcon1.TabIndex = 41;
            rjMenuIcon1.TabStop = false;
            rjMenuIcon1.Click += rjMenuIcon1_Click;
            // 
            // FrmUsuario_C
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderColor = Color.FromArgb(245, 124, 37);
            BorderSize = 1;
            Caption = "FrmUsuario_C";
            ClientSize = new Size(960, 543);
            Name = "FrmUsuario_C";
            Padding = new Padding(1);
            Text = "FrmUsuario_C";
            Load += FrmUsuario_C_Load;
            pnlClientArea.ResumeLayout(false);
            pnlClientArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)rjMenuIcon1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RJControls.RJButton BtnAtualizar;
        private RJControls.RJButton BtnCadastro;
        private RJControls.RJtxt txt_senha;
        private RJControls.RJtxt txt_Usuario;
        private RJControls.RJtxt txt_nome;
        private RJControls.RJCheckBox chb_Adm;
        private RJControls.RJCheckBox chb_OP;
        private RJControls.RJCheckBox chb_Consulta;
        private RJControls.RJCheckBox chb_Embalagem;
        private RJControls.RJCheckBox chb_cadastro;
        private RJControls.RJLabel rjLabel5;
        private Controls.DataGridViewMini DgvUsuario;
        private RJControls.RJLabel rjLabel4;
        private RJControls.RJComboBox cb_setor;
        private RJControls.RJLabel rjLabel3;
        private RJControls.RJLabel rjLabel2;
        private RJControls.RJLabel rjLabel1;
        private RJControls.RJtxt txt_Id_matricula;
        private RJControls.RJLabel rjLabel6;
        private RJControls.RJCheckBox chb_Import;
        private RJControls.RJMenuIcon rjMenuIcon1;
    }
}