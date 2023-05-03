using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace BeautyControl.View.PopUpViews
{
    public partial class VW_SplashScreenInicial : SplashScreen
    {
        public VW_SplashScreenInicial()
        {
            InitializeComponent();
            pictureEdit1.Image = BeautyControl.Properties.Resources.decodelogo02;
            pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            pictureEdit1.Properties.ZoomPercent = 50;
            pictureEdit1.Size = new Size(151, 65);
            pictureEdit1.Location = new Point(276, 249);
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }
    }
}