using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BeautyControl.Utils;
using DevExpress.XtraLayout;
using model_beautycontrol.Model.BO;
using model_beautycontrol.Model.CE;

namespace BeautyControl.View.UCViews
{
    public partial class UC_TrocarSenha : UserControl
    {
        private BO_Usuario bo;
        private bool isMudarSenhaUsuarioLogado = true;
        private CE_Usuario usuarioToTrocarSenha;
        private UserControl telaDeRetorno;

        public UC_TrocarSenha()
        {
            InitializeComponent();
            // PEga o usuario logado
            usuarioToTrocarSenha = VariaveisGlobais.usuarioLogado;
            // insere o login do usuario logado no txtUsuario
            txtUsuario.Text = usuarioToTrocarSenha.Login;
        }

        // Chamado apos uma acao que nao tenha vindo do menu principal Nav Pane
        public UC_TrocarSenha(CE_Usuario usuarioParaTrocarSenha, UserControl userControlRetorno)
        {
            InitializeComponent();
            //  Usuario que tera sua senha alterado vindo de uma outra view
            usuarioToTrocarSenha = usuarioParaTrocarSenha;
            // insere o login do usuario no txtUsuario
            txtUsuario.Text = usuarioToTrocarSenha.Login;

            // 
            isMudarSenhaUsuarioLogado = false;
            telaDeRetorno = userControlRetorno;
            lcBtnVoltar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // V&V : Todos os campos devem ser informados
                ViewUtils.doVerificarTxtEditIsEmptyDeUmLayoutControl(ref layoutControlMeio);

                // Verificar se senha e senhar sao iguais
                if (txtNovaSenha.Text != txtNovaSenhaR.Text)
                {
                    var tooltip = new MeuToolTip("Este campo deve ser informado!", "", DevExpress.Utils.ToolTipIconType.Error);
                    ViewUtils.doMudarAparenciaLayoutControlTextEditAfterValidar(ref lcNovaSenha, false, tooltip);
                    ViewUtils.doMudarAparenciaLayoutControlTextEditAfterValidar(ref lcNovaSenhaR, false, tooltip);
                    txtNovaSenha.Text = txtNovaSenhaR.Text = "";
                    throw new Exception("Senha nova e senha repetida não são iguais! Informe novamente.");
                }

                bo = new BO_Usuario();

                // Autenticar Senha principal
                if (bo.getUsuario(usuarioToTrocarSenha.Login, txtSenhaAtual.Text) == null)
                {
                    var tooltip = new MeuToolTip("A senha atual informada não pertence ao seu usuário, tente novamente!", "", DevExpress.Utils.ToolTipIconType.Error);
                    ViewUtils.doMudarAparenciaLayoutControlTextEditAfterValidar(ref lcSenhaAtual, false, tooltip);
                    throw new Exception("A senha atual informada não pertence ao seu usuário, tente novamente");
                }

                // Salvar e atualiza o usuario logado 
                usuarioToTrocarSenha.Senha = txtNovaSenha.Text;
                bo.doAlterar(usuarioToTrocarSenha);

                txtSenhaAtual.Text = txtNovaSenha.Text = txtNovaSenhaR.Text = "";

                XtraMessageBox.Show("Senha Atualizada Com Sucesso!", "Trocar Senha", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Se o usuario que esta trocando a senha é o msm que o usuario que esta logado entao a variavel global do usuario logado atualiza
                VariaveisGlobais.usuarioLogado = VariaveisGlobais.usuarioLogado.Login == usuarioToTrocarSenha.Login ? usuarioToTrocarSenha : VariaveisGlobais.usuarioLogado;

                // Se esta tela veio foi chamada de uma outra tela que nao tenha sido do menu principal entao ela retorna para tela de origem da acao
                if (!isMudarSenhaUsuarioLogado)
                    ViewUtils.doTrocarViewdoPanelPrincipal(telaDeRetorno);
                
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(model_beautycontrol.Utils.Utilidades.GetMensagemExcecao(ex), "Trocar Senha", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void doValidarCampos()
        {
            // Todos os campos devem ser informados
            ViewUtils.doVerificarTxtEditIsEmptyDeUmLayoutControl(ref layoutControl1);
        }
        
        private void txtMudado_EditValueChanged(object sender, EventArgs e)
        {
            // Verifica e valida o TextEdit que foi alterado 
            switch (((TextEdit)sender).Name)
            {
                case "txtSenhaAtual":                    
                    doValidarTexto(lcSenhaAtual, ((TextEdit)sender).Text);
                    break;
                case "txtNovaSenha":
                    doValidarTexto(lcNovaSenha, ((TextEdit)sender).Text);
                    break;
                case "txtNovaSenhaR":
                    doValidarTexto(lcNovaSenhaR, ((TextEdit)sender).Text);
                    break;
            }
        }

        private void doValidarTexto(LayoutControlItem layoutControlTextEdit, string text)
        {
            if (!String.IsNullOrEmpty(text))
                ViewUtils.doMudarAparenciaLayoutControlTextEditAfterValidar(ref layoutControlTextEdit, true, null);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            ViewUtils.doTrocarViewdoPanelPrincipal(telaDeRetorno);
        }
    }
}
