using System;
using System.Windows.Forms;
using model_beautycontrol.Model.DOM;
using BeautyControl.Utils;
using model_beautycontrol.Model.CE;

namespace BeautyControl.View.PopUpViews
{
    public partial class VW_EstoqueProdutoForm01 : DevExpress.XtraEditors.XtraForm
    {
        private DOM_Movimentacao dom = new DOM_Movimentacao();
        private CE_Produto01 produto = new CE_Produto01();

        public VW_EstoqueProdutoForm01(string operacao)
        {
            InitializeComponent();

            try
            {
                gpcProduto01.Text = ViewUtils.getTituloOperacao(operacao,"Produto");

                doPrepararCombos(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao carregar formulário", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void doPrepararCombos(bool v)
        {
            bsTipoProduto.DataSource = dom.boAuxiliar.getListaAuxiliar("produto");
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (isFormularioValido())
                {
                    #region preparar obj produto

                    produto.nome = txtNomeProduto.Text;
                    produto.marca = txtMarca.Text;
                    produto.descricao = txtDescricao.Text;
                    produto.observacao = memoObservacao.Text;
                    produto.id_tipoproduto = Convert.ToInt32(cmbTipoProduto.EditValue);

                    #endregion

                    dom.DoInserirOuAlterarProduto01(produto);

                    VariaveisGlobais.houveAlteracaoNaBase = true;

                    MessageBox.Show("Operação realizada com sucesso!", gpcProduto01.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();
                }
                else
                    MessageBox.Show("Não foi possível concluir esta operação\nVerifique o formulário.", gpcProduto01.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro - Operação Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool isFormularioValido()
        {
            bool isFormularioValido = true;

            if (string.IsNullOrEmpty(txtNomeProduto.Text))
            {
                isFormularioValido = false;
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciProduto, ViewUtils.getMeuTooltip("Campo obrigatório", "Informe o nome do produto para ser registrado na base!", DevExpress.Utils.ToolTipIconType.Exclamation), false);
            }
            else
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciProduto, ViewUtils.getMeuTooltip("Campo obrigatório", "Informe o nome do produto para ser registrado na base!", DevExpress.Utils.ToolTipIconType.Exclamation), true);

            if (cmbTipoProduto.EditValue == null)
            {
                isFormularioValido = false;
                ViewUtils.doMudarAparenciaLayoutControlLookupEditComToolTipParaValidacoes(ref lciCmbTipoProduto, ViewUtils.getMeuTooltip("Campo obrigatório", "Selecione um tipo do produto!", DevExpress.Utils.ToolTipIconType.Exclamation), false);
            }
            else
                ViewUtils.doMudarAparenciaLayoutControlLookupEditComToolTipParaValidacoes(ref lciCmbTipoProduto, ViewUtils.getMeuTooltip("Campo obrigatório", "Selecione um tipo do produto!", DevExpress.Utils.ToolTipIconType.Exclamation), true);

            return isFormularioValido;
        }
    }
}