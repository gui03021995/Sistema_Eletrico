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
    public partial class MenuFun_one : MaterialSkin.Controls.MaterialForm
    {
        List<tb_produto> ListaProdutos_one = new List<tb_produto>();
        List<tb_categoria> ListaCategorias_one = new List<tb_categoria>();

        public MenuFun_one()
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


        private void LimpaTela()
        {
            txtCategoria_Prod.Text = "";
            txt_valor_produto.Text = "";
            txtNome_Produto.Text = "";
            Txt_descricao_produto.Text = "";
        }
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
        private void btn_cadastrar_produto_Click(object sender, EventArgs e)
        {

            if (txtNome_Produto.Text != "" && Txt_descricao_produto.Text != "" && txt_valor_produto.Text != "" && txtCategoria_Prod.Text != "")
            {
                tb_produto NovoProduto = new tb_produto();

                NovoProduto.valor = txt_valor_produto.Text;
                NovoProduto.nome = txtNome_Produto.Text;
                NovoProduto.desc_produto = Txt_descricao_produto.Text;
                NovoProduto.id_categoria = Convert.ToInt32(txtCategoria_Prod.Text); 

                if (!ProdutoDataAccess.Insere(NovoProduto))
                    MessageBox.Show("Falha ao tentar inserir o novo Produto no banco de dados!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Cliente inserido com sucesso", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                //Atualiza o DataGrid em relação à nova lista de clientes
                dtgProdutos.Refresh();
               
                //loadData();               
            }
            else
            {
                MessageBox.Show("Por Favor, preencha todos os campos obrigatórios", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }




        private void btn_cadastrar_Categoria_Click(object sender, EventArgs e)
        {
            //toolTip1.SetToolTip(this.btn_cadastrar_Categoria, "My button1");

            if (Txt_nome_categoria.Text != "" && txt_desc_categoria.Text != "")
            {
                tb_categoria NovaCategoria = new tb_categoria();

                NovaCategoria.desc_categoria = txt_desc_categoria.Text;
                NovaCategoria.nome_categoria = Txt_nome_categoria.Text;


                if (!CategoriaDataAccess.Insere(NovaCategoria))
                    MessageBox.Show("Falha ao tentar inserir uma Nova Categoria no banco de dados!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                else
                    MessageBox.Show("Cliente inserido com sucesso", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //Volta os campos para o estado original
                txt_desc_categoria.Clear();
                Txt_nome_categoria.Clear();
                txt_desc_categoria.Enabled = true;
                Txt_nome_categoria.Enabled = true;


                btn_buscar_categoria_1.Enabled = true;
                btn_cadastrar_Categoria_1.Enabled = true;
                btn_excluir_Categoria_1.Enabled = true;
                btn_alterar_categoria_1.Enabled = true;

                //var scat = CategoriaDataAccess.ObterCategoria();
                //dtgCategorias.DataSource = scat;

                dtgCategorias.Refresh();
                //loadData();            
            }
            else
            {
                MessageBox.Show("Por Favor, preencha todos os campos obrigatórios", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

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
                txt_desc_categoria.Clear();
                Txt_nome_categoria.Clear();
                txt_desc_categoria.Enabled = true;
                Txt_nome_categoria.Enabled = true;


                btn_buscar_categoria_1.Enabled = true;
                btn_cadastrar_Categoria_1.Enabled = true;
                btn_excluir_Categoria_1.Enabled = true;
                btn_alterar_categoria_1.Enabled = true;

                dtgCategorias.Refresh();
    
                //var scat = CategoriaDataAccess.ObterCategoria();
                //dtgCategorias.DataSource = scat;
                //loadData();            
            }
            else
            {
                MessageBox.Show("Por Favor, preencha todos os campos obrigatórios", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btn_buscar_categoria_Click(object sender, EventArgs e)
        {

            if (txt_cod_categoria.Text != "")
            {
                tb_categoria buscarCategoria = new tb_categoria();

                buscarCategoria.id_categoria = Convert.ToInt32(txt_cod_categoria.Text);

                var tt = CategoriaDataAccess.ObterCategoria_unique(buscarCategoria.id_categoria);

                if (tt == null )
                     MessageBox.Show("Falha ao tentar buscar a Categoria " + txt_cod_categoria.Text + " .Codigo da Categoria não existe no Sistema", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                else                    
                    MessageBox.Show("Categoria encontrada com sucesso", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtgCategorias.DataSource = tt;
                   
                ///alterar daq pra baixo
                //Volta os campos para o estado original
                txt_desc_categoria.Clear();
                Txt_nome_categoria.Clear();
                txt_desc_categoria.Enabled = true;
                Txt_nome_categoria.Enabled = true;


                btn_buscar_categoria_1.Enabled = true;
                btn_cadastrar_Categoria_1.Enabled = true;
                btn_excluir_Categoria_1.Enabled = true;
                btn_alterar_categoria_1.Enabled = true;

                dtgCategorias.DataSource = tt;
                //dtgCategorias.Refresh();

            }
            else
            {
                MessageBox.Show("Por Favor, preencha o campo : Codigo Categoria" , "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

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

        private void Menu_Load(object sender, EventArgs e)
        {
            //var scat = CategoriaDataAccess.ObterCategoria();
            //var sprod = ProdutoDataAccess.ObterProduto();

            //dtgCategorias.DataSource = scat;
            //dtgProdutos.DataSource = sprod;

            dtgCategorias.Refresh();
        }

        private void btn_excluir_produtos_Click(object sender, EventArgs e)
        {
           
        }

        private void tbcategoriaBindingSource1_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void cb_tp_cadastro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
