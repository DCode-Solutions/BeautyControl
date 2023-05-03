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
using BeautyControl.Utils;
using model_beautycontrol.Model.CE;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace BeautyControl.View.PopUpViews
{
    public partial class VW_Login : XtraForm
    {
        private bool v;

        //Método da API
        [DllImport("wininet.dll")]
        private extern static Boolean InternetGetConnectedState(out int Description, int ReservedValue);


        // Um método que verifica se esta conectado
        public static Boolean IsConnected()
        {
            int Description;
            return InternetGetConnectedState(out Description, 0);
        }

        public VW_Login()
        {
            InitializeComponent();
        }

        public VW_Login(bool v)
        {
            this.v = v;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            doLogar();
        }

        private void doLogar()
        {
            try
            {
                ViewUtils.doVerificarTxtEditIsEmptyDeUmLayoutControl(ref layoutControl1);

                doAutenticarUsuario();

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(model_beautycontrol.Utils.Utilidades.GetMensagemExcecao(ex), "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void doAutenticarUsuario()
        {
            VariaveisGlobais.usuarioLogado = new model_beautycontrol.Model.BO.BO_Usuario().getUsuario(txtEmail.Text, txtSenha.Text);
            if (VariaveisGlobais.usuarioLogado == null)
            {
                throw new Exception("Login inválido!");
            }
        }

        private void linklbEsqueceuSenha_Click(object sender, EventArgs e)
        {
            try
            {
                // Há conexão com  a internet?
                if (!IsConnected())
                    throw new Exception("Você deve ter conexão com a internet para utilizar esta operção!");

                // Confirmação da operação
                DialogResult result = MessageBox.Show("Será Gerada uma nova senha e enviada para seu email\nDeseja prosseguir com esta operação?", "Confirmação", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                    return;

                if (String.IsNullOrEmpty(txtEmail.Text))
                    throw new Exception("É necessario que você informe seu email para está operação!");

                // Gera uma nova senha, esta que será atualizada no lugar da antiga e sera enviada como informçao no corpo do email
                string novaSenha = model_beautycontrol.Utils.Utilidades.getGerarSenha01(model_beautycontrol.Utils.Utilidades.getUsuarioDoEmail(txtEmail.Text));
                
                // Retorna o usuario apos buscar o usuario que possui o email informado, atualiza a senha deste usuario e retorna o usuario com os dados atualizados
                var usuarioDestinatario = new model_beautycontrol.Model.BO.BO_Usuario().getUsuarioParaEnviarEmailComNovaSenha(txtEmail.Text, novaSenha) as CE_Usuario;

                if (usuarioDestinatario == null)
                    throw new Exception("Não existe usuário associado a este email no sistema!");

                // Prepara o Corpo da mensagem
                StringBuilder msgEmail = new StringBuilder();
                msgEmail.AppendLine("Olá " + model_beautycontrol.Utils.Utilidades.getUsuarioDoEmail(usuarioDestinatario.Login));
                msgEmail.AppendLine("Aqui está o seu login e senha de acesso do sistema Beauty Control que você esqueceu");
                msgEmail.AppendLine("Login: " + usuarioDestinatario.Login);
                msgEmail.AppendLine("Senha: " + novaSenha);

                EmailToSend mensagem = new EmailToSend(VariaveisGlobais.emailSoftware,VariaveisGlobais.senhaEmailSoftware,usuarioDestinatario.Login,"Senha de Acesso Beauty Control DeskTop",msgEmail.ToString());
                mensagem.EnviarEmail01();

                MessageBox.Show("Email enviado com sucesso com a nova senha para: " + usuarioDestinatario.Login);
            }
            catch (Exception ex)
            {
                MessageBox.Show(model_beautycontrol.Utils.Utilidades.GetMensagemExcecao(ex));
            }
        }

        private void EnterPressionado_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                doLogar();
        }
    }
}