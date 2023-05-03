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
using model_beautycontrol.Model.CE;
using BeautyControl.Utils;
using BeautyControl.View.PopUpViews;

namespace BeautyControl.View.UCViews
{
    public partial class UC_Clientes : UserControl
    {
        private BO_Cliente bo = new BO_Cliente();
        public UC_Clientes()
        {
            InitializeComponent();
            doConsultar();
        }

        private void doConsultar()
        {
            try
            {
                var listaClientes = bo.getListaClientes().Where(o=> !o.nome.Contains("Avulso")).ToList();
                if (listaClientes == null || listaClientes.Count == 0)
                {
                    lciGridClientes.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    grcCliente.CustomHeaderButtons["Alterar"].Properties.Visible = false;
                    bsClientes.DataSource = null;
                }
                else
                    bsClientes.DataSource = listaClientes;
            }
            catch (Exception ex)
            {
                grcCliente.Enabled = false;
                MessageBox.Show(model_beautycontrol.Utils.Utilidades.GetMensagemExcecao(ex), "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void grcCliente_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            // Get : O nome do botao do CustomHeaderButtons para verificar qual dos botoes foi acionado
            string caption = ((DevExpress.XtraEditors.ButtonPanel.BaseButton)e.Button).Caption.ToString().ToLower();

            switch (caption)
            {
                case "novo":
                    doMostrarClienteForm("novo", null);
                    break;

                case "alterar":
                    var clienteSelecionado = gvClientes.GetFocusedRow() as CE_Cliente;
                    if (clienteSelecionado != null)
                        doMostrarClienteForm("alterar", clienteSelecionado);
                    break;             
            }

            doVerificaAlteracao();
        }

        private void doMostrarClienteForm(string operacao, CE_Cliente clienteSelecionado)
        {
            VariaveisGlobais.principal.Enabled = false;

            VW_ClienteForm janela = new VW_ClienteForm(operacao,clienteSelecionado);
            janela.ShowDialog();

            VariaveisGlobais.principal.Enabled = true;
        }

        private void doVerificaAlteracao()
        {
            if (VariaveisGlobais.houveAlteracaoNaBase)
            {
                doConsultar();
                VariaveisGlobais.houveAlteracaoNaBase = false;
            }
        }

        private void gvClientes_ColumnFilterChanged(object sender, EventArgs e)
        {

        }

        private void gvClientes_StartSorting(object sender, EventArgs e)
        {
         //   DataRow[] rows = new DataRow[gvClientes.DataRowCount];
          
        }
    }
}
