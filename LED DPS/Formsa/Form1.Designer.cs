namespace LED_DPS.Forms
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnEmbalagem = new RJControls.RJMenuButton();
            rjMenuIcon1 = new RJControls.RJMenuIcon();
            btnCadastro = new RJControls.RJMenuButton();
            btnOp = new RJControls.RJMenuButton();
            btnConsulta = new RJControls.RJMenuButton();
            rjDropdownMenu1 = new RJControls.RJDropdownMenu(components);
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem4 = new FontAwesome.Sharp.IconMenuItem();
            btnUser = new RJControls.RJMenuButton();
            rjMenuIcon2 = new RJControls.RJMenuIcon();
            label3 = new Label();
            label4 = new Label();
            btnlogin = new RJControls.RJButton();
            rjLabel3 = new RJControls.RJLabel();
            rjLabel4 = new RJControls.RJLabel();
            txtuser = new RJControls.RJTextBox();
            panel1 = new Panel();
            txtsenha = new RJControls.RJTextBox();
            btnImportSn = new RJControls.RJMenuButton();
            rjLabel1 = new RJControls.RJLabel();
            pnlSideMenu.SuspendLayout();
            pnlTitleBar.SuspendLayout();
            pnlDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rjMenuIcon1).BeginInit();
            rjDropdownMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rjMenuIcon2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSideMenu
            // 
            pnlSideMenu.Controls.Add(btnImportSn);
            pnlSideMenu.Controls.Add(btnUser);
            pnlSideMenu.Controls.Add(btnConsulta);
            pnlSideMenu.Controls.Add(btnOp);
            pnlSideMenu.Controls.Add(btnCadastro);
            pnlSideMenu.Controls.Add(btnEmbalagem);
            pnlSideMenu.Size = new Size(220, 708);
            pnlSideMenu.Controls.SetChildIndex(btnEmbalagem, 0);
            pnlSideMenu.Controls.SetChildIndex(btnCadastro, 0);
            pnlSideMenu.Controls.SetChildIndex(btnOp, 0);
            pnlSideMenu.Controls.SetChildIndex(btnConsulta, 0);
            pnlSideMenu.Controls.SetChildIndex(btnUser, 0);
            pnlSideMenu.Controls.SetChildIndex(btnImportSn, 0);
            // 
            // pnlSideMenuHeader
            // 
            pnlSideMenuHeader.BackColor = Color.FromArgb(230, 116, 34);
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.Controls.Add(rjLabel1);
            pnlTitleBar.Location = new Point(221, 1);
            pnlTitleBar.Size = new Size(1045, 60);
            pnlTitleBar.Controls.SetChildIndex(rjLabel1, 0);
            // 
            // pnlDesktop
            // 
            pnlDesktop.Controls.Add(panel1);
            pnlDesktop.Controls.Add(rjMenuIcon2);
            pnlDesktop.Controls.Add(rjMenuIcon1);
            pnlDesktop.Location = new Point(221, 86);
            pnlDesktop.Size = new Size(1045, 683);
            pnlDesktop.Paint += pnlDesktop_Paint;
            // 
            // pnlDesktopHeader
            // 
            pnlDesktopHeader.Location = new Point(221, 61);
            pnlDesktopHeader.Size = new Size(1045, 25);
            // 
            // btnEmbalagem
            // 
            btnEmbalagem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEmbalagem.BackColor = Color.FromArgb(255, 178, 91);
            btnEmbalagem.Dock = DockStyle.Top;
            btnEmbalagem.DropdownMenu = null;
            btnEmbalagem.Enabled = false;
            btnEmbalagem.FlatAppearance.BorderSize = 0;
            btnEmbalagem.FlatAppearance.MouseDownBackColor = Color.FromArgb(250, 252, 253);
            btnEmbalagem.FlatStyle = FlatStyle.Flat;
            btnEmbalagem.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmbalagem.ForeColor = Color.White;
            btnEmbalagem.IconChar = FontAwesome.Sharp.IconChar.Box;
            btnEmbalagem.IconColor = Color.White;
            btnEmbalagem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEmbalagem.IconSize = 28;
            btnEmbalagem.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmbalagem.Location = new Point(0, 65);
            btnEmbalagem.Name = "btnEmbalagem";
            btnEmbalagem.Padding = new Padding(12, 0, 0, 0);
            btnEmbalagem.Size = new Size(220, 55);
            btnEmbalagem.TabIndex = 1;
            btnEmbalagem.Text = "   Embalagem";
            btnEmbalagem.TextAlign = ContentAlignment.MiddleLeft;
            btnEmbalagem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmbalagem.UseVisualStyleBackColor = false;
            btnEmbalagem.Click += rjMenuButton1_Click;
            // 
            // rjMenuIcon1
            // 
            rjMenuIcon1.BackColor = Color.Transparent;
            rjMenuIcon1.BackIcon = false;
            rjMenuIcon1.Customizable = false;
            rjMenuIcon1.DropdownMenu = null;
            rjMenuIcon1.ForeColor = Color.WhiteSmoke;
            rjMenuIcon1.IconChar = FontAwesome.Sharp.IconChar.User;
            rjMenuIcon1.IconColor = Color.WhiteSmoke;
            rjMenuIcon1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            rjMenuIcon1.IconSize = 25;
            rjMenuIcon1.Location = new Point(1038, 679);
            rjMenuIcon1.Name = "rjMenuIcon1";
            rjMenuIcon1.Size = new Size(25, 25);
            rjMenuIcon1.SizeMode = PictureBoxSizeMode.AutoSize;
            rjMenuIcon1.TabIndex = 6;
            rjMenuIcon1.TabStop = false;
            // 
            // btnCadastro
            // 
            btnCadastro.BackColor = Color.FromArgb(255, 178, 91);
            btnCadastro.Dock = DockStyle.Top;
            btnCadastro.DropdownMenu = null;
            btnCadastro.Enabled = false;
            btnCadastro.FlatAppearance.BorderSize = 0;
            btnCadastro.FlatAppearance.MouseDownBackColor = Color.FromArgb(250, 252, 253);
            btnCadastro.FlatStyle = FlatStyle.Flat;
            btnCadastro.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastro.ForeColor = Color.White;
            btnCadastro.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            btnCadastro.IconColor = Color.White;
            btnCadastro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCadastro.IconSize = 28;
            btnCadastro.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadastro.Location = new Point(0, 120);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Padding = new Padding(12, 0, 0, 0);
            btnCadastro.Size = new Size(220, 55);
            btnCadastro.TabIndex = 2;
            btnCadastro.Text = "   Cadastro";
            btnCadastro.TextAlign = ContentAlignment.MiddleLeft;
            btnCadastro.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCadastro.UseVisualStyleBackColor = false;
            btnCadastro.Click += rjMenuButton2_Click;
            // 
            // btnOp
            // 
            btnOp.BackColor = Color.FromArgb(255, 178, 91);
            btnOp.Dock = DockStyle.Top;
            btnOp.DropdownMenu = null;
            btnOp.Enabled = false;
            btnOp.FlatAppearance.BorderSize = 0;
            btnOp.FlatAppearance.MouseDownBackColor = Color.FromArgb(250, 252, 253);
            btnOp.FlatStyle = FlatStyle.Flat;
            btnOp.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnOp.ForeColor = Color.White;
            btnOp.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            btnOp.IconColor = Color.White;
            btnOp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnOp.IconSize = 28;
            btnOp.ImageAlign = ContentAlignment.MiddleLeft;
            btnOp.Location = new Point(0, 175);
            btnOp.Name = "btnOp";
            btnOp.Padding = new Padding(12, 0, 0, 0);
            btnOp.Size = new Size(220, 55);
            btnOp.TabIndex = 3;
            btnOp.Text = "   OP's";
            btnOp.TextAlign = ContentAlignment.MiddleLeft;
            btnOp.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOp.UseVisualStyleBackColor = false;
            btnOp.Click += rjMenuButton3_Click;
            // 
            // btnConsulta
            // 
            btnConsulta.BackColor = Color.FromArgb(255, 178, 91);
            btnConsulta.BackgroundImage = (Image)resources.GetObject("btnConsulta.BackgroundImage");
            btnConsulta.Dock = DockStyle.Top;
            btnConsulta.DropdownMenu = rjDropdownMenu1;
            btnConsulta.Enabled = false;
            btnConsulta.FlatAppearance.BorderSize = 0;
            btnConsulta.FlatAppearance.MouseDownBackColor = Color.FromArgb(250, 252, 253);
            btnConsulta.FlatStyle = FlatStyle.Flat;
            btnConsulta.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsulta.ForeColor = Color.White;
            btnConsulta.IconChar = FontAwesome.Sharp.IconChar.Neuter;
            btnConsulta.IconColor = Color.White;
            btnConsulta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConsulta.IconSize = 28;
            btnConsulta.ImageAlign = ContentAlignment.MiddleLeft;
            btnConsulta.Location = new Point(0, 230);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Padding = new Padding(12, 0, 0, 0);
            btnConsulta.Size = new Size(220, 55);
            btnConsulta.TabIndex = 5;
            btnConsulta.Text = "   Consulta";
            btnConsulta.TextAlign = ContentAlignment.MiddleLeft;
            btnConsulta.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConsulta.UseVisualStyleBackColor = false;
            btnConsulta.Click += rjMenuButton5_Click;
            // 
            // rjDropdownMenu1
            // 
            rjDropdownMenu1.ActiveMenuItem = false;
            rjDropdownMenu1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rjDropdownMenu1.Items.AddRange(new ToolStripItem[] { iconMenuItem1, iconMenuItem2, iconMenuItem3, iconMenuItem4 });
            rjDropdownMenu1.Name = "rjDropdownMenu1";
            rjDropdownMenu1.OwnerIsMenuButton = false;
            rjDropdownMenu1.Size = new Size(152, 92);
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconMenuItem1.ForeColor = Color.FromArgb(64, 64, 64);
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(151, 22);
            iconMenuItem1.Text = "Graficos";
            iconMenuItem1.Click += iconMenuItem1_Click_1;
            // 
            // iconMenuItem2
            // 
            iconMenuItem2.BackColor = Color.Transparent;
            iconMenuItem2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconMenuItem2.ForeColor = Color.FromArgb(64, 64, 64);
            iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem2.IconColor = Color.Black;
            iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem2.Name = "iconMenuItem2";
            iconMenuItem2.Size = new Size(151, 22);
            iconMenuItem2.Text = "PCP";
            iconMenuItem2.Click += iconMenuItem2_Click_1;
            // 
            // iconMenuItem3
            // 
            iconMenuItem3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconMenuItem3.ForeColor = Color.FromArgb(64, 64, 64);
            iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem3.IconColor = Color.Black;
            iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem3.Name = "iconMenuItem3";
            iconMenuItem3.Size = new Size(151, 22);
            iconMenuItem3.Text = "Downtime";
            iconMenuItem3.Click += iconMenuItem3_Click;
            // 
            // iconMenuItem4
            // 
            iconMenuItem4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconMenuItem4.ForeColor = Color.FromArgb(64, 64, 64);
            iconMenuItem4.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem4.IconColor = Color.Black;
            iconMenuItem4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem4.Name = "iconMenuItem4";
            iconMenuItem4.Size = new Size(151, 22);
            iconMenuItem4.Text = "Consulta ML";
            iconMenuItem4.Click += iconMenuItem4_Click;
            // 
            // btnUser
            // 
            btnUser.BackColor = Color.FromArgb(255, 178, 91);
            btnUser.Dock = DockStyle.Top;
            btnUser.DropdownMenu = null;
            btnUser.Enabled = false;
            btnUser.FlatAppearance.BorderSize = 0;
            btnUser.FlatAppearance.MouseDownBackColor = Color.FromArgb(250, 252, 253);
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnUser.ForeColor = Color.White;
            btnUser.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            btnUser.IconColor = Color.White;
            btnUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUser.IconSize = 28;
            btnUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnUser.Location = new Point(0, 285);
            btnUser.Name = "btnUser";
            btnUser.Padding = new Padding(12, 0, 0, 0);
            btnUser.Size = new Size(220, 55);
            btnUser.TabIndex = 6;
            btnUser.Text = "   User";
            btnUser.TextAlign = ContentAlignment.MiddleLeft;
            btnUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUser.UseVisualStyleBackColor = false;
            btnUser.Click += rjMenuButton4_Click;
            // 
            // rjMenuIcon2
            // 
            rjMenuIcon2.BackColor = Color.Transparent;
            rjMenuIcon2.BackIcon = false;
            rjMenuIcon2.Customizable = false;
            rjMenuIcon2.DropdownMenu = null;
            rjMenuIcon2.ForeColor = Color.WhiteSmoke;
            rjMenuIcon2.IconChar = FontAwesome.Sharp.IconChar.User;
            rjMenuIcon2.IconColor = Color.WhiteSmoke;
            rjMenuIcon2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            rjMenuIcon2.IconSize = 25;
            rjMenuIcon2.Location = new Point(1029, 710);
            rjMenuIcon2.Name = "rjMenuIcon2";
            rjMenuIcon2.Size = new Size(25, 25);
            rjMenuIcon2.SizeMode = PictureBoxSizeMode.AutoSize;
            rjMenuIcon2.TabIndex = 7;
            rjMenuIcon2.TabStop = false;
            rjMenuIcon2.Click += rjMenuIcon2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(177, 84);
            label3.Name = "label3";
            label3.Size = new Size(98, 42);
            label3.TabIndex = 23;
            label3.Text = "DPS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(255, 128, 0);
            label4.Location = new Point(104, 84);
            label4.Name = "label4";
            label4.Size = new Size(87, 42);
            label4.TabIndex = 22;
            label4.Text = "Led";
            // 
            // btnlogin
            // 
            btnlogin._1_Size = new Size(180, 70);
            btnlogin.AutoSize = true;
            btnlogin.BackColor = Color.FromArgb(245, 124, 37);
            btnlogin.BorderColor = Color.FromArgb(245, 124, 37);
            btnlogin.BorderRadius = 15;
            btnlogin.BorderSize = 0;
            btnlogin.Design = LED_DPS.Controls.Design.ButtonDesign.Normal;
            btnlogin.FlatAppearance.BorderSize = 0;
            btnlogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, 116, 34);
            btnlogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 109, 32);
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnlogin.ForeColor = Color.White;
            btnlogin.IconChar = FontAwesome.Sharp.IconChar.Lock;
            btnlogin.IconColor = Color.White;
            btnlogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnlogin.IconSize = 35;
            btnlogin.Location = new Point(101, 338);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(180, 70);
            btnlogin.Style = LED_DPS.Controls.Design.ControlStyle.Solid;
            btnlogin.TabIndex = 21;
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // rjLabel3
            // 
            rjLabel3.AutoSize = true;
            rjLabel3.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel3.ForeColor = Color.FromArgb(132, 129, 132);
            rjLabel3.LinkLabel = false;
            rjLabel3.Location = new Point(59, 246);
            rjLabel3.Name = "rjLabel3";
            rjLabel3.Size = new Size(45, 17);
            rjLabel3.Style = LED_DPS.Controls.Design.LabelStyle.Normal;
            rjLabel3.TabIndex = 20;
            rjLabel3.Text = "Senha";
            // 
            // rjLabel4
            // 
            rjLabel4.AutoSize = true;
            rjLabel4.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel4.ForeColor = Color.FromArgb(132, 129, 132);
            rjLabel4.LinkLabel = false;
            rjLabel4.Location = new Point(59, 174);
            rjLabel4.Name = "rjLabel4";
            rjLabel4.Size = new Size(54, 17);
            rjLabel4.Style = LED_DPS.Controls.Design.LabelStyle.Normal;
            rjLabel4.TabIndex = 19;
            rjLabel4.Text = "Usuario";
            // 
            // txtuser
            // 
            txtuser._Customizable = false;
            txtuser.AutoSize = true;
            txtuser.BackColor = Color.FromArgb(240, 245, 249);
            txtuser.BorderColor = Color.FromArgb(132, 129, 132);
            txtuser.BorderFocusColor = Color.FromArgb(246, 143, 69);
            txtuser.BorderRadius = 15;
            txtuser.BorderSize = 2;
            txtuser.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtuser.ForeColor = Color.FromArgb(132, 129, 132);
            txtuser.Location = new Point(59, 194);
            txtuser.MultiLine = true;
            txtuser.Name = "txtuser";
            txtuser.Padding = new Padding(10, 7, 10, 7);
            txtuser.PasswordChar = false;
            txtuser.PlaceHolderColor = Color.DarkGray;
            txtuser.PlaceHolderText = null;
            txtuser.ScrollBars = ScrollBars.None;
            txtuser.Size = new Size(262, 39);
            txtuser.Style = LED_DPS.Controls.Design.TextBoxStyle.MatteBorder;
            txtuser.TabIndex = 18;
            txtuser.onTextChanged += txtuser_onTextChanged;
            txtuser.Leave += txtuser_Leave;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(txtsenha);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnlogin);
            panel1.Controls.Add(txtuser);
            panel1.Controls.Add(rjLabel3);
            panel1.Controls.Add(rjLabel4);
            panel1.Location = new Point(325, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(379, 503);
            panel1.TabIndex = 18;
            // 
            // txtsenha
            // 
            txtsenha._Customizable = false;
            txtsenha.AutoSize = true;
            txtsenha.BackColor = Color.FromArgb(240, 245, 249);
            txtsenha.BorderColor = Color.FromArgb(132, 129, 132);
            txtsenha.BorderFocusColor = Color.FromArgb(246, 143, 69);
            txtsenha.BorderRadius = 15;
            txtsenha.BorderSize = 2;
            txtsenha.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtsenha.ForeColor = Color.FromArgb(132, 129, 132);
            txtsenha.Location = new Point(59, 266);
            txtsenha.MultiLine = false;
            txtsenha.Name = "txtsenha";
            txtsenha.Padding = new Padding(10, 7, 10, 7);
            txtsenha.PasswordChar = true;
            txtsenha.PlaceHolderColor = Color.DarkGray;
            txtsenha.PlaceHolderText = null;
            txtsenha.ScrollBars = ScrollBars.None;
            txtsenha.Size = new Size(262, 34);
            txtsenha.Style = LED_DPS.Controls.Design.TextBoxStyle.MatteBorder;
            txtsenha.TabIndex = 24;
            txtsenha.onTextChanged += txtsenha_onTextChanged;
            // 
            // btnImportSn
            // 
            btnImportSn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnImportSn.BackColor = Color.FromArgb(255, 178, 91);
            btnImportSn.Dock = DockStyle.Top;
            btnImportSn.DropdownMenu = null;
            btnImportSn.Enabled = false;
            btnImportSn.FlatAppearance.BorderSize = 0;
            btnImportSn.FlatAppearance.MouseDownBackColor = Color.FromArgb(250, 252, 253);
            btnImportSn.FlatStyle = FlatStyle.Flat;
            btnImportSn.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnImportSn.ForeColor = Color.White;
            btnImportSn.IconChar = FontAwesome.Sharp.IconChar.Barcode;
            btnImportSn.IconColor = Color.White;
            btnImportSn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnImportSn.IconSize = 28;
            btnImportSn.ImageAlign = ContentAlignment.MiddleLeft;
            btnImportSn.Location = new Point(0, 340);
            btnImportSn.Name = "btnImportSn";
            btnImportSn.Padding = new Padding(12, 0, 0, 0);
            btnImportSn.Size = new Size(220, 55);
            btnImportSn.TabIndex = 7;
            btnImportSn.Text = "   Importação SN";
            btnImportSn.TextAlign = ContentAlignment.MiddleLeft;
            btnImportSn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnImportSn.UseVisualStyleBackColor = false;
            btnImportSn.Click += rjMenuButton1_Click_2;
            // 
            // rjLabel1
            // 
            rjLabel1.AutoSize = true;
            rjLabel1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel1.ForeColor = Color.FromArgb(132, 129, 132);
            rjLabel1.LinkLabel = false;
            rjLabel1.Location = new Point(46, 39);
            rjLabel1.Name = "rjLabel1";
            rjLabel1.Size = new Size(100, 17);
            rjLabel1.Style = LED_DPS.Controls.Design.LabelStyle.Normal;
            rjLabel1.TabIndex = 26;
            rjLabel1.Text = "Versão 1.0.0.31";
            rjLabel1.Click += rjLabel1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderColor = Color.FromArgb(245, 124, 37);
            BorderSize = 1;
            ClientSize = new Size(1267, 770);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Padding = new Padding(1);
            Text = "Form1";
            Load += Form1_Load;
            Controls.SetChildIndex(pnlTitleBar, 0);
            Controls.SetChildIndex(pnlDesktopHeader, 0);
            Controls.SetChildIndex(pnlDesktop, 0);
            pnlSideMenu.ResumeLayout(false);
            pnlTitleBar.ResumeLayout(false);
            pnlTitleBar.PerformLayout();
            pnlDesktop.ResumeLayout(false);
            pnlDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)rjMenuIcon1).EndInit();
            rjDropdownMenu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)rjMenuIcon2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RJControls.RJMenuButton btnEmbalagem;
        private RJControls.RJMenuIcon rjMenuIcon1;
        private RJControls.RJMenuButton btnCadastro;
        private RJControls.RJMenuButton btnOp;
        private RJControls.RJMenuButton btnConsulta;
        private RJControls.RJMenuButton btnUser;
        private RJControls.RJMenuIcon rjMenuIcon2;
        private Label label3;
        private Label label4;
        private RJControls.RJButton btnlogin;
        private RJControls.RJLabel rjLabel3;
        private RJControls.RJLabel rjLabel4;
        private RJControls.RJTextBox txtuser;
        private Panel panel1;
        private RJControls.RJTextBox txtsenha;
        private RJControls.RJMenuButton btnImportSn;
        private RJControls.RJLabel rjLabel1;
        private RJControls.RJDropdownMenu rjDropdownMenu1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem4;
    }
}