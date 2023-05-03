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
    public partial class UC_Estoque : UserControl
    {
        private BO_Estoque boEstoque = new BO_Estoque();
        private BO_Movimentacao01 boMovimentacao = new BO_Movimentacao01();

        public UC_Estoque()
        {
            InitializeComponent();
            bsEstoque.DataSource = boEstoque.getEstoque();


        }

        private void gvEstoque_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                var produto = (gvEstoque.GetFocusedRow() as CE_Estoque);
                if (produto != null)
                {
                    bsMovimentacao.DataSource = boMovimentacao.getListaMovimentacaoProduto(produto.id_produto);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void gvMovimentacao_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView View = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            if (e.RowHandle >= 0)
            {
                string movimentacao = View.GetRowCellDisplayText(e.RowHandle, View.Columns["TipoMovimentacao.descricao"]);

                if (movimentacao.Contains("(-)"))
                {
                    e.Appearance.BackColor = Color.Crimson;
                    e.Appearance.BackColor2 = Color.SeaShell;
                }
                else if (movimentacao.Contains("(+)"))
                {
                    e.Appearance.BackColor = Color.LightBlue;
                    e.Appearance.BackColor2 = Color.SeaShell;
                }
            }
        }

        private void gvMovimentacao_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
          

            DevExpress.XtraGrid.Views.Grid.GridView View = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            if (e.RowHandle == View.FocusedRowHandle)
            {
                string movimentacao = View.GetRowCellDisplayText(e.RowHandle, View.Columns["TipoMovimentacao.descricao"]);

                if (movimentacao.Contains("(-)"))
                {
                    e.Appearance.BackColor = Color.Crimson;
                    //  e.Appearance.BackColor2 = Color.SeaShell;
                    //   e.Appearance.ForeColor = Color.White;
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                    e.Appearance.ForeColor = Color.White;

                }
                else if (movimentacao.Contains("(+)"))
                {
                    e.Appearance.BackColor = Color.LightBlue;
                    // e.Appearance.BackColor2 = Color.SeaShell;
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                    e.Appearance.ForeColor = Color.White;
                }
            }
        }

        private void lcgEstoque_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            // Get : O nome do botao do CustomHeaderButtons para verificar qual dos botoes foi acionado
            string acao = ((DevExpress.XtraEditors.ButtonPanel.BaseButton)e.Button).Tag.ToString().ToLower();

            switch (acao)
            {
                case "entrada":
                    doMostrarMovimentacaoForm("(+)");
                    break;

                case "saida":
                    doMostrarMovimentacaoForm("(-)");
                    break;
            }

            doVerificaAlteracao();
        }

        private void doMostrarMovimentacaoForm(string tipoMovimentacao)
        {
            VariaveisGlobais.principal.Enabled = false;

            VW_EstoqueLancamentoCompra janela = new VW_EstoqueLancamentoCompra(tipoMovimentacao, true);
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

        private void doConsultar()
        {
            bsEstoque.DataSource = boEstoque.getEstoque();
        }
    }
}
