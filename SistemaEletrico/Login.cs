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

        private void Login_Load(object sender, EventArgs e)
        {
          
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirCadastro);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
            //utilizado para deixar forms atual em menoria mas nao visivel - não é adequado
            //this.Hide();       
        }

        private void abrirCadastro(Object obj)
        {
            Application.Run(new CadastroLogin());
            //CadastroLogin clg = new CadastroLogin();
            //clg.Show();
        }

        private void RBtn_Login_Click(object sender, EventArgs e)
        {

        }
    }
}
