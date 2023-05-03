using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using model_beautycontrol.Model.BO;
using model_beautycontrol.Model.CL;
using model_beautycontrol.Model.DAO;
using BeautyControl.View.PopUpViews;
using BeautyControl.Relatorios;
using DevExpress.XtraEditors;

namespace BeautyControl.View.UCViews
{
    public partial class UC_RelatorioVenda : UserControl
    {
        private BO_VendaRegistro bo = new BO_VendaRegistro();
      

        public UC_RelatorioVenda()
        {
            InitializeComponent();
            // Ao Carregar Tela a data atual no formato MM e yyyy é guardada em  var data
            var data = DateTime.Now.ToString("MM/yyyy");
            // dt1 recebe a data com o primeiro dia do mes da data atual
            dteInicio.DateTime = Convert.ToDateTime("01/" + data);
            // dt2 recebe a data com o ultimo dia do mes da data atual
            dteFim.DateTime = Convert.ToDateTime(DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month) + "/" + data);

            doConsultar();
        }

        public UC_RelatorioVenda(DateEdit dteInicio_, DateEdit dteFim_)
        {

            InitializeComponent();

            dteInicio.DateTime = dteInicio_.DateTime;
            dteFim.DateTime = dteFim_.DateTime;

            doConsultar();
        }

        private void doConsultar()
        {
            try
            {
                bsVendaRegistro.DataSource = bo.getVendaRegistroEntreDatas(dteInicio.DateTime, dteFim.DateTime);
                bsVendaRegistroLocal.DataSource = bo.getVendaRegistroLocal(bsVendaRegistro.DataSource as List<CL_VendaRegistro>);

                bsVendaRegistroDomicilio.DataSource = bo.getVendaRegistroDomicilio(bsVendaRegistro.DataSource as List<CL_VendaRegistro>);
                bsVendaRegistroAberto.DataSource = bo.getVendaRegistroAberto();

                doCalcularValores(bsVendaRegistro);
                

                // gvGeral.BestFitColumns();
            }
            catch (Exception ex)
            {
                grcRelatorioVenda.Enabled = false;
                MessageBox.Show(ex.Message, "Ocorreu um erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void doCalcularValores(BindingSource bs)
        {
            txtRegistro.Text = "Total Registros: " + bs.Count;
            txtServico.Text = "Total Serviço: R$ " + (bs.DataSource as List<CL_VendaRegistro>).Sum(o => o.precocobrado).ToString("N2");
            txtDesconto.Text = "Total Desconto: R$ " + (bs.DataSource as List<CL_VendaRegistro>).Sum(o => o.desconto).ToString("N2");
            txtVenda.Text = "Total Venda: R$ " + (bs.DataSource as List<CL_VendaRegistro>).Sum(o => o.valorpago).ToString("N2");
            txtEntrada.Text = "Total Entrada: R$ " + (bs.DataSource as List<CL_VendaRegistro>).Sum(o => o.totalentrada).ToString("N2");

        }

        private void gcAberto_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabControl1_SelectedPageChanging(object sender, DevExpress.XtraTab.TabPageChangingEventArgs e)
        {
            gvGeral.BestFitColumns();
            gvAberto.BestFitColumns();
            gvLocal.BestFitColumns();
            gvDomicilio.BestFitColumns();

            if (e.Page == tabGeral)
                doCalcularValores(bsVendaRegistro);
            else if (e.Page == tabAberto)
                doCalcularValores(bsVendaRegistroAberto);
            else if (e.Page == tabLocal)
                doCalcularValores(bsVendaRegistroLocal);
            else
                doCalcularValores(bsVendaRegistroDomicilio);

        }

        private void riAcaoAberto_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            doOpenDetalhe(gvAberto);
        }

        private void repositoryItemButtonEdit1_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            doOpenDetalhe(gvGeral);
        }

        private void riAcaoLocal_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            doOpenDetalhe(gvLocal);
        }

        private void riAcaoDomicilio_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            doOpenDetalhe(gvDomicilio);
        }

        private void doOpenDetalhe(DevExpress.XtraGrid.Views.Grid.GridView gv)
        {
            var item = gv.GetFocusedRow() as CL_VendaRegistro;

            if (item == null)
                MessageBox.Show("Não foi possível acionar a ação deste botão", "Detalhes da Venda!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                ViewUtils.doTrocarViewdoPanelPrincipal(new UC_DetalheVenda(item, this.Name,dteInicio,dteFim));
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            doConsultar();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            doExportarArquivo("PDF");
        }

        private void btnPng_Click(object sender, EventArgs e)
        {
            doExportarArquivo("PNG");
        }

        private void btnXls_Click(object sender, EventArgs e)
        {
            doExportarArquivo("XLS");

        }

        private void btnHtml_Click(object sender, EventArgs e)
        {
            doExportarArquivo("HTML");
        }

        private void doExportarArquivo(string tipoArquivo)
        {
            try
            {
                List<CL_VendaRegistro> lista = getListaTabSelecionada();

                if (lista == null)
                    throw new Exception("Operação Cancelada!");

                if (lista.Count == 0)
                    throw new Exception("Não há dados para realizar o relatório!");

                System.Windows.Forms.SaveFileDialog svdlg = new System.Windows.Forms.SaveFileDialog();
                svdlg.Title = "Salvar relatório em " + tipoArquivo;
                svdlg.FileName = "RelatorioVenda_" + DateTime.Now.ToString("dd_MM_yyyy");
                svdlg.DefaultExt = "." + tipoArquivo.ToLower();

                if (svdlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                   // RelatorioVenda01 report = new RelatorioVenda01(lista, dteInicio.DateTime, dteFim.DateTime);

                    RelatorioVenda report = new RelatorioVenda(lista, dteInicio.DateTime, dteFim.DateTime);

                    ViewUtils.doExportarReportTo(tipoArquivo, report, svdlg.FileName);

                    MessageBox.Show("Relatório exportado com sucesso!", "Relatório", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    model_beautycontrol.Utils.Utilidades.AbrirArquivo(svdlg.FileName);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Relatório", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        /// <getListaTabSelecionada >
        ///  1. Abre tela passando uma lista de VendaRegistro de acordo com a Aba que esta selecionada
        /// </getListaTabSelecionada>
        /// <returns>Retorna uma lista de VendaRegistro</returns>
        private List<CL_VendaRegistro> getListaTabSelecionada()
        {
            if (xtraTabControlRelatorio.SelectedTabPage == tabGeral)
                return doAbrirPopFiltroRelatorioVenda(bsVendaRegistro.DataSource as List<CL_VendaRegistro>, "Geral");
            if (xtraTabControlRelatorio.SelectedTabPage == tabLocal)
                return doAbrirPopFiltroRelatorioVenda(bsVendaRegistroLocal.DataSource as List<CL_VendaRegistro>, "Local");
            if (xtraTabControlRelatorio.SelectedTabPage == tabDomicilio)
                return doAbrirPopFiltroRelatorioVenda(bsVendaRegistroDomicilio.DataSource as List<CL_VendaRegistro>, "Domicilio");
            if (xtraTabControlRelatorio.SelectedTabPage == tabAberto)
                return doAbrirPopFiltroRelatorioVenda(bsVendaRegistroAberto.DataSource as List<CL_VendaRegistro>, "Aberto");

            return new List<CL_VendaRegistro>();
        }

        private List<CL_VendaRegistro> doAbrirPopFiltroRelatorioVenda(List<CL_VendaRegistro> lista, string tabSelecionada)
        {
            this.Enabled = false;

            VW_RelatorioVendaFiltro janela = new VW_RelatorioVendaFiltro(lista, tabSelecionada);
            janela.ShowDialog();
            this.Enabled = true;

            return janela.lista;

        }

    }
}
