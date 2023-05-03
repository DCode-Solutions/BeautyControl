namespace BeautyControl.View.UCViews
{
    partial class UC_Funcionario_AssociarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Funcionario_AssociarUsuario));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gcFuncionarios = new DevExpress.XtraGrid.GridControl();
            this.bsFuncionarios = new System.Windows.Forms.BindingSource(this.components);
            this.gvFuncionarios = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colfuncao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvinculoatual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldatanascimentoFormatada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfoto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riFotoFuncionario = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgAssociarFuncionarios = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciAssociarFuncionarios = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcFuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riFotoFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgAssociarFuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAssociarFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcFuncionarios);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(779, 520);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcFuncionarios
            // 
            this.gcFuncionarios.DataSource = this.bsFuncionarios;
            this.gcFuncionarios.Location = new System.Drawing.Point(5, 45);
            this.gcFuncionarios.MainView = this.gvFuncionarios;
            this.gcFuncionarios.Name = "gcFuncionarios";
            this.gcFuncionarios.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riFotoFuncionario});
            this.gcFuncionarios.Size = new System.Drawing.Size(769, 470);
            this.gcFuncionarios.TabIndex = 4;
            this.gcFuncionarios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFuncionarios});
            // 
            // bsFuncionarios
            // 
            this.bsFuncionarios.DataSource = typeof(model_beautycontrol.Model.CE.CE_Funcionario);
            // 
            // gvFuncionarios
            // 
            this.gvFuncionarios.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colfuncao,
            this.colvinculoatual,
            this.coldatanascimentoFormatada,
            this.colnome,
            this.colfoto,
            this.colid});
            this.gvFuncionarios.GridControl = this.gcFuncionarios;
            this.gvFuncionarios.Name = "gvFuncionarios";
            this.gvFuncionarios.OptionsView.ShowAutoFilterRow = true;
            this.gvFuncionarios.OptionsView.ShowGroupPanel = false;
            // 
            // colfuncao
            // 
            this.colfuncao.AppearanceCell.Options.UseTextOptions = true;
            this.colfuncao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colfuncao.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colfuncao.AppearanceHeader.Options.UseFont = true;
            this.colfuncao.AppearanceHeader.Options.UseTextOptions = true;
            this.colfuncao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colfuncao.Caption = "Função Principal";
            this.colfuncao.FieldName = "funcao.nome";
            this.colfuncao.Name = "colfuncao";
            this.colfuncao.OptionsColumn.AllowEdit = false;
            this.colfuncao.Visible = true;
            this.colfuncao.VisibleIndex = 5;
            // 
            // colvinculoatual
            // 
            this.colvinculoatual.AppearanceCell.Options.UseTextOptions = true;
            this.colvinculoatual.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colvinculoatual.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colvinculoatual.AppearanceHeader.Options.UseFont = true;
            this.colvinculoatual.AppearanceHeader.Options.UseTextOptions = true;
            this.colvinculoatual.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colvinculoatual.Caption = "Vínculo";
            this.colvinculoatual.FieldName = "vinculoatual.descricao";
            this.colvinculoatual.Name = "colvinculoatual";
            this.colvinculoatual.OptionsColumn.AllowEdit = false;
            this.colvinculoatual.Visible = true;
            this.colvinculoatual.VisibleIndex = 4;
            // 
            // coldatanascimentoFormatada
            // 
            this.coldatanascimentoFormatada.AppearanceCell.Options.UseTextOptions = true;
            this.coldatanascimentoFormatada.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatanascimentoFormatada.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.coldatanascimentoFormatada.AppearanceHeader.Options.UseFont = true;
            this.coldatanascimentoFormatada.AppearanceHeader.Options.UseTextOptions = true;
            this.coldatanascimentoFormatada.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatanascimentoFormatada.Caption = "Data Nascimento";
            this.coldatanascimentoFormatada.FieldName = "datanascimentoFormatada";
            this.coldatanascimentoFormatada.Name = "coldatanascimentoFormatada";
            this.coldatanascimentoFormatada.OptionsColumn.AllowEdit = false;
            this.coldatanascimentoFormatada.OptionsColumn.ReadOnly = true;
            this.coldatanascimentoFormatada.Visible = true;
            this.coldatanascimentoFormatada.VisibleIndex = 3;
            // 
            // colnome
            // 
            this.colnome.AppearanceCell.Options.UseTextOptions = true;
            this.colnome.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colnome.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colnome.AppearanceHeader.Options.UseFont = true;
            this.colnome.AppearanceHeader.Options.UseTextOptions = true;
            this.colnome.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colnome.Caption = "Nome";
            this.colnome.FieldName = "nome";
            this.colnome.Name = "colnome";
            this.colnome.OptionsColumn.AllowEdit = false;
            this.colnome.Visible = true;
            this.colnome.VisibleIndex = 2;
            // 
            // colfoto
            // 
            this.colfoto.AppearanceCell.Options.UseTextOptions = true;
            this.colfoto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colfoto.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colfoto.AppearanceHeader.Options.UseFont = true;
            this.colfoto.AppearanceHeader.Options.UseTextOptions = true;
            this.colfoto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colfoto.Caption = "Foto";
            this.colfoto.ColumnEdit = this.riFotoFuncionario;
            this.colfoto.FieldName = "foto";
            this.colfoto.Name = "colfoto";
            this.colfoto.Visible = true;
            this.colfoto.VisibleIndex = 0;
            // 
            // riFotoFuncionario
            // 
            this.riFotoFuncionario.AutoHeight = false;
            this.riFotoFuncionario.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riFotoFuncionario.Name = "riFotoFuncionario";
            this.riFotoFuncionario.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            // 
            // colid
            // 
            this.colid.AppearanceCell.Options.UseTextOptions = true;
            this.colid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colid.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colid.AppearanceHeader.Options.UseFont = true;
            this.colid.AppearanceHeader.Options.UseTextOptions = true;
            this.colid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colid.Caption = "Registro";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 1;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgAssociarFuncionarios});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(779, 520);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lcgAssociarFuncionarios
            // 
            this.lcgAssociarFuncionarios.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lcgAssociarFuncionarios.AppearanceGroup.ForeColor = System.Drawing.Color.Black;
            this.lcgAssociarFuncionarios.AppearanceGroup.Options.UseFont = true;
            this.lcgAssociarFuncionarios.AppearanceGroup.Options.UseForeColor = true;
            this.lcgAssociarFuncionarios.CaptionImage = ((System.Drawing.Image)(resources.GetObject("lcgAssociarFuncionarios.CaptionImage")));
            this.lcgAssociarFuncionarios.ContentImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            toolTipTitleItem1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            toolTipTitleItem1.Appearance.Options.UseImage = true;
            toolTipTitleItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem1.Image")));
            toolTipTitleItem1.Text = "\r\nVoltar para tela de usuários";
            superToolTip1.Items.Add(toolTipTitleItem1);
            toolTipTitleItem2.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            toolTipTitleItem2.Appearance.Options.UseImage = true;
            toolTipTitleItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem2.Image")));
            toolTipTitleItem2.Text = "Criar um usuário para o funncionário selecionado";
            superToolTip2.Items.Add(toolTipTitleItem2);
            this.lcgAssociarFuncionarios.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Voltar", ((System.Drawing.Image)(resources.GetObject("lcgAssociarFuncionarios.CustomHeaderButtons"))), -1, DevExpress.XtraEditors.ButtonPanel.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", true, -1, true, superToolTip1, true, false, true, null, null, -1),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Associar", ((System.Drawing.Image)(resources.GetObject("lcgAssociarFuncionarios.CustomHeaderButtons1"))), -1, DevExpress.XtraEditors.ButtonPanel.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", true, -1, true, superToolTip2, true, false, true, null, null, -1)});
            this.lcgAssociarFuncionarios.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.lcgAssociarFuncionarios.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciAssociarFuncionarios});
            this.lcgAssociarFuncionarios.Location = new System.Drawing.Point(0, 0);
            this.lcgAssociarFuncionarios.Name = "lcgAssociarFuncionarios";
            this.lcgAssociarFuncionarios.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgAssociarFuncionarios.Size = new System.Drawing.Size(779, 520);
            this.lcgAssociarFuncionarios.Text = "Funcionários disponíveis : Escolha um funcionário para adicionar usuário";
            this.lcgAssociarFuncionarios.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.lcgAssociarFuncionarios_CustomButtonClick);
            // 
            // lciAssociarFuncionarios
            // 
            this.lciAssociarFuncionarios.Control = this.gcFuncionarios;
            this.lciAssociarFuncionarios.Location = new System.Drawing.Point(0, 0);
            this.lciAssociarFuncionarios.Name = "lciAssociarFuncionarios";
            this.lciAssociarFuncionarios.Size = new System.Drawing.Size(773, 474);
            this.lciAssociarFuncionarios.TextSize = new System.Drawing.Size(0, 0);
            this.lciAssociarFuncionarios.TextVisible = false;
            // 
            // UC_Funcionario_AssociarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "UC_Funcionario_AssociarUsuario";
            this.Size = new System.Drawing.Size(779, 520);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcFuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riFotoFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgAssociarFuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAssociarFuncionarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gcFuncionarios;
        private DevExpress.XtraGrid.Views.Grid.GridView gvFuncionarios;
        private DevExpress.XtraLayout.LayoutControlGroup lcgAssociarFuncionarios;
        private DevExpress.XtraLayout.LayoutControlItem lciAssociarFuncionarios;
        private System.Windows.Forms.BindingSource bsFuncionarios;
        private DevExpress.XtraGrid.Columns.GridColumn colfuncao;
        private DevExpress.XtraGrid.Columns.GridColumn colvinculoatual;
        private DevExpress.XtraGrid.Columns.GridColumn coldatanascimentoFormatada;
        private DevExpress.XtraGrid.Columns.GridColumn colnome;
        private DevExpress.XtraGrid.Columns.GridColumn colfoto;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit riFotoFuncionario;
    }
}
