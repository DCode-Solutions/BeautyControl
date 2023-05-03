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
using model_beautycontrol.Model.DOM;
using model_beautycontrol.Model.CL;
using model_beautycontrol.Model.CE;
using DevExpress.XtraEditors;

namespace BeautyControl.View.UCViews
{
    public partial class UC_VendaApp : UserControl
    {
        //DOM_App dom = new DOM_App();
        private BO_VendaRegistro bo = new BO_VendaRegistro();
        private BO_VendaProduto boP = new BO_VendaProduto();
        private BO_VendaFormaPagamento boFP = new BO_VendaFormaPagamento();
        private BO_Funcionario boF = new BO_Funcionario();
        private BO_VendaApp boV = new BO_VendaApp();

        public UC_VendaApp()
        {
            InitializeComponent();
        }

        private void doConsultar()
        {
            try
            {
                bsVendaRegistro.DataSource = bo.getVendaRegistro_App();

                gvVenda.BestFitColumns();

                bsFuncionario.DataSource = bsVendaRegistro.Count == 0 ? null : boF.getProfissionais();

                //doCalcularValores(bsVendaRegistro);


                // gvGeral.BestFitColumns();

               
                grcVendaApp.CustomHeaderButtons[0].Properties.Visible = bsVendaRegistro.Count==0  ? false : true;

                

            }
            catch (Exception ex)
            {

                grcVendaApp.Enabled = false;
                MessageBox.Show(ex.Message, "Ocorreu um erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UC_VendaApp_Load(object sender, EventArgs e)
        {
            doConsultar();
        }

        private void gvVenda_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var obj = gvVenda.GetFocusedRow() as CL_VendaRegistro;
            if (obj != null)
                bsVendaProduto.DataSource = boP.getListaVendaProduto_App(obj.id);

            gvVendaProduto.BestFitColumns();
        }

        private void riCmbFuncionario_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void rigleFuncionario_EditValueChanged(object sender, EventArgs e)
        {
            var ven = gvVendaProduto.GetFocusedRow() as CE_VendaProduto;
            
            if (ven != null)
            {
                var x = sender as GridLookUpEdit;
                int? id = Convert.ToInt32( x.EditValue);


                if (id == null)
                    boP.doAlterarFuncionarioDoServico(ven.id, 0);
                else
                    boP.doAlterarFuncionarioDoServico(ven.id, (int)id);
            }
            else
            {
                MessageBox.Show("Erro nesta operacao!");
            }
           
        }

        private DOM_Execucao dom;
      
        private void grcVendaApp_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            int idVendaLast =0, idVendaProdutoLast =0, idVendaFormaPagamentoLast=0;
            bool isSucesso = false;
            try
            {
                var listaVenda = bo.getVendaRegistro_App();

                dom = new DOM_Execucao();
                int idvendaCorrente = 0;
                idVendaLast = dom.boVenda.getIDUltimaVenda();
                idVendaProdutoLast = dom.boVendaProduto.getUltimoId();
                idVendaFormaPagamentoLast = dom.boVendaFormaPagamento.getUltimoId();

                foreach (var item in listaVenda)
                {
                    idvendaCorrente = dom.boVenda.getID_After_Inserir(ObterVenda(item));

                    var listaServicosProdutos = boP.getListaVendaProduto_App(item.id);

                    var listaFormaPagamento = boFP.getPagamentosdaVenda_App(item.id);

                    foreach (var produto in listaServicosProdutos)
                    {
                        produto.id_venda = idvendaCorrente;
                        dom.boVendaProduto.doInserir(produto);
                    }

                    foreach (var formapagamento in listaFormaPagamento)
                    {
                        formapagamento.id_venda = idvendaCorrente;
                        dom.boVendaFormaPagamento.doInserir(formapagamento);
                    }

                    dom.boVendaFormaPagamento.doDeletarAll_App();
                    dom.boVendaProduto.doDeleteAll_App();
                    dom.boVenda.doDeleteAll_App();

                    isSucesso = true;

                    MessageBox.Show("Vendas Transferidas com Sucesso!","Aprovar Vendas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    doConsultar();

                    isSucesso = false;
                }
            }
            catch (Exception ex)
            {
                if(idVendaFormaPagamentoLast>0 && idVendaLast > 0 && idVendaProdutoLast > 0 && isSucesso == false)
                {
                    dom.boVendaFormaPagamento.doDeletarApartirDeUmID(idVendaFormaPagamentoLast);
                    dom.boVendaProduto.doDeletarApartirDeUmID(idVendaProdutoLast);
                    dom.boVenda.doDeletarApartirDeUmID(idVendaLast);
                }
               
                MessageBox.Show(ex.Message);
            }
           
        }

        private CE_Venda ObterVenda(CL_VendaRegistro item)
        {
            CE_Venda_App obj = boV.getVenda(item.id);
            CE_Venda result = new CE_Venda();// dom.boVenda.getVenda(item.id);
            result.id_cliente = obj.id_cliente;
            result.dataservico = obj.dataservico;
            result.id_servico = dom.boAuxiliar.getListaAuxiliar("tiposervico").Where(o => o.descricao.ToLower() == item.servico.ToLower()).Select(p=> p.id).FirstOrDefault();
            result.isPago = item.ispago;
            result.desconto = item.desconto;
            
            return result;
        }
    }
}
