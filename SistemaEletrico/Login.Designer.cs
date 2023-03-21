
namespace SistemaEletrico
{
    partial class Login
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
            this.SLT_User = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SLT_passord = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cbox_Lembrar_Senha = new MaterialSkin.Controls.MaterialCheckBox();
            this.RBtn_Login = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.mtlb_esqueceu_senha = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SLT_User
            // 
            this.SLT_User.Depth = 0;
            this.SLT_User.Hint = "Username";
            this.SLT_User.Location = new System.Drawing.Point(93, 286);
            this.SLT_User.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SLT_User.MaxLength = 32767;
            this.SLT_User.MouseState = MaterialSkin.MouseState.HOVER;
            this.SLT_User.Name = "SLT_User";
            this.SLT_User.PasswordChar = '\0';
            this.SLT_User.SelectedText = "";
            this.SLT_User.SelectionLength = 0;
            this.SLT_User.SelectionStart = 0;
            this.SLT_User.Size = new System.Drawing.Size(349, 28);
            this.SLT_User.TabIndex = 0;
            this.SLT_User.TabStop = false;
            this.SLT_User.UseSystemPasswordChar = false;
            // 
            // SLT_passord
            // 
            this.SLT_passord.Depth = 0;
            this.SLT_passord.Hint = "Password";
            this.SLT_passord.Location = new System.Drawing.Point(93, 370);
            this.SLT_passord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SLT_passord.MaxLength = 32767;
            this.SLT_passord.MouseState = MaterialSkin.MouseState.HOVER;
            this.SLT_passord.Name = "SLT_passord";
            this.SLT_passord.PasswordChar = '*';
            this.SLT_passord.SelectedText = "";
            this.SLT_passord.SelectionLength = 0;
            this.SLT_passord.SelectionStart = 0;
            this.SLT_passord.Size = new System.Drawing.Size(349, 28);
            this.SLT_passord.TabIndex = 1;
            this.SLT_passord.TabStop = false;
            this.SLT_passord.UseSystemPasswordChar = false;
            // 
            // cbox_Lembrar_Senha
            // 
            this.cbox_Lembrar_Senha.AutoSize = true;
            this.cbox_Lembrar_Senha.Depth = 0;
            this.cbox_Lembrar_Senha.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbox_Lembrar_Senha.Location = new System.Drawing.Point(93, 434);
            this.cbox_Lembrar_Senha.Margin = new System.Windows.Forms.Padding(0);
            this.cbox_Lembrar_Senha.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbox_Lembrar_Senha.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbox_Lembrar_Senha.Name = "cbox_Lembrar_Senha";
            this.cbox_Lembrar_Senha.Ripple = true;
            this.cbox_Lembrar_Senha.Size = new System.Drawing.Size(146, 30);
            this.cbox_Lembrar_Senha.TabIndex = 2;
            this.cbox_Lembrar_Senha.Text = "Lembrar senha";
            this.cbox_Lembrar_Senha.UseVisualStyleBackColor = true;
            // 
            // RBtn_Login
            // 
            this.RBtn_Login.AutoSize = true;
            this.RBtn_Login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RBtn_Login.Depth = 0;
            this.RBtn_Login.Icon = null;
            this.RBtn_Login.Location = new System.Drawing.Point(331, 466);
            this.RBtn_Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RBtn_Login.MouseState = MaterialSkin.MouseState.HOVER;
            this.RBtn_Login.Name = "RBtn_Login";
            this.RBtn_Login.Primary = true;
            this.RBtn_Login.Size = new System.Drawing.Size(72, 36);
            this.RBtn_Login.TabIndex = 3;
            this.RBtn_Login.Text = "Login";
            this.RBtn_Login.UseVisualStyleBackColor = true;
            this.RBtn_Login.Click += new System.EventHandler(this.RBtn_Login_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(93, 523);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(349, 1);
            this.materialDivider1.TabIndex = 2;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // mtlb_esqueceu_senha
            // 
            this.mtlb_esqueceu_senha.AutoSize = true;
            this.mtlb_esqueceu_senha.BackColor = System.Drawing.Color.Transparent;
            this.mtlb_esqueceu_senha.Depth = 0;
            this.mtlb_esqueceu_senha.Font = new System.Drawing.Font("Roboto", 11F);
            this.mtlb_esqueceu_senha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mtlb_esqueceu_senha.Location = new System.Drawing.Point(91, 551);
            this.mtlb_esqueceu_senha.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtlb_esqueceu_senha.Name = "mtlb_esqueceu_senha";
            this.mtlb_esqueceu_senha.Size = new System.Drawing.Size(176, 24);
            this.mtlb_esqueceu_senha.TabIndex = 4;
            this.mtlb_esqueceu_senha.Text = "Esqueceu a senha ?";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(357, 551);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(86, 24);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Registrar";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(125, 204);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(210, 24);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Faça login na sua conta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(197, 103);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 671);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.mtlb_esqueceu_senha);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.RBtn_Login);
            this.Controls.Add(this.cbox_Lembrar_Senha);
            this.Controls.Add(this.SLT_passord);
            this.Controls.Add(this.SLT_User);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField SLT_User;
        private MaterialSkin.Controls.MaterialSingleLineTextField SLT_passord;
        private MaterialSkin.Controls.MaterialCheckBox cbox_Lembrar_Senha;
        private MaterialSkin.Controls.MaterialRaisedButton RBtn_Login;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel mtlb_esqueceu_senha;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}