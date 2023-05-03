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
using DevExpress.XtraBars.Navigation;
using BeautyControl.Properties;
using BeautyControl.View.PopUpViews;
using DevExpress.XtraSplashScreen;
using model_beautycontrol.Model.CE;
using BeautyControl.Utils;

namespace BeautyControl.View
{
    public partial class Principal : XtraForm
    {
        public Principal()
        {
            InitializeComponent();

            SplashScreenManager.ShowForm(typeof(VW_SplashScreenInicial));
            // Verificar Conexao com banco

            // Verificar dados padroes inseridos
            new model_beautycontrol.Model.DOM.DOM_DadosDefault().doVerificarBaseDados();
           
            System.Threading.Thread.Sleep(3000);
            SplashScreenManager.CloseForm();

            this.Enabled = false;

            if (!new model_beautycontrol.Model.BO.BO_Empresa().isPossuiEmpresaNaBase())
            {
                VW_CadastroInicial janela01 = new VW_CadastroInicial();
                janela01.ShowDialog();
            }else
            {
                VW_Login janela02 = new VW_Login();
                janela02.ShowDialog();

                //CE_Usuario usuariologado = new CE_Usuario();
                CE_Empresa empresalogada = new CE_Empresa();
                empresalogada.id = 2;
                VariaveisGlobais.empresalogada = empresalogada;
               
            }

            this.Enabled = true;

            tileNavPane1 = ViewUtils.MontarMenu(tileNavPane1);
                    
            Utils.VariaveisGlobais.principal = this;
            
        }

        private void Novobotao_ElementClick(object sender, NavElementEventArgs e)
        {
            MessageBox.Show("Novo Botao clicado");
        }

        private void tileNavCategory3_ElementClick(object sender, NavElementEventArgs e)
        {

        }
    }
}