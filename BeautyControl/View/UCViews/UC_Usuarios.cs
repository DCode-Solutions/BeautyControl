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
using BeautyControl.View.PopUpViews;
using BeautyControl.Utils;
using model_beautycontrol.Model.CE;
using model_beautycontrol.Model.DOM;

namespace BeautyControl.View.UCViews
{
    /* Operaçoes 
     * 0 - Inserir
     * 1 - Editar
     * 2 - Visualizar
     */ 
    public partial class UC_Usuarios : UserControl
    {
        private Principal telaPrincipal = VariaveisGlobais.principal;
        private BO_Usuario boUsuario = new BO_Usuario();
        private BO_Auxiliar boAuxiliar = new BO_Auxiliar();
        private DOM_Seguranca dom = new DOM_Seguranca();

        public UC_Usuarios()
        {
            InitializeComponent();
            doCarregarDados();
        }

        private void doCarregarDados()
        {
            var listaUsuarios = boUsuario.getUsuarios();
            bsUsuarios.DataSource = listaUsuarios;

            rICmbStatus.Items.Clear();
            var listaStatus = boAuxiliar.getListaAuxiliar("status");

            foreach (var item in listaStatus)
                rICmbStatus.Items.Add(item.descricao);
        }

        private void lcUCUsuarios_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            // Get : O nome do botao do CustomHeaderButtons para verificar qual dos botoes foi acionado
            string caption = ((DevExpress.XtraEditors.ButtonPanel.BaseButton)e.Button).Caption.ToString().ToLower();
            switch (caption)
            {
                case "novo usuário":
                    doMostrarUsuarioForm("novo",null);
                    break;

                case "associar funcionário":
                    ViewUtils.doTrocarViewdoPanelPrincipal(new UC_Funcionario_AssociarUsuario());
                    break;

                case "alterar usuário":
                    rItemBtnAlterar_Click(null, null);
                    break;
            }
        }

        private void rItemBtnTrocarSenha_Click(object sender, EventArgs e)
        {
            var usuarioFocado = gvUsuarios.GetFocusedRow() as CE_Usuario;
            // Passa o usuario para alterar senha e o uc de retorno , apos realizar a operaçao na tela de trocar a senha ela retornara para esta tela this
            ViewUtils.doTrocarViewdoPanelPrincipal(new UC_TrocarSenha(usuarioFocado,this));            
        }

        private void doMostrarUsuarioForm(string operacao,CE_Usuario usuario)
        {
            telaPrincipal.Enabled = false;
            VW_UsuarioForm01 janela = new VW_UsuarioForm01(operacao,usuario);
            janela.ShowDialog();
            telaPrincipal.Enabled = true;

            doCarregarDados();
        }

        private void rItemBtnAlterar_Click(object sender, EventArgs e)
        {
            var usuarioFocado = gvUsuarios.GetFocusedRow() as CE_Usuario;
            doMostrarUsuarioForm("alterar",usuarioFocado);          
        }

        // Esta acao é acionado quando o usuario muda o item de um combo box de um usuario
        private void rICmbStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            // Pega o conteudo atual do combobox
            string statusSelecionado = ((DevExpress.XtraEditors.TextEdit)sender).Text;
            var usuario = gvUsuarios.GetFocusedRow() as CE_Usuario;
            // Salva as alteraçoes / muda o status do usuario focado
            dom.doMudarStatusUsuario(usuario,statusSelecionado);

            alertControlMudarStatus.Show(VariaveisGlobais.principal, "Alteração de status do usuário", "O usuário"+usuario.Login+" foi "+statusSelecionado+"!");
        }
        
        private void gvUsuarios_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var usuario = gvUsuarios.GetFocusedRow() as CE_Usuario;
            var listaPerfil = dom.getPerfisAssociadoAoUsuario(usuario);
            bsPerfis.DataSource = listaPerfil;
        }
        
    }
}
