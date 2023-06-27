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
            string user;
            string senha;
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
        //----------------------------------------------------------------------- CAMPOS PAG - PROD -------------------------------------------------------------------//
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
                NovoProduto.id_categoria = (int)txtCategoria_Prod.SelectedValue ;
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
                {
                    MessageBox.Show("Produto encontrada com sucesso", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNome_Produto.Text = tt.nome;
                    Txt_descricao_produto.Text = tt.desc_produto;
                    txt_valor_produto.Text = tt.valor;
                    txtCategoria_Prod.Text = tt.id_categoria.ToString();
                    mtxt_qt_prod.Text = tt.quantidade.ToString();
                    txt_cod_prod.ReadOnly = true;
                }

            }
            else
            {
                MessageBox.Show("Por Favor, preencha o campo : Codigo Produto", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        //----------------------------------------------------------------------- Limpar Campos ---------------------------------------------------------------------------//
        private void mtb_Limpar_Prod_Click(object sender, EventArgs e)
        {
            campos_prod();
            //campos_prod();
            //txtNome_Produto.Clear();
            //Txt_descricao_produto.Clear();
            //txt_cod_prod.Clear();
            //txt_valor_produto.Clear();
            //mtxt_qt_prod.Clear();
        }

        //----------------------------------------------------------------------- CATEGORIA ---------------------------------------------------------------------------//
        //----------------------------------------------------------------------- CAMPOS PAG - PROD ---------------------------------------------------------------------//
        public void campos_cat()
        {
            txt_desc_categoria.Clear();
            Txt_nome_categoria.Clear();
            txt_desc_categoria.Enabled = true;
            Txt_nome_categoria.Enabled = true;

            //btn_buscar_categoria.Enabled = true;
            //btn_cadastrar_Categoria.Enabled = true;
            //btn_excluir_Categoria.Enabled = true;
            //btn_alterar_categoria.Enabled = true;
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
                    txt_cod_categoria.Clear();
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
                    txt_cod_categoria.Clear();
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
        //----------------------------------------------------------------------- Limpar Campos ---------------------------------------------------------------------------//
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            txt_cod_categoria.Clear();
            Txt_nome_categoria.Clear();
            txt_desc_categoria.Clear();
        }

        //----------------------------------------------------------------------- Carregar Inicialização ---------------------------------------------------------------------------//
        public void Menu_Load(object sender, EventArgs e)
        {
            try
            {
                using (EletricoSistemaDataClassesDataContext db = new EletricoSistemaDataClassesDataContext())
                {
                    tbcategoriaBindingSource.DataSource = db.tb_categoria.ToList();
                    tbpessoasBindingSource.DataSource = db.tb_pessoas.Where(x => x.tipo_cadastro == "Cliente");
                    tbprodutoBindingSource.DataSource = db.tb_produto.ToList();
                }
                loadData();             
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
            var svenda = VendaDataAccess.ObterVenda();
            //dtgVenda.DataSource = svenda;
            dtgCategorias.DataSource = scat;
            dtgProdutos.DataSource = sprod;
            dtgCategorias.Refresh();
        }

        //----------------------------------------------------------------------- VENDAS ---------------------------------------------------------------------------//
        //----------------------------------------------------------------------- VENDA ---------------------------------------------------------------------------//
        public void campos_venda()
        {
            cb_client_venda.SelectedItem = 1;
            //txtb_cod_venda.Clear();
            mcb_prod_venda.SelectedItem = 1;
            mtxt_qt.Clear();
            mtxt_deconto.Clear();

            mfbt_deletar_item.Enabled = true;
            mfbt_cadastrar_venda.Enabled = true;
        }

        //----------------------------------------------------------------------- Lançar Item----------------------------------------------------------------------//
        public class ItemVenda
        {
            public int qtd { get; set; }
            public int desconto { get; set; }
            public float valor { get; set; }
            public string desc_item { get; set; } = string.Empty;
            
            public ItemVenda() { }

            public ItemVenda( int quantidade, int desc,  float vl, string desc_prod)
            {
                qtd = quantidade;
                desconto = desc;
                valor = vl;
                desc_item = desc_prod;
            }
        }

        public List<ItemVenda> GetItemVendas()
        {

            var listaItemVenda = new List<ItemVenda>();
            listaItemVenda.AddRange(new[]
            { new ItemVenda(Convert.ToInt32(mtxt_qt.Text), Convert.ToInt32(mtxt_deconto.Text) , Convert.ToInt32(lb_valor_prod.Text),  mcb_prod_venda.SelectedValue.ToString() )

            });
            return listaItemVenda;
        }


        //private void formataGridView()
        //{
        //    var grade = dtgVenda;
        //    grade.AutoGenerateColumns = false;
        //    grade.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
        //    grade.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        //    //altera a cor das linhas alternadas no grid
        //    grade.RowsDefaultCellStyle.BackColor = Color.White;
        //    grade.AlternatingRowsDefaultCellStyle.BackColor = Color.Cyan;
        //    //altera o nome das colunas
        //    grade.Columns[0].HeaderText = "codigo_item";
        //    grade.Columns[1].HeaderText = "Descricao_item";
        //    grade.Columns[2].HeaderText = "valor_item";
        //    grade.Columns[3].HeaderText = "Quantidade";
        //    grade.Columns[0].Width = 70;
        //    grade.Columns[1].Width = 150;
        //    //formata as colunas valor, vencimento e pagamento
        //    grade.Columns[2].DefaultCellStyle.Format = "c";
        //    //seleciona a linha inteira
        //    grade.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //    //não permite seleção de multiplas linhas    
        //    grade.MultiSelect = false;
        //    // exibe nulos formatados
        //    //grade.DefaultCellStyle.NullValue = " - ";
        //    //permite que o texto maior que célula não seja truncado
        //    grade.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        //    //define o alinhamento à direita
        //    grade.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        //    grade.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        //}

        private void mfbt_cadastrar_venda_Click(object sender, EventArgs e)
        {
            EletricoSistemaDataClassesDataContext db = new EletricoSistemaDataClassesDataContext();

            int idselecionado = Convert.ToInt32(mcb_prod_venda.SelectedValue);
            var ProdutoSelecionada = db.tb_produto.FirstOrDefault(p => p.id_produto == idselecionado);
            // Crie um objeto DataTable para armazenar os dados
            DataTable dt = new DataTable();

            // Adicione as colunas ao DataTable
            dt.Columns.Add("codigo_item");
            dt.Columns.Add("descricao_ite");
            dt.Columns.Add("valor");
            dt.Columns.Add("qt");

            // Verifica se o DataGridView já possui linhas
            if (dtgVenda.Rows.Count > 0)
            {
                // Obtém a última linha do DataGridView
                DataGridViewRow lastRow = dtgVenda.Rows[dtgVenda.Rows.Count - 1];

                // Verifica se a última linha está vazia
                if (lastRow.Cells["codigo_item"].Value == null || string.IsNullOrEmpty(lastRow.Cells["codigo_item"].Value.ToString()))
                {
                    // Preenche a última linha vazia com os valores dos Labels
                    lastRow.Cells["codigo_item"].Value = Convert.ToInt32(mcb_prod_venda.SelectedValue);
                    lastRow.Cells["descricao_ite"].Value = ProdutoSelecionada.nome;
                    lastRow.Cells["valor"].Value = Convert.ToInt32(mcb_valor.SelectedValue);
                    lastRow.Cells["qt"].Value = Convert.ToInt32(mtxt_qt.Text);
                }
                else
                {
                    // Cria uma nova linha e adiciona os valores dos Labels
                    DataRow row = ((DataTable)dtgVenda.DataSource).NewRow();
                    row["codigo_item"] = Convert.ToInt32(mcb_prod_venda.SelectedValue);
                    row["descricao_ite"] = ProdutoSelecionada.nome;
                    row["valor"] = Convert.ToInt32(mcb_valor.SelectedValue);
                    row["qt"] = Convert.ToInt32(mtxt_qt.Text);

                    int qt_grid = Convert.ToInt32(mtxt_qt.Text);

                    //verificar se a quantidade adicionada é igual ou maior a quantidade existente do produto.
                    if (ProdutoSelecionada.quantidade < qt_grid)
                    {
                        MessageBox.Show("Quantidade menor que a quantidade existente do Produto", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else{
                        // Adiciona a nova linha ao DataTable
                        ((DataTable)dtgVenda.DataSource).Rows.Add(row);                        
                    }
                }
                decimal xr = 0;
                foreach (DataGridViewRow row in dtgVenda.Rows.Cast<DataGridViewRow>()
                        .Where(t => !string.IsNullOrEmpty(t.Cells["valor"].Value?.ToString())))
                {
                    xr += Convert.ToDecimal(row.Cells["valor"].Value);    
                }
                mt_vl_compra_ant.Text = xr.ToString();
            }
            else
            {

                DataRow row = dt.NewRow();
                row["codigo_item"] = Convert.ToInt32(mcb_prod_venda.SelectedValue);
                row["descricao_ite"] = ProdutoSelecionada.nome;
                row["valor"] = Convert.ToInt32(mcb_valor.SelectedValue);
                row["qt"] = Convert.ToInt32(mtxt_qt.Text);

                // Adiciona a nova linha ao DataTable
                dt.Rows.Add(row);

                // Define o DataTable como a fonte de dados do DataGridView
                dtgVenda.DataSource = dt;

            }
            // Limpa os campos de entrada de texto
            campos_venda();
            txtb_cod_venda.Enabled = false;
        }


        public void SalvarDados()
        {
            try
            {
                if (dtgVenda.Rows.Count > 1)
                {
                    for (int i = 0; i <= dtgVenda.Rows.Count - 1; i++)
                    {
                        int col1 = Convert.ToInt32(dtgVenda.Rows[i].Cells[0].Value); //codigo_item
                        string col2 = dtgVenda.Rows[i].Cells[1].Value.ToString(); //Descricao_item 
                        decimal col3 = Convert.ToDecimal(dtgVenda.Rows[i].Cells[2].Value); //valor_item
                        int col4 = Convert.ToInt32(dtgVenda.Rows[i].Cells[3].Value); //Quantidade
                        //decimal col5 = Convert.ToDecimal(gdvItens.Rows[i].Cells[4].Value); //Total                       
                    }
                }
                MessageBox.Show("Dados incluídos com sucesso !!", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }


        //List<ItemVenda> Carrinho = new List<ItemVenda>();

        //if (Carrinho.Count > 0)
        //{
        //    MessageBox.Show("Por inserir o item", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //}
        //else
        //{
        //    MessageBox.Show("Item adicionado à venda com sucesso", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //}

        //{
        //    if(txtb_cod_venda.Text != "" && mcb_prod_venda.Text != "" && mcb_prod_venda.Text != "" && mtxt_qt.Text != "")
        //    {
        //        tb_venda NovaVenda = new tb_venda();

        //        NovaVenda.valor = lb_valor_prod.Text;
        //        NovaVenda.desconto = mlb_desconto.Text;
        //        NovaVenda.cod_venda = Convert.ToInt32(txtb_cod_venda.Text);                
        //        NovaVenda.cod_prod = Convert.ToInt32(mcb_prod_venda.SelectedValue);
        //        NovaVenda.id_pessoa_cliente = Convert.ToInt32(cb_client_venda.SelectedValue);

        //        if (!VendaDataAccess.Insere(NovaVenda))
        //            MessageBox.Show("Falha ao tentar realizar lançamento de Venda!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        //        //---PAREI AQUI-----------

        //        else
        //            MessageBox.Show("Item adicionado à venda com sucesso", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            //txt_cod_categoria.Clear();

        //            txtb_cod_venda.Clear();
        //            mcb_prod_venda.SelectedItem = null;
        //            mtxt_qt.Clear();
        //            mcb_valor.SelectedItem = null;
        //            mcb_forma_pag.SelectedItem = null;
        //            mt_vl_compra.Clear();
        //            mtxt_deconto.Clear();                

        //            campos_cat();
        //            loadData();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Por Favor, preencha todos os campos obrigatórios", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        //    }

        private void mbt_salvar_Click(object sender, EventArgs e)
        {
            //if (ValidarForms())
            //{
            //    Salvar();
            //}
            //else
            //{
            //    //Application.Exit();
            //}
        }

        private void dtgVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Desassocia o DataGridView da fonte de dados
            dtgVenda.DataSource = null;
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
