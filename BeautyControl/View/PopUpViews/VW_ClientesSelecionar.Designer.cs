namespace BeautyControl.View.PopUpViews
{
    partial class VW_ClientesSelecionar
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VW_ClientesSelecionar));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            this.grcClientes = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gcClientes = new DevExpress.XtraGrid.GridControl();
            this.bsCliente = new System.Windows.Forms.BindingSource(this.components);
            this.gvClientes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldatanascimentoFormatada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciClientes = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.grcClientes)).BeginInit();
            this.grcClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // grcClientes
            // 
            this.grcClientes.AllowBorderColorBlending = true;
            this.grcClientes.Appearance.BorderColor = System.Drawing.Color.Crimson;
            this.grcClientes.Appearance.Options.UseBorderColor = true;
            this.grcClientes.AppearanceCaption.BorderColor = System.Drawing.Color.Crimson;
            this.grcClientes.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.grcClientes.AppearanceCaption.ForeColor = System.Drawing.Color.White;
            this.grcClientes.AppearanceCaption.Options.UseBorderColor = true;
            this.grcClientes.AppearanceCaption.Options.UseFont = true;
            this.grcClientes.AppearanceCaption.Options.UseForeColor = true;
            this.grcClientes.CaptionImage = ((System.Drawing.Image)(resources.GetObject("grcClientes.CaptionImage")));
            this.grcClientes.Controls.Add(this.layoutControl1);
            toolTipTitleItem1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            toolTipTitleItem1.Appearance.Options.UseImage = true;
            toolTipTitleItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem1.Image")));
            toolTipTitleItem1.Text = "\r\nCadastrar novo cliente";
            superToolTip1.Items.Add(toolTipTitleItem1);
            toolTipTitleItem2.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            toolTipTitleItem2.Appearance.Options.UseImage = true;
            toolTipTitleItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem2.Image")));
            toolTipTitleItem2.Text = "Adiciona o cliente selecionado para a venda";
            superToolTip2.Items.Add(toolTipTitleItem2);
            toolTipTitleItem3.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            toolTipTitleItem3.Appearance.Options.UseImage = true;
            toolTipTitleItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem3.Image")));
            toolTipTitleItem3.Text = "Voltar para tela anterior";
            superToolTip3.Items.Add(toolTipTitleItem3);
            this.grcClientes.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Novo", ((System.Drawing.Image)(resources.GetObject("grcClientes.CustomHeaderButtons"))), -1, DevExpress.XtraEditors.ButtonPanel.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", false, -1, true, superToolTip1, true, false, true, null, null, -1),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Adicionar", ((System.Drawing.Image)(resources.GetObject("grcClientes.CustomHeaderButtons1"))), -1, DevExpress.XtraEditors.ButtonPanel.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", true, -1, true, superToolTip2, true, false, false, null, null, -1),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Voltar", ((System.Drawing.Image)(resources.GetObject("grcClientes.CustomHeaderButtons2"))), -1, DevExpress.XtraEditors.ButtonPanel.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", false, -1, true, superToolTip3, true, false, true, null, null, -1)});
            this.grcClientes.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.grcClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcClientes.Location = new System.Drawing.Point(0, 0);
            this.grcClientes.Name = "grcClientes";
            this.grcClientes.Size = new System.Drawing.Size(580, 316);
            this.grcClientes.TabIndex = 0;
            this.grcClientes.Text = "Clientes";
            this.grcClientes.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.grcClientes_CustomButtonClick);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcClientes);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 33);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(576, 281);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcClientes
            // 
            this.gcClientes.DataSource = this.bsCliente;
            this.gcClientes.Location = new System.Drawing.Point(4, 4);
            this.gcClientes.MainView = this.gvClientes;
            this.gcClientes.Name = "gcClientes";
            this.gcClientes.Size = new System.Drawing.Size(568, 273);
            this.gcClientes.TabIndex = 4;
            this.gcClientes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvClientes});
            // 
            // bsCliente
            // 
            this.bsCliente.DataSource = typeof(model_beautycontrol.Model.CE.CE_Cliente);
            // 
            // gvClientes
            // 
            this.gvClientes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnome,
            this.colfones,
            this.colemail,
            this.coldatanascimentoFormatada});
            this.gvClientes.GridControl = this.gcClientes;
            this.gvClientes.Name = "gvClientes";
            this.gvClientes.OptionsBehavior.Editable = false;
            this.gvClientes.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvClientes.OptionsView.ShowAutoFilterRow = true;
            this.gvClientes.OptionsView.ShowGroupPanel = false;
            this.gvClientes.OptionsView.ShowIndicator = false;
            this.gvClientes.RowHeight = 25;
            this.gvClientes.DoubleClick += new System.EventHandler(this.gvClientes_DoubleClick);
            // 
            // colnome
            // 
            this.colnome.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.colnome.AppearanceCell.Options.UseFont = true;
            this.colnome.AppearanceCell.Options.UseTextOptions = true;
            this.colnome.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colnome.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Bold);
            this.colnome.AppearanceHeader.Options.UseFont = true;
            this.colnome.AppearanceHeader.Options.UseTextOptions = true;
            this.colnome.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colnome.Caption = "Nome";
            this.colnome.FieldName = "nome";
            this.colnome.Name = "colnome";
            this.colnome.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colnome.Visible = true;
            this.colnome.VisibleIndex = 0;
            // 
            // colfones
            // 
            this.colfones.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.colfones.AppearanceCell.Options.UseFont = true;
            this.colfones.AppearanceCell.Options.UseTextOptions = true;
            this.colfones.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colfones.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Bold);
            this.colfones.AppearanceHeader.Options.UseFont = true;
            this.colfones.AppearanceHeader.Options.UseTextOptions = true;
            this.colfones.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colfones.Caption = "Fones";
            this.colfones.FieldName = "fones";
            this.colfones.Name = "colfones";
            this.colfones.OptionsColumn.ReadOnly = true;
            this.colfones.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colfones.Visible = true;
            this.colfones.VisibleIndex = 1;
            // 
            // colemail
            // 
            this.colemail.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.colemail.AppearanceCell.Options.UseFont = true;
            this.colemail.AppearanceCell.Options.UseTextOptions = true;
            this.colemail.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colemail.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Bold);
            this.colemail.AppearanceHeader.Options.UseFont = true;
            this.colemail.AppearanceHeader.Options.UseTextOptions = true;
            this.colemail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colemail.Caption = "Email";
            this.colemail.FieldName = "email";
            this.colemail.Name = "colemail";
            this.colemail.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colemail.Visible = true;
            this.colemail.VisibleIndex = 2;
            // 
            // coldatanascimentoFormatada
            // 
            this.coldatanascimentoFormatada.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.coldatanascimentoFormatada.AppearanceCell.Options.UseFont = true;
            this.coldatanascimentoFormatada.AppearanceCell.Options.UseTextOptions = true;
            this.coldatanascimentoFormatada.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.coldatanascimentoFormatada.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Bold);
            this.coldatanascimentoFormatada.AppearanceHeader.Options.UseFont = true;
            this.coldatanascimentoFormatada.AppearanceHeader.Options.UseTextOptions = true;
            this.coldatanascimentoFormatada.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.coldatanascimentoFormatada.Caption = "Data Nascimento";
            this.coldatanascimentoFormatada.FieldName = "datanascimentoFormatada";
            this.coldatanascimentoFormatada.Name = "coldatanascimentoFormatada";
            this.coldatanascimentoFormatada.OptionsColumn.ReadOnly = true;
            this.coldatanascimentoFormatada.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciClientes});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup1.Size = new System.Drawing.Size(576, 281);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciClientes
            // 
            this.lciClientes.Control = this.gcClientes;
            this.lciClientes.Location = new System.Drawing.Point(0, 0);
            this.lciClientes.Name = "lciClientes";
            this.lciClientes.Size = new System.Drawing.Size(572, 277);
            this.lciClientes.TextSize = new System.Drawing.Size(0, 0);
            this.lciClientes.TextVisible = false;
            // 
            // VW_ClientesSelecionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 316);
            this.ControlBox = false;
            this.Controls.Add(this.grcClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VW_ClientesSelecionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VW_ClientesSelecionar";
            ((System.ComponentModel.ISupportInitialize)(this.grcClientes)).EndInit();
            this.grcClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grcClientes;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gcClientes;
        private System.Windows.Forms.BindingSource bsCliente;
        private DevExpress.XtraGrid.Views.Grid.GridView gvClientes;
        private DevExpress.XtraGrid.Columns.GridColumn colnome;
        private DevExpress.XtraGrid.Columns.GridColumn colfones;
        private DevExpress.XtraGrid.Columns.GridColumn colemail;
        private DevExpress.XtraGrid.Columns.GridColumn coldatanascimentoFormatada;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem lciClientes;
    }
}