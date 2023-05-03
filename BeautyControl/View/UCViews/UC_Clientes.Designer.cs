namespace BeautyControl.View.UCViews
{
    partial class UC_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Clientes));
            this.grcCliente = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gcClientes = new DevExpress.XtraGrid.GridControl();
            this.bsClientes = new System.Windows.Forms.BindingSource(this.components);
            this.gvClientes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciGridClientes = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.grcCliente)).BeginInit();
            this.grcCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // grcCliente
            // 
            this.grcCliente.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grcCliente.AppearanceCaption.Options.UseFont = true;
            this.grcCliente.CaptionImage = ((System.Drawing.Image)(resources.GetObject("grcCliente.CaptionImage")));
            this.grcCliente.CaptionImageLocation = DevExpress.Utils.GroupElementLocation.BeforeText;
            this.grcCliente.Controls.Add(this.layoutControl1);
            this.grcCliente.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Novo", ((System.Drawing.Image)(resources.GetObject("grcCliente.CustomHeaderButtons")))),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Alterar", ((System.Drawing.Image)(resources.GetObject("grcCliente.CustomHeaderButtons1"))))});
            this.grcCliente.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.grcCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcCliente.Location = new System.Drawing.Point(0, 0);
            this.grcCliente.Name = "grcCliente";
            this.grcCliente.Size = new System.Drawing.Size(621, 439);
            this.grcCliente.TabIndex = 0;
            this.grcCliente.Text = "Clientes";
            this.grcCliente.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.grcCliente_CustomButtonClick);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcClientes);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 33);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(617, 404);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcClientes
            // 
            this.gcClientes.DataSource = this.bsClientes;
            this.gcClientes.Location = new System.Drawing.Point(12, 12);
            this.gcClientes.MainView = this.gvClientes;
            this.gcClientes.Name = "gcClientes";
            this.gcClientes.Size = new System.Drawing.Size(593, 380);
            this.gcClientes.TabIndex = 4;
            this.gcClientes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvClientes});
            // 
            // bsClientes
            // 
            this.bsClientes.DataSource = typeof(model_beautycontrol.Model.CE.CE_Cliente);
            // 
            // gvClientes
            // 
            this.gvClientes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnome,
            this.colfones,
            this.colemail,
            this.colid});
            this.gvClientes.GridControl = this.gcClientes;
            this.gvClientes.Name = "gvClientes";
            this.gvClientes.OptionsBehavior.Editable = false;
            this.gvClientes.OptionsView.ShowAutoFilterRow = true;
            this.gvClientes.OptionsView.ShowGroupPanel = false;
            this.gvClientes.StartSorting += new System.EventHandler(this.gvClientes_StartSorting);
            this.gvClientes.ColumnFilterChanged += new System.EventHandler(this.gvClientes_ColumnFilterChanged);
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
            this.colnome.Visible = true;
            this.colnome.VisibleIndex = 0;
            // 
            // colfones
            // 
            this.colfones.AppearanceCell.Options.UseTextOptions = true;
            this.colfones.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colfones.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colfones.AppearanceHeader.Options.UseFont = true;
            this.colfones.AppearanceHeader.Options.UseTextOptions = true;
            this.colfones.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colfones.Caption = "Contato";
            this.colfones.FieldName = "fones";
            this.colfones.Name = "colfones";
            this.colfones.OptionsColumn.ReadOnly = true;
            this.colfones.Visible = true;
            this.colfones.VisibleIndex = 1;
            // 
            // colemail
            // 
            this.colemail.AppearanceCell.Options.UseTextOptions = true;
            this.colemail.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colemail.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colemail.AppearanceHeader.Options.UseFont = true;
            this.colemail.AppearanceHeader.Options.UseTextOptions = true;
            this.colemail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colemail.Caption = "Email";
            this.colemail.FieldName = "email";
            this.colemail.Name = "colemail";
            this.colemail.Visible = true;
            this.colemail.VisibleIndex = 2;
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
            this.colid.Visible = true;
            this.colid.VisibleIndex = 3;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciGridClientes});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(617, 404);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciGridClientes
            // 
            this.lciGridClientes.Control = this.gcClientes;
            this.lciGridClientes.Location = new System.Drawing.Point(0, 0);
            this.lciGridClientes.Name = "lciGridClientes";
            this.lciGridClientes.Size = new System.Drawing.Size(597, 384);
            this.lciGridClientes.TextSize = new System.Drawing.Size(0, 0);
            this.lciGridClientes.TextVisible = false;
            // 
            // UC_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grcCliente);
            this.Name = "UC_Clientes";
            this.Size = new System.Drawing.Size(621, 439);
            ((System.ComponentModel.ISupportInitialize)(this.grcCliente)).EndInit();
            this.grcCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGridClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grcCliente;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gcClientes;
        private System.Windows.Forms.BindingSource bsClientes;
        private DevExpress.XtraGrid.Views.Grid.GridView gvClientes;
        private DevExpress.XtraGrid.Columns.GridColumn colnome;
        private DevExpress.XtraGrid.Columns.GridColumn colfones;
        private DevExpress.XtraGrid.Columns.GridColumn colemail;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraLayout.LayoutControlItem lciGridClientes;
    }
}
