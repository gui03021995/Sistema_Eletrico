using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EletricoSistema.DataAccess.DataAccess
{
    public class Processing_validation
    {

        public string  Validar_Pessoa(tb_pessoas pessoas)
        {
            //string erros = "";
            //if (string.IsNullOrEmpty(pessoas.nome_pessoa))
            //{
            //    erros += "Informe o NOME no cadastro";
            //}
            //if (string.IsNullOrEmpty(pessoas.CPF_CNPJ))
            //{
            //    erros += "Informe o CPF no cadastro";
            //}
            //if (string.IsNullOrEmpty(pessoas.sexo))
            //{
            //    erros += "Informe o SEXO no cadastro";
            //}
            //if (pessoas.data_nascimento != null)
            //{
            //    erros += "Informe a DATA DE NASCIMENTO no cadastro";
            //}
            //if (pessoas.data_admissao != null)
            //{
            //    erros += "Informe a DATA DE ADMISSAO no cadastro";
            //}
            //if (string.IsNullOrEmpty(pessoas.tipo_cadastro))
            //{
            //    erros += "Informe o TIPO DE CADASTRO no cadastro";
            //}
            //if (string.IsNullOrEmpty(pessoas.email))
            //{
            //    erros += "Informe o EMAIL no cadastro";
            //}

            //else if ( !string.IsNullOrEmpty(pessoas.CPF_CNPJ) || !string.IsNullOrEmpty(pessoas.email))
            //{
            //    if (PessoaDataAccess.CPF_existe(pessoas.CPF_CNPJ))
            //    {
            //        erros += "CPF existente na base de dados";
            //        return erros;
            //    }
            //    if (PessoaDataAccess.Email_existe(string.IsNullOrEmpty(pessoas.email)))
            //    {
            //        erros +=  "Email já existente na base de dados" ;
            //        return erros;
            //    }
            //    if (UsuarioDataAccess.Verificar_Login(SLT_User.Text) != 0)
            //    {
            //        MessageBox.Show("Usuário já existente na base de dados", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        mtxt_Email.Focus();
            //        return false;
            //    }
            //    return true;
            //}
            return "0";

        }

        public void Salvar_Pessoa(tb_pessoas pessoas)
        {

        }

    }
}
