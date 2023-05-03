using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using model_beautycontrol.Model.DTO;
using model_beautycontrol.Model.CE;
using model_beautycontrol.Model.BO;
using BeautyControl.Utils;

namespace BeautyControl.View.PopUpViews
{
    public partial class VW_PromocaoForm01 : DevExpress.XtraEditors.XtraForm
    {
        private BO_Preco bo = new BO_Preco();
        private CE_Preco linhafocada;

        public VW_PromocaoForm01()
        {

        }

        public VW_PromocaoForm01(CE_Preco linhafocada)
        {
            this.linhafocada = linhafocada;
            InitializeComponent();
            try
            {
                lcgPreco.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lciBtnSalvar.Enabled = false;
                txtProduto.Text = linhafocada.Produto.nome;
                txtPrecoPadrao.Text = bo.getPrecoPadrao(linhafocada.Produto.id).ToString("N2");
                bsTipoPeriodoPreco.DataSource = new CL_TipoPeriodoPreco().listaTipoPromocao;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao carregar forumulário", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbTipoPeriodo_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbTipoPeriodo.EditValue != null)
            {
                lcgPreco.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                lciBtnSalvar.Enabled = true;
                dtData.DateTime = DateTime.Now;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (isFormValido())
                {
                    CL_TipoPeriodoPreco tipo = (from x in bsTipoPeriodoPreco.DataSource as List<CL_TipoPeriodoPreco> where x.prioridade == Convert.ToInt32(cmbTipoPeriodo.EditValue) select x).FirstOrDefault();

                    CE_Preco obj = bo.getObj(linhafocada.Produto.id,tipo,dtData.DateTime,Convert.ToDouble(txtPrecoNovo.Text),txtDetalhe.Text);

                    bo.doInserir(obj);

                    MessageBox.Show("Promoção inserida com sucesso!", "Promoção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    VariaveisGlobais.houveAlteracaoNaBase = true;

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

            if (string.IsNullOrEmpty(txtPrecoNovo.Text))
            {
                isFormValido = false;
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciPrecoNovo, ViewUtils.getMeuTooltip("Campo obrigatório", "Informe o preço novo!", DevExpress.Utils.ToolTipIconType.Exclamation), false);
            }
            else
            {
                if (model_beautycontrol.Utils.Utilidades.isNumeroMaiorQueZero(Convert.ToDouble(txtPrecoNovo.Text)))
                    ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciPrecoNovo, ViewUtils.getMeuTooltip("Campo obrigatório", "Informe o preço padrão do produto/serviço!", DevExpress.Utils.ToolTipIconType.Exclamation), true);
                else
                {
                    ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciPrecoNovo, ViewUtils.getMeuTooltip("Preço inválido", "Informe um valor maior que 0,00 para o preço novo do produto/serviço!", DevExpress.Utils.ToolTipIconType.Exclamation), false);
                    isFormValido = false;
                }
            }

            return isFormValido;
        }

        private void dtData_EditValueChanged(object sender, EventArgs e)
        {
            if (dtData.Text == "")
                dtData.DateTime = DateTime.Now;
        }
    }
}