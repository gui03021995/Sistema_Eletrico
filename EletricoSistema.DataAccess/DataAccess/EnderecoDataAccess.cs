using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EletricoSistema.DataAccess
{
    public class EnderecoDataAccess
    {
        public static bool Insere(tb_pessoas_endereco nvPessoaEndereco)
        {
            try
            {
                EletricoSistemaDataClassesDataContext oDB = new EletricoSistemaDataClassesDataContext();
                oDB.tb_pessoas_endereco.InsertOnSubmit(nvPessoaEndereco);
                oDB.SubmitChanges();
                oDB.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Delete(int id_pessoas)
        {
            try
            {
                EletricoSistemaDataClassesDataContext oDB = new EletricoSistemaDataClassesDataContext();
                tb_pessoas_endereco oEndPessoa = (from Selecao in oDB.tb_pessoas_endereco where Selecao.id_pessoas == id_pessoas select Selecao).SingleOrDefault();
                oDB.tb_pessoas_endereco.DeleteOnSubmit(oEndPessoa);
                oDB.SubmitChanges();
                oDB.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static tb_pessoas_endereco ObterEndPessoa_unique(int id_pessoas)
        {
            EletricoSistemaDataClassesDataContext oDB = new EletricoSistemaDataClassesDataContext();
            tb_pessoas_endereco oEnderecoPessoa = (from Selecao in oDB.tb_pessoas_endereco where Selecao.id_pessoas == id_pessoas select Selecao).SingleOrDefault();
            return oEnderecoPessoa;
        }

        public static List<tb_pessoas_endereco> ObterEndPessoa()
        {
            EletricoSistemaDataClassesDataContext oDB = new EletricoSistemaDataClassesDataContext();
            List<tb_pessoas_endereco> oEnderecoPessoa = (from Selecao in oDB.tb_pessoas_endereco orderby Selecao.id_pessoas select Selecao).ToList<tb_pessoas_endereco>();
            return oEnderecoPessoa;
        }

        public static bool Atualiza(tb_pessoas_endereco pEndPessoa)
        {
            try
            {
                EletricoSistemaDataClassesDataContext oDB = new EletricoSistemaDataClassesDataContext();
                tb_pessoas_endereco oEndPessoa = (from Selecao in oDB.tb_pessoas_endereco where Selecao.id_endereco == pEndPessoa.id_endereco select Selecao).SingleOrDefault();

                //oProduto.id_produto = pProduto.id_produto;
                oEndPessoa.id_pessoas = pEndPessoa.id_pessoas;
                oEndPessoa.endereco1 = pEndPessoa.endereco1;
                oEndPessoa.tp_endereco1 = pEndPessoa.tp_endereco1;
                oEndPessoa.endereco2 = pEndPessoa.endereco2;
                oEndPessoa.tp_endereco2 = pEndPessoa.tp_endereco2;

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
