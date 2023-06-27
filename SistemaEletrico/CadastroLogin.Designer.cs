
namespace SistemaEletrico
{
    partial class CadastroLogin
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
            this.Cadastrar = new System.Windows.Forms.TabPage();
            this.mt_tp_docu = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ms_Senha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SLT_User = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mlb_dt_admissao = new MaterialSkin.Controls.MaterialLabel();
            this.mlb_Cargo = new MaterialSkin.Controls.MaterialLabel();
            this.mlb_setor = new MaterialSkin.Controls.MaterialLabel();
            this.mt_dt_admissao = new MetroFramework.Controls.MetroDateTime();
            this.txt_Cargo = new System.Windows.Forms.TextBox();
            this.cb_setor = new MetroFramework.Controls.MetroComboBox();
            this.gb_Pessoal = new System.Windows.Forms.GroupBox();
            this.mlb_endereco2 = new MetroFramework.Controls.MetroComboBox();
            this.mtbox_endereco2 = new MetroFramework.Controls.MetroTextBox();
            this.mlb_end2 = new MaterialSkin.Controls.MaterialLabel();
            this.mlb_endereco1 = new MetroFramework.Controls.MetroComboBox();
            this.mtbox_endereco1 = new MetroFramework.Controls.MetroTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.mlb_end1 = new MaterialSkin.Controls.MaterialLabel();
            this.mlb_situacao_cadastro = new MaterialSkin.Controls.MaterialLabel();
            this.mtxt_Email = new MetroFramework.Controls.MetroTextBox();
            this.mlb_Email = new MaterialSkin.Controls.MaterialLabel();
            this.mtxt_Contato = new MetroFramework.Controls.MetroTextBox();
            this.mlb_Contato = new MaterialSkin.Controls.MaterialLabel();
            this.mlb_tp_cadastro = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.mlb_Sexo = new MaterialSkin.Controls.MaterialLabel();
            this.mlb_Dt_Cadastro = new MaterialSkin.Controls.MaterialLabel();
            this.mtxt_Cpf_Cnpj = new MetroFramework.Controls.MetroTextBox();
            this.mlb_Cpf_Cnpj = new MaterialSkin.Controls.MaterialLabel();
            this.mtxtb_Nome = new MetroFramework.Controls.MetroTextBox();
            this.mlb_Nome = new MaterialSkin.Controls.MaterialLabel();
            this.cb_tp_cadastro = new MetroFramework.Controls.MetroComboBox();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.cb_Sexo = new MetroFramework.Controls.MetroComboBox();
            this.dt_dt_nasc = new MetroFramework.Controls.MetroDateTime();
            this.mt_dt_cadastro = new MetroFramework.Controls.MetroDateTime();
            this.mbt_salvar = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.Cadastrar.SuspendLayout();
            this.mt_tp_docu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gb_Pessoal.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cadastrar
            // 
            this.Cadastrar.Controls.Add(this.mt_tp_docu);
            this.Cadastrar.ImageKey = "icons8-add-user-male-32.png";
            this.Cadastrar.Location = new System.Drawing.Point(4, 22);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Padding = new System.Windows.Forms.Padding(3);
            this.Cadastrar.Size = new System.Drawing.Size(1165, 508);
            this.Cadastrar.TabIndex = 5;
            this.Cadastrar.Text = "CADASTRAR";
            this.Cadastrar.UseVisualStyleBackColor = true;
            // 
            // mt_tp_docu
            // 
            this.mt_tp_docu.BackColor = System.Drawing.Color.White;
            this.mt_tp_docu.Controls.Add(this.groupBox1);
            this.mt_tp_docu.Controls.Add(this.groupBox3);
            this.mt_tp_docu.Controls.Add(this.gb_Pessoal);
            this.mt_tp_docu.Controls.Add(this.mbt_salvar);
            this.mt_tp_docu.Location = new System.Drawing.Point(18, 10);
            this.mt_tp_docu.Name = "mt_tp_docu";
            this.mt_tp_docu.Size = new System.Drawing.Size(1130, 485);
            this.mt_tp_docu.TabIndex = 7;
            this.mt_tp_docu.TabStop = false;
            this.mt_tp_docu.Text = "Novo Cadastro";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ms_Senha);
            this.groupBox1.Controls.Add(this.SLT_User);
            this.groupBox1.Location = new System.Drawing.Point(17, 366);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 86);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuário";
            // 
            // ms_Senha
            // 
            this.ms_Senha.Depth = 0;
            this.ms_Senha.Hint = "SENHA";
            this.ms_Senha.Location = new System.Drawing.Point(323, 37);
            this.ms_Senha.Margin = new System.Windows.Forms.Padding(2);
            this.ms_Senha.MaxLength = 32767;
            this.ms_Senha.MouseState = MaterialSkin.MouseState.HOVER;
            this.ms_Senha.Name = "ms_Senha";
            this.ms_Senha.PasswordChar = '*';
            this.ms_Senha.SelectedText = "";
            this.ms_Senha.SelectionLength = 0;
            this.ms_Senha.SelectionStart = 0;
            this.ms_Senha.Size = new System.Drawing.Size(163, 23);
            this.ms_Senha.TabIndex = 13;
            this.ms_Senha.TabStop = false;
            this.ms_Senha.UseSystemPasswordChar = false;
            // 
            // SLT_User
            // 
            this.SLT_User.Depth = 0;
            this.SLT_User.Hint = "USUÁRIO";
            this.SLT_User.Location = new System.Drawing.Point(26, 37);
            this.SLT_User.Margin = new System.Windows.Forms.Padding(2);
            this.SLT_User.MaxLength = 32767;
            this.SLT_User.MouseState = MaterialSkin.MouseState.HOVER;
            this.SLT_User.Name = "SLT_User";
            this.SLT_User.PasswordChar = '\0';
            this.SLT_User.SelectedText = "";
            this.SLT_User.SelectionLength = 0;
            this.SLT_User.SelectionStart = 0;
            this.SLT_User.Size = new System.Drawing.Size(163, 23);
            this.SLT_User.TabIndex = 12;
            this.SLT_User.TabStop = false;
            this.SLT_User.UseSystemPasswordChar = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mlb_dt_admissao);
            this.groupBox3.Controls.Add(this.mlb_Cargo);
            this.groupBox3.Controls.Add(this.mlb_setor);
            this.groupBox3.Controls.Add(this.mt_dt_admissao);
            this.groupBox3.Controls.Add(this.txt_Cargo);
            this.groupBox3.Controls.Add(this.cb_setor);
            this.groupBox3.Location = new System.Drawing.Point(17, 269);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1094, 86);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Profissional";
            // 
            // mlb_dt_admissao
            // 
            this.mlb_dt_admissao.AutoSize = true;
            this.mlb_dt_admissao.Depth = 0;
            this.mlb_dt_admissao.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlb_dt_admissao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlb_dt_admissao.Location = new System.Drawing.Point(719, 35);
            this.mlb_dt_admissao.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlb_dt_admissao.Name = "mlb_dt_admissao";
            this.mlb_dt_admissao.Size = new System.Drawing.Size(132, 19);
            this.mlb_dt_admissao.TabIndex = 69;
            this.mlb_dt_admissao.Text = "Data de Admissão";
            // 
            // mlb_Cargo
            // 
            this.mlb_Cargo.AutoSize = true;
            this.mlb_Cargo.Depth = 0;
            this.mlb_Cargo.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlb_Cargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlb_Cargo.Location = new System.Drawing.Point(347, 37);
            this.mlb_Cargo.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlb_Cargo.Name = "mlb_Cargo";
            this.mlb_Cargo.Size = new System.Drawing.Size(49, 19);
            this.mlb_Cargo.TabIndex = 68;
            this.mlb_Cargo.Text = "Cargo";
            // 
            // mlb_setor
            // 
            this.mlb_setor.AutoSize = true;
            this.mlb_setor.Depth = 0;
            this.mlb_setor.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlb_setor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlb_setor.Location = new System.Drawing.Point(45, 42);
            this.mlb_setor.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlb_setor.Name = "mlb_setor";
            this.mlb_setor.Size = new System.Drawing.Size(45, 19);
            this.mlb_setor.TabIndex = 67;
            this.mlb_setor.Text = "Setor";
            // 
            // mt_dt_admissao
            // 
            this.mt_dt_admissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mt_dt_admissao.Location = new System.Drawing.Point(871, 27);
            this.mt_dt_admissao.MinimumSize = new System.Drawing.Size(0, 29);
            this.mt_dt_admissao.Name = "mt_dt_admissao";
            this.mt_dt_admissao.Size = new System.Drawing.Size(206, 29);
            this.mt_dt_admissao.TabIndex = 11;
            this.mt_dt_admissao.Value = new System.DateTime(2023, 3, 18, 0, 0, 0, 0);
            // 
            // txt_Cargo
            // 
            this.txt_Cargo.Location = new System.Drawing.Point(402, 37);
            this.txt_Cargo.Name = "txt_Cargo";
            this.txt_Cargo.Size = new System.Drawing.Size(276, 20);
            this.txt_Cargo.TabIndex = 9;
            // 
            // cb_setor
            // 
            this.cb_setor.FormattingEnabled = true;
            this.cb_setor.ItemHeight = 23;
            this.cb_setor.Items.AddRange(new object[] {
            "Vendas",
            "Financeiro",
            "Gerencia"});
            this.cb_setor.Location = new System.Drawing.Point(101, 35);
            this.cb_setor.Name = "cb_setor";
            this.cb_setor.Size = new System.Drawing.Size(196, 29);
            this.cb_setor.TabIndex = 8;
            this.cb_setor.UseSelectable = true;
            // 
            // gb_Pessoal
            // 
            this.gb_Pessoal.BackColor = System.Drawing.Color.White;
            this.gb_Pessoal.Controls.Add(this.mlb_endereco2);
            this.gb_Pessoal.Controls.Add(this.mtbox_endereco2);
            this.gb_Pessoal.Controls.Add(this.mlb_end2);
            this.gb_Pessoal.Controls.Add(this.mlb_endereco1);
            this.gb_Pessoal.Controls.Add(this.mtbox_endereco1);
            this.gb_Pessoal.Controls.Add(this.materialLabel3);
            this.gb_Pessoal.Controls.Add(this.materialLabel5);
            this.gb_Pessoal.Controls.Add(this.mlb_end1);
            this.gb_Pessoal.Controls.Add(this.mlb_situacao_cadastro);
            this.gb_Pessoal.Controls.Add(this.mtxt_Email);
            this.gb_Pessoal.Controls.Add(this.mlb_Email);
            this.gb_Pessoal.Controls.Add(this.mtxt_Contato);
            this.gb_Pessoal.Controls.Add(this.mlb_Contato);
            this.gb_Pessoal.Controls.Add(this.mlb_tp_cadastro);
            this.gb_Pessoal.Controls.Add(this.materialLabel1);
            this.gb_Pessoal.Controls.Add(this.mlb_Sexo);
            this.gb_Pessoal.Controls.Add(this.mlb_Dt_Cadastro);
            this.gb_Pessoal.Controls.Add(this.mtxt_Cpf_Cnpj);
            this.gb_Pessoal.Controls.Add(this.mlb_Cpf_Cnpj);
            this.gb_Pessoal.Controls.Add(this.mtxtb_Nome);
            this.gb_Pessoal.Controls.Add(this.mlb_Nome);
            this.gb_Pessoal.Controls.Add(this.cb_tp_cadastro);
            this.gb_Pessoal.Controls.Add(this.metroToggle1);
            this.gb_Pessoal.Controls.Add(this.cb_Sexo);
            this.gb_Pessoal.Controls.Add(this.dt_dt_nasc);
            this.gb_Pessoal.Controls.Add(this.mt_dt_cadastro);
            this.gb_Pessoal.Location = new System.Drawing.Point(17, 32);
            this.gb_Pessoal.Name = "gb_Pessoal";
            this.gb_Pessoal.Size = new System.Drawing.Size(1094, 228);
            this.gb_Pessoal.TabIndex = 51;
            this.gb_Pessoal.TabStop = false;
            this.gb_Pessoal.Text = "Pessoal";
            // 
            // mlb_endereco2
            // 
            this.mlb_endereco2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mlb_endereco2.FormattingEnabled = true;
            this.mlb_endereco2.ItemHeight = 23;
            this.mlb_endereco2.Items.AddRange(new object[] {
            "Comercial",
            "Residencial"});
            this.mlb_endereco2.Location = new System.Drawing.Point(787, 124);
            this.mlb_endereco2.Name = "mlb_endereco2";
            this.mlb_endereco2.Size = new System.Drawing.Size(106, 29);
            this.mlb_endereco2.Sorted = true;
            this.mlb_endereco2.TabIndex = 81;
            this.mlb_endereco2.UseSelectable = true;
            // 
            // mtbox_endereco2
            // 
            // 
            // 
            // 
            this.mtbox_endereco2.CustomButton.Image = null;
            this.mtbox_endereco2.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.mtbox_endereco2.CustomButton.Name = "";
            this.mtbox_endereco2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbox_endereco2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbox_endereco2.CustomButton.TabIndex = 1;
            this.mtbox_endereco2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbox_endereco2.CustomButton.UseSelectable = true;
            this.mtbox_endereco2.CustomButton.Visible = false;
            this.mtbox_endereco2.Lines = new string[0];
            this.mtbox_endereco2.Location = new System.Drawing.Point(787, 180);
            this.mtbox_endereco2.MaxLength = 32767;
            this.mtbox_endereco2.Name = "mtbox_endereco2";
            this.mtbox_endereco2.PasswordChar = '\0';
            this.mtbox_endereco2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbox_endereco2.SelectedText = "";
            this.mtbox_endereco2.SelectionLength = 0;
            this.mtbox_endereco2.SelectionStart = 0;
            this.mtbox_endereco2.ShortcutsEnabled = true;
            this.mtbox_endereco2.Size = new System.Drawing.Size(174, 23);
            this.mtbox_endereco2.TabIndex = 79;
            this.mtbox_endereco2.UseSelectable = true;
            this.mtbox_endereco2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbox_endereco2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlb_end2
            // 
            this.mlb_end2.AutoSize = true;
            this.mlb_end2.Depth = 0;
            this.mlb_end2.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlb_end2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlb_end2.Location = new System.Drawing.Point(697, 185);
            this.mlb_end2.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlb_end2.Name = "mlb_end2";
            this.mlb_end2.Size = new System.Drawing.Size(84, 19);
            this.mlb_end2.TabIndex = 80;
            this.mlb_end2.Text = "Endereco 2";
            // 
            // mlb_endereco1
            // 
            this.mlb_endereco1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mlb_endereco1.FormattingEnabled = true;
            this.mlb_endereco1.ItemHeight = 23;
            this.mlb_endereco1.Items.AddRange(new object[] {
            "Comercial",
            "Residencial"});
            this.mlb_endereco1.Location = new System.Drawing.Point(155, 174);
            this.mlb_endereco1.Name = "mlb_endereco1";
            this.mlb_endereco1.Size = new System.Drawing.Size(95, 29);
            this.mlb_endereco1.Sorted = true;
            this.mlb_endereco1.TabIndex = 75;
            this.mlb_endereco1.UseSelectable = true;
            // 
            // mtbox_endereco1
            // 
            // 
            // 
            // 
            this.mtbox_endereco1.CustomButton.Image = null;
            this.mtbox_endereco1.CustomButton.Location = new System.Drawing.Point(202, 1);
            this.mtbox_endereco1.CustomButton.Name = "";
            this.mtbox_endereco1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbox_endereco1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbox_endereco1.CustomButton.TabIndex = 1;
            this.mtbox_endereco1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbox_endereco1.CustomButton.UseSelectable = true;
            this.mtbox_endereco1.CustomButton.Visible = false;
            this.mtbox_endereco1.Lines = new string[0];
            this.mtbox_endereco1.Location = new System.Drawing.Point(402, 180);
            this.mtbox_endereco1.MaxLength = 32767;
            this.mtbox_endereco1.Name = "mtbox_endereco1";
            this.mtbox_endereco1.PasswordChar = '\0';
            this.mtbox_endereco1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbox_endereco1.SelectedText = "";
            this.mtbox_endereco1.SelectionLength = 0;
            this.mtbox_endereco1.SelectionStart = 0;
            this.mtbox_endereco1.ShortcutsEnabled = true;
            this.mtbox_endereco1.Size = new System.Drawing.Size(224, 23);
            this.mtbox_endereco1.TabIndex = 73;
            this.mtbox_endereco1.UseSelectable = true;
            this.mtbox_endereco1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbox_endereco1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(312, 184);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(84, 19);
            this.materialLabel3.TabIndex = 74;
            this.materialLabel3.Text = "Endereco 1";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(663, 134);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(118, 19);
            this.materialLabel5.TabIndex = 78;
            this.materialLabel5.Text = "Tipo Endereco 2";
            // 
            // mlb_end1
            // 
            this.mlb_end1.AutoSize = true;
            this.mlb_end1.Depth = 0;
            this.mlb_end1.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlb_end1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlb_end1.Location = new System.Drawing.Point(31, 183);
            this.mlb_end1.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlb_end1.Name = "mlb_end1";
            this.mlb_end1.Size = new System.Drawing.Size(118, 19);
            this.mlb_end1.TabIndex = 72;
            this.mlb_end1.Text = "Tipo Endereco 1";
            // 
            // mlb_situacao_cadastro
            // 
            this.mlb_situacao_cadastro.AutoSize = true;
            this.mlb_situacao_cadastro.Depth = 0;
            this.mlb_situacao_cadastro.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlb_situacao_cadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlb_situacao_cadastro.Location = new System.Drawing.Point(939, 119);
            this.mlb_situacao_cadastro.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlb_situacao_cadastro.Name = "mlb_situacao_cadastro";
            this.mlb_situacao_cadastro.Size = new System.Drawing.Size(133, 19);
            this.mlb_situacao_cadastro.TabIndex = 70;
            this.mlb_situacao_cadastro.Text = "Situação Cadastro";
            // 
            // mtxt_Email
            // 
            // 
            // 
            // 
            this.mtxt_Email.CustomButton.Image = null;
            this.mtxt_Email.CustomButton.Location = new System.Drawing.Point(242, 1);
            this.mtxt_Email.CustomButton.Name = "";
            this.mtxt_Email.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxt_Email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxt_Email.CustomButton.TabIndex = 1;
            this.mtxt_Email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxt_Email.CustomButton.UseSelectable = true;
            this.mtxt_Email.CustomButton.Visible = false;
            this.mtxt_Email.Lines = new string[0];
            this.mtxt_Email.Location = new System.Drawing.Point(382, 130);
            this.mtxt_Email.MaxLength = 32767;
            this.mtxt_Email.Name = "mtxt_Email";
            this.mtxt_Email.PasswordChar = '\0';
            this.mtxt_Email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxt_Email.SelectedText = "";
            this.mtxt_Email.SelectionLength = 0;
            this.mtxt_Email.SelectionStart = 0;
            this.mtxt_Email.ShortcutsEnabled = true;
            this.mtxt_Email.Size = new System.Drawing.Size(264, 23);
            this.mtxt_Email.TabIndex = 7;
            this.mtxt_Email.UseSelectable = true;
            this.mtxt_Email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxt_Email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlb_Email
            // 
            this.mlb_Email.AutoSize = true;
            this.mlb_Email.Depth = 0;
            this.mlb_Email.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlb_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlb_Email.Location = new System.Drawing.Point(318, 134);
            this.mlb_Email.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlb_Email.Name = "mlb_Email";
            this.mlb_Email.Size = new System.Drawing.Size(47, 19);
            this.mlb_Email.TabIndex = 68;
            this.mlb_Email.Text = "Email";
            // 
            // mtxt_Contato
            // 
            // 
            // 
            // 
            this.mtxt_Contato.CustomButton.Image = null;
            this.mtxt_Contato.CustomButton.Location = new System.Drawing.Point(203, 1);
            this.mtxt_Contato.CustomButton.Name = "";
            this.mtxt_Contato.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxt_Contato.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxt_Contato.CustomButton.TabIndex = 1;
            this.mtxt_Contato.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxt_Contato.CustomButton.UseSelectable = true;
            this.mtxt_Contato.CustomButton.Visible = false;
            this.mtxt_Contato.Lines = new string[0];
            this.mtxt_Contato.Location = new System.Drawing.Point(723, 78);
            this.mtxt_Contato.MaxLength = 32767;
            this.mtxt_Contato.Name = "mtxt_Contato";
            this.mtxt_Contato.PasswordChar = '\0';
            this.mtxt_Contato.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxt_Contato.SelectedText = "";
            this.mtxt_Contato.SelectionLength = 0;
            this.mtxt_Contato.SelectionStart = 0;
            this.mtxt_Contato.ShortcutsEnabled = true;
            this.mtxt_Contato.Size = new System.Drawing.Size(225, 23);
            this.mtxt_Contato.TabIndex = 6;
            this.mtxt_Contato.UseSelectable = true;
            this.mtxt_Contato.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxt_Contato.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlb_Contato
            // 
            this.mlb_Contato.AutoSize = true;
            this.mlb_Contato.Depth = 0;
            this.mlb_Contato.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlb_Contato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlb_Contato.Location = new System.Drawing.Point(654, 82);
            this.mlb_Contato.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlb_Contato.Name = "mlb_Contato";
            this.mlb_Contato.Size = new System.Drawing.Size(63, 19);
            this.mlb_Contato.TabIndex = 66;
            this.mlb_Contato.Text = "Contato";
            // 
            // mlb_tp_cadastro
            // 
            this.mlb_tp_cadastro.AutoSize = true;
            this.mlb_tp_cadastro.Depth = 0;
            this.mlb_tp_cadastro.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlb_tp_cadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlb_tp_cadastro.Location = new System.Drawing.Point(30, 134);
            this.mlb_tp_cadastro.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlb_tp_cadastro.Name = "mlb_tp_cadastro";
            this.mlb_tp_cadastro.Size = new System.Drawing.Size(104, 19);
            this.mlb_tp_cadastro.TabIndex = 65;
            this.mlb_tp_cadastro.Text = "Tipo Cadastro";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(671, 25);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(146, 19);
            this.materialLabel1.TabIndex = 64;
            this.materialLabel1.Text = "Data de Nascimento";
            // 
            // mlb_Sexo
            // 
            this.mlb_Sexo.AutoSize = true;
            this.mlb_Sexo.Depth = 0;
            this.mlb_Sexo.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlb_Sexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlb_Sexo.Location = new System.Drawing.Point(432, 29);
            this.mlb_Sexo.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlb_Sexo.Name = "mlb_Sexo";
            this.mlb_Sexo.Size = new System.Drawing.Size(42, 19);
            this.mlb_Sexo.TabIndex = 63;
            this.mlb_Sexo.Text = "Sexo";
            // 
            // mlb_Dt_Cadastro
            // 
            this.mlb_Dt_Cadastro.AutoSize = true;
            this.mlb_Dt_Cadastro.Depth = 0;
            this.mlb_Dt_Cadastro.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlb_Dt_Cadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlb_Dt_Cadastro.Location = new System.Drawing.Point(338, 78);
            this.mlb_Dt_Cadastro.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlb_Dt_Cadastro.Name = "mlb_Dt_Cadastro";
            this.mlb_Dt_Cadastro.Size = new System.Drawing.Size(126, 19);
            this.mlb_Dt_Cadastro.TabIndex = 62;
            this.mlb_Dt_Cadastro.Text = "Data do Cadastro";
            // 
            // mtxt_Cpf_Cnpj
            // 
            // 
            // 
            // 
            this.mtxt_Cpf_Cnpj.CustomButton.Image = null;
            this.mtxt_Cpf_Cnpj.CustomButton.Location = new System.Drawing.Point(156, 1);
            this.mtxt_Cpf_Cnpj.CustomButton.Name = "";
            this.mtxt_Cpf_Cnpj.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxt_Cpf_Cnpj.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxt_Cpf_Cnpj.CustomButton.TabIndex = 1;
            this.mtxt_Cpf_Cnpj.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxt_Cpf_Cnpj.CustomButton.UseSelectable = true;
            this.mtxt_Cpf_Cnpj.CustomButton.Visible = false;
            this.mtxt_Cpf_Cnpj.Lines = new string[0];
            this.mtxt_Cpf_Cnpj.Location = new System.Drawing.Point(129, 78);
            this.mtxt_Cpf_Cnpj.MaxLength = 32767;
            this.mtxt_Cpf_Cnpj.Name = "mtxt_Cpf_Cnpj";
            this.mtxt_Cpf_Cnpj.PasswordChar = '\0';
            this.mtxt_Cpf_Cnpj.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxt_Cpf_Cnpj.SelectedText = "";
            this.mtxt_Cpf_Cnpj.SelectionLength = 0;
            this.mtxt_Cpf_Cnpj.SelectionStart = 0;
            this.mtxt_Cpf_Cnpj.ShortcutsEnabled = true;
            this.mtxt_Cpf_Cnpj.Size = new System.Drawing.Size(178, 23);
            this.mtxt_Cpf_Cnpj.TabIndex = 3;
            this.mtxt_Cpf_Cnpj.UseSelectable = true;
            this.mtxt_Cpf_Cnpj.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxt_Cpf_Cnpj.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlb_Cpf_Cnpj
            // 
            this.mlb_Cpf_Cnpj.AutoSize = true;
            this.mlb_Cpf_Cnpj.Depth = 0;
            this.mlb_Cpf_Cnpj.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlb_Cpf_Cnpj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlb_Cpf_Cnpj.Location = new System.Drawing.Point(27, 78);
            this.mlb_Cpf_Cnpj.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlb_Cpf_Cnpj.Name = "mlb_Cpf_Cnpj";
            this.mlb_Cpf_Cnpj.Size = new System.Drawing.Size(88, 19);
            this.mlb_Cpf_Cnpj.TabIndex = 59;
            this.mlb_Cpf_Cnpj.Text = "CPF / CNPJ";
            // 
            // mtxtb_Nome
            // 
            // 
            // 
            // 
            this.mtxtb_Nome.CustomButton.Image = null;
            this.mtxtb_Nome.CustomButton.Location = new System.Drawing.Point(284, 1);
            this.mtxtb_Nome.CustomButton.Name = "";
            this.mtxtb_Nome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtb_Nome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtb_Nome.CustomButton.TabIndex = 1;
            this.mtxtb_Nome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtb_Nome.CustomButton.UseSelectable = true;
            this.mtxtb_Nome.CustomButton.Visible = false;
            this.mtxtb_Nome.Lines = new string[0];
            this.mtxtb_Nome.Location = new System.Drawing.Point(93, 25);
            this.mtxtb_Nome.MaxLength = 32767;
            this.mtxtb_Nome.Name = "mtxtb_Nome";
            this.mtxtb_Nome.PasswordChar = '\0';
            this.mtxtb_Nome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtb_Nome.SelectedText = "";
            this.mtxtb_Nome.SelectionLength = 0;
            this.mtxtb_Nome.SelectionStart = 0;
            this.mtxtb_Nome.ShortcutsEnabled = true;
            this.mtxtb_Nome.Size = new System.Drawing.Size(306, 23);
            this.mtxtb_Nome.TabIndex = 0;
            this.mtxtb_Nome.UseSelectable = true;
            this.mtxtb_Nome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtb_Nome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlb_Nome
            // 
            this.mlb_Nome.AutoSize = true;
            this.mlb_Nome.Depth = 0;
            this.mlb_Nome.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlb_Nome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlb_Nome.Location = new System.Drawing.Point(26, 29);
            this.mlb_Nome.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlb_Nome.Name = "mlb_Nome";
            this.mlb_Nome.Size = new System.Drawing.Size(50, 19);
            this.mlb_Nome.TabIndex = 57;
            this.mlb_Nome.Text = "Nome";
            // 
            // cb_tp_cadastro
            // 
            this.cb_tp_cadastro.FormattingEnabled = true;
            this.cb_tp_cadastro.ItemHeight = 23;
            this.cb_tp_cadastro.Items.AddRange(new object[] {
            "Administrador",
            "Funcionário I",
            "Funcionário II"});
            this.cb_tp_cadastro.Location = new System.Drawing.Point(142, 124);
            this.cb_tp_cadastro.Name = "cb_tp_cadastro";
            this.cb_tp_cadastro.Size = new System.Drawing.Size(128, 29);
            this.cb_tp_cadastro.TabIndex = 5;
            this.cb_tp_cadastro.UseSelectable = true;
            // 
            // metroToggle1
            // 
            this.metroToggle1.AutoCheck = false;
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.Checked = true;
            this.metroToggle1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroToggle1.Location = new System.Drawing.Point(961, 148);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(80, 17);
            this.metroToggle1.TabIndex = 53;
            this.metroToggle1.Tag = "1";
            this.metroToggle1.Text = "On";
            this.metroToggle1.ThreeState = true;
            this.metroToggle1.UseSelectable = true;
            this.metroToggle1.CheckedChanged += new System.EventHandler(this.metroToggle1_CheckedChanged);
            // 
            // cb_Sexo
            // 
            this.cb_Sexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Sexo.FormattingEnabled = true;
            this.cb_Sexo.ItemHeight = 23;
            this.cb_Sexo.Items.AddRange(new object[] {
            "Analberto",
            "Feminino",
            "Masculino"});
            this.cb_Sexo.Location = new System.Drawing.Point(480, 19);
            this.cb_Sexo.Name = "cb_Sexo";
            this.cb_Sexo.Size = new System.Drawing.Size(121, 29);
            this.cb_Sexo.Sorted = true;
            this.cb_Sexo.TabIndex = 1;
            this.cb_Sexo.UseSelectable = true;
            // 
            // dt_dt_nasc
            // 
            this.dt_dt_nasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_dt_nasc.Location = new System.Drawing.Point(823, 19);
            this.dt_dt_nasc.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt_dt_nasc.Name = "dt_dt_nasc";
            this.dt_dt_nasc.Size = new System.Drawing.Size(206, 29);
            this.dt_dt_nasc.TabIndex = 2;
            this.dt_dt_nasc.Value = new System.DateTime(2023, 3, 18, 0, 0, 0, 0);
            // 
            // mt_dt_cadastro
            // 
            this.mt_dt_cadastro.CustomFormat = "  /  /    ";
            this.mt_dt_cadastro.Enabled = false;
            this.mt_dt_cadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mt_dt_cadastro.Location = new System.Drawing.Point(476, 72);
            this.mt_dt_cadastro.MinimumSize = new System.Drawing.Size(0, 29);
            this.mt_dt_cadastro.Name = "mt_dt_cadastro";
            this.mt_dt_cadastro.Size = new System.Drawing.Size(147, 29);
            this.mt_dt_cadastro.TabIndex = 4;
            this.mt_dt_cadastro.Value = new System.DateTime(2023, 3, 9, 0, 0, 0, 0);
            // 
            // mbt_salvar
            // 
            this.mbt_salvar.AutoSize = true;
            this.mbt_salvar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbt_salvar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.mbt_salvar.Depth = 0;
            this.mbt_salvar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.mbt_salvar.Icon = null;
            this.mbt_salvar.Location = new System.Drawing.Point(838, 403);
            this.mbt_salvar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbt_salvar.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbt_salvar.Name = "mbt_salvar";
            this.mbt_salvar.Primary = false;
            this.mbt_salvar.Size = new System.Drawing.Size(72, 36);
            this.mbt_salvar.TabIndex = 51;
            this.mbt_salvar.Text = "Salvar";
            this.mbt_salvar.UseVisualStyleBackColor = false;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.Cadastrar);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(2, 53);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1173, 534);
            this.materialTabControl1.TabIndex = 11;
            // 
            // CadastroLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 593);
            this.Controls.Add(this.materialTabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "CadastroLogin";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Usuário";
            this.Load += new System.EventHandler(this.Login_Load_1);
            this.Cadastrar.ResumeLayout(false);
            this.mt_tp_docu.ResumeLayout(false);
            this.mt_tp_docu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gb_Pessoal.ResumeLayout(false);
            this.gb_Pessoal.PerformLayout();
            this.materialTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.TabPage Cadastrar;
        private System.Windows.Forms.GroupBox mt_tp_docu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialLabel mlb_dt_admissao;
        private MaterialSkin.Controls.MaterialLabel mlb_Cargo;
        private MaterialSkin.Controls.MaterialLabel mlb_setor;
        private MetroFramework.Controls.MetroDateTime mt_dt_admissao;
        private System.Windows.Forms.TextBox txt_Cargo;
        private MetroFramework.Controls.MetroComboBox cb_setor;
        private System.Windows.Forms.GroupBox gb_Pessoal;
        private MaterialSkin.Controls.MaterialLabel mlb_situacao_cadastro;
        private MetroFramework.Controls.MetroTextBox mtxt_Email;
        private MaterialSkin.Controls.MaterialLabel mlb_Email;
        private MetroFramework.Controls.MetroTextBox mtxt_Contato;
        private MaterialSkin.Controls.MaterialLabel mlb_Contato;
        private MaterialSkin.Controls.MaterialLabel mlb_tp_cadastro;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel mlb_Sexo;
        private MaterialSkin.Controls.MaterialLabel mlb_Dt_Cadastro;
        private MetroFramework.Controls.MetroTextBox mtxt_Cpf_Cnpj;
        private MaterialSkin.Controls.MaterialLabel mlb_Cpf_Cnpj;
        private MetroFramework.Controls.MetroTextBox mtxtb_Nome;
        private MaterialSkin.Controls.MaterialLabel mlb_Nome;
        private MetroFramework.Controls.MetroComboBox cb_tp_cadastro;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private MetroFramework.Controls.MetroDateTime dt_dt_nasc;
        private MaterialSkin.Controls.MaterialFlatButton mbt_salvar;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private MaterialSkin.Controls.MaterialSingleLineTextField ms_Senha;
        private MaterialSkin.Controls.MaterialSingleLineTextField SLT_User;
        protected MetroFramework.Controls.MetroDateTime mt_dt_cadastro;
        public MetroFramework.Controls.MetroComboBox cb_Sexo;
        public MetroFramework.Controls.MetroComboBox mlb_endereco1;
        private MetroFramework.Controls.MetroTextBox mtbox_endereco1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel mlb_end1;
        public MetroFramework.Controls.MetroComboBox mlb_endereco2;
        private MetroFramework.Controls.MetroTextBox mtbox_endereco2;
        private MaterialSkin.Controls.MaterialLabel mlb_end2;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
    }
}