using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using model_beautycontrol.Model.CL;
using model_beautycontrol.Model.CE;
using model_beautycontrol.Model.DOM;
using DevExpress.XtraEditors;

namespace BeautyControl.View.UCViews
{
    public partial class UC_DetalheVenda : UserControl
    {
        public UC_DetalheVenda()
        {
            InitializeComponent();
        }

        private string UC_NameRetorno = "";
        private DateEdit dteInicio;
        private DateEdit dteFim;

        public UC_DetalheVenda(CL_VendaRegistro vendaSelecionada, string name, DateEdit dteInicio, DateEdit dteFim) : this(vendaSelecionada, name)
        {
            this.dteInicio = dteInicio;
            this.dteFim = dteFim;

            InitializeComponent();
            UC_NameRetorno = name;

            try
            {
                bsVendaProduto.DataSource = new DOM_Execucao().getListaVendaProdutoParaDetelhe(vendaSelecionada.id);

                txtCliente.Text = vendaSelecionada.cliente;
                txtSituacao.Text = vendaSelecionada.status;
                txtTiposervico.Text = vendaSelecionada.servico;
                dteVenda.Text = vendaSelecionada.Dataformadata;
                txtValorPago.Text = vendaSelecionada.valorpago.ToString("N2");
                txtTotalItens.Text = (bsVendaProduto.DataSource as List<CE_VendaProduto>).Sum(o => o.precocobrado).ToString("N2");
                txtDesconto.Text = vendaSelecionada.desconto.ToString("N2");
                txtTotal.Text = vendaSelecionada.total.ToString("N2");

                gvDetalhesVenda.BestFitColumns();
            }
            catch (Exception ex)
            {
                lcgDetalheVenda.Enabled = false;
                MessageBox.Show("Não foi possível carregar esta tela : " + ex.Message, "Detalhe da Venda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public UC_DetalheVenda(CL_VendaRegistro vendaSelecionada, string name)
        {
            InitializeComponent();
            UC_NameRetorno = name;

            try
            {
                bsVendaProduto.DataSource = new DOM_Execucao().getListaVendaProdutoParaDetelhe(vendaSelecionada.id);

                txtCliente.Text = vendaSelecionada.cliente;
                txtSituacao.Text = vendaSelecionada.status;
                txtTiposervico.Text = vendaSelecionada.servico;
                dteVenda.Text = vendaSelecionada.Dataformadata;
                txtValorPago.Text = vendaSelecionada.valorpago.ToString("N2");
                txtTotalItens.Text = (bsVendaProduto.DataSource as List<CE_VendaProduto>).Sum(o => o.precocobrado).ToString("N2");
                txtDesconto.Text = vendaSelecionada.desconto.ToString("N2");
                txtTotal.Text = vendaSelecionada.total.ToString("N2");

                gvDetalhesVenda.BestFitColumns();
            }
            catch (Exception ex)
            {
                lcgDetalheVenda.Enabled = false;
                MessageBox.Show("Não foi possível carregar esta tela : " + ex.Message, "Detalhe da Venda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void grcDetalhesVenda_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (UC_NameRetorno.ToLower() == "uc_registrovenda")
                ViewUtils.doTrocarViewdoPanelPrincipal(new UC_RegistroVenda());
            else if (UC_NameRetorno.ToLower() == "uc_relatoriovenda")
                ViewUtils.doTrocarViewdoPanelPrincipal(new UC_RelatorioVenda(dteInicio,dteFim));
        }
    }
}
