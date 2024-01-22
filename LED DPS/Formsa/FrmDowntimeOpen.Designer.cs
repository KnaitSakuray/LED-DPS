namespace LED_DPS.Formsa
{
    partial class FrmDowntimeOpen
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
            rjLabel4 = new RJControls.RJLabel();
            cb_categoria = new RJControls.RJComboBox();
            rjLabel1 = new RJControls.RJLabel();
            txt_descricao = new RJControls.RJTextBox();
            rjLabel2 = new RJControls.RJLabel();
            lblH = new Label();
            btn_Iniciar = new RJControls.RJButton();
            btn_finalizar = new RJControls.RJButton();
            rjLabel3 = new RJControls.RJLabel();
            rjLabel5 = new RJControls.RJLabel();
            rjLabel6 = new RJControls.RJLabel();
            lbldowntime = new RJControls.RJLabel();
            cb_setor = new RJControls.RJComboBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            lblM = new Label();
            label3 = new Label();
            lblS = new Label();
            labelAvisos = new Label();
            pnlClientArea.SuspendLayout();
            SuspendLayout();
            // 
            // pnlClientArea
            // 
            pnlClientArea.BackColor = Color.FromArgb(240, 245, 249);
            pnlClientArea.Controls.Add(labelAvisos);
            pnlClientArea.Controls.Add(lblS);
            pnlClientArea.Controls.Add(label3);
            pnlClientArea.Controls.Add(lblM);
            pnlClientArea.Controls.Add(label1);
            pnlClientArea.Controls.Add(cb_setor);
            pnlClientArea.Controls.Add(lbldowntime);
            pnlClientArea.Controls.Add(rjLabel6);
            pnlClientArea.Controls.Add(rjLabel5);
            pnlClientArea.Controls.Add(rjLabel3);
            pnlClientArea.Controls.Add(btn_finalizar);
            pnlClientArea.Controls.Add(btn_Iniciar);
            pnlClientArea.Controls.Add(lblH);
            pnlClientArea.Controls.Add(rjLabel2);
            pnlClientArea.Controls.Add(txt_descricao);
            pnlClientArea.Controls.Add(rjLabel1);
            pnlClientArea.Controls.Add(cb_categoria);
            pnlClientArea.Controls.Add(rjLabel4);
            pnlClientArea.Location = new Point(1, 41);
            pnlClientArea.Size = new Size(958, 408);
            // 
            // rjLabel4
            // 
            rjLabel4.AutoSize = true;
            rjLabel4.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel4.ForeColor = Color.FromArgb(132, 129, 132);
            rjLabel4.LinkLabel = false;
            rjLabel4.Location = new Point(40, 101);
            rjLabel4.Name = "rjLabel4";
            rjLabel4.Size = new Size(44, 17);
            rjLabel4.Style = LED_DPS.Controls.Design.LabelStyle.Normal;
            rjLabel4.TabIndex = 25;
            rjLabel4.Text = "Setor:";
            // 
            // cb_categoria
            // 
            cb_categoria.AutoCompleteMode = AutoCompleteMode.None;
            cb_categoria.AutoCompleteSource = AutoCompleteSource.None;
            cb_categoria.BackColor = Color.FromArgb(240, 245, 249);
            cb_categoria.BorderColor = Color.FromArgb(132, 129, 132);
            cb_categoria.BorderRadius = 15;
            cb_categoria.BorderSize = 1;
            cb_categoria.Customizable = false;
            cb_categoria.DataSource = null;
            cb_categoria.DropDownBackColor = Color.FromArgb(250, 252, 253);
            cb_categoria.DropDownStyle = ComboBoxStyle.DropDown;
            cb_categoria.DropDownTextColor = Color.FromArgb(132, 129, 132);
            cb_categoria.IconColor = Color.FromArgb(245, 124, 37);
            cb_categoria.Location = new Point(265, 121);
            cb_categoria.Name = "cb_categoria";
            cb_categoria.Padding = new Padding(2);
            cb_categoria.SelectedIndex = -1;
            cb_categoria.Size = new Size(323, 32);
            cb_categoria.Style = LED_DPS.Controls.Design.ControlStyle.Glass;
            cb_categoria.TabIndex = 27;
            cb_categoria.Texts = "";
            // 
            // rjLabel1
            // 
            rjLabel1.AutoSize = true;
            rjLabel1.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel1.ForeColor = Color.FromArgb(132, 129, 132);
            rjLabel1.LinkLabel = false;
            rjLabel1.Location = new Point(265, 101);
            rjLabel1.Name = "rjLabel1";
            rjLabel1.Size = new Size(54, 17);
            rjLabel1.Style = LED_DPS.Controls.Design.LabelStyle.Normal;
            rjLabel1.TabIndex = 28;
            rjLabel1.Text = "Motivo:";
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
            txt_descricao.Location = new Point(40, 175);
            txt_descricao.MultiLine = true;
            txt_descricao.Name = "txt_descricao";
            txt_descricao.Padding = new Padding(10, 7, 10, 7);
            txt_descricao.PasswordChar = false;
            txt_descricao.PlaceHolderColor = Color.DarkGray;
            txt_descricao.PlaceHolderText = null;
            txt_descricao.ScrollBars = ScrollBars.None;
            txt_descricao.Size = new Size(548, 75);
            txt_descricao.Style = LED_DPS.Controls.Design.TextBoxStyle.MatteBorder;
            txt_descricao.TabIndex = 34;
            // 
            // rjLabel2
            // 
            rjLabel2.AutoSize = true;
            rjLabel2.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel2.ForeColor = Color.FromArgb(132, 129, 132);
            rjLabel2.LinkLabel = false;
            rjLabel2.Location = new Point(40, 155);
            rjLabel2.Name = "rjLabel2";
            rjLabel2.Size = new Size(83, 17);
            rjLabel2.Style = LED_DPS.Controls.Design.LabelStyle.Normal;
            rjLabel2.TabIndex = 35;
            rjLabel2.Text = "Observação:";
            // 
            // lblH
            // 
            lblH.AutoSize = true;
            lblH.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblH.ForeColor = Color.FromArgb(64, 0, 0);
            lblH.Location = new Point(30, 253);
            lblH.Name = "lblH";
            lblH.Size = new Size(93, 59);
            lblH.TabIndex = 36;
            lblH.Text = "00";
            // 
            // btn_Iniciar
            // 
            btn_Iniciar._1_Size = new Size(200, 70);
            btn_Iniciar.BackColor = Color.FromArgb(245, 124, 37);
            btn_Iniciar.BorderColor = Color.FromArgb(245, 124, 37);
            btn_Iniciar.BorderRadius = 15;
            btn_Iniciar.BorderSize = 0;
            btn_Iniciar.Design = LED_DPS.Controls.Design.ButtonDesign.Normal;
            btn_Iniciar.FlatAppearance.BorderSize = 0;
            btn_Iniciar.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, 116, 34);
            btn_Iniciar.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 109, 32);
            btn_Iniciar.FlatStyle = FlatStyle.Flat;
            btn_Iniciar.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Iniciar.ForeColor = Color.White;
            btn_Iniciar.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateBackward;
            btn_Iniciar.IconColor = Color.White;
            btn_Iniciar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Iniciar.IconSize = 1;
            btn_Iniciar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Iniciar.Location = new Point(40, 27);
            btn_Iniciar.Name = "btn_Iniciar";
            btn_Iniciar.Size = new Size(200, 70);
            btn_Iniciar.Style = LED_DPS.Controls.Design.ControlStyle.Solid;
            btn_Iniciar.TabIndex = 37;
            btn_Iniciar.Text = "INICIAR";
            btn_Iniciar.UseVisualStyleBackColor = false;
            btn_Iniciar.Click += ButtonIniciar_Click;
            // 
            // btn_finalizar
            // 
            btn_finalizar._1_Size = new Size(213, 70);
            btn_finalizar.BackColor = Color.FromArgb(245, 124, 37);
            btn_finalizar.BorderColor = Color.FromArgb(245, 124, 37);
            btn_finalizar.BorderRadius = 15;
            btn_finalizar.BorderSize = 0;
            btn_finalizar.Design = LED_DPS.Controls.Design.ButtonDesign.Normal;
            btn_finalizar.FlatAppearance.BorderSize = 0;
            btn_finalizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, 116, 34);
            btn_finalizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 109, 32);
            btn_finalizar.FlatStyle = FlatStyle.Flat;
            btn_finalizar.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_finalizar.ForeColor = Color.White;
            btn_finalizar.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateBackward;
            btn_finalizar.IconColor = Color.White;
            btn_finalizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_finalizar.IconSize = 1;
            btn_finalizar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_finalizar.Location = new Point(40, 335);
            btn_finalizar.Name = "btn_finalizar";
            btn_finalizar.Size = new Size(213, 70);
            btn_finalizar.Style = LED_DPS.Controls.Design.ControlStyle.Solid;
            btn_finalizar.TabIndex = 38;
            btn_finalizar.Text = "FINALIZAR";
            btn_finalizar.UseVisualStyleBackColor = false;
            btn_finalizar.Click += ButtonParar_Click;
            // 
            // rjLabel3
            // 
            rjLabel3.AutoSize = true;
            rjLabel3.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel3.ForeColor = Color.FromArgb(132, 129, 132);
            rjLabel3.LinkLabel = false;
            rjLabel3.Location = new Point(40, 7);
            rjLabel3.Name = "rjLabel3";
            rjLabel3.Size = new Size(200, 17);
            rjLabel3.Style = LED_DPS.Controls.Design.LabelStyle.Normal;
            rjLabel3.TabIndex = 39;
            rjLabel3.Text = "Inicia a contagem do donwtime";
            // 
            // rjLabel5
            // 
            rjLabel5.AutoSize = true;
            rjLabel5.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel5.ForeColor = Color.FromArgb(132, 129, 132);
            rjLabel5.LinkLabel = false;
            rjLabel5.Location = new Point(40, 315);
            rjLabel5.Name = "rjLabel5";
            rjLabel5.Size = new Size(213, 17);
            rjLabel5.Style = LED_DPS.Controls.Design.LabelStyle.Normal;
            rjLabel5.TabIndex = 40;
            rjLabel5.Text = "Finaliza a contagem do donwtime";
            // 
            // rjLabel6
            // 
            rjLabel6.AutoSize = true;
            rjLabel6.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            rjLabel6.ForeColor = Color.FromArgb(132, 129, 132);
            rjLabel6.LinkLabel = false;
            rjLabel6.Location = new Point(455, 27);
            rjLabel6.Name = "rjLabel6";
            rjLabel6.Size = new Size(73, 17);
            rjLabel6.Style = LED_DPS.Controls.Design.LabelStyle.Normal;
            rjLabel6.TabIndex = 42;
            rjLabel6.Text = "Downtime:";
            // 
            // lbldowntime
            // 
            lbldowntime.AutoSize = true;
            lbldowntime.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            lbldowntime.ForeColor = Color.FromArgb(132, 129, 132);
            lbldowntime.LinkLabel = false;
            lbldowntime.Location = new Point(534, 27);
            lbldowntime.Name = "lbldowntime";
            lbldowntime.Size = new Size(17, 17);
            lbldowntime.Style = LED_DPS.Controls.Design.LabelStyle.Normal;
            lbldowntime.TabIndex = 43;
            lbldowntime.Text = "...";
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
            cb_setor.IconColor = Color.FromArgb(245, 124, 37);
            cb_setor.Location = new Point(40, 120);
            cb_setor.Name = "cb_setor";
            cb_setor.Padding = new Padding(2);
            cb_setor.SelectedIndex = -1;
            cb_setor.Size = new Size(200, 32);
            cb_setor.Style = LED_DPS.Controls.Design.ControlStyle.Glass;
            cb_setor.TabIndex = 44;
            cb_setor.Texts = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(107, 253);
            label1.Name = "label1";
            label1.Size = new Size(44, 59);
            label1.TabIndex = 45;
            label1.Text = ":";
            // 
            // lblM
            // 
            lblM.AutoSize = true;
            lblM.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblM.ForeColor = Color.FromArgb(64, 0, 0);
            lblM.Location = new Point(129, 253);
            lblM.Name = "lblM";
            lblM.Size = new Size(93, 59);
            lblM.TabIndex = 46;
            lblM.Text = "00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Location = new Point(209, 253);
            label3.Name = "label3";
            label3.Size = new Size(44, 59);
            label3.TabIndex = 47;
            label3.Text = ":";
            // 
            // lblS
            // 
            lblS.AutoSize = true;
            lblS.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblS.ForeColor = Color.FromArgb(64, 0, 0);
            lblS.Location = new Point(237, 256);
            lblS.Name = "lblS";
            lblS.Size = new Size(93, 59);
            lblS.TabIndex = 48;
            lblS.Text = "00";
            // 
            // labelAvisos
            // 
            labelAvisos.AutoSize = true;
            labelAvisos.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelAvisos.ForeColor = Color.Red;
            labelAvisos.Location = new Point(247, 62);
            labelAvisos.Name = "labelAvisos";
            labelAvisos.Size = new Size(341, 35);
            labelAvisos.TabIndex = 49;
            labelAvisos.Text = "Parada Já Solicitada";
            // 
            // FrmDowntimeOpen
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderColor = Color.FromArgb(245, 124, 37);
            BorderSize = 1;
            Caption = "FrmDowntimeOpen";
            ClientSize = new Size(960, 450);
            Name = "FrmDowntimeOpen";
            Padding = new Padding(1);
            Text = "FrmDowntimeOpen";
            pnlClientArea.ResumeLayout(false);
            pnlClientArea.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RJControls.RJLabel rjLabel4;
        private RJControls.RJLabel rjLabel1;
        private RJControls.RJComboBox cb_categoria;
        private RJControls.RJLabel rjLabel2;
        private RJControls.RJTextBox txt_descricao;
        private Label lblH;
        private RJControls.RJLabel rjLabel5;
        private RJControls.RJLabel rjLabel3;
        private RJControls.RJButton btn_finalizar;
        private RJControls.RJButton btn_Iniciar;
        private RJControls.RJLabel lbldowntime;
        private RJControls.RJLabel rjLabel6;
        private RJControls.RJComboBox cb_setor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Label lblS;
        private Label label3;
        private Label lblM;
        private Label label1;
        private Label labelAvisos;
    }
}