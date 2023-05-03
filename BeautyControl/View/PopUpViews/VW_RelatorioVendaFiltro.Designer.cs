namespace BeautyControl.View.PopUpViews
{
    partial class VW_RelatorioVendaFiltro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VW_RelatorioVendaFiltro));
            this.gcRelatorio = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnConfirmar = new DevExpress.XtraEditors.SimpleButton();
            this.ckcListTipo = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.ckcListSituacao = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgTipoServico = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgSituacaoVenda = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gcRelatorio)).BeginInit();
            this.gcRelatorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckcListTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckcListSituacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgTipoServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgSituacaoVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // gcRelatorio
            // 
            this.gcRelatorio.AllowBorderColorBlending = true;
            this.gcRelatorio.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.gcRelatorio.Appearance.Options.UseBackColor = true;
            this.gcRelatorio.AppearanceCaption.BorderColor = System.Drawing.Color.Crimson;
            this.gcRelatorio.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gcRelatorio.AppearanceCaption.ForeColor = System.Drawing.Color.White;
            this.gcRelatorio.AppearanceCaption.Options.UseBorderColor = true;
            this.gcRelatorio.AppearanceCaption.Options.UseFont = true;
            this.gcRelatorio.AppearanceCaption.Options.UseForeColor = true;
            this.gcRelatorio.CaptionImage = ((System.Drawing.Image)(resources.GetObject("gcRelatorio.CaptionImage")));
            this.gcRelatorio.Controls.Add(this.layoutControl1);
            this.gcRelatorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcRelatorio.Location = new System.Drawing.Point(0, 0);
            this.gcRelatorio.Name = "gcRelatorio";
            this.gcRelatorio.Size = new System.Drawing.Size(284, 228);
            this.gcRelatorio.TabIndex = 0;
            this.gcRelatorio.Text = "Relatório";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnCancelar);
            this.layoutControl1.Controls.Add(this.btnConfirmar);
            this.layoutControl1.Controls.Add(this.ckcListTipo);
            this.layoutControl1.Controls.Add(this.ckcListSituacao);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 33);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(280, 193);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(142, 167);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(134, 22);
            this.btnCancelar.StyleController = this.layoutControl1;
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(4, 167);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(134, 22);
            this.btnConfirmar.StyleController = this.layoutControl1;
            this.btnConfirmar.TabIndex = 8;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // ckcListTipo
            // 
            this.ckcListTipo.CheckOnClick = true;
            this.ckcListTipo.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Local", System.Windows.Forms.CheckState.Checked, "0"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Domicílio", System.Windows.Forms.CheckState.Checked, "1")});
            this.ckcListTipo.Location = new System.Drawing.Point(7, 26);
            this.ckcListTipo.Name = "ckcListTipo";
            this.ckcListTipo.Size = new System.Drawing.Size(266, 46);
            this.ckcListTipo.StyleController = this.layoutControl1;
            this.ckcListTipo.TabIndex = 7;
            // 
            // ckcListSituacao
            // 
            this.ckcListSituacao.CheckOnClick = true;
            this.ckcListSituacao.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Finalizado", System.Windows.Forms.CheckState.Checked, "0"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Aberto - Aguardando finalizaçao da venda", System.Windows.Forms.CheckState.Checked, "1"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Aberto - Aguardando pagamento do cliente", System.Windows.Forms.CheckState.Checked, "2")});
            this.ckcListSituacao.Location = new System.Drawing.Point(7, 101);
            this.ckcListSituacao.Name = "ckcListSituacao";
            this.ckcListSituacao.Size = new System.Drawing.Size(266, 59);
            this.ckcListSituacao.StyleController = this.layoutControl1;
            this.ckcListSituacao.TabIndex = 6;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgTipoServico,
            this.lcgSituacaoVenda,
            this.layoutControlItem2,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup1.Size = new System.Drawing.Size(280, 193);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lcgTipoServico
            // 
            this.lcgTipoServico.CustomizationFormText = "Tipo Serviço";
            this.lcgTipoServico.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.lcgTipoServico.Location = new System.Drawing.Point(0, 0);
            this.lcgTipoServico.Name = "lcgTipoServico";
            this.lcgTipoServico.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgTipoServico.Size = new System.Drawing.Size(276, 75);
            this.lcgTipoServico.Text = "Tipo Serviço";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ckcListTipo;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(270, 50);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // lcgSituacaoVenda
            // 
            this.lcgSituacaoVenda.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
            this.lcgSituacaoVenda.Location = new System.Drawing.Point(0, 75);
            this.lcgSituacaoVenda.Name = "lcgSituacaoVenda";
            this.lcgSituacaoVenda.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgSituacaoVenda.Size = new System.Drawing.Size(276, 88);
            this.lcgSituacaoVenda.Text = "Situação de Venda";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ckcListSituacao;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(270, 63);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnConfirmar;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 163);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(138, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnCancelar;
            this.layoutControlItem4.Location = new System.Drawing.Point(138, 163);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(138, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // VW_RelatorioVendaFiltro
            // 
            this.Appearance.BorderColor = System.Drawing.Color.Crimson;
            this.Appearance.Options.UseBorderColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 228);
            this.Controls.Add(this.gcRelatorio);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VW_RelatorioVendaFiltro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VW_RelatorioVendaFiltro";
            ((System.ComponentModel.ISupportInitialize)(this.gcRelatorio)).EndInit();
            this.gcRelatorio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ckcListTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckcListSituacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgTipoServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgSituacaoVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcRelatorio;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.CheckedListBoxControl ckcListSituacao;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup lcgTipoServico;
        private DevExpress.XtraLayout.LayoutControlGroup lcgSituacaoVenda;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.CheckedListBoxControl ckcListTipo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnConfirmar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}