namespace BeautyControl.View.UCViews
{
    partial class UC_Usuarios
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Usuarios));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gcPerfis = new DevExpress.XtraGrid.GridControl();
            this.bsPerfis = new System.Windows.Forms.BindingSource(this.components);
            this.gvPerfis = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldescricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprioridade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisSelecionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcUsuarios = new DevExpress.XtraGrid.GridControl();
            this.bsUsuarios = new System.Windows.Forms.BindingSource(this.components);
            this.gvUsuarios = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLogin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFuncionario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMudarStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rICmbStatus = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colMudarSenha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rItemBtnAlterar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.rItemBtnMudarStatus = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcUCUsuarios = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcGcPerfis = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcGcUsuarios = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.alertControlMudarStatus = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPerfis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPerfis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPerfis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rICmbStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rItemBtnAlterar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rItemBtnMudarStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcUCUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcGcPerfis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcGcUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcPerfis);
            this.layoutControl1.Controls.Add(this.gcUsuarios);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(512, 315, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(854, 544);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcPerfis
            // 
            this.gcPerfis.DataSource = this.bsPerfis;
            this.gcPerfis.Location = new System.Drawing.Point(606, 43);
            this.gcPerfis.MainView = this.gvPerfis;
            this.gcPerfis.Name = "gcPerfis";
            this.gcPerfis.Size = new System.Drawing.Size(239, 492);
            this.gcPerfis.TabIndex = 5;
            this.gcPerfis.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPerfis});
            // 
            // bsPerfis
            // 
            this.bsPerfis.DataSource = typeof(model_beautycontrol.Model.CE.CE_PerfilDeUsuario);
            // 
            // gvPerfis
            // 
            this.gvPerfis.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldescricao,
            this.colprioridade,
            this.colisSelecionado});
            this.gvPerfis.GridControl = this.gcPerfis;
            this.gvPerfis.Name = "gvPerfis";
            this.gvPerfis.OptionsBehavior.Editable = false;
            this.gvPerfis.OptionsBehavior.ReadOnly = true;
            this.gvPerfis.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvPerfis.OptionsView.ShowGroupPanel = false;
            // 
            // coldescricao
            // 
            this.coldescricao.Caption = "Descrição";
            this.coldescricao.FieldName = "descricao";
            this.coldescricao.Name = "coldescricao";
            this.coldescricao.Visible = true;
            this.coldescricao.VisibleIndex = 0;
            // 
            // colprioridade
            // 
            this.colprioridade.Caption = "Prioridade";
            this.colprioridade.FieldName = "prioridade";
            this.colprioridade.Name = "colprioridade";
            this.colprioridade.Visible = true;
            this.colprioridade.VisibleIndex = 1;
            // 
            // colisSelecionado
            // 
            this.colisSelecionado.FieldName = "isSelecionado";
            this.colisSelecionado.Name = "colisSelecionado";
            // 
            // gcUsuarios
            // 
            this.gcUsuarios.DataSource = this.bsUsuarios;
            this.gcUsuarios.Location = new System.Drawing.Point(9, 43);
            this.gcUsuarios.MainView = this.gvUsuarios;
            this.gcUsuarios.Name = "gcUsuarios";
            this.gcUsuarios.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rItemBtnAlterar,
            this.rItemBtnMudarStatus,
            this.rICmbStatus});
            this.gcUsuarios.Size = new System.Drawing.Size(581, 492);
            this.gcUsuarios.TabIndex = 4;
            this.gcUsuarios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUsuarios});
            // 
            // bsUsuarios
            // 
            this.bsUsuarios.DataSource = typeof(model_beautycontrol.Model.CE.CE_Usuario);
            // 
            // gvUsuarios
            // 
            this.gvUsuarios.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLogin,
            this.colFuncionario,
            this.colStatus,
            this.colMudarStatus,
            this.colMudarSenha});
            this.gvUsuarios.GridControl = this.gcUsuarios;
            this.gvUsuarios.Name = "gvUsuarios";
            this.gvUsuarios.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvUsuarios.OptionsView.ShowGroupPanel = false;
            this.gvUsuarios.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvUsuarios_FocusedRowChanged);
            // 
            // colLogin
            // 
            this.colLogin.Caption = "Login";
            this.colLogin.FieldName = "Login";
            this.colLogin.Name = "colLogin";
            this.colLogin.OptionsColumn.AllowEdit = false;
            this.colLogin.Visible = true;
            this.colLogin.VisibleIndex = 0;
            this.colLogin.Width = 140;
            // 
            // colFuncionario
            // 
            this.colFuncionario.Caption = "Funcionário";
            this.colFuncionario.FieldName = "NomeFuncionario";
            this.colFuncionario.Name = "colFuncionario";
            this.colFuncionario.OptionsColumn.AllowEdit = false;
            this.colFuncionario.Visible = true;
            this.colFuncionario.VisibleIndex = 1;
            this.colFuncionario.Width = 232;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Situação";
            this.colStatus.FieldName = "Status.descricao";
            this.colStatus.Name = "colStatus";
            this.colStatus.OptionsColumn.AllowEdit = false;
            // 
            // colMudarStatus
            // 
            this.colMudarStatus.Caption = "Status";
            this.colMudarStatus.ColumnEdit = this.rICmbStatus;
            this.colMudarStatus.FieldName = "Status.descricao";
            this.colMudarStatus.Name = "colMudarStatus";
            this.colMudarStatus.Visible = true;
            this.colMudarStatus.VisibleIndex = 3;
            this.colMudarStatus.Width = 114;
            // 
            // rICmbStatus
            // 
            this.rICmbStatus.AutoHeight = false;
            this.rICmbStatus.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rICmbStatus.Name = "rICmbStatus";
            this.rICmbStatus.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.rICmbStatus.SelectedValueChanged += new System.EventHandler(this.rICmbStatus_SelectedValueChanged);
            // 
            // colMudarSenha
            // 
            this.colMudarSenha.Caption = "Alterar";
            this.colMudarSenha.ColumnEdit = this.rItemBtnAlterar;
            this.colMudarSenha.Name = "colMudarSenha";
            this.colMudarSenha.Visible = true;
            this.colMudarSenha.VisibleIndex = 2;
            this.colMudarSenha.Width = 74;
            // 
            // rItemBtnAlterar
            // 
            this.rItemBtnAlterar.AutoHeight = false;
            this.rItemBtnAlterar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("rItemBtnAlterar.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.rItemBtnAlterar.Name = "rItemBtnAlterar";
            this.rItemBtnAlterar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.rItemBtnAlterar.Click += new System.EventHandler(this.rItemBtnAlterar_Click);
            // 
            // rItemBtnMudarStatus
            // 
            this.rItemBtnMudarStatus.AutoHeight = false;
            this.rItemBtnMudarStatus.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("rItemBtnMudarStatus.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.rItemBtnMudarStatus.Name = "rItemBtnMudarStatus";
            this.rItemBtnMudarStatus.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcUCUsuarios});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup1.Size = new System.Drawing.Size(854, 544);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lcUCUsuarios
            // 
            this.lcUCUsuarios.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lcUCUsuarios.AppearanceGroup.Options.UseFont = true;
            this.lcUCUsuarios.CaptionImage = ((System.Drawing.Image)(resources.GetObject("lcUCUsuarios.CaptionImage")));
            this.lcUCUsuarios.ContentImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            toolTipTitleItem1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            toolTipTitleItem1.Appearance.Options.UseImage = true;
            toolTipTitleItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem1.Image")));
            toolTipTitleItem1.Text = "Criar um usuário para um funcionário da empresa";
            superToolTip1.Items.Add(toolTipTitleItem1);
            toolTipTitleItem2.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            toolTipTitleItem2.Appearance.Options.UseImage = true;
            toolTipTitleItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem2.Image")));
            toolTipTitleItem2.Text = "\r\nAlterar dados do usuário";
            superToolTip2.Items.Add(toolTipTitleItem2);
            toolTipTitleItem3.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            toolTipTitleItem3.Appearance.Options.UseImage = true;
            toolTipTitleItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem3.Image")));
            toolTipTitleItem3.Text = "\r\nCadastro um novo usuário no sistema";
            superToolTip3.Items.Add(toolTipTitleItem3);
            this.lcUCUsuarios.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Associar Funcionário", ((System.Drawing.Image)(resources.GetObject("lcUCUsuarios.CustomHeaderButtons"))), -1, DevExpress.XtraEditors.ButtonPanel.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", true, -1, true, superToolTip1, true, false, true, null, null, -1),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Alterar Usuário", ((System.Drawing.Image)(resources.GetObject("lcUCUsuarios.CustomHeaderButtons1"))), -1, DevExpress.XtraEditors.ButtonPanel.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", true, -1, true, superToolTip2, true, false, false, null, null, -1),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Novo Usuário", ((System.Drawing.Image)(resources.GetObject("lcUCUsuarios.CustomHeaderButtons2"))), -1, DevExpress.XtraEditors.ButtonPanel.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", true, -1, true, superToolTip3, true, false, true, null, null, -1)});
            this.lcUCUsuarios.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.lcUCUsuarios.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcGcPerfis,
            this.lcGcUsuarios,
            this.splitterItem1});
            this.lcUCUsuarios.Location = new System.Drawing.Point(0, 0);
            this.lcUCUsuarios.Name = "lcUCUsuarios";
            this.lcUCUsuarios.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.lcUCUsuarios.Size = new System.Drawing.Size(850, 540);
            this.lcUCUsuarios.Text = "Usuários";
            this.lcUCUsuarios.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.lcUCUsuarios_CustomButtonClick);
            // 
            // lcGcPerfis
            // 
            this.lcGcPerfis.Control = this.gcPerfis;
            this.lcGcPerfis.Location = new System.Drawing.Point(597, 0);
            this.lcGcPerfis.Name = "lcGcPerfis";
            this.lcGcPerfis.Size = new System.Drawing.Size(243, 496);
            this.lcGcPerfis.TextLocation = DevExpress.Utils.Locations.Top;
            this.lcGcPerfis.TextSize = new System.Drawing.Size(0, 0);
            this.lcGcPerfis.TextVisible = false;
            // 
            // lcGcUsuarios
            // 
            this.lcGcUsuarios.Control = this.gcUsuarios;
            this.lcGcUsuarios.Location = new System.Drawing.Point(0, 0);
            this.lcGcUsuarios.Name = "lcGcUsuarios";
            this.lcGcUsuarios.Size = new System.Drawing.Size(585, 496);
            this.lcGcUsuarios.TextLocation = DevExpress.Utils.Locations.Top;
            this.lcGcUsuarios.TextSize = new System.Drawing.Size(0, 0);
            this.lcGcUsuarios.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.Location = new System.Drawing.Point(585, 0);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(12, 496);
            // 
            // alertControlMudarStatus
            // 
            this.alertControlMudarStatus.AutoFormDelay = 4000;
            this.alertControlMudarStatus.FormLocation = DevExpress.XtraBars.Alerter.AlertFormLocation.BottomLeft;
            this.alertControlMudarStatus.FormShowingEffect = DevExpress.XtraBars.Alerter.AlertFormShowingEffect.SlideVertical;
            this.alertControlMudarStatus.LookAndFeel.SkinMaskColor = System.Drawing.Color.Crimson;
            this.alertControlMudarStatus.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.alertControlMudarStatus.LookAndFeel.UseDefaultLookAndFeel = false;
            this.alertControlMudarStatus.ShowPinButton = false;
            this.alertControlMudarStatus.ShowToolTips = false;
            // 
            // UC_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "UC_Usuarios";
            this.Size = new System.Drawing.Size(854, 544);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPerfis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPerfis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPerfis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rICmbStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rItemBtnAlterar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rItemBtnMudarStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcUCUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcGcPerfis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcGcUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gcPerfis;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPerfis;
        private DevExpress.XtraGrid.GridControl gcUsuarios;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUsuarios;
        private DevExpress.XtraLayout.LayoutControlGroup lcUCUsuarios;
        private DevExpress.XtraLayout.LayoutControlItem lcGcPerfis;
        private DevExpress.XtraLayout.LayoutControlItem lcGcUsuarios;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private System.Windows.Forms.BindingSource bsUsuarios;
        private DevExpress.XtraGrid.Columns.GridColumn colLogin;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colFuncionario;
        private DevExpress.XtraGrid.Columns.GridColumn colMudarSenha;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit rItemBtnAlterar;
        private DevExpress.XtraGrid.Columns.GridColumn colMudarStatus;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit rItemBtnMudarStatus;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox rICmbStatus;
        private DevExpress.XtraBars.Alerter.AlertControl alertControlMudarStatus;
        private System.Windows.Forms.BindingSource bsPerfis;
        private DevExpress.XtraGrid.Columns.GridColumn coldescricao;
        private DevExpress.XtraGrid.Columns.GridColumn colprioridade;
        private DevExpress.XtraGrid.Columns.GridColumn colisSelecionado;
    }
}
