using model_beautycontrol.Model.CE;
using model_beautycontrol.Model.DOM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautyControl.View.PopUpViews
{
    public partial class VW_FuncionarioFuncao : DevExpress.XtraEditors.XtraForm
    {
        private CE_Funcionario funcionario = new CE_Funcionario();
        private List<CE_Funcao> listaFuncao = new List<CE_Funcao>();
        private DOM_Funcionario dom = new DOM_Funcionario();

        public VW_FuncionarioFuncao(CE_Funcionario _funcionario)
        {
            InitializeComponent();
            funcionario = _funcionario;
            bsFuncoes.DataSource = dom.getFuncoesParaAssociar(funcionario);
            lblFuncionario.Text = "Funcionario: " + funcionario.nome; 
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var lista = bsFuncoes.DataSource as List<CE_Funcao>;
                dom.doAssociar(lista, funcionario);
                //MessageBox.Show(ex.Message, "Erro ao carregar formulário", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Salvar - Ocorreu um erro nesta operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
