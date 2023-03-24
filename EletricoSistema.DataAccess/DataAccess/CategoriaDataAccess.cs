using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EletricoSistema.DataAccess
{
    public class CategoriaDataAccess
    {
        public static bool Insere(tb_categoria nvCategoria)
        {
            try
            {
                EletricoSistemaDataClassesDataContext oDB = new EletricoSistemaDataClassesDataContext();
                oDB.tb_categoria.InsertOnSubmit(nvCategoria);
                oDB.SubmitChanges();
                oDB.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Delete(int id_categoria)
        {
            try
            {
                EletricoSistemaDataClassesDataContext oDB = new EletricoSistemaDataClassesDataContext();
                tb_categoria oCategoria = (from Selecao in oDB.tb_categoria where Selecao.id_categoria == id_categoria select Selecao).SingleOrDefault();
                oDB.tb_categoria.DeleteOnSubmit(oCategoria);
                oDB.SubmitChanges();
                oDB.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static tb_categoria ObterCategoria_unique(int id_categoria)
        {
            EletricoSistemaDataClassesDataContext oDB = new EletricoSistemaDataClassesDataContext();
            tb_categoria oCategoria = (from Selecao in oDB.tb_categoria where Selecao.id_categoria == id_categoria select Selecao).SingleOrDefault();
            return oCategoria;
        }

        public static List<tb_categoria> ObterCategoria()
        {
            EletricoSistemaDataClassesDataContext oDB = new EletricoSistemaDataClassesDataContext();
            List<tb_categoria> oCategoria = (from Selecao in oDB.tb_categoria orderby Selecao.id_categoria select Selecao).ToList<tb_categoria>();
            return oCategoria;
        }

        public static bool Atualiza(tb_categoria pCategoria)
        {
            try
            {
                EletricoSistemaDataClassesDataContext oDB = new EletricoSistemaDataClassesDataContext();
                tb_categoria oCategoria = (from Selecao in oDB.tb_categoria where Selecao.id_categoria == pCategoria.id_categoria select Selecao).SingleOrDefault();

                //oProduto.id_produto = pProduto.id_produto;
                oCategoria.nome_categoria = pCategoria.nome_categoria;
                oCategoria.desc_categoria = pCategoria.desc_categoria;
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
