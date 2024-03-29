﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EletricoSistema.DataAccess;
using MaterialSkin;
using MaterialSkin.Controls;

//Utilizado para encerrar forms atual quando abrir outro forms
using System.Threading;

using EletricoSistema.DataAccess.DataAccess;

namespace SistemaEletrico
{
    public partial class CadastroLogin : MaterialSkin.Controls.MaterialForm
    {
        List<tb_pessoas> ListaPessoa = new List<tb_pessoas>();
        List<tb_usuario> ListaUser = new List<tb_usuario>();

        Thread t1;
        public CadastroLogin()
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
        private void Login_Load_1(object sender, EventArgs e)
        {
            
        }

        private void abrirLogin(Object obj)
        {
            Application.Run(new Login());
            //CadastroLogin clg = new CadastroLogin();
            //clg.Show();
        }

        public void ClearCampo()
        {
            mtxtb_Nome.Clear();
            cb_Sexo.SelectedItem = 0;
            mtxt_Cpf_Cnpj.Clear();
            mtxt_Contato.Clear();
            mtxt_Email.Clear();
            mtbox_endereco1.Clear();
            mtbox_endereco2.Clear();
            cb_setor.SelectedItem = 0;
            cb_tp_cadastro.SelectedItem = 0;
            mlb_endereco2.SelectedItem = 0;
            cb_setor.SelectedItem = 0;
            txt_Cargo.Clear();
            SLT_User.Clear();
            ms_Senha.Clear();
        }

        //private void mbt_salvar_Click(object sender, EventArgs e)
        //{
        //    tb_pessoas pessoa = preencherDados();
        //    Processing_validation validar_salvar = new Processing_validation();
        //    string erros = Processing_validation.Validar_Pessoa(pessoa);          
        //    if (ValidarForms())
        //    {
        //      Salvar();
        //    }
        //    else
        //    {
        //        //Application.Exit();
        //    }
        //}

        //tb_pessoas preencherDados()
        //{          
        //        tb_pessoas p = new tb_pessoas();
        //        p.nome_pessoa = mtxtb_Nome.Text;
        //        p.sexo = cb_Sexo.Text;
        //        return p;            
        //}



        public void Salvar()
        {
            if (mtxtb_Nome.Text != "" && mtxt_Cpf_Cnpj.Text != "" && SLT_User.Text != "" && ms_Senha.Text != "")
            {
                tb_pessoas NovaPessoa = new tb_pessoas();
                tb_usuario NovoUser = new tb_usuario();

                tb_pessoas_endereco NovoEndereco = new tb_pessoas_endereco();


                NovaPessoa.nome_pessoa = mtxtb_Nome.Text;
                NovaPessoa.sexo = cb_Sexo.Text;
                //NovaPessoa.data_nascimento = Convert.ToString(dt_dt_nasc);
                NovaPessoa.CPF_CNPJ = mtxt_Cpf_Cnpj.Text;
                //NovaPessoa.data_cadastro = Convert.ToInt32(mlb_Dt_Cadastro.Text);
                NovaPessoa.email = mtxt_Email.Text;
                NovaPessoa.contato = mtxt_Contato.Text;
                NovaPessoa.setor = cb_setor.Text;
                NovaPessoa.tipo_cadastro = cb_tp_cadastro.Text;
                NovaPessoa.situacao_cadastro = metroToggle1.Text;
                NovaPessoa.cargo = txt_Cargo.Text;
                NovaPessoa.data_cadastro = mt_dt_cadastro.Value.Date; 
                NovaPessoa.data_nascimento = Convert.ToDateTime(dt_dt_nasc.Text);
                NovaPessoa.data_admissao = Convert.ToDateTime(mt_dt_admissao.Text);

                //Informações Endereco
                NovoEndereco.endereco1 = mtbox_endereco1.Text;
                NovoEndereco.tp_endereco1 = mlb_endereco1.Text;

                NovoEndereco.endereco2 = mtbox_endereco2.Text;
                NovoEndereco.tp_endereco2 = mlb_endereco2.Text;

                //NovaPessoa.situacao_cadastro = mlb_situacao_cadastro.Text;
                NovoUser.usuario = SLT_User.Text;
                NovoUser.senha = ms_Senha.Text;

                if (!PessoaDataAccess.InserePessoa(NovaPessoa))                    
                    MessageBox.Show("Falha ao tentar inserir a nova Pessoa no banco de dados!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NovoEndereco.id_pessoas = NovaPessoa.id_pessoas;
                if (!EnderecoDataAccess.Insere(NovoEndereco))
                    MessageBox.Show("Falha ao tentar inserir o novo Endereco a nova Pessoa no banco de dados!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NovoUser.id_pessoas = NovaPessoa.id_pessoas;
                if (!UsuarioDataAccess.InsereUser(NovoUser))
                    MessageBox.Show("Falha ao tentar inserir o novo Usuário no banco de dados!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Usuario inserido com sucesso", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearCampo();
                    //chamar a tela de login inicial 
                    this.Close();
                    t1 = new Thread(abrirLogin);
                    t1.SetApartmentState(ApartmentState.STA);
                    t1.Start();

            }
            else
            {
                MessageBox.Show("Por Favor, preencha todos os campos obrigatórios", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        private bool ValidarForms()
        {
            if (mtxt_Cpf_Cnpj.Text == "")
            {
                MessageBox.Show("Informe o CPF no cadastro", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtxt_Cpf_Cnpj.Focus();
                return false;
            }                                   
            
            else if (mtxtb_Nome.Text == "")
            {
                MessageBox.Show("Informe o NOME no cadastro", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtxtb_Nome.Focus();
                return false;
            }           
            else if (cb_Sexo.Text == "")
            {
                MessageBox.Show("Informe o SEXO no cadastro", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cb_Sexo.Focus();
                return false;
            }
            else if (dt_dt_nasc.Text == "")
            {
                MessageBox.Show("Informe a DATA DE NASCIMENTO no cadastro", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dt_dt_nasc.Focus();
                return false;
            }
            else if (mt_dt_admissao.Text == "")
            {
                MessageBox.Show("Informe a DATA DE ADMISSAO no cadastro", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dt_dt_nasc.Focus();
                return false;
            }
            else if (cb_tp_cadastro.Text == "")
            {
                MessageBox.Show("Informe o TIPO DE CADASTRO no cadastro", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cb_tp_cadastro.Focus();
                return false;
            }
            else if (mtxt_Contato.Text == "")
            {
                MessageBox.Show("Informe o CONTATO no cadastro", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtxt_Contato.Focus();
                return false;
            }
            else if (mtxt_Email.Text == "")
            {
                MessageBox.Show("Informe o EMAIL no cadastro", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtxt_Email.Focus();
                return false;
            }        

            else if (SLT_User.Text == "")
            {
                MessageBox.Show("Informe o USUÁRIO no cadastro", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SLT_User.Focus();
                return false;
            }
            else if (ms_Senha.Text == "")
            {
                MessageBox.Show("Informe a SENHA no cadastro", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ms_Senha.Focus();
                return false;
            }

            else if(mtxt_Cpf_Cnpj.Text != "" || mtxt_Email.Text != "")
            {
                if (PessoaDataAccess.CPF_existe(mtxt_Cpf_Cnpj.Text))
                {
                    MessageBox.Show("CPF existente na base de dados", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtxt_Cpf_Cnpj.Focus();
                    return false;
                }
                if (PessoaDataAccess.Email_existe(mtxt_Email.Text) != "0")
                {
                    MessageBox.Show("Email já existente na base de dados", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtxt_Email.Focus();
                    return false;
                }
                if (UsuarioDataAccess.Verificar_Login(SLT_User.Text) != 0)                    
                {
                    MessageBox.Show("Usuário já existente na base de dados", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtxt_Email.Focus();
                    return false;
                }
                return true;
            }
            return true;
        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            //var valorComboBox = comboBox.SelectedValue;
            // Definir o valor fixo para "ON = 1" e "OFF = 0"
            int valorFixo = metroToggle1.Checked ? 1 : 0;
        }
    }
}
