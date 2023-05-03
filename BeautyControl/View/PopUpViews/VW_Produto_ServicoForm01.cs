using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using model_beautycontrol.Model.DOM;
using model_beautycontrol.Model.CE;
using BeautyControl.Utils;

namespace BeautyControl.View.PopUpViews
{
    public partial class VW_Produto_ServicoForm01 : DevExpress.XtraEditors.XtraForm
    {
        private DOM_Execucao dom = new DOM_Execucao();
        private CE_Produto obj;
        private bool isEditando;
        public VW_Produto_ServicoForm01()
        {
            InitializeComponent();
            isEditando = false;
            doPrepararCombo(isEditando);
        }

        public VW_Produto_ServicoForm01(CE_Produto produto)
        {
            InitializeComponent();
            obj = produto;
            isEditando = true;
            doPreencherForm(obj);
        }

        private void doPreencherForm(CE_Produto produto)
        {
            doPrepararCombo(isEditando);
            txtNome.Text = produto.nome;
            //txtPreco.Text = produto.preco.ToString();
            lciPReco.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            txtMinEst.Text = produto.minutosestimado == 0 ? "" : produto.minutosestimado.ToString();
            txtDescricao.Text = produto.descricao;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (isFormValido())
                {
                    obj = isEditando == false
                          ? new CE_Produto(txtNome.Text, txtDescricao.Text, Convert.ToDouble(txtPreco.Text), txtMinEst.Text != "" ? Convert.ToInt32(txtMinEst.Text) : 0, Convert.ToInt32(cmbCategoria.EditValue))
                          : new CE_Produto(obj.id,txtNome.Text, txtDescricao.Text, txtMinEst.Text != "" ? Convert.ToInt32(txtMinEst.Text) : 0, Convert.ToInt32(cmbCategoria.EditValue));

                    dom.InserirOrAlterarProduto(obj);

                    VariaveisGlobais.houveAlteracaoNaBase = true;

                    MessageBox.Show("Operação realizada com sucesso!", "Alterar aqui", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();
                }
                else
                    MessageBox.Show("Não foi possível concluir esta operação\nVerifique o formulário.", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro - Operação Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool isFormValido()
        {
            bool isFormValido = true;

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                isFormValido = false;
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciNome, ViewUtils.getMeuTooltip("Campo obrigatório", "Informe o nome do profissional para ser registrado na base!", DevExpress.Utils.ToolTipIconType.Exclamation), false);
            }
            else
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciNome, ViewUtils.getMeuTooltip("Campo obrigatório", "Informe o nome do profissional para ser registrado na base!", DevExpress.Utils.ToolTipIconType.Exclamation), true);

            if (isEditando == false)
            {
                if (string.IsNullOrEmpty(txtPreco.Text))
                {
                    isFormValido = false;
                    ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciPReco, ViewUtils.getMeuTooltip("Campo obrigatório", "Informe o preço padrão do produto/serviço!", DevExpress.Utils.ToolTipIconType.Exclamation), false);
                }
                else
                {
                    if (model_beautycontrol.Utils.Utilidades.isNumeroMaiorQueZero(Convert.ToDouble(txtPreco.Text)))
                        ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciPReco, ViewUtils.getMeuTooltip("Campo obrigatório", "Informe o preço padrão do produto/serviço!", DevExpress.Utils.ToolTipIconType.Exclamation), true);
                    else
                        ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciPReco, ViewUtils.getMeuTooltip("Preço inválido", "Informe um valor maior que 0,00 para o preço padrão do produto/serviço!", DevExpress.Utils.ToolTipIconType.Exclamation), false);
                }
            }
           

            if (!string.IsNullOrEmpty(txtMinEst.Text) && Convert.ToDouble(txtMinEst.Text) < 0)
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciMinutosEstimado, ViewUtils.getMeuTooltip("Minutos inválido", "Informe um valor positivo o minuto estimado da realização do serviço!", DevExpress.Utils.ToolTipIconType.Exclamation), false);
            else
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciMinutosEstimado, ViewUtils.getMeuTooltip("Campo obrigatório", "Informe o preço padrão do produto/serviço!", DevExpress.Utils.ToolTipIconType.Exclamation), true);


            if (cmbCategoria.EditValue == null)
            {
                isFormValido = false;
                ViewUtils.doMudarAparenciaLayoutControlLookupEditComToolTipParaValidacoes(ref lcicmbCategoria, ViewUtils.getMeuTooltip("Campo obrigatório", "Selecione uma categoria para produto/serviço!", DevExpress.Utils.ToolTipIconType.Exclamation), false);
            }
            else
                ViewUtils.doMudarAparenciaLayoutControlLookupEditComToolTipParaValidacoes(ref lcicmbCategoria, ViewUtils.getMeuTooltip("Campo obrigatório", "Selecione uma categoria para produto/serviço!", DevExpress.Utils.ToolTipIconType.Exclamation), true);


            return isFormValido;
        }

        private void doPrepararCombo(bool isEditando)
        {
            bsCategoria.DataSource = dom.boCategoria.getCategorias();

            if (isEditando)
                cmbCategoria.EditValue = (from x in bsCategoria.DataSource as List<CE_Categoria> where x.id == obj.idcategoria select x).FirstOrDefault().id;
        }
    }
}