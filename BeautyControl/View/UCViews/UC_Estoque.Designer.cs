namespace BeautyControl.View.UCViews
{
    partial class UC_Estoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Estoque));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gcMovimentacao = new DevExpress.XtraGrid.GridControl();
            this.bsMovimentacao = new System.Windows.Forms.BindingSource(this.components);
            this.gvMovimentacao = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldatamovimentacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colquantidade1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcustounit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coliscompraefetuada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoMovimentacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResponsavel_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcEstoque = new DevExpress.XtraGrid.GridControl();
            this.bsEstoque = new System.Windows.Forms.BindingSource(this.components);
            this.gvEstoque = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_produto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colquantidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgEstoque = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciGCMovimentacao = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciGCEstoque = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMovimentacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMovimentacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMovimentacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGCMovimentacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGCEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcMovimentacao);
            this.layoutControl1.Controls.Add(this.gcEstoque);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(804, 521);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcMovimentacao
            // 
            this.gcMovimentacao.DataSource = this.bsMovimentacao;
            this.gcMovimentacao.Location = new System.Drawing.Point(336, 43);
            this.gcMovimentacao.MainView = this.gvMovimentacao;
            this.gcMovimentacao.Name = "gcMovimentacao";
            this.gcMovimentacao.Size = new System.Drawing.Size(459, 469);
            this.gcMovimentacao.TabIndex = 5;
            this.gcMovimentacao.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMovimentacao});
            // 
            // bsMovimentacao
            // 
            this.bsMovimentacao.DataSource = typeof(model_beautycontrol.Model.CE.CE_Movimentacao01);
            // 
            // gvMovimentacao
            // 
            this.gvMovimentacao.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldatamovimentacao,
            this.colquantidade1,
            this.colcustounit,
            this.coliscompraefetuada,
            this.colTipoMovimentacao,
            this.colResponsavel_});
            this.gvMovimentacao.GridControl = this.gcMovimentacao;
            this.gvMovimentacao.Name = "gvMovimentacao";
            this.gvMovimentacao.OptionsBehavior.Editable = false;
            this.gvMovimentacao.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvMovimentacao.OptionsView.ShowAutoFilterRow = true;
            this.gvMovimentacao.OptionsView.ShowGroupPanel = false;
            this.gvMovimentacao.OptionsView.ShowIndicator = false;
            this.gvMovimentacao.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvMovimentacao_RowCellStyle);
            this.gvMovimentacao.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gvMovimentacao_RowStyle);
            // 
            // coldatamovimentacao
            // 
            this.coldatamovimentacao.AppearanceCell.Options.UseTextOptions = true;
            this.coldatamovimentacao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatamovimentacao.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.coldatamovimentacao.AppearanceHeader.Options.UseFont = true;
            this.coldatamovimentacao.AppearanceHeader.Options.UseTextOptions = true;
            this.coldatamovimentacao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatamovimentacao.Caption = "Data";
            this.coldatamovimentacao.FieldName = "dataMovimentacaoFormatada";
            this.coldatamovimentacao.Name = "coldatamovimentacao";
            this.coldatamovimentacao.Visible = true;
            this.coldatamovimentacao.VisibleIndex = 0;
            this.coldatamovimentacao.Width = 218;
            // 
            // colquantidade1
            // 
            this.colquantidade1.AppearanceCell.Options.UseTextOptions = true;
            this.colquantidade1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colquantidade1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colquantidade1.AppearanceHeader.Options.UseFont = true;
            this.colquantidade1.AppearanceHeader.Options.UseTextOptions = true;
            this.colquantidade1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colquantidade1.Caption = "Qtd";
            this.colquantidade1.FieldName = "quantidade";
            this.colquantidade1.Name = "colquantidade1";
            this.colquantidade1.Visible = true;
            this.colquantidade1.VisibleIndex = 2;
            this.colquantidade1.Width = 64;
            // 
            // colcustounit
            // 
            this.colcustounit.AppearanceCell.Options.UseTextOptions = true;
            this.colcustounit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colcustounit.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colcustounit.AppearanceHeader.Options.UseFont = true;
            this.colcustounit.AppearanceHeader.Options.UseTextOptions = true;
            this.colcustounit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colcustounit.Caption = "Custo";
            this.colcustounit.FieldName = "custounit";
            this.colcustounit.Name = "colcustounit";
            this.colcustounit.Visible = true;
            this.colcustounit.VisibleIndex = 3;
            this.colcustounit.Width = 105;
            // 
            // coliscompraefetuada
            // 
            this.coliscompraefetuada.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.coliscompraefetuada.AppearanceHeader.Options.UseFont = true;
            this.coliscompraefetuada.FieldName = "iscompraefetuada";
            this.coliscompraefetuada.Name = "coliscompraefetuada";
            // 
            // colTipoMovimentacao
            // 
            this.colTipoMovimentacao.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTipoMovimentacao.AppearanceHeader.Options.UseFont = true;
            this.colTipoMovimentacao.Caption = "Tipo Movimentação";
            this.colTipoMovimentacao.FieldName = "TipoMovimentacao.descricao";
            this.colTipoMovimentacao.Name = "colTipoMovimentacao";
            this.colTipoMovimentacao.Visible = true;
            this.colTipoMovimentacao.VisibleIndex = 1;
            this.colTipoMovimentacao.Width = 281;
            // 
            // colResponsavel_
            // 
            this.colResponsavel_.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colResponsavel_.AppearanceHeader.Options.UseFont = true;
            this.colResponsavel_.FieldName = "Responsavel_.nome";
            this.colResponsavel_.Name = "colResponsavel_";
            this.colResponsavel_.Visible = true;
            this.colResponsavel_.VisibleIndex = 4;
            this.colResponsavel_.Width = 426;
            // 
            // gcEstoque
            // 
            this.gcEstoque.DataSource = this.bsEstoque;
            this.gcEstoque.Location = new System.Drawing.Point(9, 43);
            this.gcEstoque.MainView = this.gvEstoque;
            this.gcEstoque.Name = "gcEstoque";
            this.gcEstoque.Size = new System.Drawing.Size(323, 469);
            this.gcEstoque.TabIndex = 4;
            this.gcEstoque.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEstoque});
            // 
            // bsEstoque
            // 
            this.bsEstoque.DataSource = typeof(model_beautycontrol.Model.CE.CE_Estoque);
            // 
            // gvEstoque
            // 
            this.gvEstoque.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_produto,
            this.colquantidade,
            this.colProduto});
            this.gvEstoque.GridControl = this.gcEstoque;
            this.gvEstoque.Name = "gvEstoque";
            this.gvEstoque.OptionsBehavior.Editable = false;
            this.gvEstoque.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvEstoque.OptionsView.ShowAutoFilterRow = true;
            this.gvEstoque.OptionsView.ShowGroupPanel = false;
            this.gvEstoque.OptionsView.ShowIndicator = false;
            this.gvEstoque.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvEstoque_FocusedRowChanged);
            // 
            // colid_produto
            // 
            this.colid_produto.AppearanceCell.Options.UseTextOptions = true;
            this.colid_produto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colid_produto.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colid_produto.AppearanceHeader.Options.UseFont = true;
            this.colid_produto.AppearanceHeader.Options.UseTextOptions = true;
            this.colid_produto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colid_produto.Caption = "Código";
            this.colid_produto.FieldName = "id_produto";
            this.colid_produto.Name = "colid_produto";
            this.colid_produto.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colid_produto.Visible = true;
            this.colid_produto.VisibleIndex = 0;
            this.colid_produto.Width = 130;
            // 
            // colquantidade
            // 
            this.colquantidade.AppearanceCell.Options.UseTextOptions = true;
            this.colquantidade.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colquantidade.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colquantidade.AppearanceHeader.Options.UseFont = true;
            this.colquantidade.AppearanceHeader.Options.UseTextOptions = true;
            this.colquantidade.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colquantidade.Caption = "Quantidade";
            this.colquantidade.FieldName = "quantidade";
            this.colquantidade.Name = "colquantidade";
            this.colquantidade.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colquantidade.Visible = true;
            this.colquantidade.VisibleIndex = 2;
            this.colquantidade.Width = 155;
            // 
            // colProduto
            // 
            this.colProduto.AppearanceCell.Options.UseTextOptions = true;
            this.colProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colProduto.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colProduto.AppearanceHeader.Options.UseFont = true;
            this.colProduto.AppearanceHeader.Options.UseTextOptions = true;
            this.colProduto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colProduto.Caption = "Produto";
            this.colProduto.FieldName = "Produto.nome";
            this.colProduto.Name = "colProduto";
            this.colProduto.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colProduto.Visible = true;
            this.colProduto.VisibleIndex = 1;
            this.colProduto.Width = 809;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgEstoque});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup1.Size = new System.Drawing.Size(804, 521);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lcgEstoque
            // 
            this.lcgEstoque.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lcgEstoque.AppearanceGroup.Options.UseFont = true;
            this.lcgEstoque.CaptionImage = ((System.Drawing.Image)(resources.GetObject("lcgEstoque.CaptionImage")));
            toolTipTitleItem1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            toolTipTitleItem1.Appearance.Options.UseImage = true;
            toolTipTitleItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem1.Image")));
            toolTipTitleItem1.Text = "Adiconar entrada no estoque";
            superToolTip1.Items.Add(toolTipTitleItem1);
            toolTipTitleItem2.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            toolTipTitleItem2.Appearance.Options.UseImage = true;
            toolTipTitleItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem2.Image")));
            toolTipTitleItem2.Text = "Decrementar do estoque";
            superToolTip2.Items.Add(toolTipTitleItem2);
            this.lcgEstoque.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Lançar Entrada/Compra", ((System.Drawing.Image)(resources.GetObject("lcgEstoque.CustomHeaderButtons"))), -1, DevExpress.XtraEditors.ButtonPanel.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", true, -1, true, superToolTip1, true, false, true, null, "entrada", -1),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Lançar Saída", ((System.Drawing.Image)(resources.GetObject("lcgEstoque.CustomHeaderButtons1"))), -1, DevExpress.XtraEditors.ButtonPanel.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", true, -1, true, superToolTip2, true, false, true, null, "saida", -1)});
            this.lcgEstoque.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.lcgEstoque.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciGCMovimentacao,
            this.lciGCEstoque});
            this.lcgEstoque.Location = new System.Drawing.Point(0, 0);
            this.lcgEstoque.Name = "lcgEstoque";
            this.lcgEstoque.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.lcgEstoque.Size = new System.Drawing.Size(800, 517);
            this.lcgEstoque.Text = "Estoque";
            this.lcgEstoque.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.lcgEstoque_CustomButtonClick);
            // 
            // lciGCMovimentacao
            // 
            this.lciGCMovimentacao.Control = this.gcMovimentacao;
            this.lciGCMovimentacao.Location = new System.Drawing.Point(327, 0);
            this.lciGCMovimentacao.Name = "lciGCMovimentacao";
            this.lciGCMovimentacao.Size = new System.Drawing.Size(463, 473);
            this.lciGCMovimentacao.TextSize = new System.Drawing.Size(0, 0);
            this.lciGCMovimentacao.TextVisible = false;
            // 
            // lciGCEstoque
            // 
            this.lciGCEstoque.Control = this.gcEstoque;
            this.lciGCEstoque.Location = new System.Drawing.Point(0, 0);
            this.lciGCEstoque.Name = "lciGCEstoque";
            this.lciGCEstoque.Size = new System.Drawing.Size(327, 473);
            this.lciGCEstoque.TextSize = new System.Drawing.Size(0, 0);
            this.lciGCEstoque.TextVisible = false;
            // 
            // UC_Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "UC_Estoque";
            this.Size = new System.Drawing.Size(804, 521);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcMovimentacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMovimentacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMovimentacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGCMovimentacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGCEstoque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gcMovimentacao;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMovimentacao;
        private DevExpress.XtraGrid.GridControl gcEstoque;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEstoque;
        private DevExpress.XtraLayout.LayoutControlGroup lcgEstoque;
        private DevExpress.XtraLayout.LayoutControlItem lciGCMovimentacao;
        private DevExpress.XtraLayout.LayoutControlItem lciGCEstoque;
        private System.Windows.Forms.BindingSource bsEstoque;
        private DevExpress.XtraGrid.Columns.GridColumn colid_produto;
        private DevExpress.XtraGrid.Columns.GridColumn colquantidade;
        private DevExpress.XtraGrid.Columns.GridColumn colProduto;
        private System.Windows.Forms.BindingSource bsMovimentacao;
        private DevExpress.XtraGrid.Columns.GridColumn coldatamovimentacao;
        private DevExpress.XtraGrid.Columns.GridColumn colquantidade1;
        private DevExpress.XtraGrid.Columns.GridColumn colcustounit;
        private DevExpress.XtraGrid.Columns.GridColumn coliscompraefetuada;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoMovimentacao;
        private DevExpress.XtraGrid.Columns.GridColumn colResponsavel_;
    }
}
