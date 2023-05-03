namespace BeautyControl.View.UCViews
{
    partial class UC_Servicos_Produtos
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Servicos_Produtos));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gcProdutos = new DevExpress.XtraGrid.GridControl();
            this.bsProduto_Preco = new System.Windows.Forms.BindingSource(this.components);
            this.gvProdutos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colpreco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPromocao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colCategoriaNome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgProdutos = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciProdutos = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduto_Preco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcProdutos);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(834, 638);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcProdutos
            // 
            this.gcProdutos.DataSource = this.bsProduto_Preco;
            this.gcProdutos.Location = new System.Drawing.Point(24, 58);
            this.gcProdutos.MainView = this.gvProdutos;
            this.gcProdutos.Name = "gcProdutos";
            this.gcProdutos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.gcProdutos.Size = new System.Drawing.Size(786, 556);
            this.gcProdutos.TabIndex = 4;
            this.gcProdutos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProdutos});
            // 
            // bsProduto_Preco
            // 
            this.bsProduto_Preco.DataSource = typeof(model_beautycontrol.Model.CE.CE_Preco);
            // 
            // gvProdutos
            // 
            this.gvProdutos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colpreco,
            this.colProduto,
            this.colDescricao,
            this.colCodigo,
            this.colPromocao,
            this.colCategoriaNome});
            this.gvProdutos.GridControl = this.gcProdutos;
            this.gvProdutos.GroupCount = 1;
            this.gvProdutos.Name = "gvProdutos";
            this.gvProdutos.OptionsBehavior.AutoExpandAllGroups = true;
            this.gvProdutos.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvProdutos.OptionsView.ShowAutoFilterRow = true;
            this.gvProdutos.OptionsView.ShowGroupPanel = false;
            this.gvProdutos.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCategoriaNome, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colpreco
            // 
            this.colpreco.AppearanceCell.Options.UseTextOptions = true;
            this.colpreco.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colpreco.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colpreco.AppearanceHeader.Options.UseFont = true;
            this.colpreco.AppearanceHeader.Options.UseTextOptions = true;
            this.colpreco.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colpreco.Caption = "Preço";
            this.colpreco.DisplayFormat.FormatString = "N2";
            this.colpreco.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colpreco.FieldName = "preco";
            this.colpreco.Name = "colpreco";
            this.colpreco.OptionsColumn.AllowEdit = false;
            this.colpreco.Visible = true;
            this.colpreco.VisibleIndex = 2;
            // 
            // colProduto
            // 
            this.colProduto.AppearanceCell.Options.UseTextOptions = true;
            this.colProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colProduto.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colProduto.AppearanceHeader.Options.UseFont = true;
            this.colProduto.AppearanceHeader.Options.UseTextOptions = true;
            this.colProduto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colProduto.Caption = "Nome";
            this.colProduto.FieldName = "Produto.nome";
            this.colProduto.Name = "colProduto";
            this.colProduto.OptionsColumn.AllowEdit = false;
            this.colProduto.Visible = true;
            this.colProduto.VisibleIndex = 1;
            // 
            // colDescricao
            // 
            this.colDescricao.AppearanceCell.Options.UseTextOptions = true;
            this.colDescricao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDescricao.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colDescricao.AppearanceHeader.Options.UseFont = true;
            this.colDescricao.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescricao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDescricao.Caption = "Descrição";
            this.colDescricao.FieldName = "Produto.descricao";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.OptionsColumn.AllowEdit = false;
            this.colDescricao.Visible = true;
            this.colDescricao.VisibleIndex = 3;
            // 
            // colCodigo
            // 
            this.colCodigo.AppearanceCell.Options.UseTextOptions = true;
            this.colCodigo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCodigo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colCodigo.AppearanceHeader.Options.UseFont = true;
            this.colCodigo.AppearanceHeader.Options.UseTextOptions = true;
            this.colCodigo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCodigo.Caption = "Código";
            this.colCodigo.FieldName = "Produto.id";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.OptionsColumn.AllowEdit = false;
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 0;
            // 
            // colPromocao
            // 
            this.colPromocao.AppearanceCell.Options.UseTextOptions = true;
            this.colPromocao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPromocao.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colPromocao.AppearanceHeader.Options.UseFont = true;
            this.colPromocao.AppearanceHeader.Options.UseTextOptions = true;
            this.colPromocao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPromocao.Caption = "Promoção";
            this.colPromocao.ColumnEdit = this.repositoryItemButtonEdit1;
            this.colPromocao.Name = "colPromocao";
            this.colPromocao.Visible = true;
            this.colPromocao.VisibleIndex = 4;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            toolTipTitleItem1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            toolTipTitleItem1.Appearance.Options.UseImage = true;
            toolTipTitleItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem1.Image")));
            toolTipTitleItem1.Text = "\r\nCriar um preço para um determinado período";
            superToolTip1.Items.Add(toolTipTitleItem1);
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("repositoryItemButtonEdit1.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, superToolTip1, true)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit1.Click += new System.EventHandler(this.repositoryItemButtonEdit1_Click);
            // 
            // colCategoriaNome
            // 
            this.colCategoriaNome.AppearanceCell.Options.UseTextOptions = true;
            this.colCategoriaNome.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCategoriaNome.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colCategoriaNome.AppearanceHeader.Options.UseFont = true;
            this.colCategoriaNome.AppearanceHeader.Options.UseTextOptions = true;
            this.colCategoriaNome.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCategoriaNome.Caption = "Categoria";
            this.colCategoriaNome.FieldName = "Produto.Categoria.nome";
            this.colCategoriaNome.Name = "colCategoriaNome";
            this.colCategoriaNome.OptionsColumn.AllowEdit = false;
            this.colCategoriaNome.Visible = true;
            this.colCategoriaNome.VisibleIndex = 1;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgProdutos});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(834, 638);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lcgProdutos
            // 
            this.lcgProdutos.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lcgProdutos.AppearanceGroup.Options.UseFont = true;
            this.lcgProdutos.CaptionImage = ((System.Drawing.Image)(resources.GetObject("lcgProdutos.CaptionImage")));
            toolTipTitleItem2.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            toolTipTitleItem2.Appearance.Options.UseImage = true;
            toolTipTitleItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem2.Image")));
            toolTipTitleItem2.Text = "\r\nCadastrar novo produto/serviço";
            superToolTip2.Items.Add(toolTipTitleItem2);
            toolTipTitleItem3.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            toolTipTitleItem3.Appearance.Options.UseImage = true;
            toolTipTitleItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem3.Image")));
            toolTipTitleItem3.Text = "\r\nAlterar dados do produto/serviço";
            superToolTip3.Items.Add(toolTipTitleItem3);
            this.lcgProdutos.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Novo", ((System.Drawing.Image)(resources.GetObject("lcgProdutos.CustomHeaderButtons"))), -1, DevExpress.XtraEditors.ButtonPanel.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", true, -1, true, superToolTip2, true, false, true, null, null, -1),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Alterar", ((System.Drawing.Image)(resources.GetObject("lcgProdutos.CustomHeaderButtons1"))), -1, DevExpress.XtraEditors.ButtonPanel.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", true, -1, true, superToolTip3, true, false, true, null, null, -1)});
            this.lcgProdutos.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.lcgProdutos.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciProdutos});
            this.lcgProdutos.Location = new System.Drawing.Point(0, 0);
            this.lcgProdutos.Name = "lcgProdutos";
            this.lcgProdutos.Size = new System.Drawing.Size(814, 618);
            this.lcgProdutos.Text = "Serviços e produtos";
            this.lcgProdutos.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.lcgProdutos_CustomButtonClick);
            // 
            // lciProdutos
            // 
            this.lciProdutos.Control = this.gcProdutos;
            this.lciProdutos.Location = new System.Drawing.Point(0, 0);
            this.lciProdutos.Name = "lciProdutos";
            this.lciProdutos.Size = new System.Drawing.Size(790, 560);
            this.lciProdutos.TextSize = new System.Drawing.Size(0, 0);
            this.lciProdutos.TextVisible = false;
            // 
            // UC_Servicos_Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "UC_Servicos_Produtos";
            this.Size = new System.Drawing.Size(834, 638);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduto_Preco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gcProdutos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProdutos;
        private DevExpress.XtraLayout.LayoutControlGroup lcgProdutos;
        private DevExpress.XtraLayout.LayoutControlItem lciProdutos;
        private System.Windows.Forms.BindingSource bsProduto_Preco;
        private DevExpress.XtraGrid.Columns.GridColumn colpreco;
        private DevExpress.XtraGrid.Columns.GridColumn colProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colDescricao;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colPromocao;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoriaNome;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
    }
}
