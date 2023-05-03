using System;
using System.Collections.Generic;
using System.Windows.Forms;
using model_beautycontrol.Model.BO;
using model_beautycontrol.Model.CE;
using BeautyControl.Utils;
using model_beautycontrol.Utils;

namespace BeautyControl.View.PopUpViews
{
    public partial class VW_FornecedorForm01 : DevExpress.XtraEditors.XtraForm
    {
        private CE_Fornecedor fornecedor;

        public VW_FornecedorForm01()
        {
            InitializeComponent();

            try
            {
                gpcFornecedor.Text = ViewUtils.getTituloOperacao("Novo", "Fornecedor");

                fornecedor = new CE_Fornecedor();

                doPrepararCombos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao carregar formulário", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void doPrepararCombos()
        {
            var lista = new List<CE_Bairro>();
            lista.Add(new CE_Bairro(0, "Selecione um bairro", 0));
            lista.AddRange(new BO_Bairro().getListaBairro(239));
            bsBairro.DataSource = lista;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (isFormularioValido())
                {
                    #region preparar obj cliente

                    fornecedor.nome = txtNomeRazao.Text;
                    fornecedor.razaosocial = txtRazaoSocial.Text;
                    fornecedor.celular01 = Utilidades.getSomenteDigitosDePhone(txtCelular01.Text);
                    fornecedor.celular02 = Utilidades.getSomenteDigitosDePhone(txtCelular02.Text);
                    fornecedor.celular03 = Utilidades.getSomenteDigitosDePhone(txtCelular03.Text);
                    fornecedor.cep = txtCep.Text;
                    fornecedor.cnpj = txtCnpj.Text;
                    fornecedor.email = txtEmail.Text;
                    fornecedor.id_bairro = cmbBairro.EditValue == null ? 0 : Convert.ToInt32(cmbBairro.EditValue);
                    fornecedor.inscricaoestadual = txtInscricaoEstadual.Text;
                    fornecedor.inscricaomunicipal = txtinscricaoMunicipal.Text;
                    fornecedor.referencia = txtReferencia.Text;
                    fornecedor.rua = txtEndereco.Text;
                    fornecedor.site = txtSite.Text;
                    fornecedor.telefone = Utilidades.getSomenteDigitosDePhone(txtContato.Text);

                    #endregion

                    new BO_Fornecedor().doInserirOuAlterar(fornecedor);// .boCliente.doInserirOuAlterar(cliente);

                    VariaveisGlobais.houveAlteracaoNaBase = true;

                    MessageBox.Show("Operação realizada com sucesso!", gpcFornecedor.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();
                }
                else
                    MessageBox.Show("Não foi possível concluir esta operação\nVerifique o formulário.", gpcFornecedor.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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
            // mensagem = ViewUtils.getObterMensagem01(mensagem, "Vínculo");
            if (string.IsNullOrEmpty(txtNomeRazao.Text))
            {
                isFormularioValido = false;
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lcinomeRazao, ViewUtils.getMeuTooltip("Campo obrigatório", "Informe o nome do fornecedor para ser registrado na base!", DevExpress.Utils.ToolTipIconType.Exclamation), false);
            }
            else
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lcinomeRazao, ViewUtils.getMeuTooltip("Campo obrigatório", "Informe o nome do fornecedor para ser registrado na base!", DevExpress.Utils.ToolTipIconType.Exclamation), true);

           
            if (!string.IsNullOrEmpty(txtCnpj.Text) && Utilidades.isTamanhoStringEhMenorQueTamMax(txtCnpj.Text.Length, txtCnpj.Properties.MaxLength))
            {
                isFormularioValido = false;
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciCnpj, ViewUtils.getMeuTooltip("CNPJ inválido", "A quantidade de digitos para o cpf está incompleto!", DevExpress.Utils.ToolTipIconType.Exclamation), false);
            }
            else
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciCnpj, ViewUtils.getMeuTooltip("CNPJ inválido", "A quantidade de digitos para o cpf está incompleto!", DevExpress.Utils.ToolTipIconType.Exclamation), true);

            if (!string.IsNullOrEmpty(txtCep.Text) && Utilidades.isTamanhoStringEhMenorQueTamMax(txtCep.Text.Length, txtCep.Properties.MaxLength))
            {
                isFormularioValido = false;
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciCep, ViewUtils.getMeuTooltip("Cep inválido", "A quantidade de digitos para o cep está incompleto!", DevExpress.Utils.ToolTipIconType.Exclamation), false);
            }
            else
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciCep, ViewUtils.getMeuTooltip("Cep inválido", "A quantidade de digitos para o cep está incompleto!", DevExpress.Utils.ToolTipIconType.Exclamation), true);

            if (!string.IsNullOrEmpty(txtContato.Text) && Utilidades.isTamanhoStringEhDiferenteQueTamMax(Utilidades.getSomenteDigitosDePhone(txtContato.Text).Length, txtContato.Properties.MaxLength - 3))
            {
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciContato, ViewUtils.getMeuTooltip("Telefone inválido", "A quantidade de digitos para o telefone está incompleto!", DevExpress.Utils.ToolTipIconType.Exclamation), false);
                isFormularioValido = false;
            }
            else
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciContato, ViewUtils.getMeuTooltip("Telefone inválido", "A quantidade de digitos para o telefone está incompleto!", DevExpress.Utils.ToolTipIconType.Exclamation), true);

            if (!string.IsNullOrEmpty(txtCelular01.Text) && Utilidades.isTamanhoStringEhDiferenteQueTamMax(Utilidades.getSomenteDigitosDePhone(txtCelular01.Text).Length, txtCelular01.Properties.MaxLength - 3))
            {
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciCelular01, ViewUtils.getMeuTooltip("Celular inválido", "A quantidade de dígitos para o celular está incompleto!", DevExpress.Utils.ToolTipIconType.Exclamation), false);
                isFormularioValido = false;
            }
            else
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciCelular01, ViewUtils.getMeuTooltip("Celular inválido", "A quantidade de dígitos para o celular está incompleto!", DevExpress.Utils.ToolTipIconType.Exclamation), true);

            if (!string.IsNullOrEmpty(txtCelular02.Text) && Utilidades.isTamanhoStringEhDiferenteQueTamMax(Utilidades.getSomenteDigitosDePhone(txtCelular02.Text).Length, txtCelular02.Properties.MaxLength - 3))
            {
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciCelular02, ViewUtils.getMeuTooltip("Celular inválido", "A quantidade de dígitos para o celular está incompleto!", DevExpress.Utils.ToolTipIconType.Exclamation), false);
                isFormularioValido = false;
            }
            else
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciCelular02, ViewUtils.getMeuTooltip("Celular inválido", "A quantidade de dígitos para o celular está incompleto!", DevExpress.Utils.ToolTipIconType.Exclamation), true);


            if (!string.IsNullOrEmpty(txtCelular03.Text) && Utilidades.isTamanhoStringEhDiferenteQueTamMax(Utilidades.getSomenteDigitosDePhone(txtCelular03.Text).Length, txtCelular03.Properties.MaxLength - 3))
            {
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciCelular03, ViewUtils.getMeuTooltip("Celular inválido", "A quantidade de dígitos para o celular está incompleto!", DevExpress.Utils.ToolTipIconType.Exclamation), false);
                isFormularioValido = false;
            }
            else
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciCelular03, ViewUtils.getMeuTooltip("Celular inválido", "A quantidade de dígitos para o celular está incompleto!", DevExpress.Utils.ToolTipIconType.Exclamation), true);

            return isFormularioValido;
        }
    }
}
