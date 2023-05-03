using DevExpress.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyControl.Utils
{
    public class MeuToolTip
    {
        private string titulo;
        private string texto;
        private ToolTipIconType tipo;

        public MeuToolTip()
        {

        }

        public MeuToolTip(string titulo, string texto, ToolTipIconType tipo)
        {
            this.titulo = titulo;
            this.texto = texto;
            this.tipo = tipo;
        }

        public string Titulo
        {
            get
            {
                return titulo;
            }

            set
            {
                titulo = value;
            }
        }

        public string Texto
        {
            get
            {
                return texto;
            }

            set
            {
                texto = value;
            }
        }

        public ToolTipIconType Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }
    }
}
