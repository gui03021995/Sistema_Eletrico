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
    public partial class MenuFun_two : MaterialSkin.Controls.MaterialForm
    {
        List<tb_produto> ListaProdutos_two = new List<tb_produto>();
        List<tb_categoria> ListaCategorias_two = new List<tb_categoria>();

        public MenuFun_two()
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
            //txtCategoria_Prod.Text = "";
            //txt_valor_produto.Text = "";
            //txtNome_Produto.Text = "";
            //Txt_descricao_produto.Text = "";
        }
        private void HabilitaOuDesabilitaCampos(bool pNovoStatus)
        {
           

        }
        private void btn_cadastrar_produto_Click(object sender, EventArgs e)
        {

          
        }




        private void btn_cadastrar_Categoria_Click(object sender, EventArgs e)
        {
            //toolTip1.SetToolTip(this.btn_cadastrar_Categoria, "My button1");

            //if (Txt_nome_categoria.Text != "" && txt_desc_categoria.Text != "")
            //{
            //    tb_categoria NovaCategoria = new tb_categoria();

            //    NovaCategoria.desc_categoria = txt_desc_categoria.Text;
            //    NovaCategoria.nome_categoria = Txt_nome_categoria.Text;


            //    if (!CategoriaDataAccess.Insere(NovaCategoria))
            //        MessageBox.Show("Falha ao tentar inserir uma Nova Categoria no banco de dados!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            //    else
            //        MessageBox.Show("Cliente inserido com sucesso", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //    Volta os campos para o estado original
            //    txt_desc_categoria.Clear();
            //    Txt_nome_categoria.Clear();
            //    txt_desc_categoria.Enabled = true;
            //    Txt_nome_categoria.Enabled = true;


            //    btn_buscar_categoria_1.Enabled = true;
            //    btn_cadastrar_Categoria_1.Enabled = true;
            //    btn_excluir_Categoria_1.Enabled = true;
            //    btn_alterar_categoria_1.Enabled = true;

            //    var scat = CategoriaDataAccess.ObterCategoria();
            //    dtgCategorias.DataSource = scat;

            //    dtgCategorias.Refresh();
            //    loadData();
            //}
            //else
            //{
            //    MessageBox.Show("Por Favor, preencha todos os campos obrigatórios", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //}
        }

        private void btn_excluir_Categoria_Click(object sender, EventArgs e)
        {
           
            
        }

        private void btn_buscar_categoria_Click(object sender, EventArgs e)
        {

          
        }

        private void MenuFun_two_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbEletricDataSet.tb_pessoas'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_pessoasTableAdapter.Fill(this.dbEletricDataSet.tb_pessoas);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tb_pessoasTableAdapter.Fill(this.dbEletricDataSet.tb_pessoas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void cb_client_venda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
