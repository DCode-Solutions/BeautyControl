namespace BeautyControl.View.UCViews
{
    partial class UC_Funcionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Funcionarios));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gcProfissionais = new DevExpress.XtraGrid.GridControl();
            this.bsProfissionais = new System.Windows.Forms.BindingSource(this.components);
            this.gvProfissionais = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colfoto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riImgFotoProfissional = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataNascimentoFun = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvinculoatual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfuncao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riPicImgFoto = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgProfissionais = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciProfissionais = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcProfissionais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProfissionais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProfissionais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riImgFotoProfissional)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riPicImgFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgProfissionais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciProfissionais)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcProfissionais);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(850, 550);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcProfissionais
            // 
            this.gcProfissionais.DataSource = this.bsProfissionais;
            this.gcProfissionais.Location = new System.Drawing.Point(9, 43);
            this.gcProfissionais.MainView = this.gvProfissionais;
            this.gcProfissionais.Name = "gcProfissionais";
            this.gcProfissionais.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riImgFotoProfissional,
            this.riPicImgFoto});
            this.gcProfissionais.Size = new System.Drawing.Size(832, 498);
            this.gcProfissionais.TabIndex = 4;
            this.gcProfissionais.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProfissionais});
            // 
            // bsProfissionais
            // 
            this.bsProfissionais.DataSource = typeof(model_beautycontrol.Model.CE.CE_Funcionario);
            // 
            // gvProfissionais
            // 
            this.gvProfissionais.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colfoto,
            this.colid,
            this.colnome,
            this.colDataNascimentoFun,
            this.colvinculoatual,
            this.colfuncao});
            this.gvProfissionais.GridControl = this.gcProfissionais;
            this.gvProfissionais.Name = "gvProfissionais";
            this.gvProfissionais.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvProfissionais.OptionsView.ShowGroupPanel = false;
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
            this.colfoto.ColumnEdit = this.riImgFotoProfissional;
            this.colfoto.FieldName = "foto";
            this.colfoto.Name = "colfoto";
            this.colfoto.Visible = true;
            this.colfoto.VisibleIndex = 5;
            // 
            // riImgFotoProfissional
            // 
            this.riImgFotoProfissional.AutoHeight = false;
            this.riImgFotoProfissional.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riImgFotoProfissional.Name = "riImgFotoProfissional";
            this.riImgFotoProfissional.ShowMenu = false;
            this.riImgFotoProfissional.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
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
            this.colid.VisibleIndex = 0;
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
            this.colnome.VisibleIndex = 1;
            // 
            // colDataNascimentoFun
            // 
            this.colDataNascimentoFun.AppearanceCell.Options.UseTextOptions = true;
            this.colDataNascimentoFun.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDataNascimentoFun.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colDataNascimentoFun.AppearanceHeader.Options.UseFont = true;
            this.colDataNascimentoFun.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataNascimentoFun.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDataNascimentoFun.Caption = "Data Nascimento";
            this.colDataNascimentoFun.FieldName = "datanascimentoFormatada";
            this.colDataNascimentoFun.Name = "colDataNascimentoFun";
            this.colDataNascimentoFun.OptionsColumn.AllowEdit = false;
            this.colDataNascimentoFun.Visible = true;
            this.colDataNascimentoFun.VisibleIndex = 2;
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
            this.colfuncao.VisibleIndex = 3;
            // 
            // riPicImgFoto
            // 
            this.riPicImgFoto.Name = "riPicImgFoto";
            this.riPicImgFoto.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgProfissionais});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup1.Size = new System.Drawing.Size(850, 550);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lcgProfissionais
            // 
            this.lcgProfissionais.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lcgProfissionais.AppearanceGroup.Options.UseFont = true;
            this.lcgProfissionais.CaptionImage = ((System.Drawing.Image)(resources.GetObject("lcgProfissionais.CaptionImage")));
            this.lcgProfissionais.ContentImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            toolTipTitleItem1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            toolTipTitleItem1.Appearance.Options.UseImage = true;
            toolTipTitleItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem1.Image")));
            toolTipTitleItem1.Text = "\r\nCadastrar novo profissional";
            superToolTip1.Items.Add(toolTipTitleItem1);
            toolTipTitleItem2.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            toolTipTitleItem2.Appearance.Options.UseImage = true;
            toolTipTitleItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem2.Image")));
            toolTipTitleItem2.Text = "\r\nAlterar dados do profissional";
            superToolTip2.Items.Add(toolTipTitleItem2);
            toolTipTitleItem3.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            toolTipTitleItem3.Appearance.Options.UseImage = true;
            toolTipTitleItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem3.Image")));
            toolTipTitleItem3.Text = "\r\nAssociar funções ao funcionário";
            superToolTip3.Items.Add(toolTipTitleItem3);
            this.lcgProfissionais.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Novo", ((System.Drawing.Image)(resources.GetObject("lcgProfissionais.CustomHeaderButtons"))), -1, DevExpress.XtraEditors.ButtonPanel.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", true, -1, true, superToolTip1, true, false, true, null, null, -1),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Alterar", ((System.Drawing.Image)(resources.GetObject("lcgProfissionais.CustomHeaderButtons1"))), -1, DevExpress.XtraEditors.ButtonPanel.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", true, -1, true, superToolTip2, true, false, true, null, null, -1),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Função", ((System.Drawing.Image)(resources.GetObject("lcgProfissionais.CustomHeaderButtons2"))), -1, DevExpress.XtraEditors.ButtonPanel.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", true, -1, true, superToolTip3, true, false, true, null, null, -1)});
            this.lcgProfissionais.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.lcgProfissionais.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciProfissionais});
            this.lcgProfissionais.Location = new System.Drawing.Point(0, 0);
            this.lcgProfissionais.Name = "lcgProfissionais";
            this.lcgProfissionais.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.lcgProfissionais.Size = new System.Drawing.Size(846, 546);
            this.lcgProfissionais.Text = "Profissionais";
            this.lcgProfissionais.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.lcgProfissionais_CustomButtonClick);
            // 
            // lciProfissionais
            // 
            this.lciProfissionais.Control = this.gcProfissionais;
            this.lciProfissionais.Location = new System.Drawing.Point(0, 0);
            this.lciProfissionais.Name = "lciProfissionais";
            this.lciProfissionais.Size = new System.Drawing.Size(836, 502);
            this.lciProfissionais.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciProfissionais.TextSize = new System.Drawing.Size(0, 0);
            this.lciProfissionais.TextVisible = false;
            // 
            // UC_Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "UC_Funcionarios";
            this.Size = new System.Drawing.Size(850, 550);
            this.Load += new System.EventHandler(this.UC_Funcionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcProfissionais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProfissionais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProfissionais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riImgFotoProfissional)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riPicImgFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgProfissionais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciProfissionais)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gcProfissionais;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProfissionais;
        private DevExpress.XtraLayout.LayoutControlGroup lcgProfissionais;
        private DevExpress.XtraLayout.LayoutControlItem lciProfissionais;
        private System.Windows.Forms.BindingSource bsProfissionais;
        private DevExpress.XtraGrid.Columns.GridColumn colfoto;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colnome;
        private DevExpress.XtraGrid.Columns.GridColumn colvinculoatual;
        private DevExpress.XtraGrid.Columns.GridColumn colfuncao;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit riImgFotoProfissional;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit riPicImgFoto;
        private DevExpress.XtraGrid.Columns.GridColumn colDataNascimentoFun;
    }
}
