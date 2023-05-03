namespace BeautyControl.View.PopUpViews
{
    partial class VW_InserirItemVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VW_InserirItemVenda));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            this.grcInserirItem = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtValorCobrado = new DevExpress.XtraEditors.TextEdit();
            this.txtValor = new DevExpress.XtraEditors.TextEdit();
            this.txtServico = new DevExpress.XtraEditors.TextEdit();
            this.txtObservacao = new DevExpress.XtraEditors.MemoEdit();
            this.cmbFuncionario = new DevExpress.XtraEditors.LookUpEdit();
            this.bsFuncionarios = new System.Windows.Forms.BindingSource(this.components);
            this.txtQuantidade = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciServico = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciQuantidade = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciFuncionario = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciValor = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciValorCobrado = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciObservacao = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.grcInserirItem)).BeginInit();
            this.grcInserirItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorCobrado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFuncionario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciValorCobrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciObservacao)).BeginInit();
            this.SuspendLayout();
            // 
            // grcInserirItem
            // 
            this.grcInserirItem.AllowBorderColorBlending = true;
            this.grcInserirItem.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.grcInserirItem.Appearance.BorderColor = System.Drawing.Color.Crimson;
            this.grcInserirItem.Appearance.Options.UseBackColor = true;
            this.grcInserirItem.Appearance.Options.UseBorderColor = true;
            this.grcInserirItem.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.grcInserirItem.AppearanceCaption.ForeColor = System.Drawing.Color.White;
            this.grcInserirItem.AppearanceCaption.Options.UseFont = true;
            this.grcInserirItem.AppearanceCaption.Options.UseForeColor = true;
            this.grcInserirItem.CaptionImage = ((System.Drawing.Image)(resources.GetObject("grcInserirItem.CaptionImage")));
            this.grcInserirItem.Controls.Add(this.layoutControl1);
            toolTipTitleItem1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            toolTipTitleItem1.Appearance.Options.UseImage = true;
            toolTipTitleItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem1.Image")));
            toolTipTitleItem1.Text = "Adiciona este serviço a venda";
            superToolTip1.Items.Add(toolTipTitleItem1);
            this.grcInserirItem.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Salvar", ((System.Drawing.Image)(resources.GetObject("grcInserirItem.CustomHeaderButtons"))), -1, DevExpress.XtraEditors.ButtonPanel.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", true, -1, true, superToolTip1, true, false, true, null, null, -1),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Voltar", ((System.Drawing.Image)(resources.GetObject("grcInserirItem.CustomHeaderButtons1"))))});
            this.grcInserirItem.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.grcInserirItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcInserirItem.Location = new System.Drawing.Point(0, 0);
            this.grcInserirItem.Name = "grcInserirItem";
            this.grcInserirItem.Size = new System.Drawing.Size(491, 236);
            this.grcInserirItem.TabIndex = 0;
            this.grcInserirItem.Text = "Inserir Item";
            this.grcInserirItem.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.grcInserirItem_CustomButtonClick);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtValorCobrado);
            this.layoutControl1.Controls.Add(this.txtValor);
            this.layoutControl1.Controls.Add(this.txtServico);
            this.layoutControl1.Controls.Add(this.txtObservacao);
            this.layoutControl1.Controls.Add(this.cmbFuncionario);
            this.layoutControl1.Controls.Add(this.txtQuantidade);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 39);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(487, 195);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtValorCobrado
            // 
            this.txtValorCobrado.Location = new System.Drawing.Point(366, 60);
            this.txtValorCobrado.Name = "txtValorCobrado";
            this.txtValorCobrado.Properties.Appearance.Options.UseTextOptions = true;
            this.txtValorCobrado.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtValorCobrado.Properties.Mask.EditMask = "n2";
            this.txtValorCobrado.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtValorCobrado.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtValorCobrado.Size = new System.Drawing.Size(117, 20);
            this.txtValorCobrado.StyleController = this.layoutControl1;
            this.txtValorCobrado.TabIndex = 8;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(246, 60);
            this.txtValor.Name = "txtValor";
            this.txtValor.Properties.Appearance.Options.UseTextOptions = true;
            this.txtValor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtValor.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.txtValor.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtValor.Properties.Mask.EditMask = "n2";
            this.txtValor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtValor.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtValor.Properties.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(116, 20);
            this.txtValor.StyleController = this.layoutControl1;
            this.txtValor.TabIndex = 7;
            // 
            // txtServico
            // 
            this.txtServico.Location = new System.Drawing.Point(4, 20);
            this.txtServico.Name = "txtServico";
            this.txtServico.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.txtServico.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtServico.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.txtServico.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtServico.Properties.ReadOnly = true;
            this.txtServico.Size = new System.Drawing.Size(358, 20);
            this.txtServico.StyleController = this.layoutControl1;
            this.txtServico.TabIndex = 4;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(4, 100);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(479, 91);
            this.txtObservacao.StyleController = this.layoutControl1;
            this.txtObservacao.TabIndex = 9;
            // 
            // cmbFuncionario
            // 
            this.cmbFuncionario.Location = new System.Drawing.Point(4, 60);
            this.cmbFuncionario.Name = "cmbFuncionario";
            this.cmbFuncionario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFuncionario.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayMember01", "Funcionário", 97, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cmbFuncionario.Properties.DataSource = this.bsFuncionarios;
            this.cmbFuncionario.Properties.DisplayMember = "nome";
            this.cmbFuncionario.Properties.DropDownRows = 8;
            this.cmbFuncionario.Properties.NullText = "";
            this.cmbFuncionario.Properties.ValueMember = "id";
            this.cmbFuncionario.Size = new System.Drawing.Size(238, 20);
            this.cmbFuncionario.StyleController = this.layoutControl1;
            this.cmbFuncionario.TabIndex = 6;
            // 
            // bsFuncionarios
            // 
            this.bsFuncionarios.DataSource = typeof(model_beautycontrol.Model.CE.CE_Funcionario);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQuantidade.Location = new System.Drawing.Point(366, 20);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Properties.Appearance.Options.UseTextOptions = true;
            this.txtQuantidade.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtQuantidade.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtQuantidade.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtQuantidade.Properties.Mask.EditMask = "d";
            this.txtQuantidade.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtQuantidade.Properties.MaxValue = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.txtQuantidade.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQuantidade.Size = new System.Drawing.Size(117, 20);
            this.txtQuantidade.StyleController = this.layoutControl1;
            this.txtQuantidade.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.layoutControlGroup1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciServico,
            this.lciQuantidade,
            this.lciFuncionario,
            this.lciValor,
            this.lciValorCobrado,
            this.lciObservacao});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup1.Size = new System.Drawing.Size(487, 195);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciServico
            // 
            this.lciServico.Control = this.txtServico;
            this.lciServico.Location = new System.Drawing.Point(0, 0);
            this.lciServico.Name = "lciServico";
            this.lciServico.Size = new System.Drawing.Size(362, 40);
            this.lciServico.Text = "Serviço / Produto";
            this.lciServico.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciServico.TextSize = new System.Drawing.Size(84, 13);
            // 
            // lciQuantidade
            // 
            this.lciQuantidade.Control = this.txtQuantidade;
            this.lciQuantidade.Location = new System.Drawing.Point(362, 0);
            this.lciQuantidade.Name = "lciQuantidade";
            this.lciQuantidade.Size = new System.Drawing.Size(121, 40);
            this.lciQuantidade.Text = "Quantidade";
            this.lciQuantidade.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciQuantidade.TextSize = new System.Drawing.Size(84, 13);
            // 
            // lciFuncionario
            // 
            this.lciFuncionario.Control = this.cmbFuncionario;
            this.lciFuncionario.Location = new System.Drawing.Point(0, 40);
            this.lciFuncionario.Name = "lciFuncionario";
            this.lciFuncionario.Size = new System.Drawing.Size(242, 40);
            this.lciFuncionario.Text = "Funcionário";
            this.lciFuncionario.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciFuncionario.TextSize = new System.Drawing.Size(84, 13);
            // 
            // lciValor
            // 
            this.lciValor.Control = this.txtValor;
            this.lciValor.Location = new System.Drawing.Point(242, 40);
            this.lciValor.Name = "lciValor";
            this.lciValor.Size = new System.Drawing.Size(120, 40);
            this.lciValor.Text = "Valor R$";
            this.lciValor.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciValor.TextSize = new System.Drawing.Size(84, 13);
            // 
            // lciValorCobrado
            // 
            this.lciValorCobrado.Control = this.txtValorCobrado;
            this.lciValorCobrado.Location = new System.Drawing.Point(362, 40);
            this.lciValorCobrado.Name = "lciValorCobrado";
            this.lciValorCobrado.Size = new System.Drawing.Size(121, 40);
            this.lciValorCobrado.Text = "Valor Cobrado R$";
            this.lciValorCobrado.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciValorCobrado.TextSize = new System.Drawing.Size(84, 13);
            // 
            // lciObservacao
            // 
            this.lciObservacao.Control = this.txtObservacao;
            this.lciObservacao.Location = new System.Drawing.Point(0, 80);
            this.lciObservacao.Name = "lciObservacao";
            this.lciObservacao.Size = new System.Drawing.Size(483, 111);
            this.lciObservacao.Text = "Observacão";
            this.lciObservacao.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciObservacao.TextSize = new System.Drawing.Size(84, 13);
            // 
            // VW_InserirItemVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 236);
            this.Controls.Add(this.grcInserirItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VW_InserirItemVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VW_InserirItemVenda";
            ((System.ComponentModel.ISupportInitialize)(this.grcInserirItem)).EndInit();
            this.grcInserirItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtValorCobrado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFuncionario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciValorCobrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciObservacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grcInserirItem;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txtValorCobrado;
        private DevExpress.XtraEditors.TextEdit txtValor;
        private DevExpress.XtraEditors.TextEdit txtServico;
        private DevExpress.XtraEditors.MemoEdit txtObservacao;
        private DevExpress.XtraLayout.LayoutControlItem lciServico;
        private DevExpress.XtraLayout.LayoutControlItem lciQuantidade;
        private DevExpress.XtraLayout.LayoutControlItem lciFuncionario;
        private DevExpress.XtraLayout.LayoutControlItem lciValor;
        private DevExpress.XtraLayout.LayoutControlItem lciValorCobrado;
        private DevExpress.XtraLayout.LayoutControlItem lciObservacao;
        private DevExpress.XtraEditors.LookUpEdit cmbFuncionario;
        private System.Windows.Forms.BindingSource bsFuncionarios;
        private DevExpress.XtraEditors.SpinEdit txtQuantidade;
    }
}