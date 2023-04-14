using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EletricoSistema.DataAccess
{
    public class UsuarioDataAccess
    {
        public static bool InsereUser(tb_usuario nvUser)
        {
            try
            {
                EletricoSistemaDataClassesDataContext oDB = new EletricoSistemaDataClassesDataContext();

                var usuario = nvUser;
                usuario.id_pessoas = nvUser.id_pessoas;                
                usuario.senha = nvUser.senha;
                usuario.usuario = nvUser.usuario;

                oDB.tb_usuario.InsertOnSubmit(usuario);
                oDB.SubmitChanges();
                oDB.Dispose();
                return true;
            }
            catch (Exception ex)
            {

                throw new ApplicationException(ex.Message);
            }
        }

        public static bool DeleteUser(int id_pessoas)
        {
            try
            {
                EletricoSistemaDataClassesDataContext oDB = new EletricoSistemaDataClassesDataContext();
                tb_usuario oUser = (from Selecao in oDB.tb_usuario where Selecao.id_pessoas == id_pessoas select Selecao).SingleOrDefault();
                oDB.tb_usuario.DeleteOnSubmit(oUser);
                oDB.SubmitChanges();
                oDB.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static tb_usuario ObterUser_unique(int id_pessoas)
        {
            EletricoSistemaDataClassesDataContext oDB = new EletricoSistemaDataClassesDataContext();
            tb_usuario oUser = (from Selecao in oDB.tb_usuario where Selecao.id_pessoas == id_pessoas select Selecao).SingleOrDefault();
            return oUser;
        }

        public static int Verificar_Login(string usuario)
        {
            try
            {
                EletricoSistemaDataClassesDataContext oDB = new EletricoSistemaDataClassesDataContext();
                tb_usuario oUser = (from Selecao in oDB.tb_usuario where Selecao.usuario == usuario select Selecao).SingleOrDefault();
                //TRATAR QUANDO FOR NULO, NO CASO PRIMEIRO CADASTRO.
                if(oUser == null)
                {
                    return 0;
                }
                else
                {
                    return oUser.id_pessoas;
                }

            }
            catch (Exception ex)
            {
                //return ex;
                throw new ApplicationException(ex.Message);
            }
        }


        public static bool Att_Senha(int id_pessoa, string senha)
        {
            try
            {
                EletricoSistemaDataClassesDataContext oDB = new EletricoSistemaDataClassesDataContext();
                tb_usuario oUser = (from Selecao in oDB.tb_usuario where Selecao.id_pessoas == id_pessoa select Selecao).SingleOrDefault();
                oUser.senha = senha;
                oDB.SubmitChanges();
                oDB.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }                      
        }

        public static List<tb_usuario> ObterUsuario()
        {
            EletricoSistemaDataClassesDataContext oDB = new EletricoSistemaDataClassesDataContext();
            List<tb_usuario> oUser = (from Selecao in oDB.tb_usuario orderby Selecao.id_pessoas select Selecao).ToList<tb_usuario>();
            return oUser;
        }

        public static bool Atualiza(tb_usuario pUser)
        {
            try
            {
                EletricoSistemaDataClassesDataContext oDB = new EletricoSistemaDataClassesDataContext();
                tb_usuario oUser = (from Selecao in oDB.tb_usuario where Selecao.id_pessoas == pUser.id_pessoas select Selecao).SingleOrDefault();

                //oProduto.id_produto = pProduto.id_produto;
                oUser.usuario = oUser.usuario;
                oUser.senha = oUser.senha;
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
