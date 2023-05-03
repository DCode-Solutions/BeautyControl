using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using model_beautycontrol.Model.CE;
using model_beautycontrol.Model.DOM;
using System.Windows.Media.Imaging;
using BeautyControl.Utils;
using model_beautycontrol.Utils;

namespace BeautyControl.View.PopUpViews
{
    public partial class VW_FuncionarioForm : DevExpress.XtraEditors.XtraForm
    {
        private string operacao;
        private CE_Funcionario profissional = new CE_Funcionario();
        DOM_Funcionario dom = new DOM_Funcionario();

        public VW_FuncionarioForm()
        {
            InitializeComponent();
        }

        public VW_FuncionarioForm(string _operacao, CE_Funcionario _profissional)
        {
            InitializeComponent();
            try
            {
                operacao = _operacao.ToLower();
                gpcProfissionalForm.Text = ViewUtils.getTituloOperacao(_operacao, "Profissional");

                if (operacao == "novo")
                {
                    doPrepararCombos(false);
                    //  bsPerfis.DataSource = boPerfil.getPerfis();
                }
                else
                {
                    // Recupera profissional
                    this.profissional = dom.boFuncionario.getFuncionario(_profissional.id);
                    // Imagem 
                    if (profissional.foto != null && profissional.foto.ToArray().Count() > 0)
                    {
                        imageEdit1.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
                        imageEdit1.EditValue = profissional.foto;
                        imageEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
                    }

                    doPrepararCombos(true);

                    txtNome.Text = profissional.nome;
                    txtRg.Text = profissional.rg;
                    txtRua.Text = profissional.rua;
                    txtReferencia.Text = profissional.referencia;
                    txtCep.Text = profissional.cep;
                    txtTelefone.Text = profissional.telefone01;
                    txtCel01.Text = profissional.celular01;
                    txtCel02.Text = profissional.celular02;
                    txtCel03.Text = profissional.celular03;
                    txtCpf.Text = profissional.cpf;
                    txtEmail.Text = profissional.email;
                    dtNascimento.Text = profissional.datanascimento == null || profissional.datanascimento == 0 ? "" : Utilidades.getConverterDataTIPO_INTEIRO_ANO_MES_DIA_PARA_DIA_MES_ANO_PARA_STRING((int)profissional.datanascimento);

                    // nao permite alteração do vinculo
                    cmbVinculo.ReadOnly = true;

                    if (dom.boAuxiliar.getAuxiliar(profissional.idvinculoatual).descricao.ToLower() != "freelancer")
                    {
                        lciDataInicioVinculo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                        dtInicioVinculo.Text = Utilidades.getConverterDataTIPO_INTEIRO_ANO_MES_DIA_PARA_DIA_MES_ANO_PARA_STRING(dom.boPeriodoAssociado.getDataInicioVinculo(profissional.id, profissional.idvinculoatual));
                        dtInicioVinculo.ReadOnly = true;
                    }
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
            bsVinculo.DataSource = dom.boAuxiliar.getListaAuxiliar("vinculo");
            bsBairro.DataSource = dom.boBairro.getListaBairro(239); // refatorar depois aqui
            bsFuncao.DataSource = dom.boFuncao.getListaFuncao();

            #region Deixar combos selecionados
            if (isEditando)
            {
                var sexo = (from x in bsSexo.DataSource as List<CE_Auxiliar> where x.id == profissional.idsexo select x).FirstOrDefault() as CE_Auxiliar;

                if (sexo != null)
                    cmbSexo.EditValue = sexo.id;

                var vinculo = (from x in bsVinculo.DataSource as List<CE_Auxiliar> where x.id == profissional.idvinculoatual select x).FirstOrDefault() as CE_Auxiliar;

                if (vinculo != null)
                    cmbVinculo.EditValue = vinculo.id;//.descricao;

                var bairro = (from x in bsBairro.DataSource as List<CE_Bairro> where x.id == profissional.idbairro select x).FirstOrDefault() as CE_Bairro;

                if (bairro != null)
                    cmbBairro.EditValue = bairro.id;

                var funcao = (from x in bsFuncao.DataSource as List<CE_Funcao> where x.id == profissional.idfuncao select x).FirstOrDefault() as CE_Funcao;

                if (funcao != null)
                    cmbFuncao.EditValue = funcao.id;
                #endregion
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (isFormularioValido())
                {
                    #region preparar obj funcionario

                    profissional.nome = txtNome.Text;
                    profissional.datanascimento = string.IsNullOrEmpty(dtNascimento.Text) ? 0 : Utilidades.getDataFormatoInt_yyyyMMdd(dtNascimento.DateTime);
                    profissional.idsexo = gvSexo.GetFocusedRow() == null ? 0 : (cmbSexo.GetSelectedDataRow() as CE_Auxiliar).id;
                    profissional.rg = txtRg.Text;
                    profissional.cpf = txtCpf.Text;
                    profissional.rua = txtRua.Text;
                    profissional.cep = txtCep.Text;
                    profissional.referencia = txtReferencia.Text;
                    profissional.telefone01 = Utilidades.getSomenteDigitosDePhone(txtTelefone.Text);
                    profissional.celular01 = Utilidades.getSomenteDigitosDePhone(txtCel01.Text);
                    profissional.celular02 = Utilidades.getSomenteDigitosDePhone(txtCel02.Text);
                    profissional.celular03 = Utilidades.getSomenteDigitosDePhone(txtCel03.Text);
                    profissional.email = txtEmail.Text;
                    profissional.idbairro = gvBairro.GetFocusedRow() == null ? 0 : (gvBairro.GetFocusedRow() as CE_Bairro).id;
                    profissional.idvinculoatual = gvVinculo.GetFocusedRow() == null ? 0 : (cmbVinculo.GetSelectedDataRow() as CE_Auxiliar).id;
                    profissional.idfuncao = gvFuncao.GetFocusedRow() == null ? 0 : (cmbFuncao.GetSelectedDataRow() as CE_Funcao).id;
                    profissional.idempresa = VariaveisGlobais.empresalogada.id;
                    profissional.foto = imageEdit1.EditValue == null ? null : imageEdit1.EditValue as Byte[]; //Utilidades.getImageToBytearray((Image)imageEdit1.EditValue);
                    #endregion

                    dom.InserirOuAlterar(profissional, dtInicioVinculo.DateTime);

                    VariaveisGlobais.houveAlteracaoNaBase = true;

                    MessageBox.Show("Operação realizada com sucesso!", gpcProfissionalForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();
                }
                else
                    MessageBox.Show("Não foi possível concluir esta operação\nVerifique o formulário.", gpcProfissionalForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro - Operação Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Xceed.Wpf.Toolkit.MessageBox.Show(ex.Message, "Ocorreu um erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
               // mensagem = "";
            }
        }

        // Desabilita a validação do componente ao acusar que o valor inserido no textedit com Mask setada é invalido
        private void txtEdit_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = false;
        }

        private void cmbVinculo_Properties_EditValueChanged(object sender, EventArgs e)
        {
            if (gvVinculo.GetFocusedRow() != null)
            {
                if ((gvVinculo.GetFocusedRow() as CE_Auxiliar).descricao.ToLower() == "freelancer")
                    lciDataInicioVinculo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                else
                    lciDataInicioVinculo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
        }

        private bool isFormularioValido()
        {
            bool isFormularioValido = true;
            // mensagem = ViewUtils.getObterMensagem01(mensagem, "Vínculo");
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                isFormularioValido = false;
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciNome, ViewUtils.getMeuTooltip("Campo obrigatório", "Informe o nome do profissional para ser registrado na base!", DevExpress.Utils.ToolTipIconType.Exclamation), false);
            }
            else
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciNome, ViewUtils.getMeuTooltip("Campo obrigatório", "Informe o nome do profissional para ser registrado na base!", DevExpress.Utils.ToolTipIconType.Exclamation), true);

            if (cmbVinculo.GetSelectedDataRow() == null)
            {
                isFormularioValido = false;
                ViewUtils.doMudarAparenciaLayoutControlGridLookupEditComToolTipParaValidacoes(ref lciVinculo, ViewUtils.getMeuTooltip("Campo obrigatório", "Selecione um vínculo!", DevExpress.Utils.ToolTipIconType.Exclamation), false);
            }
            else
            {
                ViewUtils.doMudarAparenciaLayoutControlGridLookupEditComToolTipParaValidacoes(ref lciVinculo, ViewUtils.getMeuTooltip("Campo obrigatório", "Selecione um vínculo!", DevExpress.Utils.ToolTipIconType.Exclamation), true);
                if ((cmbVinculo.GetSelectedDataRow() as CE_Auxiliar).descricao.ToLower() != "freelancer" && string.IsNullOrEmpty(dtInicioVinculo.Text))
                {
                    isFormularioValido = false;
                    ViewUtils.doMudarAparenciaLayoutControlGDateEditComToolTipParaValidacoes(ref lciDataInicioVinculo, ViewUtils.getMeuTooltip("Campo obrigatório", "Informe a data de início do vinculo!", DevExpress.Utils.ToolTipIconType.Exclamation), false);
                }else
                {
                    ViewUtils.doMudarAparenciaLayoutControlGDateEditComToolTipParaValidacoes(ref lciDataInicioVinculo, ViewUtils.getMeuTooltip("Campo obrigatório", "Informe a data de início do vinculo!", DevExpress.Utils.ToolTipIconType.Exclamation), true);
                }
            }

            if (cmbFuncao.GetSelectedDataRow() == null)
            {
                isFormularioValido = false;
                ViewUtils.doMudarAparenciaLayoutControlGridLookupEditComToolTipParaValidacoes(ref lciFuncaoPrincipal, ViewUtils.getMeuTooltip("Campo obrigatório", "Selecione uma função!", DevExpress.Utils.ToolTipIconType.Exclamation), false);
            }
            else
                ViewUtils.doMudarAparenciaLayoutControlGridLookupEditComToolTipParaValidacoes(ref lciFuncaoPrincipal, ViewUtils.getMeuTooltip("Campo obrigatório", "Selecione uma função!", DevExpress.Utils.ToolTipIconType.Exclamation), true);

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

            if (!string.IsNullOrEmpty(txtTelefone.Text) && Utilidades.isTamanhoStringEhDiferenteQueTamMax(Utilidades.getSomenteDigitosDePhone(txtTelefone.Text).Length, txtTelefone.Properties.MaxLength - 3))
            {
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciTelefone, ViewUtils.getMeuTooltip("Telefone inválido", "A quantidade de digitos para o telefone está incompleto!", DevExpress.Utils.ToolTipIconType.Exclamation), false);
                isFormularioValido = false;
            }
            else
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciTelefone, ViewUtils.getMeuTooltip("Telefone inválido", "A quantidade de digitos para o telefone está incompleto!", DevExpress.Utils.ToolTipIconType.Exclamation), true);

            if (!string.IsNullOrEmpty(txtCel01.Text) && Utilidades.isTamanhoStringEhDiferenteQueTamMax(Utilidades.getSomenteDigitosDePhone(txtCel01.Text).Length, txtCel01.Properties.MaxLength - 3))
            {
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciCelular01, ViewUtils.getMeuTooltip("Celular inválido", "A quantidade de dígitos para o celular está incompleto!", DevExpress.Utils.ToolTipIconType.Exclamation), false);
                isFormularioValido = false;
            }
            else
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciCelular01, ViewUtils.getMeuTooltip("Celular inválido", "A quantidade de dígitos para o celular está incompleto!", DevExpress.Utils.ToolTipIconType.Exclamation), true);

            if (!string.IsNullOrEmpty(txtCel02.Text) && Utilidades.isTamanhoStringEhDiferenteQueTamMax(Utilidades.getSomenteDigitosDePhone(txtCel02.Text).Length, txtCel02.Properties.MaxLength - 3))
            {
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciCelular02, ViewUtils.getMeuTooltip("Celular inválido", "A quantidade de dígitos para o celular está incompleto!", DevExpress.Utils.ToolTipIconType.Exclamation), false);
                isFormularioValido = false;
            }
            else
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciCelular02, ViewUtils.getMeuTooltip("Celular inválido", "A quantidade de dígitos para o celular está incompleto!", DevExpress.Utils.ToolTipIconType.Exclamation), true);


            if (!string.IsNullOrEmpty(txtCel03.Text) && Utilidades.isTamanhoStringEhDiferenteQueTamMax(Utilidades.getSomenteDigitosDePhone(txtCel03.Text).Length, txtCel03.Properties.MaxLength - 3))
            {
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciCelular03, ViewUtils.getMeuTooltip("Celular inválido", "A quantidade de dígitos para o celular está incompleto!", DevExpress.Utils.ToolTipIconType.Exclamation), false);
                isFormularioValido = false;
            }
            else
                ViewUtils.doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref lciCelular03, ViewUtils.getMeuTooltip("Celular inválido", "A quantidade de dígitos para o celular está incompleto!", DevExpress.Utils.ToolTipIconType.Exclamation), true);

            return isFormularioValido;
        }

        private void imageEdit1_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.InitialDirectory = "c:\\";
            dlg.Filter = "Image files (*.jpg)|*.jpg";
            dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string arquivoSelecionado = dlg.FileName;

                // Redimensionar a imagem escolhida
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(arquivoSelecionado);
                bitmap.DecodePixelHeight = 100;
                bitmap.DecodePixelWidth = 100;
                bitmap.EndInit();

                // Dizer para o componente que ele vai receber uma imagem por bytearray
                imageEdit1.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
                // Converter a imagem selecionada que foi redimensionada em um array de byte
                imageEdit1.EditValue = Utilidades.ObterArrayByteFromImageControl(bitmap);

                imageEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            }
        }
    }
}
