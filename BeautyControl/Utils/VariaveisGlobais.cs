using model_beautycontrol.Model.CE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyControl.Utils
{
    public static class VariaveisGlobais
    {
        public static CE_Usuario usuarioLogado { get; set; }
        public static string emailSoftware = "igoxr2@gmail.com";
        public static string senhaEmailSoftware = "pprkut12";
        public static CE_Empresa empresalogada { get; set; }

        // View principal 
        public static View.Principal principal;
        public static bool houveAlteracaoNaBase =false;


        // Venda
        public static List<CE_VendaProduto> listaProdutosServicosCorrente { get; set; }
    }
}
