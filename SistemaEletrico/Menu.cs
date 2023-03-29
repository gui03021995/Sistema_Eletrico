using System;
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

namespace SistemaEletrico
{
    public partial class Menu : MaterialSkin.Controls.MaterialForm
    {
        List<tb_produto> ListaProdutos = new List<tb_produto>();
        List<tb_categoria> ListaCategorias = new List<tb_categoria>();
        //-----------------------------------------------------------------------INICIALIZAÇÃO------------------------------------------------------------------------------------//
        public Menu()
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
        //-----------------------------------------------------------------------Metodo Limpar os campos---------------------------------------------------------------------------//
        private void LimpaTela()
        {
            txt_cod_prod.Text = "";
            txt_valor_produto.Text = "";
            txtNome_Produto.Text = "";
            Txt_descricao_produto.Text = "";
        }

        //-----------------------------------------------------------------------Metodo Habilitar campos---------------------------------------------------------------------------//
        private void HabilitaOuDesabilitaCampos(bool pNovoStatus)
        {
            Txt_nome_categoria.Enabled = pNovoStatus;
            txt_valor_produto.Enabled = pNovoStatus;
            
            //txtApresentacao.Enabled = pNovoStatus;
            txtNome_Produto.Enabled = pNovoStatus;
            Txt_descricao_produto.Enabled = pNovoStatus;

            txt_desc_categoria.Enabled = pNovoStatus;
            Txt_nome_categoria.Enabled = pNovoStatus;
        }
        //----------------------------------------------------------------------- PRODUTO ---------------------------------------------------------------------------//
        //----------------------------------------------------------------------- CAMPOS PAG - PROD ---------------------------------------------------------------------------//
        public void campos_prod()
        {
            txtNome_Produto.Clear();
            Txt_descricao_produto.Clear();
            txt_cod_prod.Clear();
            txt_valor_produto.Clear();
            mtxt_qt_prod.Clear();

            txtNome_Produto.Enabled = true;
            Txt_descricao_produto.Enabled = true;
            txt_cod_prod.Enabled = true;
            txt_valor_produto.Enabled = true;

            btn_alterar_prod.Enabled = true;
            mf_btn_buscar.Enabled = true;
            btn_cadastrar_produto.Enabled = true;
            btn_excluir_produtos.Enabled = true;
        }
        //----------------------------------------------------------------------- Alterar ---------------------------------------------------------------------------//
        private void btn_alterar_prod_Click(object sender, EventArgs e)
        {
            if (txt_cod_prod.Text != "")
            {
                tb_produto attProduto = new tb_produto();

                attProduto.id_produto = Convert.ToInt32(txt_cod_prod.Text);
                attProduto.nome = txtNome_Produto.Text;
                attProduto.desc_produto = Txt_descricao_produto.Text;
                attProduto.valor = txt_valor_produto.Text;
                attProduto.id_categoria = Convert.ToInt32(txtCategoria_Prod.SelectedValue);
                attProduto.quantidade = Convert.ToInt32(mtxt_qt_prod.Text);                

                if (!ProdutoDataAccess.Atualiza(attProduto))
                    MessageBox.Show("Falha ao tentar atualizar o Produto no banco de dados!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                else
                    MessageBox.Show("Produto atualizado com sucesso : " + txt_cod_prod.Text + " ", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //Volta os campos para o estado original
                campos_prod();
                loadData();
            }else if(txtNome_Produto.Text != "" && Txt_descricao_produto.Text != "" && txt_cod_prod.Text != "" && txt_valor_produto.Text != "" && txt_valor_produto.Text != "")
            {
                MessageBox.Show("Por Favor, realize primeiro a busca do produto que deseja alterar", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Por Favor, preencha todos os campos obrigatórios", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome_Produto.Clear();
                Txt_descricao_produto.Clear();
                txt_cod_prod.Clear();
                txt_valor_produto.Clear();
                txtCategoria_Prod.SelectedItem = 1;
            }         
        }

        //----------------------------------------------------------------------- Cadastrar ---------------------------------------------------------------------------//
        private void btn_cadastrar_produto_Click(object sender, EventArgs e)
        {
            if (txtNome_Produto.Text != "" && Txt_descricao_produto.Text != "" && txt_valor_produto.Text != "" && txtCategoria_Prod.Text != "")
            {
                tb_produto NovoProduto = new tb_produto();

                NovoProduto.valor = txt_valor_produto.Text;
                NovoProduto.nome = txtNome_Produto.Text;
                NovoProduto.desc_produto = Txt_descricao_produto.Text;
                NovoProduto.id_categoria = Convert.ToInt32(txtCategoria_Prod.Text);
                NovoProduto.quantidade = Convert.ToInt32(mtxt_qt_prod.Text);


                if (!ProdutoDataAccess.Insere(NovoProduto))
                    MessageBox.Show("Falha ao tentar inserir o novo Produto no banco de dados!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Cliente inserido com sucesso", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                campos_prod();
                loadData();            

            }
            else
            {
                MessageBox.Show("Por Favor, preencha todos os campos obrigatórios", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        //----------------------------------------------------------------------- Excluir ---------------------------------------------------------------------------//
        private void btn_excluir_produtos_Click(object sender, EventArgs e)
        {
            if (txt_cod_prod.Text != "")
            {
                tb_produto deleteProduto = new tb_produto();

                deleteProduto.id_produto = Convert.ToInt32(txt_cod_prod.Text);

                if (!ProdutoDataAccess.Delete(deleteProduto.id_produto))
                    MessageBox.Show("Falha ao tentar deletar o Produto no banco de dados!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                else
                    MessageBox.Show("Produto deletada com sucesso : " + txt_cod_prod.Text + " ", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                ///alterar daq pra baixo
                //Volta os campos para o estado original
                campos_prod();
                loadData();
            }
            else
            {
                MessageBox.Show("Por Favor, preencha todos os campos obrigatórios", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome_Produto.Clear();
                Txt_descricao_produto.Clear();
                txt_cod_prod.Clear();
                txt_valor_produto.Clear();
            }
        }

        //----------------------------------------------------------------------- Buscar ---------------------------------------------------------------------------//
        private void mf_btn_buscar_Click(object sender, EventArgs e)
        {

            if (txt_cod_prod.Text != "")
            {
                tb_produto buscarProduto = new tb_produto();

                buscarProduto.id_produto = Convert.ToInt32(txt_cod_prod.Text);

                var tt = ProdutoDataAccess.ObterProduto_unique(buscarProduto.id_produto);

                if (tt == null)
                    MessageBox.Show("Falha ao tentar buscar o Produto " + txt_cod_prod.Text + " . Codigo do Produto não existe no Sistema", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                else
                    MessageBox.Show("Produto encontrada com sucesso", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                               
                    txtNome_Produto.Text = tt.nome;
                    Txt_descricao_produto.Text = tt.desc_produto;
                    txt_valor_produto.Text = tt.valor;
                    txtCategoria_Prod.Text = tt.id_categoria.ToString();
                    mtxt_qt_prod.Text =  tt.quantidade.ToString();

                    txt_cod_prod.ReadOnly = true;       

            }
            else
            {
                MessageBox.Show("Por Favor, preencha o campo : Codigo Produto", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        //----------------------------------------------------------------------- Limpar Campos ---------------------------------------------------------------------------//
        private void mtb_Limpar_Prod_Click(object sender, EventArgs e)
        {
            //campos_prod();
            txtNome_Produto.Clear();
            Txt_descricao_produto.Clear();
            txt_cod_prod.Clear();
            txt_valor_produto.Clear();
            mtxt_qt_prod.Clear();
        }

        //----------------------------------------------------------------------- CATEGORIA ---------------------------------------------------------------------------//
        //----------------------------------------------------------------------- CAMPOS PAG - PROD ---------------------------------------------------------------------------//
        public void campos_cat()
        {
            txt_desc_categoria.Clear();
            Txt_nome_categoria.Clear();
            txt_desc_categoria.Enabled = true;
            Txt_nome_categoria.Enabled = true;

            btn_buscar_categoria.Enabled = true;
            btn_cadastrar_Categoria.Enabled = true;
            btn_excluir_Categoria.Enabled = true;
            btn_alterar_categoria.Enabled = true;
        }

        //----------------------------------------------------------------------- Cadastrar ---------------------------------------------------------------------------//
        private void btn_cadastrar_Categoria_Click(object sender, EventArgs e)
        {
            if (Txt_nome_categoria.Text != "" && txt_desc_categoria.Text != "")
            {
                tb_categoria NovaCategoria = new tb_categoria();

                NovaCategoria.desc_categoria = txt_desc_categoria.Text;
                NovaCategoria.nome_categoria = Txt_nome_categoria.Text;


                if (!CategoriaDataAccess.Insere(NovaCategoria))
                    MessageBox.Show("Falha ao tentar inserir uma Nova Categoria no banco de dados!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                else
                    MessageBox.Show("Cliente inserido com sucesso", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                campos_cat();             
                loadData();            
            }
            else
            {
                MessageBox.Show("Por Favor, preencha todos os campos obrigatórios", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        //----------------------------------------------------------------------- Excluir ---------------------------------------------------------------------------//
        private void btn_excluir_Categoria_Click(object sender, EventArgs e)
        {
            if (txt_cod_categoria.Text != "" )
            {
                tb_categoria deteleCategoria = new tb_categoria();

                deteleCategoria.id_categoria = Convert.ToInt32(txt_cod_categoria.Text);

                if (!CategoriaDataAccess.Delete(deteleCategoria.id_categoria))
                    MessageBox.Show("Falha ao tentar deletar uma Nova Categoria no banco de dados!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                else
                    MessageBox.Show("Categoria deletada com sucesso : " + txt_cod_categoria.Text + " ","Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                ///alterar daq pra baixo
                //Volta os campos para o estado original
                loadData();           
                campos_cat();
            }
            else
            {
                MessageBox.Show("Por Favor, preencha todos os campos obrigatórios", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        //----------------------------------------------------------------------- Buscar ---------------------------------------------------------------------------//
        private void btn_buscar_categoria_Click(object sender, EventArgs e)
        {
            if (txt_cod_categoria.Text != "")
            {
                tb_categoria buscarCategoria = new tb_categoria();

                buscarCategoria.id_categoria = Convert.ToInt32(txt_cod_categoria.Text);

                var tt = CategoriaDataAccess.ObterCategoria_unique(buscarCategoria.id_categoria);

                if (tt == null )
                     MessageBox.Show("Falha ao tentar buscar a Categoria " + txt_cod_categoria.Text + " .Codigo da Categoria não existe no Sistema. ", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Categoria encontrada com sucesso", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                Txt_nome_categoria.Text = tt.nome_categoria;
                txt_desc_categoria.Text = tt.desc_categoria;
                txt_cod_categoria.ReadOnly = true;
                
            }
            else
            {
                MessageBox.Show("Por Favor, preencha o campo : Codigo Categoria " , "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //----------------------------------------------------------------------- Alterar ---------------------------------------------------------------------------//
        private void btn_alterar_categoria_Click(object sender, EventArgs e)
        {

            if (txt_cod_categoria.Text != "")
            {
                tb_categoria alterarCategoria = new tb_categoria();

                alterarCategoria.id_categoria = Convert.ToInt32(txt_cod_categoria.Text);
                    
            }
            else
            {
                MessageBox.Show("Por Favor, preencha todos os campos obrigatórios", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        //----------------------------------------------------------------------- Carregar Inicialização ---------------------------------------------------------------------------//
        public void Menu_Load(object sender, EventArgs e)
        {
            try
            {
                //var scat = CategoriaDataAccess.ObterCategoria();
                //var sprod = ProdutoDataAccess.ObterProduto();
                //dtgCategorias.DataSource = scat;
                //dtgProdutos.DataSource = sprod;
                //dtgCategorias.Refresh();    
                using( EletricoSistemaDataClassesDataContext  db = new EletricoSistemaDataClassesDataContext())
                {
                    tbcategoriaBindingSource.DataSource = db.tb_categoria.ToList();
                }
                loadData();
                //using( Eletrica db = new EletricoSistema())
                //{

                //}

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //----------------------------------------------------------------------- Recarregar Grid ---------------------------------------------------------------------------//
        public void loadData()
        {
            var scat = CategoriaDataAccess.ObterCategoria();
            var sprod = ProdutoDataAccess.ObterProduto();
            dtgCategorias.DataSource = scat;
            dtgProdutos.DataSource = sprod;
            dtgCategorias.Refresh();
        }

        //private void txtCategoria_Prod_SelectionChangeCommitted(object sender, EventArgs e)
        //{
        //    //tb_categoria obj = txtCategoria_Prod.SelectedItem as tb_categoria;
        //    //if (obj != null)
        //    //{
        //    //    using (EletricoSistemaDataClassesDataContext db = new EletricoSistemaDataClassesDataContext())
        //    //    {
        //    //        tbcategoriaBindingSource.DataSource = db.tb_produto.Where(p => p.id_categoria == obj.id_categoria).ToList();
        //    //    }
        //    //}
        //}

        //private void txtCategoria_Prod_Click(object sender, EventArgs e)
        //{
        
        //}

        //private void txtCategoria_Prod_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        //private void txtCategoria_Prod_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    tb_categoria obj = txtCategoria_Prod.SelectedItem as tb_categoria;
        //    if (obj != null)
        //    {
        //        using (EletricoSistemaDataClassesDataContext db = new EletricoSistemaDataClassesDataContext())
        //        {
        //            tbcategoriaBindingSource.DataSource = db.tb_produto.Where(p => p.id_categoria == obj.id_categoria).ToList();
        //        }
        //    }
        //}
    }
}
