
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.mbt_alterar_cad = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.mbt_salvar = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.Cadastrar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gb_Pessoal.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cadastrar
            // 
            this.Cadastrar.Controls.Add(this.groupBox2);
            this.Cadastrar.ImageKey = "icons8-add-user-male-32.png";
            this.Cadastrar.Location = new System.Drawing.Point(4, 25);
            this.Cadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Padding = new System.Windows.Forms.Padding(4);
            this.Cadastrar.Size = new System.Drawing.Size(1677, 657);
            this.Cadastrar.TabIndex = 5;
            this.Cadastrar.Text = "CADASTRAR";
            this.Cadastrar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.gb_Pessoal);
            this.groupBox2.Controls.Add(this.mbt_alterar_cad);
            this.groupBox2.Controls.Add(this.materialCheckBox1);
            this.groupBox2.Controls.Add(this.mbt_salvar);
            this.groupBox2.Location = new System.Drawing.Point(8, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1507, 597);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Novo Cadastro";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ms_Senha);
            this.groupBox1.Controls.Add(this.SLT_User);
            this.groupBox1.Location = new System.Drawing.Point(23, 451);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(716, 106);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuário";
            // 
            // ms_Senha
            // 
            this.ms_Senha.Depth = 0;
            this.ms_Senha.Hint = "SENHA";
            this.ms_Senha.Location = new System.Drawing.Point(431, 45);
            this.ms_Senha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ms_Senha.MaxLength = 32767;
            this.ms_Senha.MouseState = MaterialSkin.MouseState.HOVER;
            this.ms_Senha.Name = "ms_Senha";
            this.ms_Senha.PasswordChar = '*';
            this.ms_Senha.SelectedText = "";
            this.ms_Senha.SelectionLength = 0;
            this.ms_Senha.SelectionStart = 0;
            this.ms_Senha.Size = new System.Drawing.Size(217, 28);
            this.ms_Senha.TabIndex = 13;
            this.ms_Senha.TabStop = false;
            this.ms_Senha.UseSystemPasswordChar = false;
            // 
            // SLT_User
            // 
            this.SLT_User.Depth = 0;
            this.SLT_User.Hint = "USUÁRIO";
            this.SLT_User.Location = new System.Drawing.Point(34, 45);
            this.SLT_User.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SLT_User.MaxLength = 32767;
            this.SLT_User.MouseState = MaterialSkin.MouseState.HOVER;
            this.SLT_User.Name = "SLT_User";
            this.SLT_User.PasswordChar = '\0';
            this.SLT_User.SelectedText = "";
            this.SLT_User.SelectionLength = 0;
            this.SLT_User.SelectionStart = 0;
            this.SLT_User.Size = new System.Drawing.Size(217, 28);
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
            this.groupBox3.Location = new System.Drawing.Point(23, 343);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1459, 106);
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
            this.mlb_dt_admissao.Location = new System.Drawing.Point(959, 47);
            this.mlb_dt_admissao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlb_dt_admissao.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlb_dt_admissao.Name = "mlb_dt_admissao";
            this.mlb_dt_admissao.Size = new System.Drawing.Size(165, 24);
            this.mlb_dt_admissao.TabIndex = 69;
            this.mlb_dt_admissao.Text = "Data de Admissão";
            // 
            // mlb_Cargo
            // 
            this.mlb_Cargo.AutoSize = true;
            this.mlb_Cargo.Depth = 0;
            this.mlb_Cargo.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlb_Cargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlb_Cargo.Location = new System.Drawing.Point(463, 42);
            this.mlb_Cargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlb_Cargo.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlb_Cargo.Name = "mlb_Cargo";
            this.mlb_Cargo.Size = new System.Drawing.Size(60, 24);
            this.mlb_Cargo.TabIndex = 68;
            this.mlb_Cargo.Text = "Cargo";
            // 
            // mlb_setor
            // 
            this.mlb_setor.AutoSize = true;
            this.mlb_setor.Depth = 0;
            this.mlb_setor.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlb_setor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlb_setor.Location = new System.Drawing.Point(48, 43);
            this.mlb_setor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlb_setor.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlb_setor.Name = "mlb_setor";
            this.mlb_setor.Size = new System.Drawing.Size(54, 24);
            this.mlb_setor.TabIndex = 67;
            this.mlb_setor.Text = "Setor";
            // 
            // mt_dt_admissao
            // 
            this.mt_dt_admissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mt_dt_admissao.Location = new System.Drawing.Point(1161, 37);
            this.mt_dt_admissao.Margin = new System.Windows.Forms.Padding(4);
            this.mt_dt_admissao.MinimumSize = new System.Drawing.Size(0, 30);
            this.mt_dt_admissao.Name = "mt_dt_admissao";
            this.mt_dt_admissao.Size = new System.Drawing.Size(273, 30);
            this.mt_dt_admissao.TabIndex = 11;
            this.mt_dt_admissao.Value = new System.DateTime(2023, 3, 18, 0, 0, 0, 0);
            // 
            // txt_Cargo
            // 
            this.txt_Cargo.Location = new System.Drawing.Point(536, 42);
            this.txt_Cargo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Cargo.Name = "txt_Cargo";
            this.txt_Cargo.Size = new System.Drawing.Size(367, 22);
            this.txt_Cargo.TabIndex = 9;
            // 
            // cb_setor
            // 
            this.cb_setor.FormattingEnabled = true;
            this.cb_setor.ItemHeight = 24;
            this.cb_setor.Items.AddRange(new object[] {
            "Vendas",
            "Financeiro",
            "Gerencia"});
            this.cb_setor.Location = new System.Drawing.Point(123, 34);
            this.cb_setor.Margin = new System.Windows.Forms.Padding(4);
            this.cb_setor.Name = "cb_setor";
            this.cb_setor.Size = new System.Drawing.Size(260, 30);
            this.cb_setor.TabIndex = 8;
            this.cb_setor.UseSelectable = true;
            // 
            // gb_Pessoal
            // 
            this.gb_Pessoal.BackColor = System.Drawing.Color.White;
            this.gb_Pessoal.Controls.Add(this.comboBox1);
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
            this.gb_Pessoal.Location = new System.Drawing.Point(23, 39);
            this.gb_Pessoal.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Pessoal.Name = "gb_Pessoal";
            this.gb_Pessoal.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Pessoal.Size = new System.Drawing.Size(1459, 281);
            this.gb_Pessoal.TabIndex = 51;
            this.gb_Pessoal.TabStop = false;
            this.gb_Pessoal.Text = "Pessoal";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Analberto"});
            this.comboBox1.Location = new System.Drawing.Point(755, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 71;
            // 
            // mlb_situacao_cadastro
            // 
            this.mlb_situacao_cadastro.AutoSize = true;
            this.mlb_situacao_cadastro.Depth = 0;
            this.mlb_situacao_cadastro.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlb_situacao_cadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlb_situacao_cadastro.Location = new System.Drawing.Point(1197, 191);
            this.mlb_situacao_cadastro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlb_situacao_cadastro.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlb_situacao_cadastro.Name = "mlb_situacao_cadastro";
            this.mlb_situacao_cadastro.Size = new System.Drawing.Size(164, 24);
            this.mlb_situacao_cadastro.TabIndex = 70;
            this.mlb_situacao_cadastro.Text = "Situação Cadastro";
            // 
            // mtxt_Email
            // 
            // 
            // 
            // 
            this.mtxt_Email.CustomButton.Image = null;
            this.mtxt_Email.CustomButton.Location = new System.Drawing.Point(409, 2);
            this.mtxt_Email.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.mtxt_Email.CustomButton.Name = "";
            this.mtxt_Email.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtxt_Email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxt_Email.CustomButton.TabIndex = 1;
            this.mtxt_Email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxt_Email.CustomButton.UseSelectable = true;
            this.mtxt_Email.CustomButton.Visible = false;
            this.mtxt_Email.Lines = new string[0];
            this.mtxt_Email.Location = new System.Drawing.Point(621, 212);
            this.mtxt_Email.Margin = new System.Windows.Forms.Padding(4);
            this.mtxt_Email.MaxLength = 32767;
            this.mtxt_Email.Name = "mtxt_Email";
            this.mtxt_Email.PasswordChar = '\0';
            this.mtxt_Email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxt_Email.SelectedText = "";
            this.mtxt_Email.SelectionLength = 0;
            this.mtxt_Email.SelectionStart = 0;
            this.mtxt_Email.ShortcutsEnabled = true;
            this.mtxt_Email.Size = new System.Drawing.Size(435, 28);
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
            this.mlb_Email.Location = new System.Drawing.Point(531, 217);
            this.mlb_Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlb_Email.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlb_Email.Name = "mlb_Email";
            this.mlb_Email.Size = new System.Drawing.Size(58, 24);
            this.mlb_Email.TabIndex = 68;
            this.mlb_Email.Text = "Email";
            // 
            // mtxt_Contato
            // 
            // 
            // 
            // 
            this.mtxt_Contato.CustomButton.Image = null;
            this.mtxt_Contato.CustomButton.Location = new System.Drawing.Point(274, 2);
            this.mtxt_Contato.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.mtxt_Contato.CustomButton.Name = "";
            this.mtxt_Contato.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtxt_Contato.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxt_Contato.CustomButton.TabIndex = 1;
            this.mtxt_Contato.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxt_Contato.CustomButton.UseSelectable = true;
            this.mtxt_Contato.CustomButton.Visible = false;
            this.mtxt_Contato.Lines = new string[0];
            this.mtxt_Contato.Location = new System.Drawing.Point(157, 212);
            this.mtxt_Contato.Margin = new System.Windows.Forms.Padding(4);
            this.mtxt_Contato.MaxLength = 32767;
            this.mtxt_Contato.Name = "mtxt_Contato";
            this.mtxt_Contato.PasswordChar = '\0';
            this.mtxt_Contato.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxt_Contato.SelectedText = "";
            this.mtxt_Contato.SelectionLength = 0;
            this.mtxt_Contato.SelectionStart = 0;
            this.mtxt_Contato.ShortcutsEnabled = true;
            this.mtxt_Contato.Size = new System.Drawing.Size(300, 28);
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
            this.mlb_Contato.Location = new System.Drawing.Point(48, 217);
            this.mlb_Contato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlb_Contato.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlb_Contato.Name = "mlb_Contato";
            this.mlb_Contato.Size = new System.Drawing.Size(76, 24);
            this.mlb_Contato.TabIndex = 66;
            this.mlb_Contato.Text = "Contato";
            // 
            // mlb_tp_cadastro
            // 
            this.mlb_tp_cadastro.AutoSize = true;
            this.mlb_tp_cadastro.Depth = 0;
            this.mlb_tp_cadastro.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlb_tp_cadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlb_tp_cadastro.Location = new System.Drawing.Point(1000, 138);
            this.mlb_tp_cadastro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlb_tp_cadastro.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlb_tp_cadastro.Name = "mlb_tp_cadastro";
            this.mlb_tp_cadastro.Size = new System.Drawing.Size(129, 24);
            this.mlb_tp_cadastro.TabIndex = 65;
            this.mlb_tp_cadastro.Text = "Tipo Cadastro";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(959, 47);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(182, 24);
            this.materialLabel1.TabIndex = 64;
            this.materialLabel1.Text = "Data de Nascimento";
            // 
            // mlb_Sexo
            // 
            this.mlb_Sexo.AutoSize = true;
            this.mlb_Sexo.Depth = 0;
            this.mlb_Sexo.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlb_Sexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlb_Sexo.Location = new System.Drawing.Point(616, 47);
            this.mlb_Sexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlb_Sexo.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlb_Sexo.Name = "mlb_Sexo";
            this.mlb_Sexo.Size = new System.Drawing.Size(51, 24);
            this.mlb_Sexo.TabIndex = 63;
            this.mlb_Sexo.Text = "Sexo";
            // 
            // mlb_Dt_Cadastro
            // 
            this.mlb_Dt_Cadastro.AutoSize = true;
            this.mlb_Dt_Cadastro.Depth = 0;
            this.mlb_Dt_Cadastro.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlb_Dt_Cadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlb_Dt_Cadastro.Location = new System.Drawing.Point(492, 138);
            this.mlb_Dt_Cadastro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlb_Dt_Cadastro.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlb_Dt_Cadastro.Name = "mlb_Dt_Cadastro";
            this.mlb_Dt_Cadastro.Size = new System.Drawing.Size(156, 24);
            this.mlb_Dt_Cadastro.TabIndex = 62;
            this.mlb_Dt_Cadastro.Text = "Data do Cadastro";
            // 
            // mtxt_Cpf_Cnpj
            // 
            // 
            // 
            // 
            this.mtxt_Cpf_Cnpj.CustomButton.Image = null;
            this.mtxt_Cpf_Cnpj.CustomButton.Location = new System.Drawing.Point(274, 2);
            this.mtxt_Cpf_Cnpj.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.mtxt_Cpf_Cnpj.CustomButton.Name = "";
            this.mtxt_Cpf_Cnpj.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtxt_Cpf_Cnpj.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxt_Cpf_Cnpj.CustomButton.TabIndex = 1;
            this.mtxt_Cpf_Cnpj.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxt_Cpf_Cnpj.CustomButton.UseSelectable = true;
            this.mtxt_Cpf_Cnpj.CustomButton.Visible = false;
            this.mtxt_Cpf_Cnpj.Lines = new string[0];
            this.mtxt_Cpf_Cnpj.Location = new System.Drawing.Point(123, 138);
            this.mtxt_Cpf_Cnpj.Margin = new System.Windows.Forms.Padding(4);
            this.mtxt_Cpf_Cnpj.MaxLength = 32767;
            this.mtxt_Cpf_Cnpj.Name = "mtxt_Cpf_Cnpj";
            this.mtxt_Cpf_Cnpj.PasswordChar = '\0';
            this.mtxt_Cpf_Cnpj.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxt_Cpf_Cnpj.SelectedText = "";
            this.mtxt_Cpf_Cnpj.SelectionLength = 0;
            this.mtxt_Cpf_Cnpj.SelectionStart = 0;
            this.mtxt_Cpf_Cnpj.ShortcutsEnabled = true;
            this.mtxt_Cpf_Cnpj.Size = new System.Drawing.Size(300, 28);
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
            this.mlb_Cpf_Cnpj.Location = new System.Drawing.Point(48, 138);
            this.mlb_Cpf_Cnpj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlb_Cpf_Cnpj.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlb_Cpf_Cnpj.Name = "mlb_Cpf_Cnpj";
            this.mlb_Cpf_Cnpj.Size = new System.Drawing.Size(45, 24);
            this.mlb_Cpf_Cnpj.TabIndex = 59;
            this.mlb_Cpf_Cnpj.Text = "CPF";
            // 
            // mtxtb_Nome
            // 
            // 
            // 
            // 
            this.mtxtb_Nome.CustomButton.Image = null;
            this.mtxtb_Nome.CustomButton.Location = new System.Drawing.Point(445, 2);
            this.mtxtb_Nome.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtb_Nome.CustomButton.Name = "";
            this.mtxtb_Nome.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtxtb_Nome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtb_Nome.CustomButton.TabIndex = 1;
            this.mtxtb_Nome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtb_Nome.CustomButton.UseSelectable = true;
            this.mtxtb_Nome.CustomButton.Visible = false;
            this.mtxtb_Nome.Lines = new string[0];
            this.mtxtb_Nome.Location = new System.Drawing.Point(123, 47);
            this.mtxtb_Nome.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtb_Nome.MaxLength = 32767;
            this.mtxtb_Nome.Name = "mtxtb_Nome";
            this.mtxtb_Nome.PasswordChar = '\0';
            this.mtxtb_Nome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtb_Nome.SelectedText = "";
            this.mtxtb_Nome.SelectionLength = 0;
            this.mtxtb_Nome.SelectionStart = 0;
            this.mtxtb_Nome.ShortcutsEnabled = true;
            this.mtxtb_Nome.Size = new System.Drawing.Size(471, 28);
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
            this.mlb_Nome.Location = new System.Drawing.Point(48, 47);
            this.mlb_Nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlb_Nome.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlb_Nome.Name = "mlb_Nome";
            this.mlb_Nome.Size = new System.Drawing.Size(62, 24);
            this.mlb_Nome.TabIndex = 57;
            this.mlb_Nome.Text = "Nome";
            // 
            // cb_tp_cadastro
            // 
            this.cb_tp_cadastro.FormattingEnabled = true;
            this.cb_tp_cadastro.ItemHeight = 24;
            this.cb_tp_cadastro.Items.AddRange(new object[] {
            "Administrador",
            "Funcionário I",
            "Funcionário II"});
            this.cb_tp_cadastro.Location = new System.Drawing.Point(1161, 126);
            this.cb_tp_cadastro.Margin = new System.Windows.Forms.Padding(4);
            this.cb_tp_cadastro.Name = "cb_tp_cadastro";
            this.cb_tp_cadastro.Size = new System.Drawing.Size(260, 30);
            this.cb_tp_cadastro.TabIndex = 5;
            this.cb_tp_cadastro.UseSelectable = true;
            // 
            // metroToggle1
            // 
            this.metroToggle1.AutoCheck = false;
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.Checked = true;
            this.metroToggle1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroToggle1.Location = new System.Drawing.Point(1227, 226);
            this.metroToggle1.Margin = new System.Windows.Forms.Padding(4);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(80, 21);
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
            this.cb_Sexo.ItemHeight = 24;
            this.cb_Sexo.Items.AddRange(new object[] {
            "Analberto",
            "Feminino",
            "Masculino"});
            this.cb_Sexo.Location = new System.Drawing.Point(755, 36);
            this.cb_Sexo.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Sexo.Name = "cb_Sexo";
            this.cb_Sexo.Size = new System.Drawing.Size(160, 30);
            this.cb_Sexo.Sorted = true;
            this.cb_Sexo.TabIndex = 1;
            this.cb_Sexo.UseSelectable = true;
            // 
            // dt_dt_nasc
            // 
            this.dt_dt_nasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_dt_nasc.Location = new System.Drawing.Point(1161, 34);
            this.dt_dt_nasc.Margin = new System.Windows.Forms.Padding(4);
            this.dt_dt_nasc.MinimumSize = new System.Drawing.Size(0, 30);
            this.dt_dt_nasc.Name = "dt_dt_nasc";
            this.dt_dt_nasc.Size = new System.Drawing.Size(273, 30);
            this.dt_dt_nasc.TabIndex = 2;
            this.dt_dt_nasc.Value = new System.DateTime(2023, 3, 18, 0, 0, 0, 0);
            // 
            // mt_dt_cadastro
            // 
            this.mt_dt_cadastro.CustomFormat = "  /  /    ";
            this.mt_dt_cadastro.Enabled = false;
            this.mt_dt_cadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mt_dt_cadastro.Location = new System.Drawing.Point(668, 126);
            this.mt_dt_cadastro.Margin = new System.Windows.Forms.Padding(4);
            this.mt_dt_cadastro.MinimumSize = new System.Drawing.Size(0, 30);
            this.mt_dt_cadastro.Name = "mt_dt_cadastro";
            this.mt_dt_cadastro.Size = new System.Drawing.Size(273, 30);
            this.mt_dt_cadastro.TabIndex = 4;
            this.mt_dt_cadastro.Value = new System.DateTime(2023, 3, 9, 0, 0, 0, 0);
            // 
            // mbt_alterar_cad
            // 
            this.mbt_alterar_cad.AutoSize = true;
            this.mbt_alterar_cad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbt_alterar_cad.Depth = 0;
            this.mbt_alterar_cad.Icon = null;
            this.mbt_alterar_cad.Location = new System.Drawing.Point(1241, 496);
            this.mbt_alterar_cad.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.mbt_alterar_cad.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbt_alterar_cad.Name = "mbt_alterar_cad";
            this.mbt_alterar_cad.Primary = false;
            this.mbt_alterar_cad.Size = new System.Drawing.Size(96, 36);
            this.mbt_alterar_cad.TabIndex = 47;
            this.mbt_alterar_cad.Text = "Alterar";
            this.mbt_alterar_cad.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.AutoSize = true;
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox1.Location = new System.Drawing.Point(760, 501);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(181, 30);
            this.materialCheckBox1.TabIndex = 45;
            this.materialCheckBox1.Text = "materialCheckBox1";
            this.materialCheckBox1.UseVisualStyleBackColor = true;
            // 
            // mbt_salvar
            // 
            this.mbt_salvar.AutoSize = true;
            this.mbt_salvar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbt_salvar.BackColor = System.Drawing.Color.Transparent;
            this.mbt_salvar.Depth = 0;
            this.mbt_salvar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.mbt_salvar.Icon = null;
            this.mbt_salvar.Location = new System.Drawing.Point(1385, 496);
            this.mbt_salvar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.mbt_salvar.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbt_salvar.Name = "mbt_salvar";
            this.mbt_salvar.Primary = false;
            this.mbt_salvar.Size = new System.Drawing.Size(86, 36);
            this.mbt_salvar.TabIndex = 51;
            this.mbt_salvar.Text = "Salvar";
            this.mbt_salvar.UseVisualStyleBackColor = false;
            this.mbt_salvar.Click += new System.EventHandler(this.mbt_salvar_Click);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.Cadastrar);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 65);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1685, 686);
            this.materialTabControl1.TabIndex = 11;
            // 
            // CadastroLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1583, 751);
            this.Controls.Add(this.materialTabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "CadastroLogin";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Usuário";
            this.Load += new System.EventHandler(this.Login_Load_1);
            this.Cadastrar.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox2;
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
        private MaterialSkin.Controls.MaterialFlatButton mbt_alterar_cad;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
        private MaterialSkin.Controls.MaterialFlatButton mbt_salvar;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private MaterialSkin.Controls.MaterialSingleLineTextField ms_Senha;
        private MaterialSkin.Controls.MaterialSingleLineTextField SLT_User;
        protected MetroFramework.Controls.MetroDateTime mt_dt_cadastro;
        private System.Windows.Forms.ComboBox comboBox1;
        public MetroFramework.Controls.MetroComboBox cb_Sexo;
    }
}