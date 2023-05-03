using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using model_beautycontrol.Model.BO;
using model_beautycontrol.Model.CE;
using model_beautycontrol.Model.DOM;

namespace BeautyControl.View.PopUpViews
{
    public partial class VW_PagarServico : DevExpress.XtraEditors.XtraForm
    {
        private CE_Venda vendaCorrente;
        private DOM_Execucao dom = new DOM_Execucao();
        private double valorAPagar, valorSubTotal;
        private double valorTotalPago, valorTroco, valorDesconto = 0;

        public bool isPago = false;

        public VW_PagarServico()
        {
            InitializeComponent();
            this.Enabled = false;
        }

        public VW_PagarServico(CE_Venda vendaCorrente,string total)
        {
            InitializeComponent();
            bsTipoPagamento.DataSource = new BO_Auxiliar().getListaAuxiliar("formapagamento");

            this.vendaCorrente = vendaCorrente;

            valorAPagar = Convert.ToDouble(total);
            valorDesconto = vendaCorrente.desconto;
            valorSubTotal = valorAPagar - valorDesconto;

            txtValorAPagar.Text = total;
            txtValorDesconto.Text = vendaCorrente.desconto.ToString("N2");
            txtSubTotal.Text = valorSubTotal.ToString();

            bsVendaFormaPagamento.DataSource = dom.boVendaFormaPagamento.getPagamentosdaVenda(vendaCorrente.id);

            gleTipoPagamento.EditValue = (bsTipoPagamento.DataSource as List<CE_Auxiliar>).First().id;
           
            doCalcularValores();
        }

        private void doCalcularValores()
        {
            valorTotalPago = (bsVendaFormaPagamento.DataSource as List<CE_VendaFormaPagamento>).Sum(o => o.valor);
            txtValorTotalPago.Text = valorTotalPago.ToString("N2");

            valorDesconto = string.IsNullOrEmpty(txtValorDesconto.Text) ? 0 : Convert.ToDouble(txtValorDesconto.Text.Replace(".", ","));

            valorSubTotal = valorAPagar - valorDesconto;
            txtSubTotal.Text = valorSubTotal.ToString();

            txtValorRestante.Text = valorTotalPago < valorSubTotal ? (valorSubTotal - valorTotalPago).ToString() : "0,00";

            // Calcular Troco se o valorTotalPago for maior ou igual ao valorSubTotal
            if (valorTotalPago >= valorSubTotal)
            {
                valorTroco = valorTotalPago - valorSubTotal;
                txtValorTroco.Text = Convert.ToString(valorTroco);
                
                btnFecharConta.Enabled = true;
            }
            else
            {
                txtValorTroco.Text = "";
                btnFecharConta.Enabled = false;
            }

            if (valorSubTotal > valorTotalPago)
                txtValorTeclado.Text = (valorAPagar - valorTotalPago).ToString();
        }
       
        private void doAdicionarDesconto()
        {
            vendaCorrente.desconto = String.IsNullOrEmpty(txtValorDesconto.Text) ? 0 : Convert.ToDouble(txtValorDesconto.Text);

            dom.boVenda.doAtualizarDesconto(vendaCorrente);

            doCalcularValores();
        }

        private CE_VendaFormaPagamento getPagamento()
        {
            CE_VendaFormaPagamento result = new CE_VendaFormaPagamento();
            result.FormaPagamento = (from x in bsTipoPagamento.DataSource as List<CE_Auxiliar> where x.id == Convert.ToInt32(gleTipoPagamento.EditValue) select x).FirstOrDefault();
            result.id_formapagamento = result.FormaPagamento.id;

            result.valor = Convert.ToDouble(txtValorTeclado.Text);
            result.id_venda = vendaCorrente.id;

            return result;
        }
       
        private void gleTipoPagamento_QueryPopUp(object sender, CancelEventArgs e)
        {
            GridLookUpEdit editor = (GridLookUpEdit)sender;
            DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit properties = editor.Properties;
            properties.PopupFormMinSize = new Size(editor.MinimumSize.Width - 20, properties.PopupFormSize.Height);
        }

        private void txtValorDesconto_KeyDown(object sender, KeyEventArgs e)
        {
            // Se a tecla Enter for pressionada
            if ((System.Windows.Input.Keyboard.IsKeyDown(System.Windows.Input.Key.Return)))
                doAdicionarDesconto();

            if ((System.Windows.Input.Keyboard.IsKeyDown(System.Windows.Input.Key.OemMinus)))
                e.Handled = true;
        }

        private void txtValorDesconto_Leave(object sender, EventArgs e)
        {
            doAdicionarDesconto();
        }

        private void txtValorTeclado_Leave(object sender, EventArgs e)
        {
            string valorTeclado;
            valorTeclado = txtValorTeclado.Text;
            if (valorTeclado.Count() > 1)
                txtValorTeclado.Text = txtValorTeclado.Text.Replace(".", ",");
        }

        private void grcPagamento_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            Close();
        }

        private void riBtnAcoesPagamento_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var linha = gvPagamento.GetFocusedRow() as CE_VendaFormaPagamento;

            try
            {
                dom.boVendaFormaPagamento.doDeletar(linha.id);
                bsVendaFormaPagamento.DataSource = dom.boVendaFormaPagamento.getPagamentosdaVenda(vendaCorrente.id);
                doCalcularValores();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFecharConta_Click(object sender, EventArgs e)
        {
            try
            {
                dom.doVerificarValorPago(valorTotalPago, valorSubTotal);

                isPago = true;
               
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pagamento");
                // Xceed.Wpf.Toolkit.MessageBox.Show(ex.Message, "Pagamento", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void teclado_Click(object sender, EventArgs e)
        {
            char tag = Convert.ToChar(((System.Windows.Forms.Control)sender).Tag);

            if (txtValorTeclado.EditValue.ToString().Contains(',') && tag == ',')
            {

            }
            else
                txtValorTeclado.EditValue = txtValorTeclado.EditValue.ToString() + tag;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValorTeclado.EditValue = txtValorTeclado.Text = "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txtValorTeclado.Text) <= 0)
                    throw new Exception("Insira uma valor maior que R$ 0,00");

                if (gleTipoPagamento.EditValue == null || gleTipoPagamento.EditValue.ToString() == "")
                    throw new Exception("Selecione uma forma de pagamento");

                bsVendaFormaPagamento.Add(getPagamento());

                // salvar
                if (bsVendaFormaPagamento.Count != 0)
                {
                    dom.doSalvarVendaFormaPgto(bsVendaFormaPagamento.DataSource as List<CE_VendaFormaPagamento>);

                    txtValorTeclado.Text = "";
                }

                gvPagamento.RefreshData();
                gvPagamento.BestFitColumns();

                doCalcularValores();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}