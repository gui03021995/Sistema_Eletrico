using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EletricoSistema.DataAccess
{
    public class ProdutoDataAccess
    {
        public static bool Insere(tb_produto nvCliente)
        {
            try
            {
                EletricoSistemaDataClassesDataContext oDB = new EletricoSistemaDataClassesDataContext();
                oDB.tb_produto.InsertOnSubmit(nvCliente);
                oDB.SubmitChanges();
                oDB.Dispose();
                return true;
            }
            catch(Exception ex)
            {
                throw new ApplicationException(ex.Message); //return false;
            }
        }

        public static bool Delete(int id_Produto)
        {
            try
            {
                EletricoSistemaDataClassesDataContext oDB = new EletricoSistemaDataClassesDataContext();
                tb_produto oProduto = (from Selecao in oDB.tb_produto where Selecao.id_produto == id_Produto select Selecao).SingleOrDefault();
                oDB.tb_produto.DeleteOnSubmit(oProduto);
                oDB.SubmitChanges();
                oDB.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static tb_produto ObterProduto(int id_Produto)
        {
            EletricoSistemaDataClassesDataContext oDB = new EletricoSistemaDataClassesDataContext();
            tb_produto oProduto = (from Selecao in oDB.tb_produto where Selecao.id_produto == id_Produto select Selecao).SingleOrDefault();
            return oProduto;
        }

        public static List<tb_produto> ObterProduto()
        {
            EletricoSistemaDataClassesDataContext oDB = new EletricoSistemaDataClassesDataContext();
            List<tb_produto> oProduto = (from Selecao in oDB.tb_produto orderby Selecao.id_produto select Selecao).ToList<tb_produto>();
            return oProduto;
        }
        public static tb_produto ObterProduto_unique(int id_produto)
        {
            EletricoSistemaDataClassesDataContext oDB = new EletricoSistemaDataClassesDataContext();
            tb_produto oProduto = (from Selecao in oDB.tb_produto where Selecao.id_produto == id_produto select Selecao).SingleOrDefault();
            return oProduto;
        }
        public static bool Atualiza(tb_produto pProduto)
        {
            try
            {
                EletricoSistemaDataClassesDataContext oDB = new EletricoSistemaDataClassesDataContext();
                tb_produto oProduto = (from Selecao in oDB.tb_produto where Selecao.id_produto == pProduto.id_produto select Selecao).SingleOrDefault();

                //oProduto.id_produto = pProduto.id_produto;
                oProduto.desc_produto = pProduto.desc_produto;
                oProduto.valor = pProduto.valor;
                oProduto.quantidade = pProduto.quantidade;
                oProduto.nome = pProduto.nome;
                oProduto.id_categoria = pProduto.id_categoria;

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
