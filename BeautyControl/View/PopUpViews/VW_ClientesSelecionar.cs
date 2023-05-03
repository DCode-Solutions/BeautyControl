using System;
using model_beautycontrol.Model.BO;
using model_beautycontrol.Model.CE;
using System.Linq;
using System.Collections.Generic;

namespace BeautyControl.View.PopUpViews
{
    
    public partial class VW_ClientesSelecionar : DevExpress.XtraEditors.XtraForm
    {
        private List<CE_Cliente> listaClientes = new List<CE_Cliente>();
        public CE_Cliente clienteSelecionado;
        public VW_ClientesSelecionar()
        {
            InitializeComponent();

            var lista = new BO_Cliente().getListaClientes().OrderBy(o=> o.nome).ToList();
            listaClientes.AddRange((from x in lista where x.nome.Contains("Avulso") select x).ToList());
            listaClientes.AddRange((from x in lista where !x.nome.Contains("Avulso") select x).ToList());
            bsCliente.DataSource = listaClientes;
        }

        private void grcClientes_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            // Get : O nome do botao do CustomHeaderButtons para verificar qual dos botoes foi acionado
            string caption = ((DevExpress.XtraEditors.ButtonPanel.BaseButton)e.Button).Caption.ToString().ToLower();

            switch (caption)
            {
                case "adicionar":
                    clienteSelecionado = gvClientes.GetFocusedRow() as CE_Cliente;
                    break;

                case "novo":
                    VW_ClienteForm janela = new VW_ClienteForm("Novo", true);
                    janela.ShowDialog();

                    if (janela.cliente != null)
                        clienteSelecionado = janela.cliente;
                    
                    break;

                case "voltar":
                    clienteSelecionado = null;
                    break;
            }

            Close();

            //doVerificaAlteracao();
        }

        private void gvClientes_DoubleClick(object sender, EventArgs e)
        {
            clienteSelecionado = gvClientes.GetFocusedRow() as CE_Cliente;
            Close();
        }
    }
}