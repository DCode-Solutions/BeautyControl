using System;
using System.Collections.Generic;
using System.Data;

using System.Windows.Forms;
using model_beautycontrol.Model.CE;
using model_beautycontrol.Model.DOM;
using BeautyControl.Utils;
using model_beautycontrol.Utils;
using System.Linq;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;

namespace BeautyControl.View.PopUpViews
{
    public partial class VW_ClienteForm : Form
    {
        private DOM_Execucao dom = new DOM_Execucao();
        public CE_Cliente cliente = new CE_Cliente();
        private string operacao;
        private bool isVoltaParaTelaVenda = false;

        public VW_ClienteForm()
        {
            InitializeComponent();
        }

        public VW_ClienteForm(string _operacao, CE_Cliente clienteSelecionado)
        {
            InitializeComponent();

            try
            {
                operacao = _operacao.ToLower();
                gpcClienteForm.Text = ViewUtils.getTituloOperacao(_operacao, "Cliente");

                if (operacao == "novo")
                {
                    doPrepararCombos(false);
                }
                else
                {
                    // Recupera profissional
                    this.cliente = dom.boCliente.getCliente(clienteSelecionado.id);

                    doPrepararCombos(true);

                    txtNome.Text = cliente.nome;
                    txtRg.Text = cliente.rg;
                    txtRua.Text = cliente.rua;
                    txtReferencia.Text = cliente.referencia;
                    txtCep.Text = cliente.cep;
                    txtTel01.Text = cliente.telefone;
                    txtCel01.Text = cliente.celular01;
                    txtCel02.Text = cliente.celular02;
                    txtCel03.Text = cliente.celular03;
                    txtCpf.Text = cliente.cpf;
                    txtEmail.Text = cliente.email;
                    txtDtNascimento.Text = cliente.datanascimento == 0 ? "" : Utilidades.getConverterDataTIPO_INTEIRO_ANO_MES_DIA_PARA_DIA_MES_ANO_PARA_STRING((int)cliente.datanascimento);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao carregar formulário", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public VW_ClienteForm(string _operacao, bool isVoltaParaTelaVenda)
        {
            InitializeComponent();

            this.isVoltaParaTelaVenda = isVoltaParaTelaVenda;

            try
            {
                operacao = _operacao.ToLower();
                gpcClienteForm.Text = ViewUtils.getTituloOperacao(_operacao, "Cliente");

                if (operacao == "novo")
                {
                    doPrepararCombos(false);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao carregar formulário", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void doPrepararCombos(bool isEditando)
        {
            bsSexo.DataSource = dom.boAuxiliar.getListaAuxiliar("sexo");
            bsBairro.DataSource = dom.boBairro.getListaBairro(239);


            #region Deixar combos selecionados
            if (isEditando)
            {

                var sexo = (from x in bsSexo.DataSource as List<CE_Auxiliar> where x.id == cliente.id_sexo select x).FirstOrDefault() as CE_Auxiliar;

                if (sexo != null)
                    cmbSexo.EditValue = sexo.id;

                var bairro = (from x in bsBairro.DataSource as List<CE_Bairro> where x.id == cliente.id_bairro select x).FirstOrDefault() as CE_Bairro;

                if (bairro != null)
                    gleBairro.EditValue = bairro.id;//cmbBairro.EditValue = bairro.id;
                #endregion
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            cliente = null;
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (isFormularioValido())
                {
                    #region preparar obj cliente

                    cliente.nome = txtNome.Text;
                    cliente.datanascimento = string.IsNullOrEmpty(txtDtNascimento.Text) ? 0 : Utilidades.getDataFormatoInt_yyyyMMdd(txtDtNascimento.DateTime);
                    cliente.id_sexo = Convert.ToInt32(cmbSexo.EditValue);
                    cliente.rg = txtRg.Text;
                    cliente.cpf = txtCpf.Text;
                    cliente.rua = txtRua.Text;
                    cliente.cep = txtCep.Text;
                    cliente.referencia = txtReferencia.Text;
                    cliente.telefone = Utilidades.getSomenteDigitosDePhone(txtTel01.Text);
                    cliente.celular01 = Utilidades.getSomenteDigitosDePhone(txtCel01.Text);
                    cliente.celular02 = Utilidades.getSomenteDigitosDePhone(txtCel02.Text);
                    cliente.celular03 = Utilidades.getSomenteDigitosDePhone(txtCel03.Text);
                    cliente.email = txtEmail.Text;
                    cliente.id_bairro = gleBairro.EditValue == null || gleBairro.EditValue == "" ? 0 :  Convert.ToInt32(gleBairro.EditValue);//cmbBairro.EditValue == null ? 0 : Convert.ToInt32(cmbBairro.EditValue);
                    // cliente.foto = imageEdit1.EditValue == null ? null : imageEdit1.EditValue as Byte[]; //Utilidades.getImageToBytearray((Image)imageEdit1.EditValue);
                    #endregion

                    dom.boCliente.doInserirOuAlterar(cliente);

                    cliente.id = dom.boCliente.getIdUltimoCliente();

                    if (!isVoltaParaTelaVenda)
                        VariaveisGlobais.houveAlteracaoNaBase = true;

                    MessageBox.Show("Operação realizada com sucesso!", gpcClienteForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();
                }
                else
                    MessageBox.Show("Não foi possível concluir esta operação\nVerifique o formulário.", gpcClienteForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                isFormularioValido = false;
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciNome, ViewUtils.getMeuTooltip("Campo obrigatório", "Informe o nome do cliente para ser registrado na base!", DevExpress.Utils.ToolTipIconType.Exclamation), false);
            }
            else
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciNome, ViewUtils.getMeuTooltip("Campo obrigatório", "Informe o nome do cliente para ser registrado na base!", DevExpress.Utils.ToolTipIconType.Exclamation), true);

            if (cmbSexo.EditValue == null)
            {
                isFormularioValido = false;
                ViewUtils.doMudarAparenciaLayoutControlLookupEditComToolTipParaValidacoes(ref lciSexo, ViewUtils.getMeuTooltip("Campo obrigatório", "Selecione um sexo!", DevExpress.Utils.ToolTipIconType.Exclamation), false);
            }
            else
                ViewUtils.doMudarAparenciaLayoutControlLookupEditComToolTipParaValidacoes(ref lciSexo, ViewUtils.getMeuTooltip("Campo obrigatório", "Selecione um sexo!", DevExpress.Utils.ToolTipIconType.Exclamation), true);

            if (!string.IsNullOrEmpty(txtCpf.Text) && Utilidades.isTamanhoStringEhMenorQueTamMax(txtCpf.Text.Length, txtCpf.Properties.MaxLength))
            {
                isFormularioValido = false;
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciCpf, ViewUtils.getMeuTooltip("Cpf inválido", "A quantidade de digitos para o cpf está incompleto!", DevExpress.Utils.ToolTipIconType.Exclamation), false);
            }
            else
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciCpf, ViewUtils.getMeuTooltip("Cpf inválido", "A quantidade de digitos para o cpf está incompleto!", DevExpress.Utils.ToolTipIconType.Exclamation), true);

            if (!string.IsNullOrEmpty(txtCep.Text) && Utilidades.isTamanhoStringEhMenorQueTamMax(txtCep.Text.Length, txtCep.Properties.MaxLength))
            {
                isFormularioValido = false;
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciCep, ViewUtils.getMeuTooltip("Cep inválido", "A quantidade de digitos para o cep está incompleto!", DevExpress.Utils.ToolTipIconType.Exclamation), false);
            }
            else
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciCep, ViewUtils.getMeuTooltip("Cep inválido", "A quantidade de digitos para o cep está incompleto!", DevExpress.Utils.ToolTipIconType.Exclamation), true);

            if (!string.IsNullOrEmpty(txtTel01.Text) && Utilidades.isTamanhoStringEhDiferenteQueTamMax(Utilidades.getSomenteDigitosDePhone(txtTel01.Text).Length, txtTel01.Properties.MaxLength - 3))
            {
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciTel01, ViewUtils.getMeuTooltip("Telefone inválido", "A quantidade de digitos para o telefone está incompleto!", DevExpress.Utils.ToolTipIconType.Exclamation), false);
                isFormularioValido = false;
            }
            else
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciTel01, ViewUtils.getMeuTooltip("Telefone inválido", "A quantidade de digitos para o telefone está incompleto!", DevExpress.Utils.ToolTipIconType.Exclamation), true);

            if (!string.IsNullOrEmpty(txtCel01.Text) && Utilidades.isTamanhoStringEhDiferenteQueTamMax(Utilidades.getSomenteDigitosDePhone(txtCel01.Text).Length, txtCel01.Properties.MaxLength - 3))
            {
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciCel01, ViewUtils.getMeuTooltip("Celular inválido", "A quantidade de dígitos para o celular está incompleto!", DevExpress.Utils.ToolTipIconType.Exclamation), false);
                isFormularioValido = false;
            }
            else
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciCel01, ViewUtils.getMeuTooltip("Celular inválido", "A quantidade de dígitos para o celular está incompleto!", DevExpress.Utils.ToolTipIconType.Exclamation), true);

            if (!string.IsNullOrEmpty(txtCel02.Text) && Utilidades.isTamanhoStringEhDiferenteQueTamMax(Utilidades.getSomenteDigitosDePhone(txtCel02.Text).Length, txtCel02.Properties.MaxLength - 3))
            {
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciCel02, ViewUtils.getMeuTooltip("Celular inválido", "A quantidade de dígitos para o celular está incompleto!", DevExpress.Utils.ToolTipIconType.Exclamation), false);
                isFormularioValido = false;
            }
            else
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciCel02, ViewUtils.getMeuTooltip("Celular inválido", "A quantidade de dígitos para o celular está incompleto!", DevExpress.Utils.ToolTipIconType.Exclamation), true);


            if (!string.IsNullOrEmpty(txtCel03.Text) && Utilidades.isTamanhoStringEhDiferenteQueTamMax(Utilidades.getSomenteDigitosDePhone(txtCel03.Text).Length, txtCel03.Properties.MaxLength - 3))
            {
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciCel03, ViewUtils.getMeuTooltip("Celular inválido", "A quantidade de dígitos para o celular está incompleto!", DevExpress.Utils.ToolTipIconType.Exclamation), false);
                isFormularioValido = false;
            }
            else
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciCel03, ViewUtils.getMeuTooltip("Celular inválido", "A quantidade de dígitos para o celular está incompleto!", DevExpress.Utils.ToolTipIconType.Exclamation), true);

            return isFormularioValido;
        }

        private void cmbSexo_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridLookUpEdit1_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridLookUpEdit editor = (GridLookUpEdit)sender;
            RepositoryItemGridLookUpEdit properties = editor.Properties;
            properties.PopupFormSize = new System.Drawing.Size(editor.Width - 4, properties.PopupFormSize.Height);
        }
    }
}
