using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using model_beautycontrol.Model.DOM;
using model_beautycontrol.Model.CE;
using BeautyControl.View.PopUpViews;
using BeautyControl.Utils;

namespace BeautyControl.View.UCViews
{
    public partial class UC_Servicos_Produtos : UserControl
    {
        private DOM_Execucao dom =  new DOM_Execucao();
        private List<CE_Preco> listaProdutos;

        public UC_Servicos_Produtos()
        {
            InitializeComponent();
            doConsultar();
        }

        private void doConsultar()
        {
            try
            {
                // é necessário ter categorias na base para realizar  "manter" nesta tela
                var categorias = dom.boCategoria.getCategorias();

                if (categorias == null || categorias.Count == 0)
                    throw new Exception("Não há regitros de categoria(s) no banco de dados!");

                listaProdutos = dom.getProdutos();
                if (listaProdutos.Count == 0)
                {
                    lcgProdutos.CustomHeaderButtons["Alterar"].Properties.Visible = false;
                    lcgProdutos.Expanded = false;
                }
                else
                {
                    bsProduto_Preco.DataSource = (from x in listaProdutos select x).ToList();
                    gvProdutos.BestFitColumns();
                    lcgProdutos.CustomHeaderButtons["Alterar"].Properties.Visible = true;
                    lcgProdutos.Expanded = true;
                }
              
            }
            catch (Exception ex)
            {
                lcgProdutos.Enabled = false;
                MessageBox.Show(model_beautycontrol.Utils.Utilidades.GetMensagemExcecao(ex), "Produtos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lcgProdutos_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            // Get : O nome do botao do CustomHeaderButtons para verificar qual dos botoes foi acionado
            string caption = ((DevExpress.XtraEditors.ButtonPanel.BaseButton)e.Button).Caption.ToString().ToLower();

            switch (caption)
            {
                case "novo":
                    doInserirORalterarProduto(false);
                    break;

                case "alterar":
                    doInserirORalterarProduto(true);
                    break;
            }

            doVerificarAlteracao();
        }

        private void doInserirORalterarProduto(bool isAlterar)
        {
            this.Enabled = false;
            VW_Produto_ServicoForm01 j;

            if (!isAlterar)
            {
                j = new VW_Produto_ServicoForm01();
                j.ShowDialog();
            }else
            {
                var preco = gvProdutos.GetFocusedRow() as CE_Preco;
                j = new VW_Produto_ServicoForm01(preco.Produto);
                j.ShowDialog();
            }

            this.Enabled = true;
        }

        private void doVerificarAlteracao()
        {
            // manter o foco na mesma linha depois de realizar consulta
            int linhaFocada = gvProdutos.FocusedRowHandle;
            
            if (VariaveisGlobais.houveAlteracaoNaBase)
                doConsultar();

            gvProdutos.FocusedRowHandle = linhaFocada;
            VariaveisGlobais.houveAlteracaoNaBase = false;
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            var produtoFocado = gvProdutos.GetFocusedRow() as CE_Preco;
            if (produtoFocado == null)
               MessageBox.Show("Não há Produtos para Edição!","Promoção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                this.Enabled = false;
                var linhafocada = gvProdutos.GetFocusedRow() as CE_Preco;
                VW_PromocaoForm01 janela = new  VW_PromocaoForm01(linhafocada);
                janela.ShowDialog();

                this.Enabled = true;

                doVerificarAlteracao();

            }
        }
    }
}
