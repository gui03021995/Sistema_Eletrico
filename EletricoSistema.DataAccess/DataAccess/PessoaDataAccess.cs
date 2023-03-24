using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EletricoSistema.DataAccess
{
    public class PessoaDataAccess
    {
        public static bool InserePessoa(tb_pessoas nvPessoa)
        {
            try
            {
                EletricoSistemaDataClassesDataContext oDB = new EletricoSistemaDataClassesDataContext();
                oDB.tb_pessoas.InsertOnSubmit(nvPessoa);
                oDB.SubmitChanges();
                oDB.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }

        public static bool DeletePessoa(int id_pessoas)
        {
            try
            {
                EletricoSistemaDataClassesDataContext oDB = new EletricoSistemaDataClassesDataContext();
                tb_pessoas oPessoa = (from Selecao in oDB.tb_pessoas where Selecao.id_pessoas == id_pessoas select Selecao).SingleOrDefault();
                oDB.tb_pessoas.DeleteOnSubmit(oPessoa);
                oDB.SubmitChanges();
                oDB.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static tb_pessoas ObterPessoa_unique(int id_pessoas)
        {
            EletricoSistemaDataClassesDataContext oDB = new EletricoSistemaDataClassesDataContext();
            tb_pessoas oPessoa = (from Selecao in oDB.tb_pessoas where Selecao.id_pessoas == id_pessoas select Selecao).SingleOrDefault();
            return oPessoa;
        }

        public static bool CPF_existe(string cpf)
        {
            EletricoSistemaDataClassesDataContext oDB = new EletricoSistemaDataClassesDataContext();
            tb_pessoas oPessoa = (from Selecao in oDB.tb_pessoas where Selecao.CPF_CNPJ == cpf select Selecao).SingleOrDefault();
            return oPessoa != null ;
        }

        public static string Email_existe(string email)
        {
            
            EletricoSistemaDataClassesDataContext oDB = new EletricoSistemaDataClassesDataContext();
            tb_pessoas oPessoa = (from Selecao in oDB.tb_pessoas where Selecao.email == email select Selecao).SingleOrDefault();
            //this.oPessoa.CPF_CNPJ = oPessoa.CPF_CNPJ;
            var NvPessoa = oPessoa;
            if (NvPessoa != null)
            {
                string NovaSenha =  oPessoa.CPF_CNPJ;
                //= (from Selecao in oDB.tb_pessoas where Selecao.email == email select Selecao).SingleOrDefault();
                return NovaSenha;

            }
            else
            {
                return "0";
            }
        }

        public static List<tb_pessoas> ObterPessoa()
        {
            EletricoSistemaDataClassesDataContext oDB = new EletricoSistemaDataClassesDataContext();
            List<tb_pessoas> oPessoa = (from Selecao in oDB.tb_pessoas orderby Selecao.id_pessoas select Selecao).ToList<tb_pessoas>();
            return oPessoa;
        }

        public static bool Atualiza(tb_pessoas pPessoa)
        {
            try
            {
                EletricoSistemaDataClassesDataContext oDB = new EletricoSistemaDataClassesDataContext();
                tb_pessoas oPessoa = (from Selecao in oDB.tb_pessoas where Selecao.id_pessoas == pPessoa.id_pessoas select Selecao).SingleOrDefault();

                //oProduto.id_produto = pProduto.id_produto;
                oPessoa.data_nascimento = pPessoa.data_nascimento;
                oPessoa.CPF_CNPJ = pPessoa.CPF_CNPJ;
                //oPessoa.data_cadastro = pPessoa.data_cadastro;
                oPessoa.situacao_cadastro = pPessoa.situacao_cadastro;
                oPessoa.tipo_cadastro = pPessoa.tipo_cadastro;
                oPessoa.cargo = pPessoa.cargo;
                oPessoa.sexo = pPessoa.sexo;
                oPessoa.contato = pPessoa.contato;
                oPessoa.email = pPessoa.email;

                oDB.SubmitChanges();
                oDB.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



    }
}
