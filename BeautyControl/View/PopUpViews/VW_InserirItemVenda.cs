using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using model_beautycontrol.Model.BO;
using model_beautycontrol.Model.CE;
using model_beautycontrol.Model.DOM;
using BeautyControl.Utils;

namespace BeautyControl.View.PopUpViews
{
    public partial class VW_InserirItemVenda : DevExpress.XtraEditors.XtraForm
    {
        private CE_Preco itemCorrente;
        private CE_VendaProduto obj;        

        public VW_InserirItemVenda()
        {
            InitializeComponent();
            bsFuncionarios.DataSource = new BO_Funcionario().getFuncionariosProducao();// getFuncionariosAtivos();
        }

        public VW_InserirItemVenda(CE_Preco item)
        {
            InitializeComponent();
            this.itemCorrente = item;
            obj = new CE_VendaProduto();
            bsFuncionarios.DataSource = new BO_Funcionario().getFuncionariosProducao();
            txtServico.Text = item.Produto.nome;
            txtValor.Text = txtValorCobrado.Text = item.preco.ToString("N2");
        }

        private void grcInserirItem_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            // Get : O nome do botao do CustomHeaderButtons para verificar qual dos botoes foi acionado
            string caption = ((DevExpress.XtraEditors.ButtonPanel.BaseButton)e.Button).Caption.ToString().ToLower();

            switch (caption)
            {
                case "salvar":
                    doSalvar();
                    break;

                case "voltar":
                    Close();
                    break;
            }

            // doVerificarAlteracao();
        }

        private void doSalvar()
        {
            try
            {
                if (isFormularioValido())
                {
                    // #region preparar obj item

                    obj.qtdproduto = Convert.ToInt32(txtQuantidade.Text);
                    obj.precoproduto = Convert.ToDouble(txtValor.Text);
                    obj.precocobrado = Convert.ToDouble(txtValorCobrado.Text);
                    obj.id_produto = itemCorrente.idproduto;
                    obj.Produto = itemCorrente.Produto;

                    obj.id_funcionario = Convert.ToInt32(cmbFuncionario.EditValue);
                    obj.Funcionario = (from x in bsFuncionarios.DataSource as List<CE_Funcionario> where x.id == obj.id_funcionario select x).FirstOrDefault();
                    
                    //#endregion

                    VariaveisGlobais.listaProdutosServicosCorrente.Add(obj);

                    //dom = new DOM_Execucao();

                    //dom.boCliente.doInserirOuAlterar(cliente);

                    //if (!isVoltaParaTelaVenda)
                    //    VariaveisGlobais.houveAlteracaoNaBase = true;

                  //  MessageBox.Show("Operação realizada com sucesso!", "Inserir item", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();
                }
                else
                    MessageBox.Show("Não foi possível concluir esta operação\nVerifique o formulário.", "Inserir Item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro - Operação Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Xceed.Wpf.Toolkit.MessageBox.Show(ex.Message, "Ocorreu um erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private bool isFormularioValido()
        {

            bool isFormularioValido = true;

            if (cmbFuncionario.EditValue == null)
            {
                isFormularioValido = false;
                ViewUtils.doMudarAparenciaLayoutControlLookupEditComToolTipParaValidacoes(ref lciFuncionario, ViewUtils.getMeuTooltip("Campo obrigatório", "Selecione um funconário!", DevExpress.Utils.ToolTipIconType.Exclamation), false);
            }
            else
                ViewUtils.doMudarAparenciaLayoutControlLookupEditComToolTipParaValidacoes(ref lciFuncionario, ViewUtils.getMeuTooltip("Campo obrigatório", "Selecione um funconario!", DevExpress.Utils.ToolTipIconType.Exclamation), true);

            return isFormularioValido;

        }
    }
}