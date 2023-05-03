using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using model_beautycontrol.Utils;
using model_beautycontrol.Model.CE;
using BeautyControl.View.PopUpViews;

namespace BeautyControl.View.UCViews
{
    public partial class UC_Funcionario_AssociarUsuario : UserControl
    {
        public UC_Funcionario_AssociarUsuario()
        {
            InitializeComponent();
            doConsultar();
        }

        private void doConsultar()
        {
            try
            {
                bsFuncionarios.DataSource = new model_beautycontrol.Model.BO.BO_Funcionario().getFuncionariosSemUsuarios();// getFuncionariosAtivos();
                if((bsFuncionarios.DataSource as List<CE_Funcionario>).Count == 0)
                {
                    MessageBox.Show("Não há funcionarios para adicionar usuário!", "Inserir usuárioo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Muda visibilidade do custom header btn associar para falso
                    lcgAssociarFuncionarios.CustomHeaderButtons["Associar"].Properties.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Utilidades.GetMensagemExcecao(ex), "Ocorreu uma exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lcgAssociarFuncionarios_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            // Get : O nome do botao do CustomHeaderButtons para verificar qual dos botoes foi acionado
            string caption = ((DevExpress.XtraEditors.ButtonPanel.BaseButton)e.Button).Caption.ToString().ToLower();
            switch (caption)
            {
                case "voltar":
                    ViewUtils.doTrocarViewdoPanelPrincipal(new UC_Usuarios());
                    break;
                case "associar":
                    var funcionarioFocado = gvFuncionarios.GetFocusedRow() as CE_Funcionario;
                    //.Opacity = 0.2;
                    VW_UsuarioForm01 janela = new VW_UsuarioForm01(caption,funcionarioFocado);
                    janela.ShowDialog();
                    break;

            }
        }
    }
}
