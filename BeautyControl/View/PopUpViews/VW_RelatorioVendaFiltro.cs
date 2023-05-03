using model_beautycontrol.Model.CL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BeautyControl.View.PopUpViews
{
    public partial class VW_RelatorioVendaFiltro : DevExpress.XtraEditors.XtraForm
    {
        public List<CL_VendaRegistro> lista;
        public VW_RelatorioVendaFiltro(List<CL_VendaRegistro> lista, string tabSelecionada)
        {
            InitializeComponent();
            this.lista = lista.OrderByDescending(o=> o.dataservico).ToList();

            switch (tabSelecionada.ToUpper())
            {
                case "LOCAL":
                    ckcListTipo.Items[1].CheckState = CheckState.Unchecked;
                    lcgTipoServico.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    
                    break;
                case "DOMICILIO":
                    ckcListTipo.Items[0].CheckState = CheckState.Unchecked;
                    lcgTipoServico.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    break;

                case "ABERTO":
                    ckcListSituacao.Items[0].Enabled = false;
                    ckcListSituacao.Items[0].CheckState = CheckState.Unchecked;
                    break;
                    
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lista = null;
            Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string msg = "";

            List<string> listaTipo = (from x in ckcListTipo.Items.ToList() where x.CheckState == CheckState.Checked select x.Description).ToList();

            if (listaTipo.Count() == 0)
                msg += "Selecione pelo menos um tipo de Serviço\n";
            else if (lista.Count() == 1)
                lista = (from x in lista where x.servico == listaTipo.FirstOrDefault() select x).ToList();

            List<string> listaServico = (from x in ckcListSituacao.Items.ToList() where x.CheckState == CheckState.Checked select x.Description).ToList();

            if (listaServico.Count() == 0)
                msg += "Selecione pelo menos uma Situação de venda\n";
            else if (listaServico.Count() < 3)
            {
                lista = (from x in lista
                         where (x.status.Contains(ckcListSituacao.Items[0].Description) && ckcListSituacao.Items[0].CheckState == CheckState.Checked)
                           || (x.status.Contains(ckcListSituacao.Items[1].Description) && ckcListSituacao.Items[1].CheckState == CheckState.Checked)
                           || (x.status.Contains(ckcListSituacao.Items[2].Description) && ckcListSituacao.Items[2].CheckState == CheckState.Checked)
                         select x).ToList();
            }

            if (string.IsNullOrEmpty(msg))
                Close();
            else
                MessageBox.Show(msg, "Relatório", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
