using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Utilizado para encerrar forms atual quando abrir outro forms
using System.Threading;


using EletricoSistema.DataAccess;

using MaterialSkin;
using MaterialSkin.Controls;

namespace SistemaEletrico
{
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {
        Thread t1;
        public Login()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            //Fundo do sistema escuro
            //materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            //Fundo do sistema Claro
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            // Definindo um esquema de Cor para formulário com tom Azul
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue500, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
            // Definindo um esquema de Cor para formulário com tom Azul agua
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan800, Primary.Cyan900, Primary.Cyan500, Accent.Cyan200, TextShade.WHITE);
        }

        private bool ValidarForms()
        {
            if (SLT_User.Text == "")
            {
                MessageBox.Show("Informe o Usuário no cadastro");
                SLT_User.Focus();
                return false;
            }

            else if (SLT_passord.Text == "")
            {
                MessageBox.Show("Informe a Senha no cadastro");
                SLT_passord.Focus();
                return false;
            }
            return true;
        }

        private void abrirCadastro(Object obj)
        {
            Application.Run(new CadastroLogin());
            //CadastroLogin clg = new CadastroLogin();
            //clg.Show();
        }

        private void enviarSMTP(Object obj)
        {
            Application.Run(new LoginEsqueceuSenha());
        }
        private void logar_adm(Object obj)
        {
            Application.Run(new Menu());
        }
        private void logar_func_one(Object obj)
        {
            Application.Run(new MenuFun_one());
        }
        private void logar_func_two(Object obj)
        {
            Application.Run(new MenuFun_two());
        }

        private void RBtn_Login_Click(object sender, EventArgs e)
        {
            if (ValidarForms())
            {
                if ( UsuarioDataAccess.Verificar_Login(SLT_User.Text, SLT_passord.Text) != 0 )
                {
                    var Pes_Tp = UsuarioDataAccess.Verificar_Login(SLT_User.Text, SLT_passord.Text);
                    if ( PessoaDataAccess.Pessoa_Tp(Pes_Tp)  == "Administrador")
                    {
                        this.Close();
                        t1 = new Thread(logar_adm);
                        t1.SetApartmentState(ApartmentState.STA);
                        t1.Start();                                 

                    }
                    if (PessoaDataAccess.Pessoa_Tp(Pes_Tp) == "Funcionário I")
                    {
                        this.Close();
                        //t1 = new Thread();
                        //t1.SetApartmentState(ApartmentState.STA);
                        //t1.Start();
                    }
                    if (PessoaDataAccess.Pessoa_Tp(Pes_Tp) == "Funcionário II")
                    {
                        this.Close();
                        //t1 = new Thread();
                        //t1.SetApartmentState(ApartmentState.STA);
                        //t1.Start();
                    }
                }
                else
                {
                    MessageBox.Show("Credenciais não exitem no sistema", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    SLT_User.Focus();
                    //return false;
                }
            }

        }

        private void mtlb_esqueceu_senha_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(enviarSMTP);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }    
}
