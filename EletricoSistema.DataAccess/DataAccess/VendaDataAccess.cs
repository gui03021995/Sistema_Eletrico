using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EletricoSistema.DataAccess
{
    public class VendaDataAccess
    {
        public static bool Insere(tb_venda nvVenda)
        {
            try
            {
                EletricoSistemaDataClassesDataContext oDB = new EletricoSistemaDataClassesDataContext();
                oDB.tb_venda.InsertOnSubmit(nvVenda);
                oDB.SubmitChanges();
                oDB.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }

        //public static bool Delete(int id_categoria)
        //{
        //    try
        //    {
        //        EletricoSistemaDataClassesDataContext oDB = new EletricoSistemaDataClassesDataContext();
        //        tb_venda oCategoria = (from Selecao in oDB.tb_venda where Selecao.id_categoria == id_categoria select Selecao).SingleOrDefault();
        //        oDB.tb_venda.DeleteOnSubmit(oCategoria);
        //        oDB.SubmitChanges();
        //        oDB.Dispose();
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}


        public static tb_venda ObterVenda_unique(int cod_venda)
        { 
        
            EletricoSistemaDataClassesDataContext oDB = new EletricoSistemaDataClassesDataContext();
            tb_venda oVenda = (from Selecao in oDB.tb_venda where Selecao.cod_venda == cod_venda select Selecao).SingleOrDefault();
            return oVenda;
        }

        public static List<tb_venda> ObterVenda()
        {
            EletricoSistemaDataClassesDataContext oDB = new EletricoSistemaDataClassesDataContext();
            List<tb_venda> oVenda = (from Selecao in oDB.tb_venda orderby Selecao.cod_venda select Selecao).ToList<tb_venda>();
            return oVenda;
        }

        public static bool Atualiza(tb_venda pVenda)
        {
            try
            {
                EletricoSistemaDataClassesDataContext oDB = new EletricoSistemaDataClassesDataContext();
                tb_venda oVenda = (from Selecao in oDB.tb_venda where Selecao.cod_venda == pVenda.cod_venda select Selecao).SingleOrDefault();

                //oProduto.id_produto = pProduto.id_produto;
                oVenda.valor = pVenda.valor;
                oVenda.desconto = pVenda.desconto;
                //oVenda.valor_pago = pVenda.valor_pago;
                oVenda.id_pessoa_cliente = pVenda.id_pessoa_cliente;
                oVenda.id_pessoa_funcionario = pVenda.id_pessoa_funcionario;
                oVenda.cod_venda = pVenda.cod_venda;
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
