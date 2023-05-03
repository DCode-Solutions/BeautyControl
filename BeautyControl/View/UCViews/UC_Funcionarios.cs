using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeautyControl.Utils;
using model_beautycontrol.Model.BO;
using model_beautycontrol.Model.CE;
using BeautyControl.View.PopUpViews;

namespace BeautyControl.View.UCViews
{
    public partial class UC_Funcionarios : UserControl
    {
        private Principal telaPrincipal = VariaveisGlobais.principal;
        private BO_Funcionario boProfissional = new BO_Funcionario();
        private BO_Auxiliar boAuxiliar = new BO_Auxiliar();

        public UC_Funcionarios()
        {
            InitializeComponent();
        }

        private void UC_Funcionarios_Load(object sender, EventArgs e)
        {
            try
            {
                doConsultar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(model_beautycontrol.Utils.Utilidades.GetMensagemExcecao(ex), "Profissioanis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            // var listaStatus = boAuxiliar.getListaAuxiliar("status");

            //foreach (var item in listaStatus)
            //{
            //    rICmbStatus.Items.Add(item.descricao);
            //}
        }

        private void lcgProfissionais_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            // Get : O nome do botao do CustomHeaderButtons para verificar qual dos botoes foi acionado
            string caption = ((DevExpress.XtraEditors.ButtonPanel.BaseButton)e.Button).Caption.ToString().ToLower();

            switch (caption)
            {
                case "novo":
                    doMostrarProfissionalForm("novo", null);
                    break;

                case "alterar":
                    var funcionarioSelecionado = gvProfissionais.GetFocusedRow() as CE_Funcionario;
                    if (funcionarioSelecionado != null)
                        doMostrarProfissionalForm("alterar", funcionarioSelecionado);
                    break;

                case "função":
                    var funcionarioSelecionadofun = gvProfissionais.GetFocusedRow() as CE_Funcionario;
                    if (funcionarioSelecionadofun != null)
                        doMostrarFuncionarioFuncaoView(funcionarioSelecionadofun);
                    break;
            }

            doVerificaAlteracao();

        }

        private void doMostrarFuncionarioFuncaoView(CE_Funcionario funcionarioSelecionadofun)
        {
            telaPrincipal.Enabled = false;
            VW_FuncionarioFuncao janela = new VW_FuncionarioFuncao(funcionarioSelecionadofun);
            janela.ShowDialog();
            telaPrincipal.Enabled = true;
        }

        private void doVerificaAlteracao()
        {
            if (VariaveisGlobais.houveAlteracaoNaBase)
            {
                doConsultar();
                VariaveisGlobais.houveAlteracaoNaBase = false;
            }
        }

        private void doConsultar()
        {
            var listaProfissionais = boProfissional.getProfissionais();
            if (listaProfissionais == null || listaProfissionais.Count == 0)
            {
                lciProfissionais.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lcgProfissionais.CustomHeaderButtons["Alterar"].Properties.Visible = false;
                lcgProfissionais.CustomHeaderButtons["Função"].Properties.Visible = false;
                bsProfissionais.DataSource = null;
                //MessageBox.Show("Não há profissionais cadastrados na base!", "Profissioanis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                bsProfissionais.DataSource = listaProfissionais;
        }

        private void doMostrarProfissionalForm(string operacao, CE_Funcionario profissional)
        {
            telaPrincipal.Enabled = false;
            VW_FuncionarioForm janela = new VW_FuncionarioForm(operacao,profissional);
            //VW_UsuarioForm01 janela = new VW_UsuarioForm01(operacao, usuario);
            janela.ShowDialog();
            telaPrincipal.Enabled = true;
            //doCarregarDados();
        }
    }
}
