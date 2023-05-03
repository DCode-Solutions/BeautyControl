using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeautyControl.View.PopUpViews;
using model_beautycontrol.Model.CE;
using model_beautycontrol.Model.BO;
using model_beautycontrol.Model.DOM;
using BeautyControl.Utils;

namespace BeautyControl.View.UCViews
{
    public partial class UC_Venda : UserControl
    {
        private CE_Venda vendaCorrente;
        private CE_Cliente clienteSelecionado;
        private DOM_Execucao dom = new DOM_Execucao();

        public UC_Venda()
        {
            InitializeComponent();
            bsTipoServiço.DataSource = dom.boAuxiliar.getListaAuxiliar("tiposervico");
            bsServicos.DataSource = dom.getProdutos();
        }

        public UC_Venda(CE_Venda cE_Venda)
        {
            InitializeComponent();
            this.vendaCorrente = cE_Venda;

            doConsultar();

        }

        private void doConsultar()
        {
            bsTipoServiço.DataSource = dom.boAuxiliar.getListaAuxiliar("tiposervico");
            bsServicos.DataSource = dom.getProdutos();

            if (vendaCorrente.id == 0)
            {
                // Venda nova
                 VariaveisGlobais.listaProdutosServicosCorrente =  new List<CE_VendaProduto>();
                dteDataVenda.DateTime = DateTime.Now;
            }
            else
            {
                VariaveisGlobais.listaProdutosServicosCorrente = dom.boVendaProduto.getListaVendaProduto(vendaCorrente.id);
                bsVendaProduto.DataSource = VariaveisGlobais.listaProdutosServicosCorrente;
                gvItensVenda.RefreshData();

                clienteSelecionado = vendaCorrente.Cliente;
                cmbTipoServico.EditValue = vendaCorrente.id_servico;

                txtCliente.Text = clienteSelecionado.nome;
                dteDataVenda.DateTime = Convert.ToDateTime(vendaCorrente.dataFormatada);
                
            }

            btnPagar.Enabled = VariaveisGlobais.listaProdutosServicosCorrente.Count == 0 ?  false : true;
           
        }

        private void doSalvarVenda()
        {
            vendaCorrente.id_cliente = clienteSelecionado.id;
            vendaCorrente.Cliente = clienteSelecionado;
            vendaCorrente.dataservico = Convert.ToInt32(dteDataVenda.DateTime.ToString("yyyyMMdd"));
            vendaCorrente.id_servico = Convert.ToInt32(cmbTipoServico.EditValue);

            if (vendaCorrente.id == 0)
                dom.doRegistrarNovaVenda(ref vendaCorrente, VariaveisGlobais.listaProdutosServicosCorrente);
            else
                dom.doAtualizarVenda(ref vendaCorrente, VariaveisGlobais.listaProdutosServicosCorrente);
        }

        private void doAtualizarTxtValorTotal()
        {
            double value = 0.0;

            var lista = bsVendaProduto.DataSource as List<CE_VendaProduto>;

            if (lista != null)
                value = lista.Sum(o => o.Total);

            txtTotal.Text = value.ToString("N2");

            btnPagar.Enabled = VariaveisGlobais.listaProdutosServicosCorrente.Count == 0 ? false : true;
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            VW_ClientesSelecionar janela = new VW_ClientesSelecionar();
            janela.ShowDialog();

            if (janela.clienteSelecionado != null)
            {
                clienteSelecionado = janela.clienteSelecionado;
                txtCliente.Text = clienteSelecionado.nome;
            }

        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            VW_ClienteForm janela = new VW_ClienteForm("Novo", true);
            janela.ShowDialog();

            if (janela.cliente != null)
            {
                clienteSelecionado = janela.cliente;
                txtCliente.Text = clienteSelecionado.nome;
            }


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (isFormularioValido())
                {
                    doSalvarVenda();

                    VariaveisGlobais.listaProdutosServicosCorrente.Clear();

                    ViewUtils.doTrocarViewdoPanelPrincipal(new UC_RegistroVenda());
                }
                else
                    MessageBox.Show("Não foi possível concluir esta operação\nVerifique o formulário.", lcgVenda.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Operação Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (isFormularioValido())
                {
                    doSalvarVenda();

                    VW_PagarServico janela = new VW_PagarServico(vendaCorrente, txtTotal.Text);
                    janela.ShowDialog();

                    if (janela.isPago)
                    {
                        dom.doFinalizarVenda(vendaCorrente);

                        MessageBox.Show("Operação realizada com sucesso!", "Venda");

                        VariaveisGlobais.listaProdutosServicosCorrente.Clear();

                        ViewUtils.doTrocarViewdoPanelPrincipal(new UC_RegistroVenda());
                    }
                }
                else
                    MessageBox.Show("Não foi possível concluir esta operação\nVerifique o formulário.", lcgVenda.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Operação Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.listaProdutosServicosCorrente.Clear();
            ViewUtils.doTrocarViewdoPanelPrincipal(new UC_RegistroVenda());
        }

        private void gcServicos_Click(object sender, EventArgs e)
        {

        }

        private void riBtnAddServico_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var item = gvServicos.GetFocusedRow() as CE_Preco;
            VW_InserirItemVenda janela = new VW_InserirItemVenda(item);
            janela.ShowDialog();

            if (VariaveisGlobais.listaProdutosServicosCorrente != null)
            {
                bsVendaProduto.DataSource = VariaveisGlobais.listaProdutosServicosCorrente;
                gvItensVenda.RefreshData();
            }
        }

        private void riAçoesVendaProduto_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var item = gvItensVenda.GetFocusedRow() as CE_VendaProduto;

            if (e.Button.Tag.ToString() == "0")
            {
                if (item.qtdproduto == 1)
                    bsVendaProduto.Remove(item);
                else
                    (bsVendaProduto.Current as CE_VendaProduto).qtdproduto = item.qtdproduto - 1;
            }
            else if(e.Button.Tag.ToString() == "2")
            {
                bsVendaProduto.Remove(item);
            }

            gvItensVenda.RefreshData();

            VariaveisGlobais.listaProdutosServicosCorrente = bsVendaProduto.DataSource as List<CE_VendaProduto>;

            doAtualizarTxtValorTotal();
        }

        private bool isFormularioValido()
        {
            bool isFormularioValido = true;           


            if (clienteSelecionado == null)
            {
                isFormularioValido = false;
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciCliente, ViewUtils.getMeuTooltip("Campo obrigatório", "Informe um cliente!", DevExpress.Utils.ToolTipIconType.Exclamation), false);
            }
            else
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciCliente, ViewUtils.getMeuTooltip("Campo obrigatório", "Informe um cliente!", DevExpress.Utils.ToolTipIconType.Exclamation), true);

            if (cmbTipoServico.EditValue == null)
            {
                isFormularioValido = false;
                ViewUtils.doMudarAparenciaLayoutControlLookupEditComToolTipParaValidacoes(ref lciTipoServico, ViewUtils.getMeuTooltip("Campo obrigatório", "Informe o tipo de serviço!", DevExpress.Utils.ToolTipIconType.Exclamation), false);
            }
            else
                ViewUtils.doMudarAparenciaLayoutControlLookupEditComToolTipParaValidacoes(ref lciTipoServico, ViewUtils.getMeuTooltip("Campo obrigatório", "", DevExpress.Utils.ToolTipIconType.Exclamation), true);

            return isFormularioValido;
        }

        private void gvItensVenda_RowCountChanged(object sender, EventArgs e)
        {
            doAtualizarTxtValorTotal();
        }
    }
}
