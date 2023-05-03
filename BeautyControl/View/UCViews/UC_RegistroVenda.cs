using System;
using System.Linq;
using System.Windows.Forms;
using BeautyControl.Utils;
using model_beautycontrol.Model.CE;
using model_beautycontrol.Model.BO;
using model_beautycontrol.Model.CL;
using model_beautycontrol.Model.DOM;
using DevExpress.XtraEditors;

namespace BeautyControl.View.UCViews
{
    public partial class UC_RegistroVenda : UserControl
    {
        private BO_VendaRegistro bo = new BO_VendaRegistro();
        private BO_Venda boVenda = new BO_Venda();
        private Int32? prioridade_do_usuario = new BO_PerfilDeUsuario().getPerfisAssociadoAoUsuario(VariaveisGlobais.usuarioLogado).Max(o => o.prioridade);
        private DOM_Execucao dom;

        public UC_RegistroVenda()
        {
            InitializeComponent();
            dteData.DateTime = DateTime.Now;

            // disponibiliza o botao excluir venda caso a prioridade do usuario seja maior que 7
            riBtnRegistroAberto.Buttons[2].Visible = prioridade_do_usuario < 8 ? false : true;

            try
            {
                doConsultar(dteData);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar esta operação: " + ex.Message, "Registros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void doConsultar(DateEdit dteData)
        {
            var lista = bo.getVendaRegistro(dteData.DateTime);

            bsVendaRegistroLocal.DataSource = new BO_VendaRegistro().getVendaRegistroLocal(lista);
            bsVendaRegistroDomicilio.DataSource = bo.getVendaRegistroDomicilio(lista);
            bsServicosAbertos.DataSource = bo.getVendaRegistroAberto();
            bsVendaMes.DataSource = bo.getEntradaVendaLocalDomicilioMes(dteData.DateTime);
        }

        private void lcgServiços_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            ViewUtils.doTrocarViewdoPanelPrincipal(new UC_Venda(new CE_Venda()));
        }

        private void doMostrarClienteForm()
        {
            VariaveisGlobais.principal.Enabled = false;

            //VW_ClienteForm janela = new VW_ClienteForm(operacao, clienteSelecionado);
            //janela.ShowDialog();

            VariaveisGlobais.principal.Enabled = true;
        }

        private void doVerificaAlteracao()
        {
            if (VariaveisGlobais.houveAlteracaoNaBase)
            {
                //doConsultar();
                VariaveisGlobais.houveAlteracaoNaBase = false;
            }
        }

        private void dteData_EditValueChanged(object sender, EventArgs e)
        {
            var lista = bo.getVendaRegistro(dteData.DateTime);

            bsVendaRegistroLocal.DataSource = new BO_VendaRegistro().getVendaRegistroLocal(lista);
            bsVendaRegistroDomicilio.DataSource = bo.getVendaRegistroDomicilio(lista);
            bsServicosAbertos.DataSource = bo.getVendaRegistroAberto();
            bsVendaMes.DataSource = bo.getEntradaVendaLocalDomicilioMes(dteData.DateTime);

            lciGraficoMes.Text = "Gráfico Mês - " + dteData.DateTime.ToString("Y").ToUpper();
        }

        private void riBtnRegistroAberto_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                repositoryItensBtnAcao(gvServicosAbertos, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar esta operação: " + ex.Message, "Registro Aberto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void repositoryItensBtnAcao(DevExpress.XtraGrid.Views.Grid.GridView gv, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                // 0 : Editat 1: Detalhes
                if (e.Button.Tag.ToString() == "0")
                {
                    var item = gv.GetFocusedRow() as CL_VendaRegistro;
                    var venda = boVenda.getVenda(item.id);
                    ViewUtils.doTrocarViewdoPanelPrincipal(new UC_Venda(venda));
                }
                else if (e.Button.Tag.ToString() == "1")
                {
                    var item = gv.GetFocusedRow() as CL_VendaRegistro;

                    if (item == null)
                        MessageBox.Show("Não foi possível acionar a ação deste botão", "Detalhes da Venda!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        ViewUtils.doTrocarViewdoPanelPrincipal(new UC_DetalheVenda(item, this.Name));
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja excluir esta venda?", "Excluir Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //do something } else if (dialogResult == DialogResult.No) { //do something else }
                        dom = new DOM_Execucao();

                        var item = gv.GetFocusedRow() as CL_VendaRegistro;

                        dom.doDeletarVenda(item.id);

                        doConsultar(dteData);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar esta operação: " + ex.Message, "Registro Aberto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void riBtnRegistroDomicilio_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                repositoryItensBtnAcao(gvServicoDomicilio, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar esta operação: " + ex.Message, "Registro Domicílio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void riBtnAçoesRegistroLocal_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                repositoryItensBtnAcao(gvServicoLocal, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar esta operação: " + ex.Message, "Registro Locais", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gvServicoDomicilio_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            Custom_Visibilidade_BtnAcoes(sender, e, "actdom", riBtnRegistroDomicilio1, riBtnRegistroDomicilio2);
        }

        private void gvServicoLocal_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            Custom_Visibilidade_BtnAcoes(sender, e, "actloc", riBtnAçoesRegistroLocal1, riBtnAçoesRegistroLocal2);
        }

        private void Custom_Visibilidade_BtnAcoes(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e, string fieldname, DevExpress.XtraEditors.Repository.RepositoryItem repositorioBtn1, DevExpress.XtraEditors.Repository.RepositoryItem repositorioBtn2)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;// GridView view = sender as GridView;

            if (e.Column == view.Columns[fieldname])//Excluir
            {
                var row = (view.GetRow(e.RowHandle) as CL_VendaRegistro);
                if (row != null)
                {
                    if (row.ispago == false)
                        e.RepositoryItem = repositorioBtn2;
                    else
                        e.RepositoryItem = repositorioBtn1;
                }
            }
        }
    }
}

