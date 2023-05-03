using DevExpress.XtraBars.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.Utils;
using BeautyControl.View.UCViews;
using BeautyControl.Utils;
using DevExpress.XtraEditors.Controls;
using System.Drawing;
using BeautyControl.View.PopUpViews;

namespace BeautyControl.View
{
    public class ViewUtils
    {
       
        /// <summary>
        ///  Retorna um TileNavPane com botoes montados e funcionalidades
        /// </summary>
        /// <param name="tileNavPane"></param>
        /// <returns></returns>
        public static TileNavPane MontarMenu(TileNavPane tileNavPane)
        {
           
            // Logout ------------------------------------------------------------------------------------------------------------------------------------------------------
            /* Quando este botao é acionado ele retornara a pagina inicial */ 
            NavButton btnHome = getMontarNavBotao("btnHome", "Home", "esquerda", "images/navigation/home_32x32.png", true, true, null);            

            // Venda ------------------------------------------------------------------------------------------------------------------------------------------------------
            /* */
            TileNavCategory btnVendas = getMontarBotao("btnVenda", "Venda", "esquerda", "images/business%20objects/bosale_32x32.png", true,true, null);

            // Relatórios ------------------------------------------------------------------------------------------------------------------------------------------------------
            TileNavCategory btnRelatorios = getMontarBotao("btnRelatorio","Relatórios","esquerda", "images/reports/report_32x32.png", true,false,null);
            TileNavItem btnRelatorioVenda = getMontarNavItem("btnRelatorioVenda", "Venda", "images/function%20library/engineering_32x32.png", true, true);
            TileNavItem btnRelatorioVendaApp = getMontarNavItem("btnRelatorioVendaApp", "Venda App", "images/function%20library/engineering_32x32.png", true, true);

            btnRelatorios.Items.Add(btnRelatorioVenda);
            btnRelatorios.Items.Add(btnRelatorioVendaApp);

            #region Estoque ----------------------------------------------------------------------------------------------------------------------------------------------
            /* Este botao é do tipo NavCategory ao clica-lo exibirá itens/botoes filho que possuem funcionalidade ou subitens*/
            TileNavCategory btnEstoque = getMontarBotao("btnEstoque", "Estoque", "esquerda", "images/business%20objects/boproductgroup_32x32.png", true, false, null); //new TileNavCategory();

            TileNavItem btnConferirEstoque = getMontarNavItem("btnConferirEstoque", "Conferir Estoque", "images/business%20objects/boproductgroup_32x32.png", true, true);
            TileNavItem btnLancarCompra = getMontarNavItem("btnLancarCompra", "Lançar Compra", "images/business%20objects/boorderitem_32x32.png", true, true);
            TileNavItem btnLancarBaixa = getMontarNavItem("btnLancarBaixa", "Lançar Baixa", "images/business%20objects/bosaleitem_32x32.png", true, true);

            btnEstoque.Items.Add(btnConferirEstoque);
            btnEstoque.Items.Add(btnLancarCompra);
            btnEstoque.Items.Add(btnLancarBaixa);
            #endregion

            #region Administrativo ----------------------------------------------------------------------------------------------------------------------------------------------
            /* Este botao é do tipo NavCategory ao clica-lo exibirá itens/botoes filho que possuem funcionalidade ou subitens*/
            TileNavCategory btnAdministrativo = getMontarBotao("btnAdministrativo", "Administrativo", "esquerda", "images/programming/ide_32x32.png", true, false, null); //new TileNavCategory();

            /* Este NavITem é filho de um NavCategory ao clica-lo ele exibira subitens com funcionalidades*/
            TileNavItem btnCadastro = getMontarNavItem("btnCadastro", "Cadastros", "images/data/database_32x32.png", true, false);            
            btnCadastro.SubItems.Add(getMontarNavSubItem("btnCliente", "Clientes", "images/people/usergroup_16x16.png", true, true));
            btnCadastro.SubItems.Add(getMontarNavSubItem("btnProfissional", "Profissional", "images/business%20objects/boperson_16x16.png", true, true));
            btnCadastro.SubItems.Add(getMontarNavSubItem("btnServicos", "Serviços", "images/edit/cut_16x16.png", true, true));
            btnCadastro.SubItems.Add(getMontarNavSubItem("btnFornecedores", "Fornecedores", "devav/view/sales_16x16.png", true, true));
            btnCadastro.SubItems.Add(getMontarNavSubItem("btnCartoes", "Cartões", "images/business%20objects/bosale_16x16.png", true, true));
            btnCadastro.SubItems.Add(getMontarNavSubItem("btnHistoricoCliente", "Histórico Cliente", "images/business%20objects/boresume_16x16.png", true, true));
            btnCadastro.SubItems.Add(getMontarNavSubItem("btnEmpresa", "Minha Empresa", "images/programming/project_16x16.png", true, true));

            /* Este NavITem é filho de um NavCategory ao clica-lo ele exibira subitens com funcionalidades*/
            TileNavItem btnSistema = getMontarNavItem("btnSistema", "Sistema","images/programming/technology_32x32.png", true, false);
            btnSistema.SubItems.Add(getMontarNavSubItem("btnUsuarios", "Usuários", "images/people/team_16x16.png", true, true));
            btnSistema.SubItems.Add(getMontarNavSubItem("btnPerfil", "Tipos de Conta", "images/business%20objects/bouser_16x16.png", true, true));
            btnSistema.SubItems.Add(getMontarNavSubItem("btnTrocarSenha", "Trocar Senha", "images/business%20objects/bochangehistory_16x16.png", true, true));

            btnAdministrativo.Items.Add(btnCadastro);
            btnAdministrativo.Items.Add(btnSistema);
            #endregion

            // Logout ----------------------------------------------------------------------------------------------------------------------------------------------
            SuperToolTip spt = getMontarSuperTooltipInfo01("Sair do sistema",true);
           // NavButton btnSair = getMontarNavBotao("btnLogout","","direita", "images/history/redo_32x32.png", true,true,spt);
            NavButton btnSair = getMontarNavBotao("btnLogout", "", "direita", Properties.Resources.Logout, true, true, spt);

            // Logout ----------------------------------------------------------------------------------------------------------------------------------------------
            spt = getMontarSuperTooltipInfo01("Trocar Usuário", true);
            NavButton btnTrocarUsuario = getMontarNavBotao("btnTrocarUsuario", "", "direita", Properties.Resources.userchange, true, true, spt);

            // Botoes para a esquerda
            tileNavPane.Buttons.Add(btnHome);            
            tileNavPane.Buttons.Add(btnVendas);
            tileNavPane.Buttons.Add(btnRelatorios);
            tileNavPane.Buttons.Add(btnEstoque);
            tileNavPane.Buttons.Add(btnAdministrativo);
            // Botoes para a direita
            tileNavPane.Buttons.Add(btnTrocarUsuario);
            tileNavPane.Buttons.Add(btnSair);

            return tileNavPane;
        }

        /// <summary>
        /// Retorna um obj MeuTooltip
        /// </summary>
        /// <param name="titulo"></param>
        /// <param name="mensagem"></param>
        /// <param name="iconType"></param>
        /// <returns></returns>
        public static MeuToolTip getMeuTooltip(string titulo, string mensagem, ToolTipIconType iconType)
        {
            return new MeuToolTip(titulo, mensagem, iconType);
        }

        public static string getTituloOperacao(string _operacao, string v)
        {
            _operacao = _operacao.ToLower();
            if (_operacao == "novo" || _operacao == "nova" || _operacao == "new")
                return v + " - Novo";
            if(_operacao == "alterar" || _operacao == "update")
                return v + " - Atualizar Dados";
            if (_operacao == "excluir" || _operacao == "deletar" || _operacao == "delete")
                return v + " - Excluir";

            return "";
        }

        /// <summary>
        /// Se isPadrao for false : layoutcontrol que contem um textEdit é alterado<para/>
        /// Uma imagem com tooltip é habilitado do lado do texto do layout control<para/>
        /// A cor da borda do textEdit é alterado 
        /// </summary>
        /// <param name="layoutControlTextEdit"></param>
        /// <param name="isPadrao"></param>
        /// <param name="meuTooltip"></param>
        public static void doMudarAparenciaLayoutControlTextEditAfterValidar(ref LayoutControlItem layoutControlTextEdit, bool isPadrao,MeuToolTip meuTooltip)
        {
            try
            {
                TextEdit txtedit = (TextEdit)layoutControlTextEdit.Control;

                if (txtedit == null || layoutControlTextEdit.Control == null)
                    throw new Exception(layoutControlTextEdit.Name+ " Não possui um textEdit para executar este metodo : 'doMudarAparenciaLayoutControlTextEditAfterValidar'");

                if (!isPadrao)
                {
                    // Verifica se é textEdti  ** ha fazer depois 
                    doMudarCorDaBordaTextEdit(ref txtedit, Color.Red, BorderStyles.Simple);

                    // Image que fica ao lado do texto do layout control 
                    layoutControlTextEdit.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/support/info_16x16.png");

                    // ToolTip quando o usuario passa o mouse em cima da imagem ao lado do layout control
                    doToolTipParaTextEdit(ref txtedit, false, meuTooltip);

                    layoutControlTextEdit.Control = txtedit;

                    // ToolTip quando o usuario passar o mouse em cima do tectedit
                    doIconToolTipToLayoutControl(ref layoutControlTextEdit, false, meuTooltip);

                }else
                {
                    // Verifica se é textEdti  ** ha fazer depois 
                    doMudarCorDaBordaTextEdit(ref txtedit, Color.LightGray, BorderStyles.Default);

                    // Image que fica ao lado do texto do layout control 
                    layoutControlTextEdit.Image = null;// DevExpress.Images.ImageResourceCache.Default.GetImage("images/support/info_16x16.png");

                    // ToolTip quando o usuario passa o mouse em cima da imagem ao lado do layout control
                    doToolTipParaTextEdit(ref txtedit, true, meuTooltip);

                    layoutControlTextEdit.Control = txtedit;

                    // ToolTip quando o usuario passar o mouse em cima do tectedit
                    doIconToolTipToLayoutControl(ref layoutControlTextEdit, true, meuTooltip);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
     
        /// <summary>
        /// isPadrao for false um tooltip sera habilitado para o icone imagem do layoutcontrol<para/>
        /// isPAdrao for true desabilita tooltip do layoutcontrol
        /// </summary>
        /// <param name="layoutControlTextEdit"></param>
        /// <param name="isPadrao"></param>
        /// <param name="meuTooltip"></param>
        private static void doIconToolTipToLayoutControl(ref LayoutControlItem layoutControlTextEdit, bool isPadrao, MeuToolTip meuTooltip)
        {
            if (!isPadrao)
            {
                // ToolTip para image do layoutcontrol
                layoutControlTextEdit.OptionsToolTip.EnableIconToolTip = true;
                layoutControlTextEdit.OptionsToolTip.IconToolTip = meuTooltip.Texto;
                layoutControlTextEdit.OptionsToolTip.IconToolTipIconType = meuTooltip.Tipo;
                layoutControlTextEdit.OptionsToolTip.IconToolTipTitle = meuTooltip.Titulo;
                // tool tip para o texto do layoutcontrol
                layoutControlTextEdit.OptionsToolTip.ToolTip = meuTooltip.Texto;
                layoutControlTextEdit.OptionsToolTip.ToolTipIconType = meuTooltip.Tipo;
                layoutControlTextEdit.OptionsToolTip.IconToolTipTitle = meuTooltip.Titulo;

            }else
            {
                // Tooltip para image do layoutcontrol
                layoutControlTextEdit.OptionsToolTip.EnableIconToolTip = false;               
                // Tooltip do texto do layout control
                layoutControlTextEdit.OptionsToolTip.ToolTip = "";
                layoutControlTextEdit.OptionsToolTip.ToolTipIconType = ToolTipIconType.None;
                layoutControlTextEdit.OptionsToolTip.IconToolTipTitle = "";
            }
        }

        /// <summary>
        /// Tooltip para o textEdit
        /// </summary>
        /// <param name="txtEdit"></param>
        /// <param name="isPadrao">true desabilita tooltio/ false habilita</param>
        /// <param name="meuTooltip"></param>
        public static void doToolTipParaTextEdit(ref TextEdit txtEdit, bool isPadrao,MeuToolTip meuTooltip)
        {

            if (!isPadrao)
            {
                txtEdit.ToolTip = meuTooltip.Texto;
                txtEdit.ToolTipIconType = meuTooltip.Tipo;
                txtEdit.ToolTipTitle = meuTooltip.Titulo;                
            }
            else
            {
                txtEdit.ToolTip = "";
                txtEdit.ToolTipIconType = ToolTipIconType.None;
                txtEdit.ToolTipTitle = "";
            }
        }

        /// <summary>
        /// Tooltip para o DateEdit
        /// </summary>
        /// <param name="txtEdit"></param>
        /// <param name="isPadrao">true desabilita tooltio/ false habilita</param>
        /// <param name="meuTooltip"></param>
        public static void doToolTipParaDateEdit(ref DateEdit dtEdit, bool isPadrao, MeuToolTip meuTooltip)
        {

            if (!isPadrao)
            {
                dtEdit.ToolTip = meuTooltip.Texto;
                dtEdit.ToolTipIconType = meuTooltip.Tipo;
                dtEdit.ToolTipTitle = meuTooltip.Titulo;
            }
            else
            {
                dtEdit.ToolTip = "";
                dtEdit.ToolTipIconType = ToolTipIconType.None;
                dtEdit.ToolTipTitle = "";
            }
        }

        /// <summary>
        /// Tooltip para o LookupEdit
        /// </summary>
        /// <param name="LookupEdit"></param>
        /// <param name="isMostrarTooltip">true desabilita tooltio/ false habilita</param>
        /// <param name="meuTooltip"></param>
        public static void doToolTipParaLookUpEdit(ref LookUpEdit lkpEdit, bool isMostrarTooltip, MeuToolTip meuTooltip)
        {

            if (!isMostrarTooltip)
            {
                lkpEdit.ToolTip = meuTooltip.Texto;
                lkpEdit.ToolTipIconType = meuTooltip.Tipo;
                lkpEdit.ToolTipTitle = meuTooltip.Titulo;
            }
            else
            {
                lkpEdit.ToolTip = "";
                lkpEdit.ToolTipIconType = ToolTipIconType.None;
                lkpEdit.ToolTipTitle = "";
            }
        }

        /// <summary>
        /// Tooltip para o GridLookupEdit
        /// </summary>
        /// <param name="LookupEdit"></param>
        /// <param name="isMostrarTooltip">true desabilita tooltio/ false habilita</param>
        /// <param name="meuTooltip"></param>
        public static void doToolTipParaGridLookUpEdit(ref GridLookUpEdit glkpEdit, bool isMostrarTooltip, MeuToolTip meuTooltip)
        {

            if (!isMostrarTooltip)
            {
                glkpEdit.ToolTip = meuTooltip.Texto;
                glkpEdit.ToolTipIconType = meuTooltip.Tipo;
                glkpEdit.ToolTipTitle = meuTooltip.Titulo;
            }
            else
            {
                glkpEdit.ToolTip = "";
                glkpEdit.ToolTipIconType = ToolTipIconType.None;
                glkpEdit.ToolTipTitle = "";
            }
        }

        /// <summary>
        /// Muda o estilo da borda de um textEdit e altera a cor da borda
        /// </summary>
        /// <param name="layoutControlTextEdit"></param>
        /// <param name="cor"></param>
        /// <param name="estiloBorda"></param>
        private static void doMudarCorDaBordaTextEdit(ref LayoutControlItem layoutControlTextEdit, Color cor, BorderStyles estiloBorda)
        {
            ((BaseEdit)layoutControlTextEdit.Control).BorderStyle = estiloBorda;
            ((BaseEdit)layoutControlTextEdit.Control).Properties.Appearance.BorderColor = cor;
        }

        /// <summary>
        /// Muda o estilo da borda de um textEdit e altera a cor da borda
        /// </summary>
        /// <param name="layoutControlTextEdit"></param>
        /// <param name="cor"></param>
        /// <param name="estiloBorda"></param>
        public static void doMudarCorDaBordaTextEdit(ref TextEdit txtEdit, Color cor, BorderStyles estiloBorda)
        {
            txtEdit.BorderStyle = estiloBorda;
            txtEdit.Properties.Appearance.BorderColor = cor;
        }

        /// <summary>
        /// Metodo usado para validacao de layoutcontrol itens <para/>
        /// Mudar cor da borda e add um tool tipo do lado d propriedade Text do layout control item
        /// layoutcontrolItem : que contenha um TextEdit
        /// meutooltip : um obj meutooltip que contem titulo, um texto de mensagem e um icon
        /// </summary>
        /// <param name="layoutControlItem">que contenha um textEdit ou LookUpEdit</param>
        /// <param name="meuTooltip"></param>
        public static void doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes(ref LayoutControlItem layoutControlItem, MeuToolTip meuTooltip,bool isStyleParaValido)
        {
            try
            {
                TextEdit txtedit = (TextEdit)layoutControlItem.Control;

                if (txtedit == null || layoutControlItem.Control == null)
                    throw new Exception(layoutControlItem.Name + " Não possui um textEdit para executar este metodo : 'doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes'");

                if (!isStyleParaValido)
                {
                    // Verifica se é textEdti  ** ha fazer depois 
                    doMudarCorDaBordaTextEdit(ref txtedit, Color.Red, BorderStyles.Simple);

                    // Image que fica ao lado do texto do layout control 
                    layoutControlItem.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/support/info_16x16.png");

                    // ToolTip quando o usuario passa o mouse em cima da imagem ao lado do layout control
                    doToolTipParaTextEdit(ref txtedit, false, meuTooltip);

                    layoutControlItem.Control = txtedit;

                    // ToolTip quando o usuario passar o mouse em cima do tectedit
                    doIconToolTipToLayoutControl(ref layoutControlItem, false, meuTooltip);
                }
                else
                {
                    // Verifica se é textEdti  ** ha fazer depois 
                    doMudarCorDaBordaTextEdit(ref txtedit, Color.LightGray, BorderStyles.Default);

                    // Image que fica ao lado do texto do layout control 
                    layoutControlItem.Image = null;// DevExpress.Images.ImageResourceCache.Default.GetImage("images/support/info_16x16.png");

                    // ToolTip quando o usuario passa o mouse em cima da imagem ao lado do layout control
                    doToolTipParaTextEdit(ref txtedit, true, meuTooltip);

                    layoutControlItem.Control = txtedit;

                    // ToolTip quando o usuario passar o mouse em cima do tectedit
                    doIconToolTipToLayoutControl(ref layoutControlItem, true, meuTooltip);
                }
               
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void doMudarAparenciaLayoutControlGDateEditComToolTipParaValidacoes(ref LayoutControlItem layoutControlItem, MeuToolTip meuToolTip, bool isStyleParaValido)
        {
            try
            {
                DateEdit dtedit = (DateEdit)layoutControlItem.Control;

                if (dtedit == null || layoutControlItem.Control == null)
                    throw new Exception(layoutControlItem.Name + " Não possui um textEdit para executar este metodo : 'doMudarAparenciaLayoutControlTextEditComToolTipParaValidacoes'");

                if (!isStyleParaValido)
                {
                    // Verifica se é textEdti  ** ha fazer depois 
                    doMudarCorDaBordaDateEdit(ref dtedit, Color.Red, BorderStyles.Simple);

                    // Image que fica ao lado do texto do layout control 
                    layoutControlItem.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/support/info_16x16.png");

                    // ToolTip quando o usuario passa o mouse em cima da imagem ao lado do layout control
                    doToolTipParaDateEdit(ref dtedit, false, meuToolTip);

                    layoutControlItem.Control = dtedit;

                    // ToolTip quando o usuario passar o mouse em cima do tectedit
                    doIconToolTipToLayoutControl(ref layoutControlItem, false, meuToolTip);
                }
                else
                {
                    // Verifica se é textEdti  ** ha fazer depois 
                    doMudarCorDaBordaDateEdit(ref dtedit, Color.LightGray, BorderStyles.Default);

                    // Image que fica ao lado do texto do layout control 
                    layoutControlItem.Image = null;// DevExpress.Images.ImageResourceCache.Default.GetImage("images/support/info_16x16.png");

                    // ToolTip quando o usuario passa o mouse em cima da imagem ao lado do layout control
                    doToolTipParaDateEdit(ref dtedit, true, meuToolTip);

                    layoutControlItem.Control = dtedit;

                    // ToolTip quando o usuario passar o mouse em cima do tectedit
                    doIconToolTipToLayoutControl(ref layoutControlItem, true, meuToolTip);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// Metodo usado para validacao de layoutcontrol itens <para/>
        /// Mudar cor da borda e add um tool tipo do lado d propriedade Text do layout control item
        /// layoutcontrolItem : que contenha um LookUpEdit
        /// meutooltip : um obj meutooltip que contem titulo, um texto de mensagem e um icon
        /// </summary>
        /// <param name="layoutControlItem">que contenha um LookUpEdit</param>
        /// <param name="meuTooltip"></param>
        public static void doMudarAparenciaLayoutControlLookupEditComToolTipParaValidacoes(ref LayoutControlItem layoutControlItem, MeuToolTip meuTooltip, bool isStyleParaValido)
        {
            try
            {
                
                LookUpEdit lkpedit = (LookUpEdit)layoutControlItem.Control;

                if (lkpedit == null || layoutControlItem.Control == null)
                    throw new Exception(layoutControlItem.Name + " Não possui um lookupedit/combo para executar este metodo : 'doMudarAparenciaLayoutControlLookupEditComToolTipParaValidacoes'");

                if (!isStyleParaValido)
                {
                    // Verifica se é lookupEdti  ** ha fazer depois 
                    doMudarCorDaBordaLookUpEdit(ref lkpedit, Color.Red, BorderStyles.Simple);

                    // Image que fica ao lado do texto do layout control 
                    layoutControlItem.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/support/info_16x16.png");

                    // ToolTip quando o usuario passa o mouse em cima da imagem ao lado do layout control
                    doToolTipParaLookUpEdit(ref lkpedit, false, meuTooltip);

                    layoutControlItem.Control = lkpedit;

                    // ToolTip quando o usuario passar o mouse em cima do tectedit
                    doIconToolTipToLayoutControl(ref layoutControlItem, false, meuTooltip);
                }else
                {
                    // Verifica se é textEdti  ** ha fazer depois 
                    doMudarCorDaBordaLookUpEdit(ref lkpedit, Color.LightGray, BorderStyles.Default);

                    // Image que fica ao lado do texto do layout control 
                    layoutControlItem.Image = null;// DevExpress.Images.ImageResourceCache.Default.GetImage("images/support/info_16x16.png");

                    // ToolTip quando o usuario passa o mouse em cima da imagem ao lado do layout control
                    doToolTipParaLookUpEdit(ref lkpedit, true, meuTooltip);

                    layoutControlItem.Control = lkpedit;

                    // ToolTip quando o usuario passar o mouse em cima do tectedit
                    doIconToolTipToLayoutControl(ref layoutControlItem, true, meuTooltip);
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// Metodo usado para validacao de layoutcontrol itens <para/>
        /// Mudar cor da borda e add um tool tipo do lado d propriedade Text do layout control item
        /// layoutcontrolItem : que contenha um LookUpEdit
        /// meutooltip : um obj meutooltip que contem titulo, um texto de mensagem e um icon
        /// </summary>
        /// <param name="layoutControlItem">que contenha um GridLookUpEdit</param>
        /// <param name="meuTooltip"></param>
        public static void doMudarAparenciaLayoutControlGridLookupEditComToolTipParaValidacoes(ref LayoutControlItem layoutControlItem, MeuToolTip meuTooltip, bool isStyleParaValido)
        {
            try
            {

                GridLookUpEdit glkpedit = (GridLookUpEdit)layoutControlItem.Control;

                if (glkpedit == null || layoutControlItem.Control == null)
                    throw new Exception(layoutControlItem.Name + " Não possui um lookupedit/combo para executar este metodo : 'doMudarAparenciaLayoutControlLookupEditComToolTipParaValidacoes'");

                if (!isStyleParaValido)
                {
                    // Verifica se é lookupEdti  ** ha fazer depois 
                    doMudarCorDaBordaGridLookUpEdit(ref glkpedit, Color.Red, BorderStyles.Simple);

                    // Image que fica ao lado do texto do layout control 
                    layoutControlItem.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/support/info_16x16.png");

                    // ToolTip quando o usuario passa o mouse em cima da imagem ao lado do layout control
                    doToolTipParaGridLookUpEdit(ref glkpedit, false, meuTooltip);

                    layoutControlItem.Control = glkpedit;

                    // ToolTip quando o usuario passar o mouse em cima do tectedit
                    doIconToolTipToLayoutControl(ref layoutControlItem, false, meuTooltip);
                }
                else
                {
                    // Verifica se é textEdti  ** ha fazer depois 
                    doMudarCorDaBordaGridLookUpEdit(ref glkpedit, Color.LightGray, BorderStyles.Default);

                    // Image que fica ao lado do texto do layout control 
                    layoutControlItem.Image = null;// DevExpress.Images.ImageResourceCache.Default.GetImage("images/support/info_16x16.png");

                    // ToolTip quando o usuario passa o mouse em cima da imagem ao lado do layout control
                    doToolTipParaGridLookUpEdit(ref glkpedit, true, meuTooltip);

                    layoutControlItem.Control = glkpedit;

                    // ToolTip quando o usuario passar o mouse em cima do tectedit
                    doIconToolTipToLayoutControl(ref layoutControlItem, true, meuTooltip);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// Muda o estilo da borda de um LookUpEdit e altera a cor da borda
        /// </summary>
        /// <param name="layoutControlLookUpEdit"></param>
        /// <param name="cor"></param>
        /// <param name="estiloBorda"></param>
        public static void doMudarCorDaBordaLookUpEdit(ref LookUpEdit lkpEdit, Color cor, BorderStyles estiloBorda)
        {
            lkpEdit.BorderStyle = estiloBorda;
            lkpEdit.Properties.Appearance.BorderColor = cor;
        }

        /// <summary>
        /// Muda o estilo da borda de um DateEdit e altera a cor da borda
        /// </summary>
        /// <param name="layoutControlLookUpEdit"></param>
        /// <param name="cor"></param>
        /// <param name="estiloBorda"></param>
        public static void doMudarCorDaBordaDateEdit(ref DateEdit dtEdit, Color cor, BorderStyles estiloBorda)
        {
            dtEdit.BorderStyle = estiloBorda;
            dtEdit.Properties.Appearance.BorderColor = cor;
        }

        /// <summary>
        /// Muda o estilo da borda de um GridLookUpEdit e altera a cor da borda
        /// </summary>
        /// <param name="layoutControlLookUpEdit"></param>
        /// <param name="cor"></param>
        /// <param name="estiloBorda"></param>
        public static void doMudarCorDaBordaGridLookUpEdit(ref GridLookUpEdit glkpEdit, Color cor, BorderStyles estiloBorda)
        {
            glkpEdit.BorderStyle = estiloBorda;
            glkpEdit.Properties.Appearance.BorderColor = cor;
        }

        private static NavButton getMontarNavBotao(string nomeComponente, string caption, string alinhamentoBotao, string enderecoImagem, bool isGlyph, bool isPossuiEventoClick, SuperToolTip spt)
        {
            NavButton botao = new NavButton();
            botao.Caption = caption;
            botao.Name = nomeComponente;
            botao.Alignment = getNavButtonAlinhamentoLeftOrRight(alinhamentoBotao);
            botao.Glyph = DevExpress.Images.ImageResourceCache.Default.GetImage(enderecoImagem);
            botao.SuperTip = spt;

            if (isPossuiEventoClick)
                botao.ElementClick += BtnClickMenu_ElementClick;

            return botao;
        }

        private static NavButton getMontarNavBotao(string nomeComponente, string caption, string alinhamentoBotao, Bitmap enderecoImagem, bool isGlyph, bool isPossuiEventoClick, SuperToolTip spt)
        {
            NavButton botao = new NavButton();
            botao.Caption = caption;
            botao.Name = nomeComponente;
            botao.Alignment = getNavButtonAlinhamentoLeftOrRight(alinhamentoBotao);
            botao.Glyph =enderecoImagem;
            botao.SuperTip = spt;

            if (isPossuiEventoClick)
                botao.ElementClick += BtnClickMenu_ElementClick;

            return botao;
        }

        /// <getMontarBotao>
        /// OBs Fazer logica se nao for glyph e sim imagem 
        /// se endereco vazio nao possuira img
        /// </getMontarBotao>
        /// <param name="nomeComponente">Nome do componente</param>
        /// <param name="caption">Caption nome do texto do botoa</param>
        /// <param name="alinhamentoBotao">alinhamento no navPane </param>
        /// <param name="enderecoImagem"></param>
        /// <param name="isGlyph"></param>
        /// <returns></returns>
        private static TileNavCategory getMontarBotao(string nomeComponente, string caption, string alinhamentoBotao, string enderecoImagem, bool isGlyph, bool isPossuiEventoClick, SuperToolTip sTooltip)
        {
            TileNavCategory botao = new TileNavCategory();
            botao.Caption = caption;
            botao.Name = nomeComponente;
            botao.Alignment = getNavButtonAlinhamentoLeftOrRight(alinhamentoBotao);// NavButtonAlignment.Left;
            botao.Glyph = DevExpress.Images.ImageResourceCache.Default.GetImage(enderecoImagem);
            botao.OptionsDropDown.BackColor = System.Drawing.Color.Firebrick;
            botao.OptionsDropDown.AppearanceItem.Normal.BackColor = System.Drawing.Color.Crimson;
            //botao.OptionsDropDown.AppearanceItem.Normal.Font = ;

            // Assign a SuperToolTip to the button:
            botao.SuperTip = sTooltip;


            botao.OwnerCollection = null;
            if (isPossuiEventoClick)
                botao.ElementClick += BtnClickMenu_ElementClick;

            return botao;
        }

        // SuperToolTip basico com imagem de info no header opcional seguido de uma texto
        public static SuperToolTip getMontarSuperTooltipInfo01(string contentTooltip,bool isUseImage)
        {
            // Cria  e customiza um SuperToolTip:
            SuperToolTip sTooltip = new SuperToolTip();
            
            ToolTipTitleItem tooltioitem = new ToolTipTitleItem();
            tooltioitem.Appearance.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/support/info_16x16.png");
            tooltioitem.Appearance.Options.UseImage = isUseImage;
            tooltioitem.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/support/info_16x16.png");
            tooltioitem.Text = contentTooltip;

            sTooltip.Items.Add(tooltioitem);

            return sTooltip;
        }

        public static SuperToolTip getMontarSuperTip(string contentTooltip, bool isTitleImagem, string contentTitle, bool isFooterImagem, string contentFooter, bool isShowFooterSeparador)
        {
            // Cria  e customiza um SuperToolTip:
            SuperToolTip sTooltip = new SuperToolTip();

            SuperToolTipSetupArgs args = new SuperToolTipSetupArgs();

           
            if (isTitleImagem)
                args.Title.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/insert_32x32.png");
            else
                args.Title.Text = contentTitle;

            args.Contents.Text = contentTooltip;

            args.ShowFooterSeparator = isShowFooterSeparador;

            if (isFooterImagem)
                args.Footer.Text = contentFooter;
            else
                args.Footer.Text = contentFooter;



            sTooltip.Setup(args);
            // Habilitar HTML Texto Formatado pelo SuperToolTip creado:
            sTooltip.AllowHtmlText = DefaultBoolean.True;
            //..ou habilitar esse feature para todos os tooltips:
            //defaultTooltipController.AllowHtmlText = true;

            return sTooltip;
        }

        public static void doVerificarTxtEditIsEmptyDeUmLayoutControl(ref LayoutControl layoutControl)
        {
            bool isPossuiCampoEmBranco = false;
            foreach (Control item in layoutControl.Controls)
            {
                TextEdit txt = item as TextEdit;
                if (txt != null)
                {
                    doValidarTextEdit(ref txt);
                    if (String.IsNullOrEmpty(txt.Text) && txt.ReadOnly==false)
                        isPossuiCampoEmBranco = true;
                }
            }

            if (isPossuiCampoEmBranco)
                throw new Exception("Preencha o(s) campo(s) vazio(s)!");
        }

        /// <summary>
        /// Mudar cor da borda de um textEdit
        /// </summary>
        /// <param name="txtEdit"></param>
        public static void doValidarTextEdit(ref TextEdit txtEdit)
        {
            if (String.IsNullOrEmpty(txtEdit.Text))
                doMudarCorDaBordaTextEdit(ref txtEdit, Color.Red, BorderStyles.Simple);
            else
                doMudarCorDaBordaTextEdit(ref txtEdit,Color.LightGray,BorderStyles.Default);
            #region anterior
            //txtEdit.BackColor = System.Drawing.Color.RosyBrown;
            //txtEdit.ForeColor = System.Drawing.Color.White;
            // txtEdit.Font = new System.Drawing.Font(txtEdit.Font, System.Drawing.FontStyle.Bold);

            //txtEdit.BackColor = System.Drawing.Color.White;
            // txtEdit.ForeColor = System.Drawing.Color.Black;
            // txtEdit.Font = new System.Drawing.Font(txtEdit.Font, System.Drawing.FontStyle.Regular);
            #endregion
        }     

        /// <getMontarNavItem>
        /// TileNavItem é um botao filho do TiNavCategory         /// 
        /// </getMontarNavItem>
        /// <param name="nomeComponente">Nome do componente usado para ser referenciado</param>
        /// <param name="texto">Texto de identificação do botao para a view ou usuario</param>
        /// <param name="enderecoImagem">Caminho da localização da Imagem de identificaçao do botao,</param>
        /// <param name="isGlyph">Boolean para identiciar se é um glyph ou nao</param>
        /// <param name="isPossuiEventoClick">Boolean para verificar se este botao tera uma ação ou nao no Click</param>
        /// <returns></returns>
        private static TileNavItem getMontarNavItem(string nomeComponente, string texto, string enderecoImagem, bool isGlyph, bool isPossuiEventoClick)
        {
            TileNavItem item = new TileNavItem();

            item.Caption = item.TileText = texto;
            item.Name = nomeComponente;
            item.Tile.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            item.Tile.AppearanceItem.Normal.Font = new System.Drawing.Font(item.Tile.AppearanceItem.Normal.Font, System.Drawing.FontStyle.Bold);
            item.TileImage = DevExpress.Images.ImageResourceCache.Default.GetImage(enderecoImagem);
            if (isPossuiEventoClick)
                item.ElementClick += BtnClickMenu_ElementClick;

            return item;
        }

        /// <getMontarNavItem>
        /// TileNavSubItem é um botao filho do TileNavItem e neto de TileNavCategory         /// 
        /// </getMontarNavItem>
        /// <param name="nomeComponente">Nome do componente usado para ser referenciado</param>
        /// <param name="texto">Texto de identificação do botao para a view ou usuario</param>
        /// <param name="enderecoImagem">Caminho da localização da Imagem de identificaçao do botao,</param>
        /// <param name="isGlyph">Boolean para identiciar se é um glyph ou nao</param>
        /// <param name="isPossuiEventoClick">Boolean para verificar se este botao tera uma ação ou nao no Click</param>
        /// <returns></returns>
        private static TileNavSubItem getMontarNavSubItem(string nomeComponente, string texto, string enderecoImagem, bool isGlyph, bool isPossuiEventoClick)
        {
            TileNavSubItem subItem = new TileNavSubItem();

            subItem.Caption = subItem.TileText = texto;
            subItem.Name = nomeComponente;
            subItem.Tile.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            subItem.Tile.AppearanceItem.Normal.Font = new System.Drawing.Font(subItem.Tile.AppearanceItem.Normal.Font, System.Drawing.FontStyle.Bold);
            subItem.TileImage = DevExpress.Images.ImageResourceCache.Default.GetImage(enderecoImagem);

            if (isPossuiEventoClick)
                subItem.ElementClick += BtnClickMenu_ElementClick;

            return subItem;
        }

        /// <getNavButtonAlinhamentoLeftOrRight>
        /// Retorna um NavButtonAlignment
        /// 1* NavButtonAlignment.Left    se o parametro passado for left ou esquerda
        /// 2* NavButtonAlignment.Right   se o paramento passado for right ou direita
        /// 3* NavButtonAlignment.Default caso nao satisfaça nenhuma das condiçoes de 1* e 2*
        /// </getNavButtonAlinhamentoLeftOrRight>
        /// <param name="alinhamentoBotao"></param>
        /// <returns>NavButtonAlignment Left Right or Default</returns>
        private static NavButtonAlignment getNavButtonAlinhamentoLeftOrRight(string alinhamentoBotao)
        {
            if (alinhamentoBotao.ToLower() == "esquerda" || alinhamentoBotao.ToLower() == "left")
                return NavButtonAlignment.Left;
            if (alinhamentoBotao.ToLower() == "direita" || alinhamentoBotao.ToLower() == "right")
                return NavButtonAlignment.Right;

            return NavButtonAlignment.Default;
        }

        // Ação dos botoes
        private static void BtnClickMenu_ElementClick(object sender, NavElementEventArgs e)
        {
            // Apos clicar em um botao do tleNavPane o DropDown é recolhido
            VariaveisGlobais.principal.tileNavPane1.HideDropDownWindow();
            switch (e.Element.Name)
            {
                case "btnHome":
                    MessageBox.Show("Home");
                    break;
                case "btnVenda":
                    doTrocarViewdoPanelPrincipal(new UC_RegistroVenda());
                    break;
                case "btnCliente":
                    doTrocarViewdoPanelPrincipal(new UC_Clientes());
                   // MessageBox.Show("Cliente");
                    break;
                case "btnProfissional":
                    doTrocarViewdoPanelPrincipal(new UC_Funcionarios());
                   // MessageBox.Show("Profisiional");
                    break;
                case "btnServicos":
                    doTrocarViewdoPanelPrincipal(new UC_Servicos_Produtos());
                    break;
                case "btnFornecedores":
                    MessageBox.Show("fornenec");
                    break;
                case "btnCartoes":
                    MessageBox.Show("Cartoes");
                    break;
                case "btnHistoricoCliente":
                    MessageBox.Show("Historico");
                    break;
                case "btnEmpresa":
                    MessageBox.Show("Empresa");
                    break;
                case "btnUsuarios":
                    doTrocarViewdoPanelPrincipal(new UC_Usuarios());
                    break;
                case "btnPerfil":
                    MessageBox.Show("Historico");
                    break;
                case "btnTrocarSenha":
                    doTrocarViewdoPanelPrincipal(new UC_TrocarSenha());                    
                    break;
                case "btnTrocarUsuario":
                    Application.Restart();
                    break;
                case "btnLogout":
                    Application.Exit();
                    break;
                case "btnConferirEstoque":
                    doTrocarViewdoPanelPrincipal(new UC_Estoque());
                    break;
                case "btnLancarCompra":
                    doMostrarViewPopUp(new VW_EstoqueLancamentoCompra("(+)",false));
                    break;
                case "btnLancarBaixa":
                    doMostrarViewPopUp(new VW_EstoqueLancamentoCompra("(-)",false));
                    break;
                case "btnRelatorioVenda":
                    doTrocarViewdoPanelPrincipal(new UC_RelatorioVenda());
                    break;
                case "btnRelatorioVendaApp":
                    doTrocarViewdoPanelPrincipal(new UC_VendaApp());
                    break;
            }
        }

        private static void doMostrarViewPopUp(DevExpress.XtraEditors.XtraForm VW_PopUp)
        {
            VW_PopUp.ShowDialog();
        }

        /// <summary>
        /// Limpa os controles atuais inseridos no Panel Principal<para/>
        /// Adiciona uma nova View no Panel Principal
        /// </summary>
        /// <param name="UserControlView">UserControl View que será adicionado no PanelPrincipal</param>
        public static void doTrocarViewdoPanelPrincipal(UserControl UserControlView)
        {
            UserControlView.Visible = true;
            UserControlView.Dock = DockStyle.Fill;
            VariaveisGlobais.principal.panelDeViews.Controls.Clear();            
            VariaveisGlobais.principal.panelDeViews.Controls.Add(UserControlView);
        }

        /// <doExportarTo Açao de Transformar um report com um tipo de arquivo com a extensao mandando por paramentro>
        /// 1. Verifica qual tipo de extensao
        /// 2. Transformar o relatorio em um arquivo de acordo com a extensao mandando por paramentro
        /// </doExportarTo>
        /// <param name="tipoArquivo"> Extensao do arquivo</param>
        /// <param name="report"> Relatorio Montado</param>
        /// <param name="svdlg"> Nome do arquivo</param>
        public static void doExportarReportTo(string tipoArquivo, DevExpress.XtraReports.UI.XtraReport report, string fileName)
        {
            switch (tipoArquivo)
            {
                case "XLS":

                    DevExpress.XtraPrinting.XlsExportOptions xls = report.ExportOptions.Xls;
                    xls.ShowGridLines = true;
                    xls.TextExportMode = DevExpress.XtraPrinting.TextExportMode.Value;
                    // xls.ExportHyperlinks = true;
                    xls.SheetName = "RelatorioVenda";
                    report.ExportToXls(fileName);
                    break;

                case "PDF":

                    DevExpress.XtraPrinting.PdfExportOptions pdf = report.ExportOptions.Pdf;
                    //pdf.PageRange = "1";
                    pdf.ConvertImagesToJpeg = false;
                    pdf.ImageQuality = DevExpress.XtraPrinting.PdfJpegImageQuality.Medium;

                    pdf.DocumentOptions.Application = "BEAUTY CONTROL";
                    pdf.DocumentOptions.Author = "Igo Pinheiro";
                    pdf.DocumentOptions.Keywords = "BC,Relatorio,PDF";
                    pdf.DocumentOptions.Title = "Relatorio Venda";

                    report.ExportToPdf(fileName, pdf);

                    break;

                case "PNG":
                    DevExpress.XtraPrinting.ImageExportOptions img = report.ExportOptions.Image;
                    img.Format = System.Drawing.Imaging.ImageFormat.Png;
                    report.ExportToImage(fileName);
                    break;

                case "HTML":
                    DevExpress.XtraPrinting.HtmlExportOptions html = report.ExportOptions.Html;
                    html.CharacterSet = "UTF-8";
                    html.TableLayout = false;
                    html.RemoveSecondarySymbols = false;
                    html.Title = "Relatorio Venda";

                    html.ExportMode = DevExpress.XtraPrinting.HtmlExportMode.SingleFilePageByPage;
                    //html.PageRange = "1";
                    html.PageBorderColor = System.Drawing.Color.Blue;
                    html.PageBorderWidth = 2;

                    report.ExportToHtml(fileName);
                    break;

                default:
                    break;
            }
        }
    }
}
