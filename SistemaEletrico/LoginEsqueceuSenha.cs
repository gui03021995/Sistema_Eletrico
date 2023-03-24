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

//Utilizado para envio do SMTP
using System.Net;
using System.Net.Mail;


using MaterialSkin;
using MaterialSkin.Controls;
using EletricoSistema.DataAccess;

namespace SistemaEletrico
{
    public partial class LoginEsqueceuSenha : MaterialSkin.Controls.MaterialForm
    {
        //Thread t2;
        public LoginEsqueceuSenha()
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

        public bool ValidarForms()
        {
            var cpf_senha = PessoaDataAccess.Email_existe(linetxt_email_recuperar.Text);
            if (linetxt_email_recuperar.Text == "")
            {
                MessageBox.Show("Informe o EMAIL.");
                linetxt_email_recuperar.Focus();
                return false;
            }
            else
            {
                if (cpf_senha != "" )
                {
                    tb_pessoas NovaPessoa = new tb_pessoas();
                    tb_usuario NovoUser = new tb_usuario();

                    if (NovoUser.id_pessoas == NovaPessoa.id_pessoas)
                    {
                        //var id = NovaPessoa.id_pessoas;
                        UsuarioDataAccess.Att_Senha( NovoUser.id_pessoas , cpf_senha);
                        return true;

                    }
                    return true;

                    //var NovaSenha = PessoaDataAccess.Atualiza();
                    //PessoaDataAccess.Atualiza(NovaSenha);
                    //var NovaSenha = PessoaDataAccess.();
                    //return NovaSenha;
                }
                else
                {
                    MessageBox.Show("Email não existe na base de dados", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    linetxt_email_recuperar.Focus();
                    return false;
                }
            }
        }

        private void mbtn_enviar_email_Click(object sender, EventArgs e)
        {
            //Dedo nervoso
            mbtn_enviar_email.Enabled = false;

            if (ValidarForms())
            {
                //PessoaDataAccess.ObterPessoa();
                //E-MAIL Destinatário
                string emaiDestinatario = linetxt_email_recuperar.Text;

                //Assunto 
                string emailAssunto = "Nova senha - System Eletric";

                //Mensagem 
                var cpf_senha = PessoaDataAccess.Email_existe(linetxt_email_recuperar.Text);
                string emailMensagem = "Olá " + emaiDestinatario + " sua nova senha é : " + cpf_senha;
                 
                //Responsável pela estrura de envio
                MailMessage mail = new MailMessage();
                //email de origem - utilizado para enviar o email.
                mail.From = new MailAddress("guilherme.morais@unimed144.coop.br"); //DE
                //Email de destino - que receberá o email, podendo passar uma lista de email. 
                mail.To.Add(emaiDestinatario); // PARA
                mail.Subject = emailAssunto; //ASSUNTO
                mail.Body = emailMensagem; //MENSAGEM 

                //utilizando o metodo using para nao utilizar o metodo espose
                using (var smtp = new SmtpClient("smtp-mail.outlook.com", 587))
                {
                    smtp.UseDefaultCredentials = false;
                    smtp.EnableSsl = true;
                    smtp.Credentials = new NetworkCredential("guilherme.morais@unimed144.coop.br", "Unimed@369");

                    try
                    {
                        smtp.Send(mail);

                        MessageBox.Show("Email Enviado");
                        linetxt_email_recuperar.Text = string.Empty;
                        linetxt_email_recuperar.Focus();

                        mbtn_enviar_email.Enabled = true;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message , "Falha ao enviar E-mail" );
                    }
                }

            }
            
        }

        private void LoginEsqueceuSenha_Load(object sender, EventArgs e)
        {

        }
        //public static void MailMessage(string server)
        //{
        //    MailMessage mail = new MailMessage();

        //    mail.From = new MailAddress("de@gmail.com");
        //    mail.To.Add("para@gmail.com"); // para
        //    mail.Subject = "Teste"; // assunto
        //    mail.Body = "Testando mensagem de e-mail"; // mensagem

        //    // em caso de anexos
        //    mail.Attachments.Add(new Attachment(@"C:\teste.txt"));
        //}

        //private protected EnvioSMTP()
        //{

        //}
    }
}
