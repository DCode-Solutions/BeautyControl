using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using model_beautycontrol.Model.BO;
using BeautyControl.Utils;
using model_beautycontrol.Model.CE;

namespace BeautyControl.View.PopUpViews
{
    public partial class VW_EstoqueLancamentoCompra : XtraForm
    {
        private CE_Movimentacao01 obj;
        private BO_Movimentacao01 bo = new BO_Movimentacao01();
        private BO_Produto01 boprod = new BO_Produto01();
        private BO_Fornecedor boForn = new BO_Fornecedor();
        private BO_Estoque boEst = new BO_Estoque();
        private bool isEntrada = true;
        private bool isAtualizarUcEstoque = false;

        public VW_EstoqueLancamentoCompra(string tivoMovimentacao,bool isAtualizarEstoque)
        {
            isAtualizarUcEstoque = isAtualizarEstoque;

            InitializeComponent();

            lciResponsavel.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

            isEntrada = tivoMovimentacao.Contains("(+)") ? true : false;

            try
            {
                doPrepararCombos(tivoMovimentacao);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao carregar formulário", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Preenche os combos
        private void doPrepararCombos(string tipoMovimentacao)
        {
            bsCmbProduto.DataSource = boprod.getListaProduto01();
            bsCmbForncedor.DataSource = boForn.getListaFornecedores(1);
            bsTipoMovimentacao.DataSource = new BO_Auxiliar().getListaMovimentacao("movimentacaoestoque", tipoMovimentacao);
        }

        // Btn Fechar Form
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (isAtualizarUcEstoque)
                VariaveisGlobais.houveAlteracaoNaBase = true;

            Close();
        }

        // Novo Produto 
        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            VW_EstoqueProdutoForm01 janela = new VW_EstoqueProdutoForm01("Novo");
            janela.ShowDialog();

            doVerificaAlteracao("P");
        }

        // Novo fornecedor
        private void btnNovoFornecedor_Click(object sender, EventArgs e)
        {
            VW_FornecedorForm01 janela = new VW_FornecedorForm01();
            janela.ShowDialog();

            doVerificaAlteracao("F");
        }

        // Atualiza Binding source apos Cadastrar um produto ou fornecedor
        private void doVerificaAlteracao(string tabela)
        {
            if (VariaveisGlobais.houveAlteracaoNaBase)
            {
                switch (tabela)
                {
                    case "P": bsCmbProduto.DataSource = boprod.getListaProduto01(); break;
                    case "F": bsCmbForncedor.DataSource = boForn.getListaFornecedores(1); break;
                }

                VariaveisGlobais.houveAlteracaoNaBase = false;
            }
        }

        // Ao mudar a selecao de um produto - atualiza o txtEstoque de acordo com o produto selecionado
        private void cmbProduto_EditValueChanged(object sender, EventArgs e)
        {
            if (((DevExpress.XtraEditors.BaseEdit)sender).EditValue != null)
                txtEstoqueAtual.Text = new BO_Estoque().getQuantidadeEstoqueProduto(((DevExpress.XtraEditors.BaseEdit)sender).EditValue).ToString();
        }

        private void cmbTipoMovimentacao_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbTipoMovimentacao.EditValue != null)
            {
                string siglaMovimentacao = (from x in bsTipoMovimentacao.DataSource as List<CE_Auxiliar> where x.id == (int)cmbTipoMovimentacao.EditValue select x).FirstOrDefault().sigla;
                if (siglaMovimentacao == "EBB" || siglaMovimentacao == "SPQ" || siglaMovimentacao == "SUI" || siglaMovimentacao == "SVC")
                {
                    txtCustoUnit.Text = "0,00";
                    txtCustoUnit.Properties.ReadOnly = true;
                }else
                {
                    txtCustoUnit.Properties.ReadOnly = false;
                }

                if(siglaMovimentacao == "SUI" || siglaMovimentacao == "SVC")
                {
                    lciResponsavel.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    bsFuncionario.DataSource = new BO_Funcionario().getProfissionais();// getFuncionariosAtivos();
                }else
                {
                    lciResponsavel.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    bsFuncionario.DataSource = null;
                    cmbResponsavel.EditValue = null;
                }

            }
        }

        // Sempre que txtcustunit for atualizado , atualiza o valor total
        private void txtCustoUnit_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            double vl1, vl2, vl3;
            try
            {
                if (!String.IsNullOrEmpty(txtQuantidade.Text) && e.NewValue != null)
                {
                    vl1 = Convert.ToDouble(txtQuantidade.Text);
                    vl2 = Convert.ToDouble(e.NewValue.ToString().Replace('.', ','));
                    vl3 = vl1 * vl2;

                    txtCustoTotal.Text = vl3.ToString("N2");
                }
            }
            catch (Exception)
            {
                txtCustoTotal.Text = "";
            }
        }

        // Sempre que a txtquantidade for atualizado, atualiza o valor total
        private void txtQuantidade_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            double vl1, vl2, vl3;
            try
            {
                if (!String.IsNullOrEmpty(txtCustoUnit.Text) && e.NewValue != null)
                {
                    vl1 = Convert.ToDouble(e.NewValue);
                    vl2 = Convert.ToDouble(txtCustoUnit.Text);
                    vl3 = vl1 * vl2;

                    txtCustoTotal.Text = vl3.ToString("N2");
                }
            }
            catch (Exception)
            {
                txtCustoTotal.Text = "";
            }
        }

        // Salva - Registra e fecha janela
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (isFormularioValido())
                {
                    doRegistrarLancamento();

                    Close();
                }
                else
                    MessageBox.Show("Não foi possível concluir esta operação\nVerifique o formulário.", gpcLancamentoCompra.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao registrar este item", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Salva - Registra e limpa formulario
        private void btnSalvarPlus_Click(object sender, EventArgs e)
        {
            try
            {
                if (isFormularioValido())
                {
                    doRegistrarLancamento();

                    doLimparFormulario();
                }
                else
                    MessageBox.Show("Não foi possível concluir esta operação\nVerifique o formulário.", gpcLancamentoCompra.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao registrar este item", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Limpa formulario
        private void doLimparFormulario()
        {
            foreach (var item in lcgForm.Items)
            {
                if (item is DevExpress.XtraLayout.LayoutControlItem)
                {
                    var control = ((DevExpress.XtraLayout.LayoutControlItem)item).Control;

                    if (control is DevExpress.XtraEditors.TextEdit)
                        ((DevExpress.XtraEditors.TextEdit)control).Text = null;// Properties.ReadOnly = isReadOnly;

                    if (control is DevExpress.XtraEditors.LookUpEdit)
                        ((DevExpress.XtraEditors.LookUpEdit)control).EditValue = null;// Properties.ReadOnly = isReadOnly;
                }
            }

        }

        // Registra na base um lançament
        private void doRegistrarLancamento()
        {
            #region preparar obj 
            obj = new CE_Movimentacao01();
            obj.codclienteorfornecedor = cmbForncedor.EditValue == null ? 0 : Convert.ToInt32(cmbForncedor.EditValue);
            obj.custounit = string.IsNullOrEmpty(txtCustoUnit.Text) ? 0 : Convert.ToDouble(txtCustoUnit.Text.Replace('.', ','));
            obj.datamovimentacao = Convert.ToInt32(dteDataMovimentacao.DateTime.ToString("yyyyMMdd"));
            obj.id_produto = Convert.ToInt32(cmbProduto.EditValue);
            obj.id_tipomovimentacao = Convert.ToInt32(cmbTipoMovimentacao.EditValue);
            obj.notafiscal = txtNotaFiscal.Text;
            obj.observacao = txtObservacao.Text;
            obj.quantidade = Convert.ToInt32(txtQuantidade.Text);

            string siglaMovimentacao = (from x in bsTipoMovimentacao.DataSource as List<CE_Auxiliar> where x.id == (int)cmbTipoMovimentacao.EditValue select x).FirstOrDefault().sigla;

            if (siglaMovimentacao == "ECP" || siglaMovimentacao=="SDC")
                obj.iscompraefetuada = true;

            if (siglaMovimentacao == "SUI" || siglaMovimentacao == "SVC")
                obj.responsavel = cmbResponsavel.EditValue == null ? 0 : Convert.ToInt32(cmbResponsavel.EditValue);
            
            #endregion

            bo.doInserir(obj);

            int estoqueAtual = 0;

            if (!string.IsNullOrEmpty(txtEstoqueAtual.Text))
                estoqueAtual = Convert.ToInt32(txtEstoqueAtual.Text);

            boEst.doAtualizarEstoque(obj.id_produto, obj.quantidade,estoqueAtual, isEntrada);

            if (isAtualizarUcEstoque)
                VariaveisGlobais.houveAlteracaoNaBase = true;

            MessageBox.Show("Operação realizada com sucesso!", gpcLancamentoCompra.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        // Valida formulario
        private bool isFormularioValido()
        {
            bool isFormularioValido = true;


            if (cmbTipoMovimentacao.EditValue == null)
            {
                isFormularioValido = false;
                ViewUtils.doMudarAparenciaLayoutControlLookupEditComToolTipParaValidacoes(ref lciTipoMovimentacao, ViewUtils.getMeuTooltip("Campo obrigatório", "Selecione um tipo de movimentação!", DevExpress.Utils.ToolTipIconType.Exclamation), false);
            }
            else
                ViewUtils.doMudarAparenciaLayoutControlLookupEditComToolTipParaValidacoes(ref lciTipoMovimentacao, ViewUtils.getMeuTooltip("Campo obrigatório", "Selecione um tipo de movimentação!", DevExpress.Utils.ToolTipIconType.Exclamation), true);

            if (cmbTipoMovimentacao.EditValue != null)
            {
                string siglaMovimentacao = (from x in bsTipoMovimentacao.DataSource as List<CE_Auxiliar> where x.id == (int)cmbTipoMovimentacao.EditValue select x).FirstOrDefault().sigla;

                if (siglaMovimentacao == "EDV" && string.IsNullOrEmpty(txtObservacao.Text))
                {
                    ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciObservacao, ViewUtils.getMeuTooltip("Campo obrigatório", "Você deve informar um motivo na obserção para devolução!", DevExpress.Utils.ToolTipIconType.Exclamation), false);
                    isFormularioValido = false;
                }
                else
                    ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciObservacao, ViewUtils.getMeuTooltip("", "", DevExpress.Utils.ToolTipIconType.Exclamation), true);
            }

            if (cmbProduto.EditValue == null)
            {
                isFormularioValido = false;
                ViewUtils.doMudarAparenciaLayoutControlLookupEditComToolTipParaValidacoes(ref lciProduto, ViewUtils.getMeuTooltip("Campo obrigatório", "Selecione um produto!", DevExpress.Utils.ToolTipIconType.Exclamation), false);
            }
            else
                ViewUtils.doMudarAparenciaLayoutControlLookupEditComToolTipParaValidacoes(ref lciProduto, ViewUtils.getMeuTooltip("Campo obrigatório", "Selecione um produto!", DevExpress.Utils.ToolTipIconType.Exclamation), true);

            if (string.IsNullOrEmpty(dteDataMovimentacao.Text))
            {
                isFormularioValido = false;
                ViewUtils.doMudarAparenciaLayoutControlGDateEditComToolTipParaValidacoes(ref lciDataMovimentacao, ViewUtils.getMeuTooltip("Campo obrigatório", "Informe a data de movimentação!", DevExpress.Utils.ToolTipIconType.Exclamation), false);
            }
            else
            {
                ViewUtils.doMudarAparenciaLayoutControlGDateEditComToolTipParaValidacoes(ref lciDataMovimentacao, ViewUtils.getMeuTooltip("Campo obrigatório", "Informe a data de movimentação!", DevExpress.Utils.ToolTipIconType.Exclamation), true);
            }

            if (string.IsNullOrEmpty(txtQuantidade.Text))
            {
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciQuantidade, ViewUtils.getMeuTooltip("Campo obrigatório", "Informe a quantidade!", DevExpress.Utils.ToolTipIconType.Exclamation), false);
                isFormularioValido = false;
            }
            else
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciQuantidade, ViewUtils.getMeuTooltip("", "", DevExpress.Utils.ToolTipIconType.Exclamation), true);

            return isFormularioValido;
        }
    }
}