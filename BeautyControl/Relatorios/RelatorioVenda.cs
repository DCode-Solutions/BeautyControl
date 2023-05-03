using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using model_beautycontrol.Model.CL;
using System.Collections.Generic;

namespace BeautyControl.Relatorios
{
    public partial class RelatorioVenda : DevExpress.XtraReports.UI.XtraReport
    {
        public RelatorioVenda()
        {
            InitializeComponent();
        }

        public RelatorioVenda(List<CL_VendaRegistro> vendaregistros, DateTime data1, DateTime data2)
        {
            InitializeComponent();
            this.DataSource = vendaregistros;
           // bsVendaRegistro.DataSource = vendaregistros;
            xrLabelData1.Text = data1.ToString("dd/MM/yyyy");
            xrLabelData2.Text = data2.ToString("dd/MM/yyyy");
            xrTableCellTotalReceber.Text = "R$ " + getTotalAReceber(vendaregistros).ToString("N2");



        }

        private double getTotalAReceber(List<CL_VendaRegistro> list)
        {
            double somatotal = 0, somatotalentrada = 0;
            foreach (var item in list)
            {
                somatotal += item.total;
                somatotalentrada += item.totalentrada;
            }

            return somatotal - somatotalentrada;
        }
    }
}
