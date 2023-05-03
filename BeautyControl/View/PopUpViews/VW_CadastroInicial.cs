using DevExpress.XtraEditors;
using model_beautycontrol.Model.CE;
using model_beautycontrol.Model.DOM;
using System;
using System.Windows.Forms;

namespace BeautyControl.View.PopUpViews
{
    public partial class VW_CadastroInicial : Form
    {

        public VW_CadastroInicial()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Sai do sistema 
            Application.Exit();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                doValidarCampos();
                doInserirEmpresaUsuario();
                MessageBox.Show("Operação Realizado com Sucesso!\nBem Vindo ao BeautyControl.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(model_beautycontrol.Utils.Utilidades.GetMensagemExcecao(ex),"Cadastro inicial",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        /// <doValidarCampos>
        /// 1. Valida os campos do formulário
        /// 2. Percorre a lista de controles que o layoutControl possui
        /// 3. Verica no Control do tipo TextEdit se o texto esta vazio ou nulo : Mostrando uma mensagem caso houver pelo menos um campo na tela
        ///    onde texto estiver vazio ou nulo com isso  o BackColor do texto sera trocado para mostrar ao usuario que aquele campo deve ser preenchido
        /// 4. Apos Verifica que os campos estao todos preechidos , entao verifica-se se a senha informada é a mesma que a senha repetida
        /// </doValidarCampos>
        private void doValidarCampos()
        {
            ViewUtils.doVerificarTxtEditIsEmptyDeUmLayoutControl(ref layoutControl1);
            
            if (txtSenha01.Text != txtSenha02.Text)
                throw new Exception("Você errou ao repetir a senha! Tente novamente");
        }

        /// <doInserirEmpresaUsuario>
        /// 1. Prepara os obj empresa e usuario 
        /// 2. Insere na base de dados a empresa e o usuario
        /// </doInserirEmpresaUsuario>
        private void doInserirEmpresaUsuario()
        {
            CE_Empresa empresa = new CE_Empresa(txtEmpresa.Text,txtRazaoSocial.Text,txtCNPJ.Text,txtCPF.Text);
            CE_Usuario usuario = new CE_Usuario(txtEmail.Text, txtSenha01.Text);
            new DOM_Seguranca().doInserirEmpresaComUsuarioMaster(empresa,ref usuario);
            Utils.VariaveisGlobais.usuarioLogado = usuario;    
        }

        private void txtCNPJ_EditValueChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Este metodo é acionado toda vez que um campo textEdit é atualizado
        /// BackColor muda cor de o campo textEdit estiver vazio ou nulo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAtualizado_EditValueChanged(object sender, EventArgs e)
        {
            TextEdit txt = sender as TextEdit;
            ViewUtils.doValidarTextEdit(ref txt);
        }

        private void txtSenha01_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
