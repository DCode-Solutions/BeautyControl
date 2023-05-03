using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using model_beautycontrol.Model.BO;
using model_beautycontrol.Model.CE;
using model_beautycontrol.Model.DOM;
using BeautyControl.View.UCViews;

namespace BeautyControl.View.PopUpViews
{
    public partial class VW_UsuarioForm01 : DevExpress.XtraEditors.XtraForm
    {
        private BO_PerfilDeUsuario boPerfil = new BO_PerfilDeUsuario();
        private string operacao;
        private CE_Usuario usu;

        public VW_UsuarioForm01()
        {
            InitializeComponent();
            operacao = "novo";
            bsPerfis.DataSource = boPerfil.getPerfis();
            groupCUsuario.Text = "Novo Usuário";
        }

        // **** Criar um enum futuramente para 'operação'
        public VW_UsuarioForm01(string _operacao, CE_Usuario _user)
        {
            InitializeComponent();
            operacao = _operacao.ToLower();
            groupCUsuario.Text = ViewUtils.getTituloOperacao(_operacao, "Usuário");

            switch (operacao)
            {
                case "novo":
                    bsPerfis.DataSource = boPerfil.getPerfis();
                    break;

                case "alterar":
                    usu = new BO_Usuario().getUsuario(_user.Login);
                    txtLogin.Text = usu.Login;
                    txtSenha2.Text = txtSenha.Text = usu.Senha;
                    bsPerfis.DataSource = boPerfil.getPerfisVerificados(usu);
                    break;
                case "associar":
                    break;
            }

        }

        // **** Criar um enum futuramente para 'operação'
        public VW_UsuarioForm01(string _operacao, CE_Funcionario _fun)
        {
            InitializeComponent();
            operacao = _operacao.ToLower();
            groupCUsuario.Text = ViewUtils.getTituloOperacao(_operacao, "Usuário");

            if (operacao == "associar")
            {
                usu = new CE_Usuario();
                usu.Funcionario = _fun;
                usu.id_funcionario = _fun.id;
                bsPerfis.DataSource = boPerfil.getPerfis();
                lciNomeFuncionario.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                txtFuncionario.Text = _fun.nome;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool isUsuarioAlterado = true;
            try
            {
                // Valida os campos do formulario
                doValidarFormulario();
                // Guarda em uma lista todos os perfis que foram selecionados
                List<CE_PerfilDeUsuario> listaPerfisMarcados = ((List<CE_PerfilDeUsuario>)bsPerfis.DataSource).Where(x => x.isSelecionado == true).ToList();

                // Instancia um usuario 

                CE_Usuario usuario = new CE_Usuario(txtLogin.Text, txtSenha.Text);

                switch (operacao)
                {
                    case "novo":
                        new DOM_Seguranca().doInserirNovoUsuario(usuario, listaPerfisMarcados);
                        MessageBox.Show("Operação Realizada com Sucesso!", operacao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                        break;
                    case "alterar":
                        if (usu.Login == usuario.Login && usu.Senha == usuario.Senha)
                            isUsuarioAlterado = false;

                        usuario.id = usu.id;

                        new DOM_Seguranca().doAlterarUsuario(usuario, listaPerfisMarcados, isUsuarioAlterado);
                        MessageBox.Show("Operação Realizada com Sucesso!", operacao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                        break;
                    case "associar":
                        usu.Login = txtLogin.Text;
                        usu.Senha = txtSenha.Text;
                        new DOM_Seguranca().doInserirNovoUsuario(usu, listaPerfisMarcados);
                        MessageBox.Show("Operação Realizada com Sucesso!", operacao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                        ViewUtils.doTrocarViewdoPanelPrincipal(new UC_Usuarios());
                        break;

                }

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(model_beautycontrol.Utils.Utilidades.GetMensagemExcecao(ex), operacao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void doValidarFormulario()
        {
            // Verifica se o txt estao preenchidos
            ViewUtils.doVerificarTxtEditIsEmptyDeUmLayoutControl(ref layoutControl1);

            if (txtSenha.Text != txtSenha2.Text)
                throw new Exception("Você errou ao repetir a senha! Tente novamente");

            // Pega a quantidade de itens marcados no grid control usuarios
            int count = ((List<CE_PerfilDeUsuario>)bsPerfis.DataSource).Count(x => x.isSelecionado);

            if (count == 0)
                throw new Exception("Selecione pele menos um perfil para o novo usuario!");



        }
    }
}